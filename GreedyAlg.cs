using System;

namespace Algorithm_Homework_1
{
    internal class GreedyAlg
    {
        public static int MinCoinsNeeded(int[] coins, int target)
        {
            int coinCount = 0;
            int index = 0;

            while (target > 0 && index < coins.Length)
            {
                if (coins[index] <= target)
                {
                    int numCoins = target / coins[index];
                    coinCount += numCoins;
                    target -= numCoins * coins[index];
                }
                index++;
            }

            return coinCount;
        }

        public static void Main(string[] args)
        {
            int[] coins = { 25, 10, 5, 1 };
            int targetAmount = 36;

            int minCoins = MinCoinsNeeded(coins, targetAmount);

            Console.WriteLine($"Minimum number of coins: {minCoins}");
        }
    }
}
