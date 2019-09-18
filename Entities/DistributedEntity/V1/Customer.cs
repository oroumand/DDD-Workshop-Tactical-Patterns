using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DistributedEntity.V1
{
    public class Customer
    {
        public Customer(Guid id, AddressBook addresses, Orders orderHistory,
        PaymentDetails paymentDetails, LoyaltySummary loyalty)
        {
            Addresses = addresses;
            OrderHistory = orderHistory;
            PaymentDetails = paymentDetails;
            Loyalty = loyalty;
        }
        public Guid Id { get; private set; }
        public AddressBook Addresses { get; private set; }
        public Orders OrderHistory { get; private set; }
        public PaymentDetails PaymentDetails { get; private set; }
        public LoyaltySummary Loyalty { get; private set; }
    }
}
