using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public  class RatesRepoMock : ICurrRatesRepo
    {

        Models.RatesModel model;

        public RatesRepoMock()
        {
            model = new Models.RatesModel();

            model.rates.USD = 1M;
            model.rates.MXN = 19.23M;
            model.rates.EUR = 0.9M;
            model.rates.GBP = 0.79M;
            model.rates.CAD = 1.35M;
        }
        
        public decimal GetRateByCurrCode(string currCode)
        {
            return model.rates.rateDict[currCode.ToUpper()];
        }        
    }
}
