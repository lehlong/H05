using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentPlanTransferService : IGenericService<TblDepartmentPlanTransfer, DepartmentPlanTransferDto>
    {
    }
    public class DepartmentPlanTransferService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentPlanTransfer, DepartmentPlanTransferDto>(dbContext, mapper), IDepartmentPlanTransferService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentPlanTransfer.AsQueryable();
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