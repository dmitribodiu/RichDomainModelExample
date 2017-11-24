using System;

namespace RichModel.Model
{
	public class Incentive 
	{
	    public Incentive(Trader traderAssigned, IncentiveDefinition incentiveDefinition, DateTime expirationDate, int value)
	    {
	        TraderAssigned = traderAssigned;
	        Type = incentiveDefinition;
	        DateExpiring = expirationDate;
	        Value = value;
	    }
		public Trader TraderAssigned { get;  set; }
		public IncentiveDefinition Type { get;  set; }
		public DateTime DateExpiring { get;  set; }
		public int Value { get;  set; }
	}
}