using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class UserSessionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? SessionToken { get; set; }
        public string? RefreshToken { get; set; }
        public string? DeviceInfo { get; set; }
        public string? IpAddress { get; set; }
        public DateTimeOffset? LoginAt { get; set; }
        public DateTimeOffset? ExpiresAt { get; set; }
        public DateTimeOffset? LastActivityAt { get; set; }
        public DateTimeOffset? RevokedAt { get; set; }
        public int? RevokedBy { get; set; }
        public string? RevokeReason { get; set; }
        public string? Metadata { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblUserSession, UserSessionDto>().ReverseMap();
        }
    }
} 