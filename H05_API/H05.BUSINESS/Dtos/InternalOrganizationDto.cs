using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class InternalOrganizationDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? Status { get; set; }
        public long? ParentId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblInternalOrganization, InternalOrganizationDto>().ReverseMap();
        }
    }
} 