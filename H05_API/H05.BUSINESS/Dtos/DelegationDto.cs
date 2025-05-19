using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DelegationDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DelegatorId { get; set; }
        public int? DelegateId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public string? Files { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDelegation, DelegationDto>().ReverseMap();
        }
    }
} 