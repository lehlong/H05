using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("ministry_departments")]
    public class TblMinistryDepartment : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("department_id")]
        public long? DepartmentId { get; set; }
        
        [Column("role_type")]
        public short? RoleType { get; set; }
        
        [Column("assigned_task")]
        public string? AssignedTask { get; set; }
        
        [Column("progress")]
        public short? Progress { get; set; }
        
        [Column("evaluation_status")]
        public string? EvaluationStatus { get; set; }
        
        [Column("completion_level")]
        public string? CompletionLevel { get; set; }
        
        [Column("rejection_reason")]
        public string? RejectionReason { get; set; }
        
        [Column("evaluated_at")]
        public DateTime? EvaluatedAt { get; set; }
        
        [Column("evaluated_by")]
        public int? EvaluatedById { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
} 
