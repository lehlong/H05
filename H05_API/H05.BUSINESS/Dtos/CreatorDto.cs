using AutoMapper;
using Common;
using H05.CORE.Entities.AD;

namespace H05.BUSINESS.Dtos.Common
{
    public class CreatorDto : IMapFrom, IDto
    {
        public string FullName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TblAdAccount, CreatorDto>().ReverseMap();
        }
    }
}
