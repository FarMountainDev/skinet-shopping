using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Order()
        {
        }

        public Order(IReadOnlyList<OrderItem> orderItems, string buyerEmail, Address shipToAddress,
            DeliveryMethod deliveryMethod, decimal subtotal, string paymentIntendId)
        {
            OrderItems = orderItems;
            BuyerEmail = buyerEmail;
            ShipToAddress = shipToAddress;
            DeliveryMethod = deliveryMethod;
            Subtotal = subtotal;
            PaymentIntentId = paymentIntendId;
        }

        public string BuyerEmail {get; set;}
        public DateTime OrderDate {get; set;} = DateTime.UtcNow;

        [Required]
        public Address ShipToAddress {get; set;}
        public DeliveryMethod DeliveryMethod {get; set;}
        public IReadOnlyList<OrderItem> OrderItems {get; set;}
        public Decimal Subtotal {get; set;}
        public OrderStatus Status {get; set;} = OrderStatus.Pending;
        public string PaymentIntentId {get; set;}

        public decimal GetTotal()
        {
            return Subtotal + DeliveryMethod.Price;
        }
    }
}