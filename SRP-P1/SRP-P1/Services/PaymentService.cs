using System;

namespace SRP_P1.Services
{
    public class PaymentService
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public decimal AmountToCharge { get; set; }

        public void Charge()
        {
            throw new AccountBalanceMismatchException();
        }
    }

    public class AccountBalanceMismatchException: Exception { }

}
