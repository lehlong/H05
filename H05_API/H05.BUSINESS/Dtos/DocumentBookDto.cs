using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class DocumentBookDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Department { get; set; }
        public int? Year { get; set; }
        public string? SecurityLevel { get; set; }
        public string? BookType { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? StartNumber { get; set; }
        public int? OrderNumber { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? ClerkIds { get; set; }
        public int? Field { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblDocumentBook, DocumentBookDto>().ReverseMap();
        }
    }
} 