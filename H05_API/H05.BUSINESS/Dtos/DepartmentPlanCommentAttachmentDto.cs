using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DepartmentPlanCommentAttachmentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? DepartmentPlanCommentId { get; set; }
        public long? FileId { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedById { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDepartmentPlanCommentAttachment, DepartmentPlanCommentAttachmentDto>().ReverseMap();
        }
    }
}