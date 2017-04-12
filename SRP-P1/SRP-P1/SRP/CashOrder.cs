using SRP_P1.Model;

namespace SRP_P1.SRP
{
    class CashOrder : Order
    {
        public CashOrder(ShoppingCart shoppingCart) : base(shoppingCart) { }
    }
}
