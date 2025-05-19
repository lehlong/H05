using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MdKeyValueDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? KeyName { get; set; }
        public string? ValueData { get; set; }
        public string? KeyValueType { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMdKeyValue, MdKeyValueDto>().ReverseMap();
        }
    }
} 