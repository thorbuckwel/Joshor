using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{
    public class Create
    {        
        public static void WhatToCreate()
        {
            string userInput;

            Console.WriteLine("What do you want to create?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Item, NPC, MOB, Weapon, Room > ");
            Console.ForegroundColor = ConsoleColor.White;
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "item") 
            {
                CreateItem();
            }
            else if (userInput.ToLower() == "npc")
            {

            }
            else if (userInput.ToLower() == "mob")
            {

            }
            else if (userInput.ToLower() == "weapon")
            {

            }
            else if (userInput.ToLower() == "room")
            {

            }
        }

        public static void CreateItem()
        {
            string userInput;
            int id;
            string name;
            string namePlural;
            string desc;
            int price;
            bool equiptable;
            bool exist = false;


            while (exist == false)
            {
                Console.WriteLine("What is the item's ID?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("201 - 300 >");
                Console.ForegroundColor = ConsoleColor.White;
                userInput = Console.ReadLine();
                if (userInput != null)
                {
                    id = Convert.ToInt32(userInput);
                    if (id > 200 && id < 300)
                    {
                        foreach (Item item in World.Items.ToList())
                        {
                            if (item.ID == id)
                            {
                                Console.WriteLine("That item already exist");
                            }
                        }


                        Console.WriteLine("Name of the item.");
                        name = Console.ReadLine();

                        Console.WriteLine("Pluarl name of the item.");
                        namePlural = Console.ReadLine();

                        Console.WriteLine("Description of the item.");
                        desc = Console.ReadLine();

                        Console.WriteLine("Price of the item.");
                        price = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Can item be equipt.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("True or False > ");
                        Console.ForegroundColor = ConsoleColor.White;
                        equiptable = bool.Parse(Console.ReadLine());

                        World.Items.Add(new Item(id, name, namePlural, desc, price, equiptable));

                        if (File.Exists(@"../../../Engine/Docs/Items.txt"))
                        {
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", id.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", name + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", namePlural + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", desc + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", price.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Items.txt", equiptable.ToString());
                        }

                        exist = true;
                    }
                        
                }
            }    
        }
    }
}
