using FleetFlow.Domain.Enums;
using FleetFlow.GraphQL.Types.EnumTypes;

namespace FleetFlow.GraphQL.Extensions
{
    public static class CastingExtensions
    {
        public static FeedbackStatus? ToFeedbackStatus(this FeedbackStatusEnumType enumType)
        {
            if (enumType == null)
                return null;
            return Enum.Parse<FeedbackStatus>(enumType.Name);
        }
    }
}
