using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_report_attachments")]
    public class TblWorkRecordReportAttachment 
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_report_id")]
        public long? WorkRecordReportId { get; set; }
        
        [Column("file_id")]
        public long? FileId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
    }
} 
