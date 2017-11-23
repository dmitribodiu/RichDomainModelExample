using System;

namespace AnemicModel.Model
{
	public class Incentive 
	{
		public Member MemberAssigned { get;  set; }
		public IncentiveDefinition Type { get;  set; }
		public DateTime DateExpiring { get;  set; }
		public int Value { get;  set; }
	}
}