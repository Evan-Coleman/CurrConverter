using System;
using System.Linq;

namespace ConsoleApp10
{
    public class CurrConverter
    {
        ICurrRatesRepo ratesRepo;
        

        public CurrConverter(ICurrRatesRepo repo)
        {
            ratesRepo = repo;
        }

        public decimal Convert(decimal num, string fromCurr, string toCurr)
        {
            decimal fromCurrRate = ratesRepo.GetRateByCurrCode(fromCurr);
            decimal toCurrRate = ratesRepo.GetRateByCurrCode(toCurr);

            if (ratesRepo.GetRateByCurrCode(fromCurr) == 1M)
            {
                return num * toCurrRate;
            } else
            {
                decimal toUSD = num / fromCurrRate;
                return toUSD * toCurrRate;
            }            
        }
    }
}
