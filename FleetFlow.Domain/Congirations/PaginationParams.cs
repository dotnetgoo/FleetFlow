using System.Reflection.Metadata;

namespace FleetFlow.Domain.Congirations;

public class PaginationParams
{
    private const int _maxPageSize = 20;
    private int _pageSize;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value > _maxPageSize ? _maxPageSize : value;
    }
    public int PageIndex { get; set; }
}
