using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_history")]
    public class TblDocumentHistory : BaseEntity
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
        
        [Column("action")]
        public string? Action { get; set; }
        
        [Column("old_value")]
        public string? OldValue { get; set; }
        
        [Column("new_value")]
        public string? NewValue { get; set; }
        
        [Column("changed_by")]
        public int? ChangedById { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
} 
