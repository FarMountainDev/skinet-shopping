using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntendIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntendIdSpecification(string paymentIntendId)
         : base(o => o.PaymentIntentId == paymentIntendId)
        {
        }
    }
}