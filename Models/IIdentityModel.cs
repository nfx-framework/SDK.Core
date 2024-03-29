using JetBrains.Annotations;
using System;

namespace Nfx.SDK.Core.Models
{
	/// <summary>
	/// Represents the key properties for a stored model.
	/// </summary>
	[PublicAPI]
	public interface IIdentityModel : ISoftDeletable
	{
		/// <summary>
		/// Gets or sets the model identifier.
		/// </summary>
		/// <value>
		/// The model identifier.
		/// </value>
		Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the timestamp of when the model was created.
		/// </summary>
		/// <value>
		/// The timestamp of when the model was created.
		/// </value>
		DateTime Created { get; set; }
	}
}
