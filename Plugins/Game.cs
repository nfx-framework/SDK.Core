using JetBrains.Annotations;
using Newtonsoft.Json;
using System;

namespace Nfx.SDK.Core.Plugins
{
	/// <summary>
	/// Represents the supported game api set for the plugin.
	/// </summary>
	[PublicAPI]
	public class Game
	{
		/// <summary>
		/// Represents a supported game api set by the CitizenFx platform.
		/// </summary>
		internal static class GameApiSet
		{
			/// <summary>
			/// Runs on any game, but can't access game-specific APIs - only CitizenFX APIs.
			/// </summary>
			public const string Common = "common";

			/// <summary>
			/// Runs on LibertyM.
			/// </summary>
			public const string Gta4 = "gta4";

			/// <summary>
			/// Runs on FiveM.
			/// </summary>
			public const string Gta5 = "gta5";

			/// <summary>
			/// Runs on RedM.
			/// </summary>
			public const string Rdr3 = "rdr3";
		}

		/// <summary>
		/// Gets or sets the name of the game api set.
		/// </summary>
		public string Name { get; set; }

		/// <summary>Initializes a new instance of the <see cref="Game" /> class.</summary>
		[JsonConstructor]
		public Game()
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="Game" /> class.
		/// </summary>
		/// <param name="value">The game name.</param>
		public Game(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), $"Invalid game name. Supported game(s): {GameApiSet.Common},{GameApiSet.Gta4},{GameApiSet.Gta5},{GameApiSet.Rdr3}.");

			switch (value)
			{
				case GameApiSet.Common:
					this.Name = GameApiSet.Common;
					break;

				case GameApiSet.Gta4:
					this.Name = GameApiSet.Gta4;
					break;

				case GameApiSet.Gta5:
					this.Name = GameApiSet.Gta5;
					break;

				case GameApiSet.Rdr3:
					this.Name = GameApiSet.Rdr3;
					break;

				default:
					throw new ArgumentException($"Invalid game name. Supported game(s): {GameApiSet.Common},{GameApiSet.Gta4},{GameApiSet.Gta5},{GameApiSet.Rdr3}.");
			}
		}

		public override string ToString() => $"{this.Name}";
	}
}
