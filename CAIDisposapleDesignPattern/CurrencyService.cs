using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CAIDisposapleDesignPattern
{
    public class CurrencyService
    {
        private readonly HttpClient httpClient;
        public CurrencyService()
        {
            
        }
        public string GetCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            //var result = httpClient.GetStringAsync(url).Result;
            //return result;
        }
    }
}
