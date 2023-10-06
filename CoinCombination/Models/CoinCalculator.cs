using System;
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
    public void CalculateChange()
    {
      do
      {
        if (UserMoneyValue >= .25F)
        {
          TotalAddedCoinValue["Quarters"] += 1;
          UserMoneyValue -= .25F;
        }
        else if (UserMoneyValue >= .10F)
        {
          TotalAddedCoinValue["Dimes"] += 1;
          UserMoneyValue -= .10F;
        }
        else if (UserMoneyValue >= .05F)
        {
          TotalAddedCoinValue["Nickels"] += 1;
          UserMoneyValue -= .05F;
        }
        else
        {
          TotalAddedCoinValue["Pennies"] += 1;
          UserMoneyValue -= .01F;
        }
      }
      while (UserMoneyValue >= 0);
    }
    public void ClearTotalAddedCoinValue()
    {
      TotalAddedCoinValue["Quarters"] = 0;
      TotalAddedCoinValue["Dimes"] = 0;
      TotalAddedCoinValue["Nickels"] = 0;
      TotalAddedCoinValue["Pennies"] = 0;
    }
  }
}