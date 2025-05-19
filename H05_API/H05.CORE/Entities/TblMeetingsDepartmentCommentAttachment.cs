using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_department_comment_attachments")]
    public class TblMeetingsDepartmentCommentAttachment : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("meeting_department_comment_id")]
        public long? MeetingDepartmentCommentId { get; set; }
        
        [Column("file_id")]
        public long? FileId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("created_by")]
        public int? CreatedById { get; set; }
    }
} 
