using System.Collections.Generic;

namespace CoinCombination.Models
{
  public class CoinCalculator
  {
    public float CoinValue { get; set; } 
    public CoinCalculator(float userInput)
    {
      CoinValue = userInput;
    }
  }
}