using JetBrains.Annotations;

namespace Nfx.SDK.Core.Events
{
	/// <summary>
	/// Core Nfx events.
	/// </summary>
	[PublicAPI]
	public static class CoreEvents
	{
		/// <summary>
		/// The event that is fired as soon as a client initializes.
		/// </summary>
		public const string ClientInitialize = "nfx:core:clientInitialize";

		/// <summary>
		/// The event that is fired as soon as a client has initialized.
		/// </summary>
		public const string ClientInitialized = "nfx:core:clientInitialized";

		/// <summary>
		/// The event that is fired after client initialization to request plugin information.
		/// </summary>
		public const string ClientPlugins = "nfx:core:clientPlugins";

		public const string CommandDispatch = "nfx:command:dispatch";

		/// <summary>
		/// The event that is fired when the client is relaying a log message to the server.
		/// </summary>
		public const string LogMirror = "nfx:log:mirror";
	}
}
