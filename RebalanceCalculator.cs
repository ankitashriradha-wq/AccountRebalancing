using System;

namespace AccountsRebalancing
{
    public static class RebalanceCalculator
    {
        public static int Calculate_AccountShares(
            double target_P,
            double current_P,
            double totalAsset,
            double price)
        {
            if (price <= 0)
                throw new Exception("Price must be greater than zero.");

            if (target_P < 0 || current_P < 0)
                throw new Exception("Percentages must be non-negative.");

            double targetValue = (target_P / 100.0) * totalAsset;
            double currentValue = (current_P / 100.0) * totalAsset;
            double diff = targetValue - currentValue;

            double shares = diff / price;

            int rounded = (int)Math.Round(shares);

            Console.WriteLine($"calculated shares: {shares}, rounded: {rounded}");


            return rounded;
        }
    }
}
