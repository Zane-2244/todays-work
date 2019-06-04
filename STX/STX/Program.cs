using System;

namespace STX
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long text. ";
            var summary = StringUtillity.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
            
        }
        
           
    }
}
