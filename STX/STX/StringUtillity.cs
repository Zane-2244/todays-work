using System;
using System.Collections.Generic;


namespace STX
{
    public class StringUtillity
    {
        public static string SummerizeText(string text, int maxlenght = 20)
        {

            if (text.Length < maxlenght)
                return text;

            var words = text.Split(' ');
            var totalcharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalcharacters += word.Length + 1;
                if (totalcharacters > maxlenght)
                    break;
            }

            return String.Join(" ", summaryWords) + "..."; ;

        }
    }
}
