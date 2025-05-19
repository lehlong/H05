using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class PersonalPlanReviewerTransferDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? PersonalPlanId { get; set; }
        public int? FromUserId { get; set; }
        public int? ToUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsApproved { get; set; }
        public int? PersonalPlanCommentId { get; set; }
        public short? StatusReviewer { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblPersonalPlanReviewerTransfer, PersonalPlanReviewerTransferDto>().ReverseMap();
        }
    }
} 