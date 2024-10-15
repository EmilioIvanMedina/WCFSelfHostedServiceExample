using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSelfHostedServiceConsoleApp.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ComisionCalculator" in both code and config file together.
    public class ComisionCalculator : IComisionCalculator
    {
        public decimal CalculateFee(decimal price)
        {
            var fee = 0m;

            if (price < 100000)
                fee = 2500m;
            else
                fee = 10500;

            return fee;
        }
    }
}
