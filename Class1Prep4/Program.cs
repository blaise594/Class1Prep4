using System;
using System.Text.RegularExpressions;

namespace Class1Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word to search the first sentence of 'Alice's Adventures in Wonderland', then press enter: ");
            string input = Console.ReadLine().ToLower();            

            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
           
            //bool startswith = alice.ToLower().StartsWith(input);
            //Console.WriteLine("Starts with " + input + " : " + startswith);

            //bool endswith = alice.ToLower().EndsWith(input);
            //Console.WriteLine("Ends with " + input + " : " + endswith);

            bool contains = Regex.IsMatch(alice.ToLower(), input.ToLower());

            Console.WriteLine("This sentence contains the word " + input + ": " + contains);
            Console.ReadLine();
            
        }
    }
}
