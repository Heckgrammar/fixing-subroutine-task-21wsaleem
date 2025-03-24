namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    for (int i = 7; i >= 0; i--) 
            {
                Console.WriteLine(diffCurrencies(i));
            }
        }
        static string diffCurrencies(int x)
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };
        }
    }
}
