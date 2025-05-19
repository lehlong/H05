using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class TaskDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? TaskTypeId { get; set; }
        public string? TaskCode { get; set; }
        public string? Name { get; set; }
        public DateTimeOffset? ExpectedCompletionDate { get; set; }
        public string? Notes { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblTask, TaskDto>().ReverseMap();
        }
    }
} 