using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("related_outgoing_documents")]
    public class TblRelatedOutgoingDocument : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("work_record_id")]
        public long? WorkRecordId { get; set; }
        
        [Column("outgoing_document_id")]
        public long? OutgoingDocumentId { get; set; }
        
        [Column("document_date")]
        public DateTimeOffset? DocumentDate { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
    }
} 
