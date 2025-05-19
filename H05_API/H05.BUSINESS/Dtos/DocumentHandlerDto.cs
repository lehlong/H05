using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentHandlerDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? DocumentType { get; set; }
        public long? IncomingDocumentId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public int? DepartmentId { get; set; }
        public int? HandlerId { get; set; }
        public bool? IsMainHandler { get; set; }
        public bool? IsCommander { get; set; }
        public bool? IsCooperator { get; set; }
        public bool? IsForKnowledge { get; set; }
        public long? WorkflowId { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Status { get; set; }
        public string? Content { get; set; }
        public int? DocumentOpinionId { get; set; }
        public string? DocumentStatus { get; set; }
        public bool? IsPreliminary { get; set; }
        public DateTime? UpdateStatusAt { get; set; }
        public DateTime? DueDate { get; set; }
        public string? ProposeStatus { get; set; }
        public string? DocumentStatusOld { get; set; }
        public string? ProposeRole { get; set; }
        public string? IncomingDocumentType { get; set; }
        public int? WorkflowDepartmentId { get; set; }
        public string? OutGoingDocumentAction { get; set; }
        public int? DocumentNumberId { get; set; }
        public int? ParentId { get; set; }
        public int? PrivateId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentHandler, DocumentHandlerDto>().ReverseMap();
        }
    }
} 