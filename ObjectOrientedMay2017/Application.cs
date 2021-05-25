using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOTEST
{
    class Application
    {    
        static void Main(string[] args)
        {
            bool quit = false;
            string input, input1,store1;
            Console.WriteLine("Please Enter the name of the store!");
            Console.Write("Store : ");
            store1 = Console.ReadLine();
            Store store = new Store(store1);
            Console.Clear();
            while (!quit)
            {
                Console.WriteLine("1.Add New Item\n2.Find Item and Edit Item Quantity\n3.Find Unavailable Item\n4.Quit");
                Console.WriteLine("What would you like to do : ");
                input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        Item aitem = AddItem();
                        store.AddItem(aitem);
                        Console.Clear();
                        Console.WriteLine("Succesfully added!!!");
                        break;
                    case "2":
                        string aCode=FindanItem();
                        int a,b;
                        Item bitem=store.FindItem(aCode);
                        if (bitem != null)
                        {
                            Console.WriteLine("Item Code: {0}\nDescription : {1}\nQuantity : {2}\n",
                                bitem.Itemcode, bitem.Description, bitem.Quantityavailable);
                            Console.WriteLine("Do you want to put in or take out any of the item?");
                            Console.WriteLine("1.Put In Item\n2.Take Out Item\n3.No");
                            input1 = Console.ReadLine();
                            switch(input1)
                            {
                                case "1":
                                    a=AddQuantity();
                                    bitem.PutIn(a);
                                    break;
                                case "2":
                                    b = SubQuantity();
                                    if(b>bitem.Quantityavailable)
                                    {
                                        Console.WriteLine("Not enough items available!");
                                    }
                                    bitem.TakeOut(b);
                                    break;
                                case "3":
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input!");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Items not found!");
                        }
                        Console.WriteLine("Press any key back to main menu!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                   case "3":
                        ArrayList itemlist=store.GetUnavailableItems();
                        int count = itemlist.Count;
                        for(int i=0;i< count;i++)
                        {
                            Item citem = (Item)itemlist[i];
                            Console.WriteLine("Item Code: {0}\nDescription : {1}\nQuantity : {2}\n",
                                citem.Itemcode, citem.Description, citem.Quantityavailable);
                        }
                        Console.WriteLine("Press any key back to main menu!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        quit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }
        public static Item AddItem()
        {

            Console.WriteLine("Please key in item's details!");
            Console.Write("Item Code : ");
            string acode = Console.ReadLine();
            Console.Write("Description : ");
            string adescription = Console.ReadLine();
            Console.Write("Quantity of Item : ");
            int aquantity = Convert.ToInt32(Console.ReadLine());
            Item aitem = new Item(acode, adescription, aquantity);
            return aitem;
        }
        public static string FindanItem()
        {
            string acode;
            Console.WriteLine("Enter the item's code that you want to find!");
            Console.Write("Item Code : ");
            acode=Console.ReadLine();
            return acode;
        }
        public static int AddQuantity()
        {
            Console.WriteLine("How many quantity do you want to put in?");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public static int SubQuantity()
        {
            Console.WriteLine("How many quantity do you want to take out?");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            return b;
        }
    }
}

