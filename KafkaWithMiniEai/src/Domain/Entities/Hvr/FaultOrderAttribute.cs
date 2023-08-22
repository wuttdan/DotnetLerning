using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Hvr
{
    [Table("TTT_FAULT_ORDER_ATTR", Schema = "OAM")]
    public class FaultOrderAttribute
    {
        [Key]
        [Column(Order = 0)]
        public int SEQ { get; set; }
        public string? ORD_NO { get; set; }
        public string? FIELD_CODE { get; set; }
        public string? FIELD_DISP_VALUE { get; set; }
        public string? FIELD_VALUE { get; set; }
        public string? REMARKS { get; set; }
        public string? WORKORDER_NO { get; set; }
        public string? ACTIVITY_NO { get; set; }
        public int? SP_ID { get; set; }
        public string? FUNC_NAME { get; set; }
        public string? STATE { get; set; }
        public int? OPER_STAFF_ID { get; set; }
        public int? OPER_JOB_ID { get; set; }
        public DateTime? OPER_DATE { get; set; }
        public int? ORD_BATCH_ID { get; set; }
    }
}
