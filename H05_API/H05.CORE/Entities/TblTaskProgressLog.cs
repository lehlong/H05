using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("task_progress_logs")]
    public class TblTaskProgressLog : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("task_id")]
        public int? TaskId { get; set; }
        
        [Column("assignment_id")]
        public int? AssignmentId { get; set; }
        
        [Column("reporter_id")]
        public int? ReporterId { get; set; }
        
        [Column("progress_percent")]
        public short? ProgressPercent { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("hours_spent")]
        public decimal? HoursSpent { get; set; }
        
        [Column("report_date")]
        public DateTime? ReportDate { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("attachments")]
        public string? Attachments { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
    }
} 
