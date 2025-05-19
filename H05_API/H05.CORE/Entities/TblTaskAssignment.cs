using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("task_assignments")]
    public class TblTaskAssignment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("task_id")]
        public int? TaskId { get; set; }
        
        [Column("assignee_type")]
        public short? AssigneeType { get; set; }
        
        [Column("employee_id")]
        public int? EmployeeId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("assignment_type")]
        public short? AssignmentType { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("progress_percent")]
        public short? ProgressPercent { get; set; }
        
        [Column("start_date")]
        public DateTimeOffset? StartDate { get; set; }
        
        [Column("due_date")]
        public DateTimeOffset? DueDate { get; set; }
        
        [Column("completed_date")]
        public DateTimeOffset? CompletedDate { get; set; }
        
        [Column("estimated_hours")]
        public int? EstimatedHours { get; set; }
        
        [Column("actual_hours")]
        public int? ActualHours { get; set; }
        
        [Column("settings")]
        public string? Settings { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
