using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("user_departments_permissions")]
    public class TblUserDepartmentsPermission 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("is_can")]
        public bool? IsCan { get; set; }
        
        [Column("action")]
        public string? Action { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("permission_id")]
        public int? PermissionId { get; set; }
        
        [Column("department_type_id")]
        public int? DepartmentTypeId { get; set; }
    }
} 
