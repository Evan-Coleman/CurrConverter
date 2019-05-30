using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace ConsoleApp10
{
    public  class RatesRepo : ICurrRatesRepo
    {
        private HttpClient client;
        private readonly string apiURL = "https://api.exchangeratesapi.io/latest?base=USD";
        private readonly Uri uri;
        Models.RatesModel model;

        public RatesRepo()
        {
            client = new HttpClient();
            uri = new Uri(string.Format(apiURL, string.Empty));
            GetRatesFromApi();
        }

        private async void GetRatesFromApi()
        {
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<Models.RatesModel>(content);
                } else
                {
                    throw new Exception("Call to api didn't work");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public decimal GetRateByCurrCode(string currCode)
        {
            return model.rates.rateDict[currCode.ToUpper()];
        }        
    }
}
