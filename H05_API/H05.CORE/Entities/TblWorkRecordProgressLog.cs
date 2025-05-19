using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_progress_logs")]
    public class TblWorkRecordProgressLog : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("previous_progress")]
        public short? PreviousProgress { get; set; }
        
        [Column("current_progress")]
        public short? CurrentProgress { get; set; }
        
        [Column("log_date")]
        public DateTimeOffset? LogDate { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
    }
} 
