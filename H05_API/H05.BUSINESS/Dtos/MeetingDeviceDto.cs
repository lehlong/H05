using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingDeviceDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? ResourceId { get; set; }
        public int? DeviceId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingDevice, MeetingDeviceDto>().ReverseMap();
        }
    }
} 