using Application.Common.Interfaces;
using Application.Query.Microsite;
using Application.Query.NotifyAppointmentOrder;
using Application.Query.SendCheckInLate;
using Domain.Extension;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace Application.Common.Core;

public sealed class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    public ValidatorBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
            var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
            if (failures.Count != 0)
            {
                ////throw new FluentValidation.ValidationException(failures);
                var failure = failures.FirstOrDefault();
                if (failure != null)
                {
                    var res = CreateResponse<TRequest, TResponse>(request, failure);
                    return res;
                }
            }
        }
        return await next();
    }

    private TResponseModel CreateResponse<TRequestModel, TResponseModel>(TRequestModel request, ValidationFailure failure)
    {
        var res = (TResponseModel)Activator.CreateInstance(typeof(TResponseModel));
        Type type = request!.GetType();
        switch (type)
        {
            case Type _ when type == typeof(CommitNotifyAppointmentOrderRequestModel):
                var req1 = request as CommitNotifyAppointmentOrderRequestModel;
                var res1 = req1.CreateResponse(failure.ErrorMessage, failure.ErrorCode) as CommitNotifyAppointmentOrderResponseModel;
                res.SetAllProperties(res1);
                break;

            case Type _ when type == typeof(CommitSendCheckInLateRequestModel):
                var req2 = request as CommitSendCheckInLateRequestModel;
                var res2 = req2?.CreateResponse(failure.ErrorMessage, failure.ErrorCode);
                res.SetAllProperties(res2);
                break;

            case Type _ when type == typeof(CommitMicrositeRequestModel):
                var req3 = request as CommitMicrositeRequestModel;
                var res3 = req3?.CreateResponse(failure.ErrorMessage, failure.ErrorCode);
                res.SetAllProperties(res3);
                break;

            case Type _ when type == typeof(CommitMicrositeUpdateRequestModel):
                var req4 = request as CommitMicrositeUpdateRequestModel;
                var res4 = req4?.CreateResponse(failure.ErrorMessage, failure.ErrorCode);
                res.SetAllProperties(res4);
                break;
        }
        return res;
    }
}