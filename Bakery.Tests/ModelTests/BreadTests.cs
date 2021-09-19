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
  }
}