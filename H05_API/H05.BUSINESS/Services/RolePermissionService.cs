using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IRolePermissionService : IGenericService<TblRolePermission, RolePermissionDto>
    {
    }
    public class RolePermissionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblRolePermission, RolePermissionDto>(dbContext, mapper), IRolePermissionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblRolePermission.AsQueryable();
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