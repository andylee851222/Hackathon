namespace Hackathon06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = string.Empty;
                while (input != "-1")
                {
                    Console.WriteLine("請輸入年收入:");
                    input = Console.ReadLine();

                    decimal tax = Count.CalculateTax(decimal.Parse(input));
                    Console.WriteLine($"應繳稅額為: {tax} 元");
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine($"發生錯誤: {ex.Message}");
            }
        }
    }
}
