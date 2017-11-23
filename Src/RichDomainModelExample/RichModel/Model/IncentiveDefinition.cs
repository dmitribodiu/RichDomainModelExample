using System;

namespace RichModel.Model
{
    public class IncentiveDefinition
    {
        public string Name { get; set; }
        public ExpirationType ExpirationType { get; set; }
        public int DaysValid { get; set; }

        public static IncentiveDefinition CreateAssignmentExpiringIncentiveDefinition(string name, int daysValid)
        {
            return new IncentiveDefinition
            {
                Name = name,
                DaysValid = daysValid,
                ExpirationType = new AssignmentExpiring()
            };
        }

        public static IncentiveDefinition CreateFixedExpiringIncentiveDefinition(string name, int daysValid, DateTime beginDate)
        {
            return new IncentiveDefinition
            {
                Name = name,
                DaysValid = daysValid,
                ExpirationType = new FixedExpiring(beginDate)
            };
        }

        public DateTime CalculateExpirationDate(ISystemClock clock)
        {
            return ExpirationType.CalculateExpirationDate(this, clock);
        }
    }
}

