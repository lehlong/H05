using AutoMapper;
using Common;
using H05.CORE.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace H05.BUSINESS.Dtos
{
    public class AccountTypeDto : IMapFrom, IDto
    {
        [Key]
        public string Code { get; set; }
        public string? Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblMdAccountType, AccountTypeDto>().ReverseMap();
        }
    }
}
