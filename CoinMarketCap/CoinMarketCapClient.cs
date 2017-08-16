using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoinMarketCap
{
	public class CoinMarketCapClient
	{
		private const String BaseUrl = @"https://api.coinmarketcap.com";

		public async Task<CoinMarketCapResponse<T>> SendAsync<T>(CoinMarketCapRequest request)
		{
			using (var http = new HttpClient())
			{
				var builder = new UriBuilder(BaseUrl)
				{
					Path = request.RelativeUrl,
					Query = request.Properties.ToQueryString()
				};

				var response = await http.GetAsync(builder.Uri);
				var content = await response.Content.ReadAsStringAsync();

				if (!response.IsSuccessStatusCode)
				{
					var error = JsonConvert.DeserializeObject<CoinMarketCapError>(content);
					throw new CoinMarketCapException(error.Message);
				}

				var result = JsonConvert.DeserializeObject<T>(content);

				return new CoinMarketCapResponse<T>
				{
					Result = result
				};
			}
		}
	}
}
