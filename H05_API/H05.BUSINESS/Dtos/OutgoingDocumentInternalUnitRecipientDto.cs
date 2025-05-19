using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentInternalUnitRecipientDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int? DepartmentId { get; set; }
        public string? RecipientType { get; set; }
        public DateTime? CreatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocumentInternalUnitRecipient, OutgoingDocumentInternalUnitRecipientDto>().ReverseMap();
        }
    }
} 