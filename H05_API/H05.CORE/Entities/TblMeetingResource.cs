using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meeting_resources")]
    public class TblMeetingResource 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("type_id")]
        public short? TypeId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("capacity")]
        public int? Capacity { get; set; }
        
        [Column("location")]
        public string? Location { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("settings")]
        public string? Settings { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("area")]
        public short? Area { get; set; }
        
        [Column("utilities")]
        public string? Utilities { get; set; }
    }
} 
