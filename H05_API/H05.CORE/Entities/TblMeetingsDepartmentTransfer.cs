using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meetings_department_transfers")]
    public class TblMeetingsDepartmentTransfer : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("meeting_id")]
        public int? MeetingId { get; set; }
        
        [Column("from_user_id")]
        public int? FromUserId { get; set; }
        
        [Column("to_user_id")]
        public int? ToUserId { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("is_approved")]
        public bool? IsApproved { get; set; }
        
        [Column("meeting_department_comment_id")]
        public int? MeetingDepartmentCommentId { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
    }
} 
