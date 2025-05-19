using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_progress_attachments")]
    public class TblWorkRecordProgressAttachment : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("progress_log_id")]
        public long? ProgressLogId { get; set; }
        
        [Column("file_id")]
        public long? FileId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
    }
} 
