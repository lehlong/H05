using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IUserDepartmentsPermissionService : IGenericService<TblUserDepartmentsPermission, UserDepartmentsPermissionDto>
    {
    }
    public class UserDepartmentsPermissionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblUserDepartmentsPermission, UserDepartmentsPermissionDto>(dbContext, mapper), IUserDepartmentsPermissionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblUserDepartmentsPermission.AsQueryable();
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