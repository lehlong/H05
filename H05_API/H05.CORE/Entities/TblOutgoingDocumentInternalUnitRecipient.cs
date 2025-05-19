using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_internal_unit_recipients")]
    public class TblOutgoingDocumentInternalUnitRecipient : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("recipient_type")]
        public string? RecipientType { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
    }
} 
