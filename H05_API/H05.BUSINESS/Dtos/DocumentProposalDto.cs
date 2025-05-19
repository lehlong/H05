using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentProposalDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public long? IncomingDocumentId { get; set; }
        public long? OutgoingDocumentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CommanderId { get; set; }
        public int? MainHandlerDepartmentId { get; set; }
        public int? MainHandlerPersonId { get; set; }
        public string? CooperationHandlerDepartments { get; set; }
        public string? CooperationHandlerPersons { get; set; }
        public string? KnowledgeHandlerDepartments { get; set; }
        public string? KnowledgeHandlerPersons { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentProposal, DocumentProposalDto>().ReverseMap();
        }
    }
} 