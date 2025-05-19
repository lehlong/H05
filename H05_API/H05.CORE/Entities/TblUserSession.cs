using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("user_sessions")]
    public class TblUserSession : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("user_id")]
        public int? UserId { get; set; }
        
        [Column("session_token")]
        public string? SessionToken { get; set; }
        
        [Column("refresh_token")]
        public string? RefreshToken { get; set; }
        
        [Column("device_info")]
        public string? DeviceInfo { get; set; }
        
        [Column("ip_address")]
        public string? IpAddress { get; set; }
        
        [Column("login_at")]
        public DateTimeOffset? LoginAt { get; set; }
        
        [Column("expires_at")]
        public DateTimeOffset? ExpiresAt { get; set; }
        
        [Column("last_activity_at")]
        public DateTimeOffset? LastActivityAt { get; set; }
        
        [Column("revoked_at")]
        public DateTimeOffset? RevokedAt { get; set; }
        
        [Column("revoked_by")]
        public int? RevokedBy { get; set; }
        
        [Column("revoke_reason")]
        public string? RevokeReason { get; set; }
        
        [Column("metadata")]
        public string? Metadata { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
} 
