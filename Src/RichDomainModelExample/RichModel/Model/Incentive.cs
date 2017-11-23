using System;

namespace RichModel.Model
{
	public class Incentive 
	{
		public Trader TraderAssigned { get;  set; }
		public IncentiveDefinition Type { get;  set; }
		public DateTime DateExpiring { get;  set; }
		public int Value { get;  set; }
	}
}