using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Concept
    {
        public int Quantity { get; }
        public int IdBeer { get; }
        public decimal UnitPrice { get; }
        public decimal Price { get; }
        public Concept(int quantity, int idBeer, decimal unitPrice)
        {
            Quantity = quantity;
            IdBeer = idBeer;
            UnitPrice = unitPrice;
            Price = GetTotalPrice();
        }
        private decimal GetTotalPrice()
            => Quantity * UnitPrice;
    }
}
