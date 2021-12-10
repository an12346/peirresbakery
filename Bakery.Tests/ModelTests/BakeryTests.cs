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
    public void Bread_WillReturnPriceForOnePastry_2()
    {
      int pastryAmount = 1;
      Pastry newPastry = new Pastry(pastryAmount);
      Assert.AreEqual(2, newPastry.CalPastryPrice(1));
    }
  
  }
}