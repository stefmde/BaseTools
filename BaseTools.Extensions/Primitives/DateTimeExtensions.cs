using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTools.Extensions
{
	public static class DateTimeExtensions
	{
		public static long ToUnixTimestampMilliseconds(this DateTime input)
		{
			return (long)(input.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
		}

		public static int ToUnixTimestamp(this DateTime input)
		{
			return (int)(input.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
		}

		public static int CurrentUnixTimestamp(this DateTime ignored)
		{
			return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
		}
	}
}
