using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinMarketCap
{
	public static class GetTickersQuery
	{
		public static async Task<Ticker[]> GetTickersAsync(this CoinMarketCapClient client, Int32 limit = 100)
		{
			var request = new CoinMarketCapRequest
			{
				RelativeUrl = "/v1/ticker",
				Properties = new Dictionary<String, String>
				{
					["limit"] = limit.ToString()
				}
			};

			var response = await client.SendAsync<Ticker[]>(request);

			return response.Result;
		}
	}
}
