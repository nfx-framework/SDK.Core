using JetBrains.Annotations;
using System;
using System.Security.Cryptography;

namespace Nfx.SDK.Core.Helpers
{
	/// <summary>
	/// Utility for generating MySQL optimized globally unique identifiers.
	/// </summary>
	/// TODO: Fully test and verify this helps performance.
	[PublicAPI]
	public static class GuidGenerator
	{
		/// <summary>
		/// Generates a time based globally unique identifier optimized for MySQL.
		/// </summary>
		/// <returns>The generated GUID.</returns>
		public static Guid GenerateTimeBasedGuid()
		{
			var randomBytes = new byte[10];
			using (var rng = new RNGCryptoServiceProvider()) rng.GetBytes(randomBytes);

			var timestampBytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks / 10000L);
			if (BitConverter.IsLittleEndian) Array.Reverse(timestampBytes);

			var guidBytes = new byte[16];

			Buffer.BlockCopy(timestampBytes, 2, guidBytes, 0, 6);
			Buffer.BlockCopy(randomBytes, 0, guidBytes, 6, 10);

			// ReSharper disable once InvertIf
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(guidBytes, 0, 4);
				Array.Reverse(guidBytes, 4, 2);
			}

			return new Guid(guidBytes);
		}
	}
}
