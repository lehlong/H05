using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_documents")]
    public class TblOutgoingDocument 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_number")]
        public string? DocumentNumber { get; set; }
        
        [Column("draft_reference_number")]
        public string? DraftReferenceNumber { get; set; }
        
        [Column("report_reference_number")]
        public string? ReportReferenceNumber { get; set; }
        
        [Column("summary")]
        public string? Summary { get; set; }
        
        [Column("drafting_department_id")]
        public int? DraftingDepartmentId { get; set; }
        
        [Column("publishing_department_id")]
        public int? PublishingDepartmentId { get; set; }
        
        [Column("drafter_id")]
        public int? DrafterId { get; set; }
        
        [Column("document_type_id")]
        public int? DocumentTypeId { get; set; }
        
        [Column("urgency_level_id")]
        public int? UrgencyLevelId { get; set; }
        
        [Column("security_level_id")]
        public int? SecurityLevelId { get; set; }
        
        [Column("field_id")]
        public int? FieldId { get; set; }
        
        [Column("report_signer_id")]
        public int? ReportSignerId { get; set; }
        
        [Column("draft_signer_id")]
        public int? DraftSignerId { get; set; }
        
        [Column("response_deadline")]
        public DateTime? ResponseDeadline { get; set; }
        
        [Column("status")]
        public string? Status { get; set; }
        
        [Column("status_id")]
        public int? StatusId { get; set; }
        
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("published_date")]
        public DateTime? PublishedDate { get; set; }
        
        [Column("auto_publish")]
        public bool? AutoPublish { get; set; }
        
        [Column("digital_signature")]
        public bool? DigitalSignature { get; set; }
        
        [Column("processing_status")]
        public string? ProcessingStatus { get; set; }
        
        [Column("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }
        
        [Column("updated_by")]
        public int? UpdatedBy { get; set; }
        
        [Column("deleted_by")]
        public int? DeletedBy { get; set; }
        
        [Column("is_sign_draft")]
        public bool? IsSignDraft { get; set; }
        
        [Column("is_sign_report")]
        public bool? IsSignReport { get; set; }
        
        [Column("viewer_id")]
        public long? ViewerId { get; set; }
        
        [Column("publisher_id")]
        public int? PublisherId { get; set; }
    }
} 
