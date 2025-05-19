using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_opinions")]
    public class TblDocumentOpinion 
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
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("parent_id")]
        public long? ParentId { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("attachments")]
        public string? Attachments { get; set; }
        
        [Column("out_going_document_action")]
        public string? OutGoingDocumentAction { get; set; }
        
        [Column("recipient_id")]
        public int? RecipientId { get; set; }
        
        [Column("forward_request_opinion")]
        public string? ForwardRequestOpinion { get; set; }
        
        [Column("private_id")]
        public int? PrivateId { get; set; }
        
        [Column("private_type")]
        public string? PrivateType { get; set; }
    }
} 
