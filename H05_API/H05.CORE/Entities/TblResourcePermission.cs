using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("resource_permissions")]
    public class TblResourcePermission : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("resource_type")]
        public string? ResourceType { get; set; }
        
        [Column("resource_id")]
        public int? ResourceId { get; set; }
        
        [Column("grantee_type")]
        public short? GranteeType { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("permission_level")]
        public short? PermissionLevel { get; set; }
        
        [Column("is_inherited")]
        public bool? IsInherited { get; set; }
        
        [Column("granted_by")]
        public int? GrantedBy { get; set; }
        
        [Column("valid_from")]
        public DateTime? ValidFrom { get; set; }
        
        [Column("valid_until")]
        public DateTime? ValidUntil { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
} 
