using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("employees")]
    public class TblEmployee : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("username")]
        public string? Username { get; set; }
        
        [Column("full_name")]
        public string? FullName { get; set; }
        
        [Column("email")]
        public string? Email { get; set; }
        
        [Column("password_hash")]
        public string? PasswordHash { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("position_id")]
        public int? PositionId { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("settings")]
        public string? Settings { get; set; }
        
        [Column("last_login")]
        public DateTimeOffset? LastLogin { get; set; }
        
        [Column("object_id")]
        public string? ObjectId { get; set; }
        
        [Column("gender")]
        public string? Gender { get; set; }
        
        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }
        
        [Column("id_number")]
        public string? IdNumber { get; set; }
        
        [Column("address")]
        public string? Address { get; set; }
        
        [Column("phone")]
        public string? Phone { get; set; }
        
        [Column("staff_code")]
        public string? StaffCode { get; set; }
        
        [Column("require_password_change")]
        public bool? RequirePasswordChange { get; set; }
        
        [Column("rank")]
        public string? Rank { get; set; }
        
        [Column("notes")]
        public string? Notes { get; set; }
        
        [Column("position")]
        public string? Position { get; set; }
        
        [Column("personal_info")]
        public string? PersonalInfo { get; set; }
        
        [Column("portal_permission_id")]
        public short? PortalPermissionId { get; set; }
        
        [Column("preliminary_role")]
        public string? PreliminaryRole { get; set; }
    }
} 
