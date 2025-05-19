using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_tasks")]
    public class TblOutgoingDocumentTask : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("task_id")]
        public int? TaskId { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
    }
}
