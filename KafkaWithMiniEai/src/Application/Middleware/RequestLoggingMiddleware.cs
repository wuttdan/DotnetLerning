﻿using Microsoft.AspNetCore.Http;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Middleware;


public sealed class RequestLoggingMiddleware
{
    private const string MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";

    private readonly ILogger _logger;
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(ILogger logger, RequestDelegate next)
    {
        _logger = logger;
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        if (httpContext == null) throw new ArgumentNullException(nameof(httpContext));

        var sw = Stopwatch.StartNew();
        try
        {
            await _next(httpContext);
            sw.Stop();

            var statusCode = httpContext.Response?.StatusCode;
            var level = statusCode > 499 ? LogEventLevel.Error : LogEventLevel.Information;
            _logger.Write(level, MessageTemplate, httpContext.Request.Method, httpContext.Request.Path, statusCode, sw.Elapsed.TotalMilliseconds);
        }
        // Never caught, because `LogException()` returns false.
        catch (Exception ex) when (LogException(httpContext, sw, ex)) { }
    }

    private static bool LogException(HttpContext httpContext, Stopwatch sw, Exception ex)
    {
        sw.Stop();

        LogForErrorContext(httpContext).Error(ex, MessageTemplate, httpContext.Request.Method, httpContext.Request.Path, 500, sw.Elapsed.TotalMilliseconds);

        return false;
    }

    private static ILogger LogForErrorContext(HttpContext httpContext)
    {
        var request = httpContext.Request;

        var result = Log
            .ForContext("RequestHeaders", request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()), destructureObjects: true)
            .ForContext("RequestHost", request.Host)
            .ForContext("RequestProtocol", request.Protocol);

        if (request.HasFormContentType)
            result = result.ForContext("RequestForm", request.Form.ToDictionary(v => v.Key, v => v.Value.ToString()));

        return result;
    }
}