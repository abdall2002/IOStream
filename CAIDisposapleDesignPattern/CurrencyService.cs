using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CAIDisposapleDesignPattern
{
    public class CurrencyService : IDisposable
    {
        private readonly HttpClient httpClient;
        private bool _disposed = false;

        public CurrencyService()
        {
            httpClient = new HttpClient();
        }

        ~CurrencyService()
        {
            Dispose(false);
        }

        // disposing : true (dispose managed + unmanaged)      
        // disposing : false (dispose unmanaged + large fields)

        protected virtual void Dispose(bool disposing) 
        {
            if (_disposed)
                return;
            // Dispose Logic
            if (disposing)
            {
                // dispose managed resouces
                httpClient.Dispose();
            }
            // unmanaged object
            // set large fields to null
            _disposed = true;

        }

        public void Dispose()
        {
            // dipose() is called 100%
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string GetCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            var result = httpClient.GetStringAsync(url).Result;
            return result;
        }
    }
}
