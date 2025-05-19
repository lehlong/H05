using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("menu_items")]
    public class TblMenuItem : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("icon")]
        public string? Icon { get; set; }
        
        [Column("route_path")]
        public string? RoutePath { get; set; }
        
        [Column("resource_type")]
        public string? ResourceType { get; set; }
        
        [Column("permission_level")]
        public short? PermissionLevel { get; set; }
        
        [Column("display_order")]
        public int? DisplayOrder { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("auto_open")]
        public bool? AutoOpen { get; set; }
    }
} 
