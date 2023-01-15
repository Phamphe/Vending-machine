using System;
using Vanding_machine;

namespace Bank
{

 class Program
    {   
        public static void Main(string[] args)
        {

            void menuOption()
            {
                Console.WriteLine("{0, -9}{1, -15}", "SR.NO", "MENU");
                Console.WriteLine("{0, -9}{1, -15}", "1.", "Sweets");
                Console.WriteLine("{0, -9}{1, -15}", "2.", "Confentionery");
                Console.WriteLine("{0, -9}{1, -15}", "3.", "Beverages");
                Console.WriteLine("{0, -9}{1, -15}", "4.", "Fruits");
                Console.WriteLine("{0, -9}{1, -15}", "5.", "Exit");
            }

            void sweets()
            {
                string sweetsDecision = string.Empty;
                int totalSweetsBill = 0;
                do
                {
                    

                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "SR.NO", "SWEETS", "PRICE");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "1.", "Bubblegum", "1$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "2.", "Lollipop", "7$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "3.", "Sour fruits", "5$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "4.", "Chocolate", "4$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "5.", "..", "Exit");



                    Console.WriteLine("Which items would you like from this section");

                    
                    int sweetsOption = 0;
                    sweetsOption = int.Parse(Console.ReadLine());

                    switch (sweetsOption)
                    {
                        case 1:
                            totalSweetsBill += 1;
                            break;
                        case 2:
                            totalSweetsBill += 7;
                            break;
                        case 3:
                            totalSweetsBill += 5;
                            break;
                        case 4:
                            totalSweetsBill += 4;
                            break;
                        case 5:
                            menuOption();
                            break;
                        default:
                            Console.WriteLine("INVALID ENTRY!!");
                            break;
                    }
                    

                    do
                    {
                        Console.WriteLine("Do you want to add another item under this section?....");
                        sweetsDecision = Console.ReadLine().ToUpper();

                        if (sweetsDecision != "YES" && sweetsDecision != "NO")
                        {
                            Console.WriteLine("The entry is invalid");
                        }
                    } while (sweetsDecision != "YES" && sweetsDecision != "NO");

                  


                } while (sweetsDecision != "NO");
                Console.WriteLine("Your total bill amount under this section is " + totalSweetsBill + "$  Press enter to show Menu");
                Console.WriteLine("Thank you :)");
                if (sweetsDecision == "NO")
                {
                    menuOption();
                }



            }

            void confectionery()
            {
                string confectioneryDecision = string.Empty;
                int totalConfectioneryBill = 0;

                do
                {

                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "SR.NO", "CONFECTIONERY", "PRICE");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "1.", "Muffin", "3$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "2.", "Scones", "2$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "3.", "Biscut", "1$");
                    Console.WriteLine("{0, -9}{1, -15}", "4.", "Exit");


                    Console.WriteLine("Which items do you want under this section??...");

                    int confectionery = 0;
                    confectionery = int.Parse(Console.ReadLine());

                    switch (confectionery)
                    {
                        case 1:
                            totalConfectioneryBill += 3;
                            break;
                        case 2:
                            totalConfectioneryBill += 2;
                            break;
                        case 3:
                            totalConfectioneryBill += 1;
                            break;

                        case 4:
                            menuOption();
                            break;

                        default:
                            Console.WriteLine("INVALID ENTRY");
                            break;
                    }

