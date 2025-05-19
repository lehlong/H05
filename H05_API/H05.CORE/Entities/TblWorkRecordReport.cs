using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_report")]
    public class TblWorkRecordReport 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("date")]
        public DateTimeOffset? Date { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("emp_ids")]
        public string? EmpIds { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("updated_by")]
        public int? UpdatedBy { get; set; }
        
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        
        [Column("is_request")]
        public bool? IsRequest { get; set; }
        
        [Column("request_id")]
        public int? RequestId { get; set; }
        
        [Column("work_record_id")]
        public int? WorkRecordId { get; set; }
    }
} 
