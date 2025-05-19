using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("meeting_device")]
    public class TblMeetingDevice : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("resource_id")]
        public int? ResourceId { get; set; }
        
        [Column("device_id")]
        public int? DeviceId { get; set; }
    }
} 
