using System; 
using Bakery.Models;

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafPrice { get; set; }  = 5;  
    public int LoafOrder { get; set; }
    public Bread(int loafOrder)
    {
      LoafOrder = loafOrder;
    }
    public int LoafCost()
    {
      int loafPromo = LoafPrice * ((LoafOrder - (LoafOrder % 3)) / 3);
      int totalLoafCost = (LoafOrder * LoafPrice) - loafPromo;
      return totalLoafCost;
    }
  }
}