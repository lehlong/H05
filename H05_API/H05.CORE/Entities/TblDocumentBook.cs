using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_books")]
    public class TblDocumentBook : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("department")]
        public string? Department { get; set; }
        
        [Column("year")]
        public int? Year { get; set; }
        
        [Column("security_level")]
        public string? SecurityLevel { get; set; }
        
        [Column("book_type")]
        public string? BookType { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("start_number")]
        public int? StartNumber { get; set; }
        
        [Column("order_number")]
        public int? OrderNumber { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("clerk_ids")]
        public string? ClerkIds { get; set; }
        
        [Column("field")]
        public int? Field { get; set; }
    }
} 
