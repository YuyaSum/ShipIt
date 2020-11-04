using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ShipIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper ship = new Shipper();

            char choice = 'x';
            while (choice != '6')
            {
                Console.WriteLine("Choose from the following options: \n");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");

                choice = Console.ReadKey().KeyChar;

                Console.Clear();
                switch (choice)
                {
                    case '1':
                        ship.Add(new Bicycle());
                        Console.WriteLine("1 Bicycle has been added \nPress any key to return to the menu.");
                        Console.ReadKey(true);
                        break;
                    case '2':
                        ship.Add(new LawnMower());
                        Console.WriteLine("1 Lawn Mower has been added \nPress any key to return to the menu.");
                        Console.ReadKey(true);
                        break;
                    case '3':
                        ship.Add(new BaseBallGlove());
                        Console.WriteLine("1 Baseball Glove has been added \nPress any key to return to the menu.");
                        Console.ReadKey(true);
                        break;
                    case '4':
                        ship.Add(new Crackers());
                        Console.WriteLine("1 Crackers has been added \nPress any key to return to the menu.");
                        Console.ReadKey(true);
                        break;
                    case '5':
                        //List items with apporperate plurality: (Crackers is always plural)
                        int bikeCount = 0;
                        int mowerCount = 0;
                        int gloveCount = 0;
                        int crackersCount = 0;

                        foreach (IShippable item in ship.getList())
                        {
                            if (item is Bicycle)
                            {
                                bikeCount++;
                            }
                            else if (item is LawnMower)
                            {
                                mowerCount++;
                            }
                            else if (item is BaseBallGlove)
                            {
                                gloveCount++;
                            }
                            else
                            {
                                crackersCount++;
                            }
                        }
                        Console.WriteLine("Shipment manifest:");
                        if (bikeCount > 1)
                        {
                            Console.WriteLine(bikeCount + " Bicycles");
                        }
                        else
                        {
                            Console.WriteLine(bikeCount + " Bicycle");
                        }
                        if (mowerCount > 1)
                        {
                            Console.WriteLine(mowerCount + " Lawn Mowers");
                        }
                        else
                        {
                            Console.WriteLine(mowerCount + " Lawn Mower");
                        }
                        if (gloveCount > 1)
                        {
                            Console.WriteLine(gloveCount + " Baseball Gloves");
                        }
                        else
                        {
                            Console.WriteLine(gloveCount + " Baseball Glove");
                        }
                        Console.WriteLine(crackersCount + " Crackers\n");
                        break;
                    case '6':
                        Console.WriteLine("Total shipping costs for this order are $" + ship.calcShipping() + "\nPress any key to exit.");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine("Invalid Option: Try Again.");
                        break;
                }
            }
        }
    }
}
