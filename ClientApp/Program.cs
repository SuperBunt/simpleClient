using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DaftServiceClient client = new DaftServiceClient();

            client.GeneratePDF("https://stackoverflow.com/questions/20424425/recommended-size-of-icon-for-google-chrome-extension");

            Console.WriteLine("Hello");

            client.Close();

            Console.ReadKey();

        }
    }
}
