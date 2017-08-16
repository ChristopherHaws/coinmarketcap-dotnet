using System;
using System.Collections.Generic;

namespace CoinMarketCap
{
	public class CoinMarketCapRequest
	{
		public String RelativeUrl { get; set; }
		public IDictionary<String, String> Properties { get; set; } = new Dictionary<String, String>();
	}
}
