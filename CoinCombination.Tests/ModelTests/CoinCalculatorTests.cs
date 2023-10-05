using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;

namespace CoinCombination.Tests
{
  [TestClass]
  public class CoinCalculatorTests
  {
    [TestMethod]
    public void CoinCalculatorConstructor_CreateInstanceOfCoinCalculator_CoinCalculator()
    {
      CoinCalculator newCoinCalc = new CoinCalculator(0.50F);
      Assert.AreEqual(typeof(CoinCalculator), newCoinCalc.GetType());
    }

    [TestMethod]
    public void GetCoinValue_ReturnCoinValue_Float()
    {
      float newUserInput = 0.50F;
      CoinCalculator newCoinCalc = new CoinCalculator(newUserInput);
      float result = newCoinCalc.UserMoneyValue;
      Assert.AreEqual(newUserInput, result);
    }
    
    [TestMethod]
    public void SetCoinValue_SetValueOfCoinValue_Void()
    {
      CoinCalculator newCoinCalc = new CoinCalculator(.50F);
      float newCoinValue = .99F;
      newCoinCalc.UserMoneyValue = newCoinValue;
      Assert.AreEqual(newCoinValue, newCoinCalc.UserMoneyValue);
    }

    [TestMethod]
    public void DictionaryInit_StoreEmptyCoinValues_Int()
    {
      CoinCalculator newCoinCalc = new CoinCalculator(.50F);
      int emptyCoinValue = newCoinCalc.TotalAddedCoinValue["Quarters"];
      Assert.AreEqual(emptyCoinValue, newCoinCalc.TotalAddedCoinValue["Quarters"]);
      Assert.AreEqual(emptyCoinValue, newCoinCalc.TotalAddedCoinValue["Dimes"]);
      Assert.AreEqual(emptyCoinValue, newCoinCalc.TotalAddedCoinValue["Nickels"]);
      Assert.AreEqual(emptyCoinValue, newCoinCalc.TotalAddedCoinValue["Pennies"]);
    }

    [TestMethod]
    public void CalculateChange_IncreaseQuartersCountAndDecreasesTotalMoneyValue_Int()
    {
      CoinCalculator newCoinCalc = new CoinCalculator(.25F);
      newCoinCalc.CalculateChange();
      int result1 = newCoinCalc.TotalAddedCoinValue["Quarters"];
      float result2 = newCoinCalc.UserMoneyValue;
      Assert.AreEqual(1, result1);
      Assert.AreEqual(0, result2);
    }

    [TestMethod]
    public void CalculateChange_IncreaseDimeCountAndDecreaseTotalMoneyValue_Int()
    {
      CoinCalculator newCoinCalc = new CoinCalculator(.10F);
      newCoinCalc.CalculateChange();
      int result1 = newCoinCalc.TotalAddedCoinValue["Dimes"];
      float result2 = newCoinCalc.UserMoneyValue;
      Assert.AreEqual(1, result1);
      Assert.AreEqual(0, result2);
    }

    
  }
}