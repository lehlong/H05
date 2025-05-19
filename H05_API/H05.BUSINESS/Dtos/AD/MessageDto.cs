using System.ComponentModel.DataAnnotations;
using H05.CORE.Entities.AD;
using AutoMapper;
using Common;

namespace H05.BUSINESS.Dtos.AD
{
    public class MessageDto : IMapFrom, IDto
    {

        [Key]
   
        public string Code { get; set; }

        public string Lang { get; set; }

        public string Value { get; set; }
      
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblAdMessage, MessageDto>().ReverseMap();
        }
    }
}
