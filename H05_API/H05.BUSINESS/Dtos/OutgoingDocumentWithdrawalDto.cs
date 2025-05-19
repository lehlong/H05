using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class OutgoingDocumentWithdrawalDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int? WithdrawnDocumentId { get; set; }
        public DateTimeOffset? WithdrawalDate { get; set; }
        public string? WithdrawalReason { get; set; }
        public int? WithdrawnBy { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblOutgoingDocumentWithdrawal, OutgoingDocumentWithdrawalDto>().ReverseMap();
        }
    }
} 