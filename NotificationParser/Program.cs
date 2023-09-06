using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notificatiion_Parser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string result = Output(title);

            // To print out the result 
            Console.WriteLine($"Receive channels: {result}");
            Console.Read();

        }
        static string Output(string title)
        {
            // create this variable to stack each element of string
            StringBuilder sb = new StringBuilder();
            
            List<string> channel = new List<string> { "BE","FE","QA","Urgent"};
            
            // Create variable that select string inside bracket and also include bracket ("[BE]") 
            var mathces = Regex.Matches(title, @"\[(.*?)\]");

            // To list all the element which are inside the sqaure braket also including brakcet
            foreach (Match match in mathces)
            {
                // To select string inside the bracket
                string matchCase  = match.Groups[1].Value.Trim();

                // To list all elemet in channel
                foreach(string pair in channel)
                {
                    // To check if the string inside the bracket is equal to the element in channel
                    if(pair== matchCase)
                    {
                        // To add the element which is match and also add comma and space
                        sb.Append(matchCase+", ");
                    }
                }
            }
            string result = sb.ToString().Trim();

            // to return result and remove comma at the end of string
            return result.Substring(0,result.Length-1);
        }

    }
}
