using NUnit.Framework;
using System;

namespace AccountsRebalancing.RebalanceTests
{
    public class RebalanceCalculatorTests
    {
        [Test, Category("RebalanceTests")]
        public void IBM_67SharesToBeBuy()
        {
            int shares = RebalanceCalculator.Calculate_AccountShares(20, 10, 100000, 150);
            Assert.AreEqual(67, shares);
        }

        [Test, Category("RebalanceTests")]
        public void MSFT_ShouldRequireZeroShares()
        {
            int shares = RebalanceCalculator.Calculate_AccountShares(20, 20, 100000, 90);
            Assert.AreEqual(0, shares);
        }

        [Test, Category("RebalanceTests")]
        public void ORCL_45SharesToBeSell()
        {
            int shares = RebalanceCalculator.Calculate_AccountShares(20, 30, 100000, 220);
            Assert.AreEqual(-45, shares);
        }

        [Test, Category("RebalanceTests")]
        public void ZeroPrice_ShouldThrowException()
        {
            try
            {
                RebalanceCalculator.Calculate_AccountShares(20, 10, 100000, 0);

            }
            catch (Exception ex)
            {
                Assert.True(ex.Message.Contains("Price must be greater than zero."));
            }
            Assert.False(false);
        }

        [Test, Category("RebalanceTests")]
        public void NegativeTargetPct_ShouldThrowException()
        {

            try
            {
                RebalanceCalculator.Calculate_AccountShares(-10, 10, 100000, 100);
            }
            catch (Exception ex)
            {
                Assert.True(ex.Message.Contains("Percentages must be non-negative."));

            }
            Assert.False(false);

        }

        [Test, Category("RebalanceTests")]
        public void Rounding_Validation()
        {
            int shares = RebalanceCalculator.Calculate_AccountShares(25, 23, 100000, 333);
            Assert.AreEqual(6, shares);
        }
    }
}

