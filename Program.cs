using System;

namespace Letter_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's get loopin'");
            var loopString = Console.ReadLine(); // reads user input to command line 
            var looper = 0; // starts the number of characters at 0
            var lastLoopString = ""; // sets the string to zero. That way, user input is the only info our function will loop through
            for (var i = 0; i < loopString.Length; i++) // standard for-loop that will iterate over each char in the user input
            {
                looper++; // increments by one for each char
                for (var a = 0; a < looper; a++) // this will affect the command line output. Using "a" to differentiate from user input; this will also make each section one character longer than the last one.
                {
                    if (a == 0 && i > 0) // if user inputs chars to an empty command line, this condition will run
                    {
                        var firstChar = char.ToUpper(loopString[i]); // converts first char per section to upper case
                        lastLoopString += $"-{firstChar}"; // appends new section
                    }
                    else if (i == 0) // this conditional insures that the first section is capitalized.
                    {
                        var firstCharLoop = char.ToUpper(loopString[i]); // converts first char to uppercase
                        lastLoopString += firstCharLoop; // first section
                    }
                    else
                    {
                        lastLoopString += $"{loopString[i]}"; // adds to that empty string we declared in upper scope
                    }
                }
            }
            Console.WriteLine($"{lastLoopString}"); // outputs whichever conditional is true
        }
    }
}
