using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class MeetingsDepartmentTransferDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? MeetingId { get; set; }
        public int? FromUserId { get; set; }
        public int? ToUserId { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public bool? IsApproved { get; set; }
        public int? MeetingDepartmentCommentId { get; set; }
        public short? Status { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMeetingsDepartmentTransfer, MeetingsDepartmentTransferDto>().ReverseMap();
        }
    }
} 