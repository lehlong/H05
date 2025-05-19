using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class IncomingDocumentsRoleProposeDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public int? IncomingDocumentId { get; set; }
        public string? RoleCode { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedById { get; set; }
        public int? UpdatedById { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblIncomingDocumentsRolePropose, IncomingDocumentsRoleProposeDto>().ReverseMap();
        }
    }
} 