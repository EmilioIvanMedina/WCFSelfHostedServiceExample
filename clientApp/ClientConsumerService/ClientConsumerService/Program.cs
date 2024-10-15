using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsumerService.ComisionCalculatorProxy;

namespace ClientConsumerService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting services...");

            Console.Write("Please, entry the amount in order to calculate the transaction fee: ");
            var amount = Convert.ToDecimal(Console.ReadLine());

            using (var comisionCalculatorClient = new ComisionCalculatorClient("BasicHttpBinding_IComisionCalculator"))
            {
                var fee = comisionCalculatorClient.CalculateFee(amount);

                Console.WriteLine($"Fee: {fee}");
            }
            
            Console.Read();
        }
    }
}
