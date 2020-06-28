using System;
using System.Collections.Generic;
using System.Text;

namespace VendingEmulator {
    public class InventoryManager {

        private List<Product> products = new List<Product>();


        public bool IsSlotValid(int slot)
        {
            return slot > 0 && slot <= products.Count;
        }

        public Product GetProduct(int slot)
        {
            return products[slot - 1];
        }

        public void StockItem(int slot, int newStock)
        {
            GetProduct(slot).Stock += newStock;
        }

        public int StockItem(Product p)
        {
            products.Add(p);
            return products.Count;
        }

        public bool Dispense(int slot)
        {
            Product p = GetProduct(slot);
            if (p.Stock > 0) {
                Console.WriteLine("Thank you for purchasing {0}.", p.Name);
                p.Stock--;
                return true;
            } else {
                Console.WriteLine("Sorry, this product is out of stock!");
                return false;
            }
            
        }

        public void PrintMenu(FinanceManager finance)
        {
            Console.WriteLine("====== VENDING MACHINE MENU ======");
            Console.WriteLine("----------------------------------");
            int slotNum = 1;
            products.ForEach(p => {
                Console.WriteLine("[{0}] {1}: {2} ({3} in stock)", slotNum++, p.Name, finance.Format(p.Price), p.Stock);
            });
            Console.WriteLine("==================================");
            Console.WriteLine();
        }

    }
}
