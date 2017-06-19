using System;
using System.Collections.Generic;
using System.Linq;

namespace SystemInfoGrabber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string itemSelect;
            int itemNumber;
            Console.Write("24-7 Intouch Data Grabber\n" +
                          "1. Grab Network Info\n" +
                          "2. Grab System Info\n" +
                          "3. Grab Both!\n");
            itemSelect = Console.ReadLine();
            itemNumber = Convert.ToInt32(itemSelect);
            switch (itemNumber)
            {
                case 1:
                    Console.WriteLine("1 was picked!");
                    break;
                case 2:
                    Console.WriteLine("2 was picked!");
                    break;
                case 3:
                    Console.WriteLine("3 was picked!");
                    break;
                default:
                    Console.WriteLine("Invalid selection made.");
                    break;
            }
            return;
        }
    }
}
