using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_numbers")]
    public class TblDocumentNumber : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("document_book_id")]
        public int? DocumentBookId { get; set; }
        
        [Column("document_type")]
        public string? DocumentType { get; set; }
        
        [Column("document_number")]
        public int? DocumentNumber { get; set; }
        
        [Column("document_code")]
        public string? DocumentCode { get; set; }
        
        [Column("sub_number")]
        public string? SubNumber { get; set; }
        
        [Column("is_used")]
        public bool? IsUsed { get; set; }
        
        [Column("is_canceled")]
        public bool? IsCanceled { get; set; }
        
        [Column("canceled_reason")]
        public string? CanceledReason { get; set; }
        
        [Column("requested_by")]
        public int? RequestedById { get; set; }
        
        [Column("approved_by")]
        public int? ApprovedById { get; set; }
        
        [Column("requested_at")]
        public DateTimeOffset? RequestedAt { get; set; }
        
        [Column("approved_at")]
        public DateTimeOffset? ApprovedAt { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
