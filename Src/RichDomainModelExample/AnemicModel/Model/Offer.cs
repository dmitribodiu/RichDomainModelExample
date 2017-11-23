using System;

namespace AnemicModel.Model
{
	public class Offer 
	{
		public Member MemberAssigned { get;  set; }
		public OfferType Type { get;  set; }
		public DateTime DateExpiring { get;  set; }
		public int Value { get;  set; }
	}
}