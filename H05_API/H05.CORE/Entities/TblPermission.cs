using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("permissions")]
    public class TblPermission 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("feature_role_ids")]
        public string? FeatureRoleIds { get; set; }
        
        [Column("action")]
        public string? Action { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("order")]
        public int? Order { get; set; }
        
        [Column("feature_user_ids")]
        public string? FeatureUserIds { get; set; }
        
        [Column("menu_ids")]
        public string? MenuIds { get; set; }
        
        [Column("permission_type")]
        public string? PermissionType { get; set; }
    }
} 
