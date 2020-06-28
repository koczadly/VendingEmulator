using System;
using System.Collections.Generic;
using System.Text;

namespace VendingEmulator {
    public class FinanceManager {

        
        public int FromInput(string val) {
            switch (val.ToLower()) {
                case "1p": return 1;
                case "2p": return 2;
                case "5p": return 5;
                case "10p": return 10;
                case "20p": return 20;
                case "50p": return 50;
                case "£1": return 100;
                case "£2": return 200;
                default: return -1; // Not valid
            }
        }

        public string Format(int pence) {
            return String.Format("£{0:N2}", pence / 100d);
        }

        public int AcceptCoins() {
            int total = 0;

            Console.WriteLine("Accepted coins: 1p, 2p, 5p, 10p, 20p, 50p, £1, £2");
            string input;
            while (true) {
                input = Program.ReadInput("Enter a coin");
                if (input.Length == 0)
                    return total;

                int coinValue = FromInput(input);
                if (coinValue == -1) {
                    Console.WriteLine("Unknown coin {0}, please try again.", input);
                } else {
                    total += coinValue;
                    Console.WriteLine("You inserted {0}, current balance: {1}.", input, Format(total));
                }
            };
        }

    }
}
