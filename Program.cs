using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  itemselected=0,
                coffeequantity=0,
                sandwitchquantity=0,
                friesquantity = 0,
                noodlesquantity = 0,
                pizzaquantity = 0   ;
            char input;
            do
            {
                Console.WriteLine("Select the item from menu you want to order:");
                Console.WriteLine("1.  Coffee:40");
                Console.WriteLine("2.  Grilled Sandwitch:80");
                Console.WriteLine("3.  French Fries:60");
                Console.WriteLine("4.  Noodles:50");
                Console.WriteLine("5.  Pizza:120");

                itemselected = Convert.ToInt32(Console.ReadLine());
                int quantity=0;
                switch (itemselected)
                {
                    case 1:
                        {
                            Console.WriteLine("You selected coffee");
                            Console.WriteLine("Quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            coffeequantity += quantity;
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("You selected Grilled Sandwitch");
                            Console.WriteLine("Quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            sandwitchquantity += quantity;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You selected French Fries");
                            Console.WriteLine("Quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            friesquantity += quantity;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You selected Noodles");
                            Console.WriteLine("Quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            noodlesquantity += quantity;
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("You selected Pizza"); 
                            Console.WriteLine("Quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            pizzaquantity += quantity;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not a valid item");
                            break;
                        }


                }
                Console.WriteLine("Do you want to add more item:(y/n)");
                input = Convert.ToChar(Console.ReadLine());
                         } while (input == 'y');


            if (coffeequantity > 0)
            {
                Console.Write(coffeequantity + " coffee ");
            }
            if (sandwitchquantity> 0)
            {
                Console.Write(sandwitchquantity + " grilled sandwitch ");
            }
            if (friesquantity > 0)
            {
                Console.Write(friesquantity + " french fries ");
            }
            if (noodlesquantity > 0)
            {
                Console.Write(noodlesquantity + " noodles ");
            }
            if (pizzaquantity > 0)
            {
                Console.WriteLine(pizzaquantity+ " pizza ");
            }

            double totalbill = (coffeequantity * 40 + sandwitchquantity * 80 + friesquantity * 60 + noodlesquantity * 50 + pizzaquantity * 120);
            Console.WriteLine("Total Bill: " + totalbill);
            double CGST = totalbill / 20;
            double SGST = totalbill * 0.18;
            Console.WriteLine("CGST 5% " + CGST);
            Console.WriteLine("SGST 18% " + SGST);

            double amounttopay = totalbill + CGST + SGST;

            Console.WriteLine("Total amount to pay: " + amounttopay);
            


        }
    }
}
