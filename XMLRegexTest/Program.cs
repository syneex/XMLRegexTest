using System;
using System.Text.RegularExpressions;

namespace XMLRegexTest
{
    /// <summary>
    /// The Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">string args.</param>
        static void Main(string[] args)
        {
            string xmlSteps = "<steps><step>GET http://url <BR/> body: <?xml version=\"1.0\" encoding=\"utf - 8\"?><Envelope xmlns=\"http://www.w3.org/2003/05/soap-envelope\"><Body></Body></Envelope> </step></steps>";
            string body = string.Empty;

            // Logic with added seperators.
            Regex seperatorRegex = new Regex(@"(?<=\<\!\-\-start\-\-\>)[^\)]+(?=\<\!\-\-end\-\-\>)");
            if (seperatorRegex.Match(xmlSteps).Success == true)
            {
                body = seperatorRegex.Match(xmlSteps).Value;
                Console.WriteLine("Body" + body);
            }
            else
            {
                Console.WriteLine("Do DevOps Logic here.");
            }

            // Logic without added seperators.
            Regex withoutSeperatorRegex = new Regex(@"\s+body\s*[:=]\s*(.*)([]}>""] | (<\/step>))");
            if (withoutSeperatorRegex.Match(xmlSteps).Success == true)
            {
                body = withoutSeperatorRegex.Match(xmlSteps).Groups[1].Value;
                Console.WriteLine("Body" + body);
            }
            else
            {
                Console.WriteLine("Do DevOps Logic here.");
            }

            Console.ReadKey();
        }
    }
}