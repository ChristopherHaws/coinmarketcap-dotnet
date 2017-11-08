using System;
using Newtonsoft.Json;

namespace CoinMarketCap
{
	public class Ticker
	{
		[JsonProperty("id")]
		public String Id { get; set; }

		[JsonProperty("name")]
		public String Name { get; set; }

		[JsonProperty("symbol")]
		public String Symbol { get; set; }

		[JsonProperty("rank")]
		public Decimal Rank { get; set; }

		[JsonProperty("price_usd")]
		public Decimal? PriceInUsd { get; set; }

		[JsonProperty("price_btc")]
		public Decimal? PriceInBtc { get; set; }

		[JsonProperty("24h_volume_usd")]
		public Decimal? VolumeUsd24Hour { get; set; }

		[JsonProperty("market_cap_usd")]
		public Decimal? MarketCapUsd { get; set; }

		[JsonProperty("available_supply")]
		public Decimal? AvailableSupply { get; set; }

		[JsonProperty("total_supply")]
		public Decimal? TotalSupply { get; set; }

		[JsonProperty("percent_change_1h")]
		public Decimal? PercentChange1Hour { get; set; }

		[JsonProperty("percent_change_24h")]
		public Decimal? PercentChange24Hour { get; set; }

		[JsonProperty("percent_change_7d")]
		public Decimal? PercentChange7Day { get; set; }

		[JsonProperty("last_updated")]
		public Int64? LastUpdated { get; set; }
	}
}
