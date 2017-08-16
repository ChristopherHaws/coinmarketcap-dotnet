using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinMarketCap
{
	internal static class ExtensionMethods
	{
		public static String ToQueryString(this IDictionary<String, String> values)
		{
			return String.Join("&", values.Select(x => $"{x.Key}={x.Value}"));
		}

		public static DateTime FromUnixTime(this Int64 unixTime)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return epoch.AddSeconds(unixTime);
		}
		public static long ToUnixTime(this DateTime date)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return Convert.ToInt64((date.ToUniversalTime() - epoch).TotalSeconds);
		}
	}
}
