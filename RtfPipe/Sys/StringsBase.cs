// project    : System Framelet
// environment: .NET 3.5
using System;
using System.Resources;

namespace RtfPipe.Sys
{

	/// <summary>
	/// Provides some helper functionality to keep resource handling in a
	/// namespace as simple and uniform as possible.
	/// </summary>
	/// <remarks>
	/// intended to be used by a singleton class per namespace, which should
	/// commonly be named <c>Strings</c>. This singleton instance should
	/// provide access to resources via strongly typed properties, thus
	/// avoiding coding errors with misspelled resource identifiers.
	/// </remarks>
	public abstract class StringsBase
	{

		/// <summary>
		/// Formats the given format-string with the invariant culture and the
		/// given arguments.
		/// </summary>
		/// <param name="format">the string to format</param>
		/// <param name="args">the arguments to fill in</param>
		/// <returns>the formatted string</returns>
		protected static string Format( string format, params object[] args )
		{
			return StringTool.FormatSafeInvariant( format, args );
		}

	}

}
