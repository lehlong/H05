using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("work_record_task_group")]
    public class TblWorkRecordTaskGroup : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
    }
} 
