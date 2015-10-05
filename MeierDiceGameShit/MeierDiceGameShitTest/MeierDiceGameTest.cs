using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeierDiceGameShit;

namespace MeierDiceGameShitTest
{
    [TestClass]
    public class MeierDiceGameTest
    {
        [TestMethod]
        public void ResultIsMeierTest()
        {
            MeierDiceGameShitCalc calc = new MeierDiceGameShitCalc();
            int die1 = 1;
            int die2 = 2;
            bool meier = calc.Meier(die1, die2);
            Assert.IsTrue(meier, "Expected true");
        }
    }
}
