using System.Collections.Generic;

namespace CoinCombination.Models
{
  public class CoinCalculator
  {
    public float UserMoneyValue { get; set; }
    public Dictionary<string, int> totalAddedCoinValue = new Dictionary<string, int>() { {"Quarters", 0}, {"Dimes", 0}, {"Nickels", 0}, {"Pennies", 0} };
    public CoinCalculator(float userInput)
    {
      UserMoneyValue = userInput;
    }
    public float CalculateChange()
    {
      totalAddedCoinValue["Quarters"] += 1;
      return UserMoneyValue -= .25F;
    }
  }
}