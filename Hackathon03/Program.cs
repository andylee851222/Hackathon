namespace Hackathon03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個英文敘述字串:");
            Dictionary<string, int> wordCount  = WordCount.CountWords(Console.ReadLine());
            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
