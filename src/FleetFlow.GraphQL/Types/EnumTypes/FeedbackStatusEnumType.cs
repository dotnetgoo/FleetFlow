using FleetFlow.Domain.Enums;

namespace FleetFlow.GraphQL.Types.EnumTypes
{
    public class FeedbackStatusEnumType : EnumType<FeedbackStatus>
    {
        protected override void Configure(IEnumTypeDescriptor<FeedbackStatus> descriptor)
        {
            descriptor.BindValuesImplicitly();
        }
    }
}
