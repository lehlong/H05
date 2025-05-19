using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_status_history")]
    public class TblOutgoingDocumentStatusHistory : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("status_id")]
        public int? StatusId { get; set; }
        
        [Column("changed_at")]
        public DateTimeOffset? ChangedAt { get; set; }
        
        [Column("changed_by")]
        public int? ChangedBy { get; set; }
        
        [Column("comments")]
        public string? Comments { get; set; }
    }
} 
