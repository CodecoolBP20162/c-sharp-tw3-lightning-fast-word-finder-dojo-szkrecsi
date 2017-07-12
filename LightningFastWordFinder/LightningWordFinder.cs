using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            StringReader reader = new StringReader(text);
            string[] words = reader.ReadToEnd().Split(' ');
            string longest = words.OrderByDescending(s => s.Length).First();

            /*List<int> wordList = new List<int>();
            foreach (string word in words) {
                wordList.Add(word.Length);
            }
            int[] wordArray = wordList.ToArray();
            int maximum = wordArray.Max(lst => lst.Max(str => str.Length));*/

            return longest;
        }
    }
}
