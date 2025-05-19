using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_replacements")]
    public class TblOutgoingDocumentReplacement 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("replaced_document_id")]
        public int? ReplacedDocumentId { get; set; }
        
        [Column("replacement_date")]
        public DateTimeOffset? ReplacementDate { get; set; }
        
        [Column("replacement_reason")]
        public string? ReplacementReason { get; set; }
        
        [Column("replaced_by")]
        public int? ReplacedBy { get; set; }
    }
} 
