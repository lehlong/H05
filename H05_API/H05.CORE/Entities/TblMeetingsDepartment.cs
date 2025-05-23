using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_department")]
    public class TblMeetingsDepartment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string? Title { get; set; }
        
        [Column("start_time")]
        public DateTime? StartTime { get; set; }
        
        [Column("end_time")]
        public DateTime? EndTime { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("author_id")]
        public int? AuthorId { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("preparation_info")]
        public string? PreparationInfo { get; set; }
        
        [Column("reminder_settings")]
        public string? ReminderSettings { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("publisher_id")]
        public int? PublisherId { get; set; }
        
        [Column("is_publish")]
        public bool? IsPublish { get; set; }
    }
} 
