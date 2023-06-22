using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.Exceptions;
using FleetFlow.Shared.Helpers;
using Newtonsoft.Json;

namespace FleetFlow.Service.Extentions
{
    public static class CollectionExtensions
    {
        public static IQueryable<TEntity> ToPagedList<TEntity>(this IQueryable<TEntity> entities, PaginationParams @params)
            where TEntity : Auditable
        {
            if (@params.PageSize ==0 && @params.PageIndex== 0)
            {
                @params = new PaginationParams()
                {
                    PageSize = 10,
                    PageIndex = 1
                };
            }
            var metaData = new PaginationMetaData(entities.Count(), @params);

            var json = JsonConvert.SerializeObject(metaData);

            if (HttpContextHelper.ResponseHeaders != null)
            {
                if (HttpContextHelper.ResponseHeaders.ContainsKey("X-Pagination"))
                    HttpContextHelper.ResponseHeaders.Remove("X-Pagination");

                HttpContextHelper.ResponseHeaders.Add("X-Pagination", json);
            }

            return @params.PageIndex > 0 && @params.PageSize > 0 ?
                entities.OrderBy(e => e.Id)
                    .Skip((@params.PageIndex - 1) * @params.PageSize).Take(@params.PageSize) :
                        throw new FleetFlowException(400, "Please, enter valid numbers");
        }
    }
}