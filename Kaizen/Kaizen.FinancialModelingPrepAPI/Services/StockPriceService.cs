using Newtonsoft.Json;
using Kaiizen.Domain.Exceptions;
using Kaiizen.Domain.Services;
using Kaiizen.FinancialModelingPrepAPI.Results;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kaiizen.FinancialModelingPrepAPI.Services
{
    public class StockPriceService : IStockPriceService
    {
        private readonly FinancialModelingPrepHttpClient _client;

        public StockPriceService(FinancialModelingPrepHttpClient client)
        {
            _client = client;
        }

        public async Task<double> GetPrice(string symbol)
        {
            string uri = "stock/real-time-price/" + symbol;

            StockPriceResult stockPriceResult = await _client.GetAsync<StockPriceResult>(uri);

            if(stockPriceResult.Price == 0)
            {
                throw new InvalidSymbolException(symbol);
            }

            return stockPriceResult.Price;
        }
    }
}
