using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("md_key_values")]
    public class TblMdKeyValue 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("key_name")]
        public string? KeyName { get; set; }
        
        [Column("value_data")]
        public string? ValueData { get; set; }
        
        [Column("key_value_type")]
        public string? KeyValueType { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
} 
