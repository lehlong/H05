using AutoMapper;
using Common;
using H05.CORE.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OrganizationDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? OrganId { get; set; }
        public int? ParentId { get; set; }
        public short? OrganizationTypeId { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Domain { get; set; }
        public string? IntegrationSettings { get; set; }
        public bool? IsActive { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOrganization, OrganizationDto>().ReverseMap();
        }
    }
} 