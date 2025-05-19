using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentProcessingHistoryDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public string? ActionType { get; set; }
        public DateTimeOffset? ActionDate { get; set; }
        public int? ActorId { get; set; }
        public string? PreviousStatus { get; set; }
        public string? NewStatus { get; set; }
        public string? Comments { get; set; }
        public int? DepartmentId { get; set; }
        public int? CreatedBy { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public string? TaskType { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocumentProcessingHistory, OutgoingDocumentProcessingHistoryDto>().ReverseMap();
        }
    }
} 