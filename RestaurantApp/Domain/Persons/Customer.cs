using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RestaurantApp
{
    public class Customer
    {
        [Key]
        public byte TableNumber { get; set; }
        public byte NumberOfPersons { get; set; }
        public Bill  Bill{ get; set; }

        public Customer()
        {
        }

        public Customer(byte tableNumber, byte numberOfPersons, Bill bill)
        {
            TableNumber = tableNumber;
            NumberOfPersons = numberOfPersons;
            Bill = bill;
        }
    }
}
