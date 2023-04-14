using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.Exceptions;

namespace FleetFlow.Service.Extentions
{
    public static class CollectionExtensions
    {
        public static IQueryable<TEntity> ToPagedList<TEntity>(this IQueryable<TEntity> entities, PaginationParams @params)
            where TEntity : Auditable
        {
            return @params.PageIndex > 0 && @params.PageSize >= 0 ?
                entities.OrderBy(e => e.Id).Skip((@params.PageSize - 1) * @params.PageIndex).Take(@params.PageSize) :
                throw new FleetFlowException(400, "Please, enter valid numbers");
        }
    }
}