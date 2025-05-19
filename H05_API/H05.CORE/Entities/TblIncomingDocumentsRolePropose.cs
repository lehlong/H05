using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("incoming_documents_role_propose")]
    public class TblIncomingDocumentsRolePropose : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("incoming_document_id")]
        public int? IncomingDocumentId { get; set; }
        
        [Column("role_code")]
        public string? RoleCode { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_by")]
        public int? CreatedById { get; set; }
        
        [Column("updated_by")]
        public int? UpdatedById { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
} 
