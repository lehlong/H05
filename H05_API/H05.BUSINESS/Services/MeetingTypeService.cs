using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMeetingTypeService : IGenericService<TblMeetingType, MeetingTypeDto>
    {
    }
    public class MeetingTypeService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMeetingType, MeetingTypeDto>(dbContext, mapper), IMeetingTypeService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMeetingType.AsQueryable();
                return await Paging(query, filter);
            }
            catch (Exception ex)
            {
                Status = false;
                Exception = ex;
                return null;
            }
        }
    }
} 