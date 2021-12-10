using System;
using System.Collections.Generic;
using Bakery.Models;  //import namespaces from Item.cs

class BakeryUI
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! We have a wide selection of baked goods. Our Menu is listed below:");
    Console.WriteLine("Pastries: $1.00");
    Console.WriteLine("Bread: $5.00/loaf");
    Console.WriteLine("Special pastry deal: buy 3 for $5.00, 4 for $7.00, 5 for $9.00, or 6 for $10.00");
    Console.WriteLine("Special bread deal: Buy two loafs of bread get one free! (valid up to 3 loafs");
    Console.WriteLine("Would you like to order bread or pastries?");
    string selection = Console.ReadLine();

    if (selection.ToLower() == "bread")
      {
        Console.WriteLine("How many loafs of bread would you like to order?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadOrder);
        int breadTotal = newBread.CalBreadPrice(breadOrder);
        Console.WriteLine("Your total is " + "$" + breadTotal + ".00");
        Console.WriteLine("Would you like to order some pastries? (yes/no)");
        string pastrySelect = Console.ReadLine();
        if (pastrySelect.ToLower() == "yes")
          {
            Console.WriteLine("How many pastries would you like to order?");
            int pastryOrder = int.Parse(Console.ReadLine());
            Pastry newPastry = new Pastry(pastryOrder);
            int pastryTotal = newPastry.CalPastryPrice(pastryOrder);
            Console.WriteLine("Your pastry total is " + "$" + pastryTotal + ".00");
            int orderTotal = breadTotal + pastryTotal;
            Console.WriteLine("Thank you for your order! Your total is " + "$" + orderTotal + ".00");
          }
          else if (pastrySelect.ToLower() == "no")
            {
              Console.WriteLine("Thank you for your order!");
            }
            else {
              Console.WriteLine("Please enter either yes or no.");
            }
      }
        else if (selection.ToLower() == "pastries")
          {
            Console.WriteLine("How many pastries would you like to order?");
            int pastryOrder = int.Parse(Console.ReadLine());
            Pastry newPastry = new Pastry(pastryOrder);
            int pastryTotal = newPastry.CalPastryPrice(pastryOrder);
            Console.WriteLine("Your total is " + "$" + pastryTotal + ".00");
            Console.WriteLine("Would you like to order some bread? (yes/no)");
            string breadSelect = Console.ReadLine();
            if (breadSelect.ToLower() == "yes")
            {
              Console.WriteLine("How many loafs of bread would you like to order?");
              int breadOrder = int.Parse(Console.ReadLine());
              Bread newBread = new Bread(breadOrder);
              int breadTotal = newBread.CalBreadPrice(breadOrder);
              Console.WriteLine("Your bread total is " + "$" + breadTotal + ".00");
              int orderTotal = breadTotal + pastryTotal;
              Console.WriteLine("Thank you for your order! Your total is " + "$" + orderTotal + ".00");
            }
            else if (breadSelect.ToLower() == "no")
              {
                Console.WriteLine("Thank you for your order!");
              }
              else {
                Console.WriteLine("Please enter either yes or no.");
                }
          }
      else {
      Console.WriteLine("Please enter either bread or pastries.");
      Main();
    }
  }
}





