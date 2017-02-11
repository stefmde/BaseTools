using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTools.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNullOrEmpty(this string input)
		{
			return string.IsNullOrEmpty(input);
		}

		public static bool IsNotNullOrEmpty(this string input)
		{
			return !string.IsNullOrEmpty(input);
		}

		public static bool IsNullOrWhiteSpace(this string input)
		{
			return string.IsNullOrWhiteSpace(input);
		}

		public static bool IsNotNullOrWhiteSpace(this string input)
		{
			return !string.IsNullOrWhiteSpace(input);
		}

		public static string RemoveAll(this string input)
		{
			return input.Replace(input, "");
		}

		public static string RemoveAllCaseInsensitive(this string input)
		{

		}
	}
}
