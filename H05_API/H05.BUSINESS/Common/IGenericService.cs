using Common;
using H05.CORE.Common;

namespace H05.BUSINESS.Common
{
    public interface IGenericService<TEntity, TDto> : IBaseService where TEntity : BaseEntity where TDto : class
    {
        Task<PagedResponseDto> Search(BaseFilter filter);
        Task<IList<TDto>> GetAll();
        Task<TDto> GetById(object id);
        Task<TDto> Add(IDto dto);
        Task Update(IDto dto);
        Task Delete(object code);
        Task<PagedResponseDto> Paging(IQueryable<TEntity> query, BaseFilter filter);
    }
}
