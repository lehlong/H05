using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("external_organizations")]
    public class TblExternalOrganization : BaseEntity
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("pid")]
        public string? Pid { get; set; }
        
        [Column("status")]
        public int? Status { get; set; }
        
        [Column("parent_id")]
        public string? ParentId { get; set; }
    }
} 
