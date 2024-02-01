using JetBrains.Annotations;
using System;

namespace Nfx.SDK.Core.Extensions
{
	[PublicAPI]
	public static class EnumExtensions
	{
		/// <summary>
		/// Will get the string value for a given enums value, this will
		/// only work if you assign the StringValue attribute to
		/// the items in your enum.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetStringValue(this Enum value)
		{
			// Get the type
			var type = value.GetType();

			// Get field info for this type
			var fieldInfo = type.GetField(value.ToString());

			// Return the first if there was a match.
			return fieldInfo.GetCustomAttributes(
				typeof(StringValueAttribute), false) is StringValueAttribute[] attributes && attributes.Length > 0 ? attributes[0].StringValue : null;
		}
	}
}
