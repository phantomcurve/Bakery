using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      int pastryOrder = 1;
      int pastryCost = 2;
      Pastry newPastry = new Pastry(pastryOrder);
      int total = newPastry.PastryCost();
      Assert.AreEqual(pastryCost, total);
    }

    [TestMethod]
    public void GetPastryOrder_RetunsPastryOrder_Int()
    {
      int pastryOrder = 1;
      Pastry newPastry = new Pastry(pastryOrder);
      int totalPastries = pastryOrder;
      Assert.AreEqual(pastryOrder, totalPastries);
    }

    [TestMethod]
    public void TotalPastryPrice_ReturnsProductOfPastryPriceAndPastryQuantity_Int()
    {
      int pastryOrder = 1;
      int pastryPriceTest = 2;
      Pastry newPastry = new Pastry(pastryOrder);
      int totalPastryCost = newPastry.PastryCost();
      Assert.AreEqual(totalPastryCost, pastryPriceTest);
    }

    [TestMethod]
    public void TotalPastryPrice_ReturnsPromoPricingUponQuantityQualifiers_Int()
    {
      int pastryOrder = 3;
      int pastryPriceTest = 5;
      Pastry newPastry = new Pastry(pastryOrder);
      int totalPastryCost = newPastry.PastryCost();
      Assert.AreEqual(pastryPriceTest, totalPastryCost);
    }
  } 
}