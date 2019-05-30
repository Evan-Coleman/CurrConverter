using System.Collections.Generic;

namespace ConsoleApp10.Models
{
    class RatesModel
    {
        public string _base { get; set; }
        public APIRates rates { get; set; }
        public string date { get; set; }

        public RatesModel()
        {
            rates = new APIRates();
        }

        public class APIRates
        {
            public Dictionary<string, decimal> rateDict;

            public APIRates()
            {
                rateDict = new Dictionary<string, decimal>();
            }

            public decimal BGN { get {return rateDict["BGN"];} set{rateDict["BGN"] = value;}}
            public decimal NZD { get {return rateDict["NZD"];} set{rateDict["NZD"] = value;}}
            public decimal ILS { get {return rateDict["ILS"];} set{rateDict["ILS"] = value;}}
            public decimal RUB { get {return rateDict["RUB"];} set{rateDict["RUB"] = value;}}
            public decimal CAD { get {return rateDict["CAD"];} set{rateDict["CAD"] = value;}}
            public decimal USD { get {return rateDict["USD"];} set{rateDict["USD"] = value;}}
            public decimal PHP { get {return rateDict["PHP"];} set{rateDict["PHP"] = value;}}
            public decimal CHF { get {return rateDict["CHF"];} set{rateDict["CHF"] = value;}}
            public decimal AUD { get {return rateDict["AUD"];} set{rateDict["AUD"] = value;}}
            public decimal JPY { get {return rateDict["JPY"];} set{rateDict["JPY"] = value;}}
            public decimal TRY { get {return rateDict["TRY"];} set{rateDict["TRY"] = value;}}
            public decimal HKD { get {return rateDict["HKD"];} set{rateDict["HKD"] = value;}}
            public decimal MYR { get {return rateDict["MYR"];} set{rateDict["MYR"] = value;}}
            public decimal HRK { get {return rateDict["HRK"];} set{rateDict["HRK"] = value;}}
            public decimal CZK { get {return rateDict["CZK"];} set{rateDict["CZK"] = value;}}
            public decimal IDR { get {return rateDict["IDR"];} set{rateDict["IDR"] = value;}}
            public decimal DKK { get {return rateDict["DKK"];} set{rateDict["DKK"] = value;}}
            public decimal NOK { get {return rateDict["NOK"];} set{rateDict["NOK"] = value;}}
            public decimal HUF { get {return rateDict["HUF"];} set{rateDict["HUF"] = value;}}
            public decimal GBP { get {return rateDict["GBP"];} set{rateDict["GBP"] = value;}}
            public decimal MXN { get {return rateDict["MXN"];} set{rateDict["MXN"] = value;}}
            public decimal THB { get {return rateDict["THB"];} set{rateDict["THB"] = value;}}
            public decimal ISK { get {return rateDict["ISK"];} set{rateDict["ISK"] = value;}}
            public decimal ZAR { get {return rateDict["ZAR"];} set{rateDict["ZAR"] = value;}}
            public decimal BRL { get {return rateDict["BRL"];} set{rateDict["BRL"] = value;}}
            public decimal SGD { get {return rateDict["SGD"];} set{rateDict["SGD"] = value;}}
            public decimal PLN { get {return rateDict["PLN"];} set{rateDict["PLN"] = value;}}
            public decimal INR { get {return rateDict["INR"];} set{rateDict["INR"] = value;}}
            public decimal KRW { get {return rateDict["KRW"];} set{rateDict["KRW"] = value;}}
            public decimal RON { get {return rateDict["RON"];} set{rateDict["RON"] = value;}}
            public decimal CNY { get {return rateDict["CNY"];} set{rateDict["CNY"] = value;}}
            public decimal SEK { get {return rateDict["SEK"];} set{rateDict["SEK"] = value;}}
            public decimal EUR { get {return rateDict["EUR"];} set{rateDict["EUR"] = value;}}
        }
    }
}
