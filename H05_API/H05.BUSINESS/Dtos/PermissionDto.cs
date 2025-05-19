using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class PermissionDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? FeatureRoleIds { get; set; }
        public string? Action { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public string? Code { get; set; }
        public int? Order { get; set; }
        public string? FeatureUserIds { get; set; }
        public string? MenuIds { get; set; }
        public string? PermissionType { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblPermission, PermissionDto>().ReverseMap();
        }
    }
} 