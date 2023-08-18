namespace Domain.Entities.Minieai;

public partial class FbbTblEvNotifyAppointmentHeader
{
    public FbbTblEvNotifyAppointmentHeader()
    {
        FbbTblEvnotifyappointmentOrders = new HashSet<FbbTblEvNotifyAppointmentOrder>();
    }

    public long Id { get; set; }
    public string? TransactionId { get; set; }
    public string? FibrenetId { get; set; }
    public string? Type { get; set; }
    public string? OrderType { get; set; }
    public string? TypeOperDate { get; set; }
    public string? MsgSeqId { get; set; }
    public string? Status { get; set; }
    public string? Created { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? LastUpd { get; set; }
    public DateTime? LastUpdDate { get; set; }
    public string? ServerName { get; set; }

    public virtual ICollection<FbbTblEvNotifyAppointmentOrder> FbbTblEvnotifyappointmentOrders { get; set; }
}
