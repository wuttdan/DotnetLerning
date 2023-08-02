namespace Domain.Entities.Minieai
{
    public partial class FbbTblWoSoaHeader
    {
        public long Id { get; set; }
        public long? WoId { get; set; }
        public string? FibrenetId { get; set; }
        public string? Type { get; set; }
        public string? OrderType { get; set; }
        public string? TypeOperDate { get; set; }
        public string? MsgSeqId { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblWo? Wo { get; set; }
    }
}
