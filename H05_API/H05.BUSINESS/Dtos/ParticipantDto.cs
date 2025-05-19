using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class ParticipantDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? WorkRecordId { get; set; }
        public long? UserId { get; set; }
        public long? DepartmentId { get; set; }
        public short? RoleType { get; set; }
        public string? AssignedTask { get; set; }
        public short? Progress { get; set; }
        public short? Evaluation { get; set; }
        public string? EvaluationNotes { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? Status { get; set; }
        public string? RejectedReason { get; set; }
        public string? EvaluationStatus { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblParticipant, ParticipantDto>().ReverseMap();
        }
    }
} 