using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("features")]
    public class TblFeature 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
    }
} 
