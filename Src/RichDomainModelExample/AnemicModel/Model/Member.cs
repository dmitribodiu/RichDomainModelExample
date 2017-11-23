using System.Collections.Generic;

namespace AnemicModel.Model
{
	public class Member
    {
        public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Incentive> AssignedOffers { get; set; }
        public int NumberOfActiveOffers { get; set; }
    }
}