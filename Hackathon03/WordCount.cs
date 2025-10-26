using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon03
{
    internal class WordCount
    {
        public static Dictionary<string, int> CountWords(string input)
        {
            // 轉換為小寫
            string cleanedInput = input.ToLower();
            string[] words = cleanedInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,int> wordCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
            return wordCount;
        }
    }
}
