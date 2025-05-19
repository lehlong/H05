using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("workflow_steps")]
    public class TblWorkflowStep : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("workflow_id")]
        public int? WorkflowId { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("parent_step_id")]
        public int? ParentStepId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("requires_opinion_id")]
        public int? RequiresOpinionId { get; set; }
        
        [Column("step_order")]
        public int? StepOrder { get; set; }
        
        [Column("is_internal")]
        public bool? IsInternal { get; set; }
        
        [Column("is_for_information")]
        public bool? IsForInformation { get; set; }
        
        [Column("can_sign_report")]
        public bool? CanSignReport { get; set; }
        
        [Column("can_initial_sign")]
        public bool? CanInitialSign { get; set; }
        
        [Column("can_approve_draft")]
        public bool? CanApproveDraft { get; set; }
        
        [Column("can_delete_file")]
        public bool? CanDeleteFile { get; set; }
        
        [Column("can_reupload_file")]
        public bool? CanReuploadFile { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("role_direction")]
        public string? RoleDirection { get; set; }
        
        [Column("consult")]
        public string? Consult { get; set; }
        
        [Column("unit")]
        public int? Unit { get; set; }
        
        [Column("send_unit")]
        public int? SendUnit { get; set; }
        
        [Column("offer_process")]
        public bool? OfferProcess { get; set; }
        
        [Column("allow_send_to_unit")]
        public bool? AllowSendToUnit { get; set; }
        
        [Column("role_type")]
        public short? RoleType { get; set; }
    }
} 
