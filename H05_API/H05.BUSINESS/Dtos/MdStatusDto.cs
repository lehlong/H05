using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MdStatusDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? StatusType { get; set; }
        public string? StatusValue { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? StatusGroup { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMdStatus, MdStatusDto>().ReverseMap();
        }
    }
} 