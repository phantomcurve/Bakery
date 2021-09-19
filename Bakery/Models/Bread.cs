using System; 

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafOrder { get; set; }
    public Bread(int loafOrder)
    {
      LoafOrder = loafOrder;
    }
    public int[] LoafCost()
    {
      int loafOrder = LoafOrder;
      int loafMath = LoafOrder % 3;
      int loafPrice = (loafOrder -(loafOrder/3))*5;
      int newLoafPrice = loafOrder;
      if (loafMath == 2)
      {
        newLoafPrice += 1;
      }
      int[] result = {newLoafPrice,loafPrice};
      return result;
    }
  }
}