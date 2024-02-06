using JetBrains.Annotations;
using System;

namespace Nfx.SDK.Core.Models
{
	[PublicAPI]
	public interface ISoftDeletable
	{
		/// <summary>
		/// Gets or sets the timestamp of when the model was deleted.
		/// </summary>
		DateTime? DeletedAt { get; set; }
	}
}
