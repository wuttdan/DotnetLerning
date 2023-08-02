namespace Domain.Entities.Minieai
{
    public partial class FbbTblExceptionError
    {
        public int Id { get; set; }
        public string? TransactionId { get; set; }
        public string? Service { get; set; }
        public string? Fucntion { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
