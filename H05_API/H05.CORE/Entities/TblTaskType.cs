using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("task_types")]
    public class TblTaskType : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("type_code")]
        public string? TypeCode { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("year")]
        public int? Year { get; set; }
        
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
