using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_task")]
    public class TblWorkRecordTask 
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("task_content")]
        public string? TaskContent { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("work_record_id")]
        public int? WorkRecordId { get; set; }
        
        [Column("record_code")]
        public string? RecordCode { get; set; }
        
        [Column("document_date")]
        public DateTimeOffset? DocumentDate { get; set; }
        
        [Column("leader")]
        public int? LeaderId { get; set; }
        
        [Column("creation_date")]
        public DateTimeOffset? CreationDate { get; set; }
        
        [Column("end_date")]
        public DateTimeOffset? EndDate { get; set; }
        
        [Column("field_group")]
        public int? FieldGroup { get; set; }
        
        [Column("priority")]
        public int? Priority { get; set; }
        
        [Column("task_group_id")]
        public int? TaskGroupId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("task_type")]
        public int? TaskType { get; set; }
        
        [Column("report_frequency")]
        public short? ReportFrequency { get; set; }
        
        [Column("request_content")]
        public string? RequestContent { get; set; }
        
        [Column("is_task_group")]
        public bool? IsTaskGroup { get; set; }
        
        [Column("organizations")]
        public string? Organizations { get; set; }
    }
} 
