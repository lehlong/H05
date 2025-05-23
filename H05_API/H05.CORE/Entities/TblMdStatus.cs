using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("md_status")]
    public class TblMdStatus : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("status_type")]
        public string? StatusType { get; set; }
        
        [Column("status_value")]
        public string? StatusValue { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("status_group")]
        public string? StatusGroup { get; set; }
    }
} 
