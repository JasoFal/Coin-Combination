using System.Collections.Generic;

namespace CoinCombination.Models
{
  public class CoinCalculator
  {
    public float CoinValue { get; } 
    public CoinCalculator(float userInput)
    {
      CoinValue = userInput;
    }
  }
}