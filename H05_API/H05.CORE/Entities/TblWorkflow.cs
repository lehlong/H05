using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("workflows")]
    public class TblWorkflow 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("workflow_code")]
        public string? WorkflowCode { get; set; }
        
        [Column("workflow_name")]
        public string? WorkflowName { get; set; }
        
        [Column("resource_type_id")]
        public int? ResourceTypeId { get; set; }
        
        [Column("department_scope")]
        public string? DepartmentScope { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("apply_scope")]
        public string? ApplyScope { get; set; }
    }
} 
