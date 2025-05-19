using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("tasks")]
    public class TblTask : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("task_type_id")]
        public long? TaskTypeId { get; set; }
        
        [Column("task_code")]
        public string? TaskCode { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("expected_completion_date")]
        public DateTime? ExpectedCompletionDate { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
} 
