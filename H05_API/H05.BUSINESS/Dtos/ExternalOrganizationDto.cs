using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class ExternalOrganizationDto : IMapFrom, IDto
    {
        [Key]
        public string Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Pid { get; set; }
        public int? Status { get; set; }
        public string? ParentId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblExternalOrganization, ExternalOrganizationDto>().ReverseMap();
        }
    }
} 