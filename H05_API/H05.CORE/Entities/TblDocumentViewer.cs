using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_viewers")]
    public class TblDocumentViewer : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_type")]
        public string? DocumentType { get; set; }
        
        [Column("outgoing_document_id")]
        public int? OutgoingDocumentId { get; set; }
        
        [Column("viewer_id")]
        public int? ViewerId { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
} 
