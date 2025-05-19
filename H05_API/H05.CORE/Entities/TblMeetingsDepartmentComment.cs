using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_department_comments")]
    public class TblMeetingsDepartmentComment : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("meeting_id")]
        public int? MeetingId { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("content")]
        public string? Content { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("is_transfer")]
        public bool? IsTransfer { get; set; }
        
        [Column("is_done")]
        public bool? IsDone { get; set; }
    }
} 
