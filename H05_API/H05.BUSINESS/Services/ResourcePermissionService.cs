using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IResourcePermissionService : IGenericService<TblResourcePermission, ResourcePermissionDto>
    {
    }
    public class ResourcePermissionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblResourcePermission, ResourcePermissionDto>(dbContext, mapper), IResourcePermissionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblResourcePermission.AsQueryable();
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