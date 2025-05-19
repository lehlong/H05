using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("delegations")]
    public class TblDelegation 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("delegator_id")]
        public int? DelegatorId { get; set; }
        
        [Column("delegate_id")]
        public int? DelegateId { get; set; }
        
        [Column("start_date")]
        public DateTimeOffset? StartDate { get; set; }
        
        [Column("end_date")]
        public DateTimeOffset? EndDate { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("files")]
        public string? Files { get; set; }
    }
} 
