using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMeetingsDepartmentResourceBookingService : IGenericService<TblMeetingsDepartmentResourceBooking, MeetingsDepartmentResourceBookingDto>
    {
    }
    public class MeetingsDepartmentResourceBookingService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMeetingsDepartmentResourceBooking, MeetingsDepartmentResourceBookingDto>(dbContext, mapper), IMeetingsDepartmentResourceBookingService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMeetingsDepartmentResourceBooking.AsQueryable();
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