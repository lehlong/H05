using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_handlers")]
    public class TblDocumentHandler : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("document_type")]
        public string? DocumentType { get; set; }
        
        [Column("incoming_document_id")]
        public long? IncomingDocumentId { get; set; }
        
        [Column("outgoing_document_id")]
        public long? OutgoingDocumentId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("handler_id")]
        public int? HandlerId { get; set; }
        
        [Column("is_main_handler")]
        public bool? IsMainHandler { get; set; }
        
        [Column("is_commander")]
        public bool? IsCommander { get; set; }
        
        [Column("is_cooperator")]
        public bool? IsCooperator { get; set; }
        
        [Column("is_for_knowledge")]
        public bool? IsForKnowledge { get; set; }
        
        [Column("workflow_id")]
        public long? WorkflowId { get; set; }
        
        [Column("created_by")]
        public int? CreatedById { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("status")]
        public int? Status { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("document_opinion_id")]
        public int? DocumentOpinionId { get; set; }
        
        [Column("document_status")]
        public string? DocumentStatus { get; set; }
        
        [Column("is_preliminary")]
        public bool? IsPreliminary { get; set; }
        
        [Column("update_status_at")]
        public DateTimeOffset? UpdateStatusAt { get; set; }
        
        [Column("due_date")]
        public DateTime? DueDate { get; set; }
        
        [Column("propose_status")]
        public string? ProposeStatus { get; set; }
        
        [Column("document_status_old")]
        public string? DocumentStatusOld { get; set; }
        
        [Column("propose_role")]
        public string? ProposeRole { get; set; }
        
        [Column("incoming_document_type")]
        public string? IncomingDocumentType { get; set; }
        
        [Column("workflow_department_id")]
        public int? WorkflowDepartmentId { get; set; }
        
        [Column("out_going_document_action")]
        public string? OutGoingDocumentAction { get; set; }
        
        [Column("document_number_id")]
        public int? DocumentNumberId { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("private_id")]
        public int? PrivateId { get; set; }
    }
} 
