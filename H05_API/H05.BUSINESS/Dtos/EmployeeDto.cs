using AutoMapper;
using Common;
using H05.CORE.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class EmployeeDto : IMapFrom, IDto
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        [JsonIgnore]
        public string? PasswordHash { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public short? Status { get; set; }
        public string? Settings { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? ObjectId { get; set; }
        public string? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? IdNumber { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? StaffCode { get; set; }
        public bool? RequirePasswordChange { get; set; }
        public string? Rank { get; set; }
        public string? Notes { get; set; }
        public string? Position { get; set; }
        public string? PersonalInfo { get; set; }
        public short? PortalPermissionId { get; set; }
        public string? PreliminaryRole { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblEmployee, EmployeeDto>().ReverseMap();
        }
    }
} 