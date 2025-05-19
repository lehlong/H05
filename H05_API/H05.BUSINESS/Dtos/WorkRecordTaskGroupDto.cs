using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkRecordTaskGroupDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkRecordTaskGroup, WorkRecordTaskGroupDto>().ReverseMap();
        }
    }
} 