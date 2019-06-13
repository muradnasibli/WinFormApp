using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAeAppV1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Model { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}
