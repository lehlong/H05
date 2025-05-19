using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("organizations")]
    public class TblOrganization 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("organ_id")]
        public string? OrganId { get; set; }
        
        [Column("parent_id")]
        public int? ParentId { get; set; }
        
        [Column("organization_type_id")]
        public short? OrganizationTypeId { get; set; }
        
        [Column("address")]
        public string? Address { get; set; }
        
        [Column("phone")]
        public string? Phone { get; set; }
        
        [Column("email")]
        public string? Email { get; set; }
        
        [Column("domain")]
        public string? Domain { get; set; }
        
        [Column("integration_settings")]
        public string? IntegrationSettings { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
    }
} 
