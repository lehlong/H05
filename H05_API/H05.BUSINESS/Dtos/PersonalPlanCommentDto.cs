using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class PersonalPlanCommentDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? PersonalPlanId { get; set; }
        public int? UserId { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? ParentId { get; set; }
        public bool? IsTransfer { get; set; }
        public bool? IsDone { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblPersonalPlanComment, PersonalPlanCommentDto>().ReverseMap();
        }
    }
} 