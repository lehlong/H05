using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("roles")]
    public class TblRole : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string? Name { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("description")]
        public string? Description { get; set; }
        
        [Column("is_active")]
        public bool? IsActive { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
        
        [Column("can_sign_draft")]
        public bool? CanSignDraft { get; set; }
        
        [Column("can_sign_report")]
        public bool? CanSignReport { get; set; }
        
        [Column("can_manage_info")]
        public bool? CanManageInfo { get; set; }
        
        [Column("can_transfer_any")]
        public bool? CanTransferAny { get; set; }
        
        [Column("is_hidden_account")]
        public bool? IsHiddenAccount { get; set; }
        
        [Column("can_receive_internal")]
        public bool? CanReceiveInternal { get; set; }
        
        [Column("can_delegate")]
        public bool? CanDelegate { get; set; }
        
        [Column("can_direct_command")]
        public bool? CanDirectCommand { get; set; }
        
        [Column("can_manage_unit_book")]
        public bool? CanManageUnitBook { get; set; }
        
        [Column("order")]
        public float? Order { get; set; }
        
        [Column("role_type")]
        public string? RoleType { get; set; }
    }
} 
