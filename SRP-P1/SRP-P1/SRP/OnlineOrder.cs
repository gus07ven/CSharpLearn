﻿using SRP_P1.Model;

namespace SRP_P1.SRP
{
    public class OnlineOrder : Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        private readonly IReservationService _reservationService;

        public OnlineOrder(ShoppingCart shoppingCart, PaymentDetails paymentDetails, INotificationService notificationService, 
            IPaymentService paymentService, IReservationService reservationService): base(shoppingCart)
        {
            _paymentDetails = paymentDetails;
            _paymentService = paymentService;
            _reservationService = reservationService;
            _notificationService = notificationService;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            _reservationService.ReserveInventory(ShoppingCart.Items);
            _notificationService.NotifyCustomerOrderCreated(ShoppingCart);
            base.Checkout();
        }
    }
}
