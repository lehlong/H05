using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_report_status")]
    public class TblWorkRecordReportStatus : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("report_id")]
        public int? ReportId { get; set; }
        
        [Column("emp_id")]
        public int? EmpId { get; set; }
        
        [Column("is_seen")]
        public bool? IsSeen { get; set; }
    }
} 
