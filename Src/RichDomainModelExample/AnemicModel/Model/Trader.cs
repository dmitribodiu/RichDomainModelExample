using System.Collections.Generic;

namespace AnemicModel.Model
{
	public class Trader
    {
        public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Incentive> AssignedIncentives { get; set; }
        public int NumberOfAssignedIncentives { get; set; }
    }
}