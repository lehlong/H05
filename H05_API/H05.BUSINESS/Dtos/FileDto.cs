using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class FileDto : IMapFrom, IDto
    {
        [Key]
        public long Id { get; set; }
        public string? Code { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public int? FileSize { get; set; }
        public string? FullText { get; set; }
        public string? Summary { get; set; }
        public string? Classification { get; set; }
        public string? Title { get; set; }
        public string? DocDate { get; set; }
        public string? DocNumber { get; set; }
        public string? SignedBy { get; set; }
        public string? Department { get; set; }
        public DateTime? UploadDate { get; set; }
        public string? Chunks { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblFile, FileDto>().ReverseMap();
        }
    }
} 