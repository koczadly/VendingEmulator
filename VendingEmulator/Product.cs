using System;
using System.Collections.Generic;
using System.Text;

namespace VendingEmulator {
    public class Product {

        public String Name { get; }
        public int Price { get; }
        public int Stock { get; set; }

        public Product(String Name, int Price, int InitialStock) {
            this.Name = Name;
            this.Price = Price;
            this.Stock = InitialStock;
        }

    }
}
