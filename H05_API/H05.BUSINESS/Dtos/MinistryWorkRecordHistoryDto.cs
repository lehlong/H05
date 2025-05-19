using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MinistryWorkRecordHistoryDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public string? ActionType { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? UserId { get; set; }
        public string? Description { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMinistryWorkRecordHistory, MinistryWorkRecordHistoryDto>().ReverseMap();
        }
    }
} 