using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFt
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            var tokenRequester = new TokenRequester("https://bridgerstaging.lexisnexis.com/LN.WebServices/api/Token/Issue", "KyriaConSvsCITest/BMarcel30", "@Wormkernel1", "scope");
            var accessToken = await tokenRequester.GetAccessTokenAsync();
            Console.WriteLine("Token = " + accessToken);
            Console.ReadLine();
        }
    }
}
