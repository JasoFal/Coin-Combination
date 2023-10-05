using System.Collections.Generic;

namespace CoinCombination.Models
{
  public class CoinCalculator
  {
    public float UserMoneyValue { get; set; }
    public Dictionary<string, int> TotalAddedCoinValue = new Dictionary<string, int>() { {"Quarters", 0}, {"Dimes", 0}, {"Nickels", 0}, {"Pennies", 0} };
    public CoinCalculator(float userInput)
    {
      UserMoneyValue = userInput;
    }
    public float CalculateChange()
    {
      if (UserMoneyValue >= .25F)
      {
        TotalAddedCoinValue["Quarters"] += 1;
        return UserMoneyValue -= .25F;
      }
      else if (UserMoneyValue >= .10F)
      {
        TotalAddedCoinValue["Dimes"] += 1;
        return UserMoneyValue -= .10F;
      }
      else if (UserMoneyValue >= .05F)
      {
        TotalAddedCoinValue["Nickels"] += 1;
        return UserMoneyValue -= .05F;
      }
      else
      {
        TotalAddedCoinValue["Pennies"] += 1;
        return UserMoneyValue -= .01F;
      }
    }
  }
}