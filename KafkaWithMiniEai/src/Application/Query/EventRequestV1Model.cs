using Application.Common.Core;
using Application.Query.SendCheckInLate;
using System.ComponentModel;
using System.Globalization;

namespace Application.Query;

public sealed class EventRequestV1Model
{
    public EventParameterModel? MiniEaiRequest { get; set; }
    public CommitSendCheckInLateRequestModel AsSendCheckInLate(RequestHeader header)
    {
        var eventParam = MiniEaiRequest?.ParameterList?.Parameter?.ToList() ?? new List<EventParameterValue>();
        var req = new CommitSendCheckInLateRequestModel();
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CommitSendCheckInLateRequestModel));
        foreach (PropertyDescriptor pp in properties)
        {
            if (pp.Name == "Header") continue;
            var name = eventParam.FirstOrDefault(x => pp.Name == x.Name) ?? new EventParameterValue();
            pp.SetValue(req, name.Value ?? string.Empty);
        }
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