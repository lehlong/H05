using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_records")]
    public class TblWorkRecord
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("record_code")]
        public string? RecordCode { get; set; }
        
        [Column("creation_date")]
        public DateTimeOffset? CreationDate { get; set; }
        
        [Column("end_date")]
        public DateTimeOffset? EndDate { get; set; }
        
        [Column("confidentiality_level")]
        public int? ConfidentialityLevelId { get; set; }
        
        [Column("management_notes")]
        public string? ManagementNotes { get; set; }
        
        [Column("work_content")]
        public string? WorkContent { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("progress")]
        public short? Progress { get; set; }
        
        [Column("record_type")]
        public short? RecordType { get; set; }
        
        [Column("task_id")]
        public long? TaskId { get; set; }
        
        [Column("assigned_by_id")]
        public long? AssignedById { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("updated_by")]
        public int? UpdatedBy { get; set; }
        
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        
        [Column("document_status")]
        public string? DocumentStatus { get; set; }
        
        [Column("ministry_type")]
        public string? MinistryType { get; set; }
        
        [Column("leader")]
        public int? LeaderId { get; set; }
        
        [Column("document_date")]
        public DateTimeOffset? DocumentDate { get; set; }
        
        [Column("document_type")]
        public int? DocumentTypeId { get; set; }
        
        [Column("priority")]
        public short? Priority { get; set; }
        
        [Column("notice_expires")]
        public short? NoticeExpires { get; set; }
        
        [Column("organization")]
        public int? Organization { get; set; }
        
        [Column("field_group")]
        public int? FieldGroup { get; set; }
        
        [Column("rejected_reason")]
        public string? RejectedReason { get; set; }
        
        [Column("work_type")]
        public int? WorkType { get; set; }
    }
} 
