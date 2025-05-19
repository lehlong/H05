using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IFieldGroupService : IGenericService<TblFieldGroup, FieldGroupDto>
    {
    }
    public class FieldGroupService(AppDbContext dbContext, IMapper mapper) : GenericService<TblFieldGroup, FieldGroupDto>(dbContext, mapper), IFieldGroupService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblFieldGroup.AsQueryable();
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