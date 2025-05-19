using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMinistryDepartmentService : IGenericService<TblMinistryDepartment, MinistryDepartmentDto>
    {
    }
    public class MinistryDepartmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMinistryDepartment, MinistryDepartmentDto>(dbContext, mapper), IMinistryDepartmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMinistryDepartment.AsQueryable();
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