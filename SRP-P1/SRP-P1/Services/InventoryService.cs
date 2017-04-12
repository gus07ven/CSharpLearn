using System;

namespace SRP_P1.Services
{
    public class InventoryService
    {
        public void Reserve(string indentifier, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }

    public class InsufficientInventoryException : Exception { }

}
