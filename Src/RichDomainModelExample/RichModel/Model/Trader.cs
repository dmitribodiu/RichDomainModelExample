using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RichModel.Model
{
	public class Trader
	{
	    private readonly IList<Incentive> _assignedIncentives;

        public Trader(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            _assignedIncentives = new List<Incentive>();
        }

        public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Email { get; set; }

	    public IReadOnlyCollection<Incentive> AssignedIncentives => new ReadOnlyCollection<Incentive>(_assignedIncentives);
	    public int NumberOfAssignedIncentives => _assignedIncentives.Count;

        public Incentive AssignIncentive(IncentiveDefinition incentiveDefinition, IIncentiveValueCalculator incentiveValueCalculator, ISystemClock systemClock)
        {
            var incentiveValue = incentiveValueCalculator.CalculateValue(this, incentiveDefinition);
            var expirationDate = incentiveDefinition.CalculateExpirationDate(systemClock);

            var incentive = new Incentive
            {
                TraderAssigned = this,
                Type = incentiveDefinition,
                Value = incentiveValue,
                DateExpiring = expirationDate
            };

            _assignedIncentives.Add(incentive);
            return incentive;
        }
    }
}