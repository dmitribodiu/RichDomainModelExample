using System;

namespace AnemicModel.Model
{
	public class Incentive 
	{
		public Trader TraderAssigned { get;  set; }
		public IncentiveDefinition IncentiveDefinition { get;  set; }
		public DateTime DateExpiring { get;  set; }
		public int Value { get;  set; }
	}
}