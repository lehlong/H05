using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MenuItemDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; }
        public string? Icon { get; set; }
        public string? RoutePath { get; set; }
        public string? ResourceType { get; set; }
        public short? PermissionLevel { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public bool? AutoOpen { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMenuItem, MenuItemDto>().ReverseMap();
        }
    }
} 