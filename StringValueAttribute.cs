using JetBrains.Annotations;
using System;

namespace Nfx.SDK.Core
{
	/// <summary>
	/// This attribute is used to represent a string value
	/// for a value in an enum.
	/// </summary>
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Field)]
	public class StringValueAttribute : Attribute
	{
		#region Properties

		/// <summary>
		/// Holds the string value for a value in an enum.
		/// </summary>
		public string StringValue { get; protected set; }

		#endregion Properties

		#region Constructor

		/// <summary>
		/// Constructor used to init a StringValue Attribute
		/// </summary>
		/// <param name="value"></param>
		public StringValueAttribute(string value)
		{
			this.StringValue = value;
		}

		#endregion Constructor
	}
}
