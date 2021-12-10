using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
    public void Bread_WillReturnPriceForALoafOfBread_5()
    {
      int breadAmount = 1;
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(5, newBread.CalBreadPrice(1));
    }

    [TestMethod]
    public void Bread_WillReturnPriceForTwoLoaves_10()
    {
      int breadAmount = 2;
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(10, newBread.CalBreadPrice(2));
    }

    [TestMethod]
    public void Bread_WillReturnPriceForThreeLoaves_10()
    {
      int breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(10, newBread.CalBreadPrice(3));
    }
  
    [TestMethod]
    public void Pastry_WillReturnPriceForOnePastry_2()
    {
      int pastryAmount = 1;
      Pastry newPastry = new Pastry(pastryAmount);
      Assert.AreEqual(2, newPastry.CalPastryPrice(1));
    }

    [TestMethod]
    public void Pastry_WillReturnPriceForThreePastries_5()
    {
      int pastryAmount = 3;
      Pastry newPastry = new Pastry(pastryAmount);
      Assert.AreEqual(5, newPastry.CalPastryPrice(3));
    }
   
    [TestMethod]
    public void Pastry_WillReturnPriceForFourPastries_7()
    {
      int pastryAmount = 4;
      Pastry newPastry = new Pastry(pastryAmount);
      Assert.AreEqual(7, newPastry.CalPastryPrice(4));
    }

    [TestMethod]
    public void CalPastryPrice_WillReturnPriceForInputtedAmount_9()
    {
      int pastryAmount = 5;
      Pastry newPastry = new Pastry(pastryAmount);
      Assert.AreEqual(9, newPastry.CalPastryPrice(5));
    }
  
    [TestMethod]
    public void CalBreadPrice_WillReturnPriceForInputtedAmount_85()
    {
      int breadAmount = 25;
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(85, newBread.CalBreadPrice(25));
    }
  }
}