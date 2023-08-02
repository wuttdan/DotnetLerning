namespace Domain.Entities.Minieai
{
    public partial class FbbTblLogging
    {
        public long Id { get; set; }
        public string? TransactionId { get; set; }
        public string? RequestMessage { get; set; }
        public string? RequestEvent { get; set; }
        public string? RequestMethod { get; set; }
        public string? RequestPath { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
