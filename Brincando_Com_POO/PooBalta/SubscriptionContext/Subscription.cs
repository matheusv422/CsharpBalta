using System;
using PooBalta.SharedContext;

namespace PooBalta.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
         public DateTime? EndDate { get; set; }
         public bool IsInactive => EndDate <= DateTime.Now;
        
        
    }
}