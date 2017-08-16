using System;
using Newtonsoft.Json;

namespace CoinMarketCap
{
	public class CoinMarketCapError
	{
		[JsonProperty("error")]
		public String Message { get; set; }
	}
}
