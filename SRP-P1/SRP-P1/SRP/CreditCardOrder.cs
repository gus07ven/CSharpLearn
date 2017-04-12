﻿
using SRP_P1.Model;

namespace SRP_P1.SRP
{
    public class CreditCardOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;

        public CreditCardOrder(ShoppingCart shoppingCart, PaymentDetails paymentDetails, IPaymentService paymentService) : base(shoppingCart)
        {
            _paymentDetails = paymentDetails;
            _paymentService = paymentService;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            base.Checkout();
        }
    }
}
