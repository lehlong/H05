using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class IncomingDocumentDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public int? DocumentBookId { get; set; }
        public long? DocumentNumberId { get; set; }
        public string? DocumentCode { get; set; }
        public int? SenderDepartmentId { get; set; }
        public int? ReceiverDepartmentId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? BookDate { get; set; }
        public DateTime? ResponseDeadline { get; set; }
        public string? SubNumber { get; set; }
        public int? ReceiveMethod { get; set; }
        public int? SecurityLevel { get; set; }
        public int? UrgencyLevel { get; set; }
        public int? DocumentType { get; set; }
        public int? Field { get; set; }
        public string? Signer { get; set; }
        public string? Summary { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? DocumentStatusOld { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblIncomingDocument, IncomingDocumentDto>().ReverseMap();
        }
    }
} 