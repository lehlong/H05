using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("departments")]
    public class TblDepartment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("type_id")]
        public short? TypeId { get; set; }
        
        [Column("contact_info")]
        public string? ContactInfo { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("display_order")]
        public short? DisplayOrder { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("object_id")]
        public string? ObjectId { get; set; }
        
        [Column("type")]
        public string? Type { get; set; }
        
        [Column("status")]
        public int? Status { get; set; }
    }
} 
