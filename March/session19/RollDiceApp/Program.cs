namespace RollDiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var diceRolls = RollDice(10);

            // Print the number of occurrences of each side
            foreach (var roll in diceRolls)
            {
                Console.WriteLine($"Side {roll.Key}: rolled {roll.Value} times");
            }
        }
        static Dictionary<int, int> RollDice(int times)
        {
            var rand = new Random();
            var result = new Dictionary<int, int>();

            for (int i = 0; i < times; i++)
            {
                int roll = rand.Next(1, 7);

                if (result.ContainsKey(roll))
                {
                    result[roll]++;
                }
                else
                {
                    result.Add(roll, 1);
                }
            }

            return result;
        }
    }
}