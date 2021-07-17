using System;

namespace Letter_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's get loopin'");
            var loopString = Console.ReadLine();
            var looper = 0;
            var lastLoopString = "";
            for (var i = 0; i < loopString.Length; i++)
            {
                looper++;
                for (var a = 0; a < looper; a++)
                {
                    if (a == 0 && i > 0)
                    {
                        var firstChar = char.ToUpper(loopString[i]);
                        lastLoopString += $"-{firstChar}";
                    }
                    else if (i == 0)
                    {
                        var firstCharLoop = char.ToUpper(loopString[i]);
                        lastLoopString += firstCharLoop;
                    }
                    else
                    {
                        lastLoopString += $"{loopString[i]}";
                    }
                }
            }
            Console.WriteLine($"{lastLoopString}");
        }
    }
}
