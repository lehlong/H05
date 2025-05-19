using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IEmployeeRoleAssignmentService : IGenericService<TblEmployeeRoleAssignment, EmployeeRoleAssignmentDto>
    {
    }
    public class EmployeeRoleAssignmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblEmployeeRoleAssignment, EmployeeRoleAssignmentDto>(dbContext, mapper), IEmployeeRoleAssignmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblEmployeeRoleAssignment.AsQueryable();
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