using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("permission_actions")]
    public class TblPermissionAction 
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
        
        [Column("category")]
        public string? Category { get; set; }
        
        [Column("settings")]
        public string? Settings { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("permission_type")]
        public string? PermissionType { get; set; }
    }
} 
