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
      int emptyCoinValue = 0;
      Assert.AreEqual(emptyCoinValue, newCoinCalc.totalAddedCoinValue["Quarters"]);
      Assert.AreEqual(emptyCoinValue, newCoinCalc.totalAddedCoinValue["Dimes"]);
      Assert.AreEqual(emptyCoinValue, newCoinCalc.totalAddedCoinValue["Nickels"]);
      Assert.AreEqual(emptyCoinValue, newCoinCalc.totalAddedCoinValue["Pennies"]);
    }
  }
}