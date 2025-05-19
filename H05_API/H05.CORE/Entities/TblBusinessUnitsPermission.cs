using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("business_units_permissions")]
    public class TblBusinessUnitsPermission
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("business_unit_id")]
        public int? BusinessUnitId { get; set; }
        
        [Column("is_can")]
        public bool? IsCan { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("role_id")]
        public int? RoleId { get; set; }
        
        [Column("business_unit_type_id")]
        public int? BusinessUnitTypeId { get; set; }
        
        [Column("permission_id")]
        public int? PermissionId { get; set; }
    }
} 
