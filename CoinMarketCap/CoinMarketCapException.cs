using System;

namespace CoinMarketCap
{
	public class CoinMarketCapException : Exception
	{
		public CoinMarketCapException(String message)
			: base(message)
		{
		}
	}
}
