using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_attachments")]
    public class TblDocumentAttachment : BaseEntity
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
        
        [Column("file_id")]
        public long? FileId { get; set; }
        
        [Column("attachment_type")]
        public string? AttachmentType { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("is_signed")]
        public bool? IsSigned { get; set; }
        
        [Column("document_book_id")]
        public long? DocumentBookId { get; set; }
        
        [Column("document_number")]
        public string? DocumentNumber { get; set; }
        
        [Column("symbol")]
        public string? Symbol { get; set; }
        
        [Column("issue_date")]
        public DateTime? IssueDate { get; set; }
        
        [Column("parent_attachment_id")]
        public long? ParentAttachmentId { get; set; }
        
        [Column("version_type")]
        public string? VersionType { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("is_initial_signed")]
        public bool? IsInitialSigned { get; set; }
    }
} 
