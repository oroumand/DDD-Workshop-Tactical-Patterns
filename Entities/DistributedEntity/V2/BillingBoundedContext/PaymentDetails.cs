using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DistributedEntity.V2.BillingBoundedContext
{
    public class PaymentDetails
    {

        public Guid CustomerId { get; private set; }
        public CardDetails Default { get; private set; }
        public CardDetails Alternate { get; private set; }

    }
}
