using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class WorkRecordAttachmentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public long? FileId { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblWorkRecordAttachment, WorkRecordAttachmentDto>().ReverseMap();
        }
    }
} 