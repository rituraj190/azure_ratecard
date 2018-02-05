using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string grant_type = "";

            RateCardApIWrapper rateCard = new RateCardApIWrapper();

            string tokne = rateCard.GetToken();
        }

     
    }
}
