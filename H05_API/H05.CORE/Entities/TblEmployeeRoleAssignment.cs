using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("employee_role_assignments")]
    public class TblEmployeeRoleAssignment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("employee_id")]
        public int? EmployeeId { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("settings")]
        public string? Settings { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
} 
