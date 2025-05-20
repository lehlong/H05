using Common;
using H05.CORE.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace H05.BUSINESS.Common
{
    public interface IGenericService<TEntity, TDto, TFilterDto> : IBaseService
        where TEntity : BaseEntity
        where TDto : class
        where TFilterDto : class
    {
        Task<PagedResponseDto> Search(Filter<TFilterDto> filter); 
        Task<IList<TDto>> GetAll();
        Task<TDto> GetById(object id);
        Task<TDto> Add(IDto dto);
        Task Update(IDto dto);
        Task Delete(object code);
        Task<PagedResponseDto> Paging(IQueryable<TEntity> query, Filter<TFilterDto> filter);
    }
}
