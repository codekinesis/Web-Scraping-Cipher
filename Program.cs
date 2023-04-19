using System;
using System.Net;

namespace WebScrapingCipher
{
    class WebScrapingCipher
    {
        public static void Main(string[] args)
        {

            string url;
            Console.Write("Please enter a URL: ");
            url = Console.ReadLine();

            WebClient webClient = new WebClient();
            string webText = webClient.DownloadString(url);


            foreach (char c in webText)
            {
                if (c == ' ')
                {
                    Console.Write(" ");
                }
                else
                {
                    char letter = c;
                    if (letter > ('Z' - 5) && letter <= 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter > ('z' - 5) && letter <= 'z')
                    {
                        letter = (char)(letter - 26);
                    }

                    Console.Write($"{(char)(letter + 5)}");
                }
            }
        }
    }
}
