using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitInStock { get; set; }
    }
}
