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
      float result = newCoinCalc.CoinValue;
      Assert.AreEqual(newUserInput, result);
    }
  }
}