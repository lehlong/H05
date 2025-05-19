using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("storage_boxes")]
    public class TblStorageBox : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("box_code")]
        public string? BoxCode { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("location")]
        public string? Location { get; set; }
        
        [Column("capacity")]
        public int? Capacity { get; set; }
        
        [Column("used_capacity")]
        public int? UsedCapacity { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("created_by")]
        public long? CreatedBy { get; set; }
        
        [Column("updated_by")]
        public long? UpdatedBy { get; set; }
    }
} 
