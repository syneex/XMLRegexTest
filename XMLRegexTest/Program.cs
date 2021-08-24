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
            string body = string.Empty;

            // Logic with added seperators.
            string xmlSteps = "<steps><step>GET http://url <BR/> body: <?xml version=\"1.0\" encoding=\"utf - 8\"?><Envelope xmlns=\"http://www.w3.org/2003/05/soap-envelope\"><Body></Body></Envelope></step></steps>";
            Regex regex = new Regex(@"(?<=\<\!\-\-start\-\-\>)[^\)]+(?=\<\!\-\-end\-\-\>)");
            if (regex.Match(xmlSteps).Success == true)
            {
                body = regex.Match(xmlSteps).Value;
            }
            else
            {
                Console.WriteLine("Do VSTS TestExecutor Logic here.");
            }

            Console.ReadKey();
        }
    }
}