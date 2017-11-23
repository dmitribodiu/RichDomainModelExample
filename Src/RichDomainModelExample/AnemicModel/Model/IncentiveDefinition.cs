using System;

namespace AnemicModel.Model
{
    public class IncentiveDefinition
    {
        public string Name { get;  set; }
        public ExpirationType ExpirationType { get;  set; }
        public int DaysValid { get;  set; }
        public DateTime? BeginDate { get;  set; }
    }
}