using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMeetingsDepartmentTransferService : IGenericService<TblMeetingsDepartmentTransfer, MeetingsDepartmentTransferDto>
    {
    }
    public class MeetingsDepartmentTransferService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMeetingsDepartmentTransfer, MeetingsDepartmentTransferDto>(dbContext, mapper), IMeetingsDepartmentTransferService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMeetingsDepartmentTransfer.AsQueryable();
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