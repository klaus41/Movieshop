using System;
using MeierDiceGame;
using NUnit.Framework;

namespace MeierDiceGameTest
{
    [TestFixture]
    public class MeierCalculatorTest
    {
        [Test]
        public void ResultIsMeierTest()
        {
            MeierCalculator2 calc = new MeierCalculator2();
            int dice1 = 1;
            int dice2 = 2;
            bool meier = calc.Meier(dice1, dice2);
            Assert.True(meier, "Expected result was meier (true)");
        }
    }
}
