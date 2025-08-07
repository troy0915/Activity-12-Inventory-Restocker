using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_12Inventory_Restocker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productNames = new List<string>();
            List<int> stockCounts = new List<int>();
            List<bool> wasRestocked = new List<bool>();

            Console.WriteLine("Enter details for 10 products:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Product {i + 1} name: ");
                string name = Console.ReadLine();

                Console.Write($"Stock count for {name}: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int stock) && stock >= 0)
                    {
                        productNames.Add(name);
                        stockCounts.Add(stock);
                        wasRestocked.Add(false);
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                }
            }
            for (int i = 0; i < stockCounts.Count; i++)
            {
                if (stockCounts[i] < 10)
                {
                    stockCounts[i] += 20;
                    wasRestocked[i] = true;
                }
            }
            Console.WriteLine("\nStock Report:");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < productNames.Count; i++)
            {
                string restockFlag = wasRestocked[i] ? "[RESTOCKED]" : "";
                Console.WriteLine($"{productNames[i],-20} {stockCounts[i],5} {restockFlag}");
            }
        }
    }
}



