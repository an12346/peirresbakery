using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int amountBread {get; set;}

    public Bread(int amountBread)
    {
      amountBread = 5;
    }
    
    public int CalBreadPrice(int amount) 
    {
      int breadPrice = 0;
      
      if (amount == 1)
      {
        return breadPrice += 5;
      }
      else if (amount == 2) 
      {
        return breadPrice += 10;
      }
      else if (amount == 3)
      {
        return breadPrice += 10;
      }
      else
      {
        return breadPrice;
      }
    }
  }
  public class Pastry
  {
    public int amountPastry {get; set;}
    public Pastry(int amountPastry)
    {
      amountPastry = 2;
    }

    public int CalPastryPrice(int amount)
    {
      int pastryPrice = 0;
      
      if (amount == 1)
      {
        return pastryPrice += 2;
      }
      else if (amount == 3)
      {
        return pastryPrice += 5;
      }
      else if (amount == 4)
      {
        return pastryPrice += 7;
      }
      else {
        return amount * 2;
      }
    }
  }
}

// include auto implemented properties
// Instructions:
  //Create a console app for a bakery 
  // Bread class and Pastry class 
  // When a user runs the app, they should receive the message: "Welcome to Pierre's Bakery! We offer a wide selection of Bread and Pastries. Our prices are listed below.
  // Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
  // Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
  // Would you like to order a pastry or bread? (bread/pastry)
  // How many?
  // would that be all (yes/no)
  // Your order is ---. Thank you for your order!

// 1. Create class for bread
// 2. create constructor for Bread
// 3. create a test 
// 4. Red green refactor

// 5. Create a class for pastry 
// 6. create constructor for Pastry
// 7. create test 
// 8. Red green refactor

// create UI logic 