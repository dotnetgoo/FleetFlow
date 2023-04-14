using System.Runtime.CompilerServices;

namespace FleetFlow.Domain.Congirations
{
    public class PeginationData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public PeginationData(int totalCount,PaginationParams @params)
        {
            TotalCount = totalCount;
            TotalPages = (int)Math.Ceiling(totalCount / (double)@params.PageSize);
            CurrentPage = @params.PageIndex;
        }

    }
}
