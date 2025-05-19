using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMeetingsDepartmentService : IGenericService<TblMeetingsDepartment, MeetingsDepartmentDto>
    {
    }
    public class MeetingsDepartmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMeetingsDepartment, MeetingsDepartmentDto>(dbContext, mapper), IMeetingsDepartmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMeetingsDepartment.AsQueryable();
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