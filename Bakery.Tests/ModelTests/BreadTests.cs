using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void LoafConstructor_CreatesInstanceOfLoaf_Bread()
    {
      Bread newLoaf = new Bread(5);
      Assert.AreEqual(typeof(Bread), newLoaf.GetType());
    }

    [TestMethod]
    public void GetLoafPrice_ReturnsLoafPrice_Int()
    {
      int loafPrice = 5;
      Bread newLoaf = new Bread(1);
      int totalLoafPrice = newLoaf.LoafCost();
      Assert.AreEqual(loafPrice, totalLoafPrice);
    }

    [TestMethod]
    public void GetLoafOrder_ReturnsLoafOrder_Int()
    {
      int loafOrder = 1;
      Bread newLoaf = new Bread(loafOrder);
      int totalLoaves = loafOrder;
      Assert.AreEqual(loafOrder, totalLoaves);
    }

     [TestMethod]
     public void TotalLoafPrice_ReturnsProductOfLoafPriceAndLoafOrder_Int()
     {
       int loafOrder = 1;
       int totalLoafPriceTest = 5;
       Bread newBread = new Bread (loafOrder);
       int totalLoafPrice = newBread.LoafCost();
       Assert.AreEqual(totalLoafPriceTest, totalLoafPrice);
     }
  }
}