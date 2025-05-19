using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("storage_document_details")]
    public class TblStorageDocumentDetail 
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("storage_record_id")]
        public long? StorageRecordId { get; set; }
        
        [Column("document_type")]
        public string? DocumentType { get; set; }
        
        [Column("document_id")]
        public long? DocumentId { get; set; }
        
        [Column("document_code")]
        public string? DocumentCode { get; set; }
        
        [Column("document_name")]
        public string? DocumentName { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
    }
} 
