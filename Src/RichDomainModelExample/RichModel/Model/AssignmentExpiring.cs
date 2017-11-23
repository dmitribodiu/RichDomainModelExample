using System;

namespace RichModel.Model
{
    public class AssignmentExpiring: ExpirationType
    {
        public override DateTime CalculateExpirationDate(IncentiveDefinition incentiveDefinition, ISystemClock systemClock)
        {
            return systemClock.UtcNow.AddDays(incentiveDefinition.DaysValid);
        }
    }
}