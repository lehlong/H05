using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("internal_organizations")]
    public class TblInternalOrganization 
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("status")]
        public int? Status { get; set; }
        
        [Column("parent_id")]
        public long? ParentId { get; set; }
    }
} 
