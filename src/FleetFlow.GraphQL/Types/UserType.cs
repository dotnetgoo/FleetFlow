using FleetFlow.Service.DTOs.User;

namespace FleetFlow.GraphQL.Types
{
    public class UserType : ObjectType<UserForResultDto>
    {
        protected override void Configure(IObjectTypeDescriptor<UserForResultDto> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(u => u.Id).Type<IdType>();
            descriptor.Field(u => u.FirstName).Type<StringType>();
            descriptor.Field(u => u.LastName).Type<StringType>();
            //descriptor.Field(u => u.Role).Type<UserRoleEnumType>();
        }
    }
}