using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAeAppV1.Models
{
    public class Product
    {  
        public int Id { get; set; }
        public string Model { get; set; }
        public string Memory { get; set; }
        public string ScreenType { get; set; }
        public string OS { get; set; }
        public string RAM { get; set; }
        public string Color { get; set; }
        public decimal Cost { get; set; }
        public string Path { get; set; }
    }
}
