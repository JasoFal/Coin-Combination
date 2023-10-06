using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoinCombination.Models;

namespace CoinCombination
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Coin Combination app!");
      Console.WriteLine("We'll calculate the amount and type of coins given based on change.");
      Console.WriteLine("Do you wish to check? If so enter 'yes' below");
      string userAgreement = Console.ReadLine();
      if (userAgreement.ToLower() == "yes")
      {
        CalculateChangeUIPrompt();
      }
    }

    static void CalculateChangeUIPrompt()
    {
      Console.WriteLine("Please enter amount of change:");
      string userInputChange = Console.ReadLine();
      try
      {
        float amountOfChange = float.Parse(userInputChange);
        CoinCalculator coinCalc = new CoinCalculator(amountOfChange);
        ConfirmOrEditInputtedChange(coinCalc);
      }
      catch
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("ERROR: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.WriteLine("Please try again...");
        Main();
      }
    }

    static void ConfirmOrEditInputtedChange(CoinCalculator coinCalc)
    {
      Console.WriteLine("Please confirm that you have entered in your change correctly:");
      Console.WriteLine($"Your change is {coinCalc.UserMoneyValue}");
      string correctChangeInput = Console.ReadLine();
      if (correctChangeInput == "yes")
      {
        CalculateAmountOfCoins(coinCalc);
      }
      else
      {
        Console.WriteLine("Please reenter your change.");
        string reenteredUserChange = Console.ReadLine();
        coinCalc.UserMoneyValue = float.Parse(reenteredUserChange);
        ConfirmOrEditInputtedChange(coinCalc);
      }
    }

    static void CalculateAmountOfCoins(CoinCalculator coinCalc)
    {
      coinCalc.CalculateChange();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is:");
      foreach (KeyValuePair<string, int> coinValues in coinCalc.TotalAddedCoinValue)
      {
        if (coinValues.Value != 0)
        {
          Console.WriteLine($"{coinValues.Key}: {coinValues.Value}");
        }
      }
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to enter a new amount of change.");
      Console.WriteLine("If so please enter 'new' below.");
      string newChangeAmount = Console.ReadLine();
      if (newChangeAmount.ToLower() == "new")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}