using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_handler_opinions")]
    public class TblDocumentHandlerOpinion : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("document_handle_id")]
        public long? DocumentHandleId { get; set; }
        
        [Column("opinion_id")]
        public long? OpinionId { get; set; }
    }
} 
