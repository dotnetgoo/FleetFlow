using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Staffs;
using FleetFlow.Service.Interfaces.Staffs;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<StaffForResultDto> GetStaffById([Service] IStaffService service, long id)
        {
            return await service.RetrieveByIdAsync(id);
        }
        public async ValueTask<IEnumerable<StaffForResultDto>> GetStaffAll([Service] IStaffService service,
            PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
        public async ValueTask<StaffForResultDto> GetStaffByUserId([Service] IStaffService service, long userId)
        {
            return await service.RetrieveByUserIdAsync(userId);
        }
        public async ValueTask<IEnumerable<StaffForResultDto>> GetStaffByRoleId([Service] IStaffService service,
            PaginationParams @params, long roleId)
        {
            return await service.RetrieveAllByRoleAsync(@params, roleId);
        }
    }
}
