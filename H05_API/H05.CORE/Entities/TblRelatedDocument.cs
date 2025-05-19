using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("related_documents")]
    public class TblRelatedDocument : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("document_type")]
        public string? DocumentType { get; set; }
        
        [Column("incoming_document_id")]
        public long? IncomingDocumentId { get; set; }
        
        [Column("outgoing_document_id")]
        public long? OutgoingDocumentId { get; set; }
        
        [Column("document_date")]
        public DateTime? DocumentDate { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
    }
} 
