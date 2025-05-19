using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("department_plans_employees")]
    public class TblDepartmentPlansEmployee : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("department_plan_id")]
        public int? DepartmentPlanId { get; set; }
        
        [Column("employee_id")]
        public int? EmployeeId { get; set; }
        
        [Column("is_viewed")]
        public bool? IsViewed { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
