using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_responses")]
    public class TblOutgoingDocumentResponse : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("outgoing_document_id")]
        public int? OutgoingDocumentId { get; set; }
        
        [Column("incoming_document_id")]
        public int? IncomingDocumentId { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
} 