                    do
                    {
                        Console.WriteLine("Do you want another item under this section");
                        confectioneryDecision = Console.ReadLine().ToUpper();
                        if (confectioneryDecision != "YES" && confectioneryDecision != "NO")
                        {
                            Console.WriteLine("The entry is invalid");
                        }

                    } while (confectioneryDecision != "YES" && confectioneryDecision != "NO");

                } while (confectioneryDecision != "NO");

                Console.WriteLine("You total bill under this section is " + totalConfectioneryBill + "$.");
                Console.WriteLine("Thank You :)");
                if (confectioneryDecision == "NO")
                {
                    menuOption();
                }

            }

            void beverages()
            {
                string beverageDecision = string.Empty;
                int totalBeverageBill = 0;

                do
                {

                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "SR.NO", "BEVERAGES", "PRICE");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "1.", "Coca-cola", "2$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "2.", "Water", "3$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "3.", "Juice", "5$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "4.", "Aloe Vera", "7$");
                    Console.WriteLine("{0, -9}{1, -15}", "5.", "Exit");

                    Console.WriteLine("Which items do you want under this section??");

                    int Beverage = 0;
                    Beverage = int.Parse(Console.ReadLine());

                    switch (Beverage)
                    {
                        case 1:
                            totalBeverageBill += 2;
                            break;
                        case 2:
                            totalBeverageBill += 3;
                            break;
                        case 3:
                            totalBeverageBill += 5;
                            break;
                        case 4:
                            totalBeverageBill += 7;
                            break;
                        case 5:
                            menuOption();
                            break;

                        default:
                            Console.WriteLine("INVALID ENTRY");
                            break;
                    }
                    do
                    {
                        Console.WriteLine("Do you want another item under this section");
                        beverageDecision = Console.ReadLine().ToUpper();
                        if (beverageDecision != "YES" && beverageDecision != "NO")
                        {
                            Console.WriteLine("The entry is invalid");
                        }

                    } while (beverageDecision != "YES" && beverageDecision != "NO");
                } while (beverageDecision != "NO");

                Console.WriteLine("You total bill under this section is " + totalBeverageBill + "$.");
                Console.WriteLine("Thank You :)");
                if (beverageDecision == "NO")
                {
                    menuOption();
                }


            }

            void fruits()
            {
                string fruitsDecision = string.Empty;
                int totalFruitsBill = 0;

                do
                {

                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "SR.NO", "FRUITS", "PRICE");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "1.", "Banana", "1$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "2.", "Pear", "2$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "3.", "Grapes", "3$");
                    Console.WriteLine("{0, -9}{1, -15}{2, 0}", "4.", "Oranges", "6$");
                    Console.WriteLine("{0, -9}{1, -15}", "5.", "Exit");

                    int Fruits = 0;
                    Fruits = int.Parse(Console.ReadLine());

                    switch (Fruits)
                    {
                        case 1:
                            totalFruitsBill += 1;
                            break;
                        case 2:
                            totalFruitsBill += 2;
                            break;
                        case 3:
                            totalFruitsBill += 3;
                            break;
                        case 4:
                            totalFruitsBill += 6;
                            break;
                        case 5:
                            menuOption();
                            break;
                            default:
                            Console.WriteLine("INVALID ENTRY");
                            break;

                    }
                    do
                    {
                        Console.WriteLine("Do you want another item under this section");
                        fruitsDecision = Console.ReadLine().ToUpper();
                        if (fruitsDecision != "YES" && fruitsDecision != "NO")
                        {
                            Console.WriteLine("The entry is invalid");
                        }
                    } while (fruitsDecision != "YES" && fruitsDecision != "NO");

                } while (fruitsDecision != "NO");

                Console.WriteLine("You total bill under this section is " + totalFruitsBill + "$.");
                Console.WriteLine("Thank You:");

                if(fruitsDecision =="NO")
                {
                    menuOption();
                }
                

              




            }
            Console.Write("Welcome to our vending machine. Proceed and enter your name:");
           

            string Username = Console.ReadLine();

            Console.WriteLine(Username + " This what we currently have on the menu: ");

            menuOption();
            


            int menuDecision = 0;
            menuDecision = int.Parse(Console.ReadLine());


                if (menuDecision == 1)
                {
                    sweets();
                }
                else if (menuDecision == 2)
                {
                    confectionery();
                }
                else if (menuDecision == 3)
                {
                    beverages();
                }
                else if (menuDecision == 4)
                {
                    fruits();
                }
             
                else
                {
                    Console.WriteLine("INVALID ENTRY!!!");
                }
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
            





        }
    }



}


