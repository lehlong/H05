using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("role_permissions")]
    public class TblRolePermission : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("permission_type_id")]
        public int? PermissionTypeId { get; set; }
        
        [Column("additional_rights")]
        public string? AdditionalRights { get; set; }
        
        [Column("conditions")]
        public string? Conditions { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("permission_id")]
        public int? PermissionId { get; set; }
        
        [Column("is_can")]
        public bool? IsCan { get; set; }
    }
} 
