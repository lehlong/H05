using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("participants")]
    public class TblParticipant : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("user_id")]
        public long? UserId { get; set; }
        
        [Column("department_id")]
        public long? DepartmentId { get; set; }
        
        [Column("role_type")]
        public short? RoleType { get; set; }
        
        [Column("assigned_task")]
        public string? AssignedTask { get; set; }
        
        [Column("progress")]
        public short? Progress { get; set; }
        
        [Column("evaluation")]
        public short? Evaluation { get; set; }
        
        [Column("evaluation_notes")]
        public string? EvaluationNotes { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("status")]
        public string? Status { get; set; }
        
        [Column("rejected_reason")]
        public string? RejectedReason { get; set; }
        
        [Column("evaluation_status")]
        public string? EvaluationStatus { get; set; }
    }
} 
