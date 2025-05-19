using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMeetingsPersonalService : IGenericService<TblMeetingsPersonal, MeetingsPersonalDto>
    {
    }
    public class MeetingsPersonalService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMeetingsPersonal, MeetingsPersonalDto>(dbContext, mapper), IMeetingsPersonalService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMeetingsPersonal.AsQueryable();
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