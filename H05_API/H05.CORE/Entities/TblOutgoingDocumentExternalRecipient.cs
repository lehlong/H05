using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_external_recipients")]
    public class TblOutgoingDocumentExternalRecipient : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("organization_id")]
        public string? OrganizationId { get; set; }
        
        [Column("recipient_type")]
        public string? RecipientType { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
} 
