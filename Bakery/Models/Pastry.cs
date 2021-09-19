using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; } = 2;
    public int PastryOrder { get; set; }
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
    public int PastryCost()
    {
     if (PastryOrder % 3 == 0)
      {
        int totalPastryPrice = (PastryOrder / 3) * 5;
        return totalPastryPrice;
      }
      else if (PastryOrder % 3 > 0 && PastryOrder >3)
      {
        int totalPastryPrice = ((PastryOrder / 3) *5) + ((PastryOrder % 3) * PastryPrice);
        return totalPastryPrice;
      }
      else
      {
      return PastryPrice * PastryOrder;
      }
    }
  } 
}
      