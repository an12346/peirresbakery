using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]

    public void Bread_WillReturnPriceForALoafOfBread_2()
    {
      string breadAmount = "1";
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(2, newBread.CalBreadPrice(1));
    }

  }
}