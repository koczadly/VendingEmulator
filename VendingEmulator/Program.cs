using System;

namespace VendingEmulator {
    class Program {

        static FinanceManager financeMgr = new FinanceManager();
        static InventoryManager inventoryMgr = new InventoryManager();

        static void Main(string[] args) {
            initInventory();

            while (true) {
                inventoryMgr.PrintMenu(financeMgr);

                // Enter money
                int insertedCoins = financeMgr.AcceptCoins();


                Console.WriteLine("Current balance: {0}.", financeMgr.Format(insertedCoins));
            }
        }

        static void initInventory() {
            inventoryMgr.StockItem(new Product("Coca-Cola", 125, 10));
            inventoryMgr.StockItem(new Product("Pepsi", 125, 20));
            inventoryMgr.StockItem(new Product("Sprite", 125, 10));
            inventoryMgr.StockItem(new Product("Dr. Pepper", 125, 8));
            inventoryMgr.StockItem(new Product("Doritos", 75, 15));
            inventoryMgr.StockItem(new Product("Pringles", 75, 5));
        }


        public static string ReadInput(string msg) {
            if (msg != null)
                Console.Write(msg + ": ");
            return Console.ReadLine().Trim().ToLower();
        }

    }
}
