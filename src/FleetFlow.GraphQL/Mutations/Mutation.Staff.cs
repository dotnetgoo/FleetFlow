using FleetFlow.Service.DTOs.Staffs;
using FleetFlow.Service.Interfaces.Staffs;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<StaffForResultDto> CreateStaffAsync([Service] IStaffService service,
            StaffForCreationDto dto)
        {
            return await service.AddAsync(dto);
        }
        public async ValueTask<StaffForResultDto> UpdateStaffAsync([Service] IStaffService service,
            long id, StaffForUpdateDto dto)
        {
            return await service.ModifyAsync(id, dto);
        }
        public async ValueTask<bool> DeleteStaffAsync([Service] IStaffService service, long id)
        {
            return await service.RemoveAsync(id);
        }
    }
}
