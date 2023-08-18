using Application.Common.Core;
using Application.Query.SendCheckInLate;

namespace Application.Query;

public sealed class EventRequestV1Model
{
    public EventParameterModel? MiniEaiRequest { get; set; }
    public CommitSendCheckInLateRequestModel AsSendCheckInLate(RequestHeader header)
    {
        var req = new CommitSendCheckInLateRequestModel();
        req.Header = header;
        return req;
    }
}

public sealed class EventParameterModel
{
    public string? Event { get; set; }
    public EventParameterListModel? ParameterList { get; set; }
}

public sealed class EventParameterListModel
{
    public string ParameterType { get; set; } = string.Empty;
    public IEnumerable<EventParameterValue>? Parameter { get; set; }
}

public sealed class EventParameterValue
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}