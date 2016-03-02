using System;
using System.Collections.Generic;
using System.Text;

namespace CommonWin32
{
	/// <summary>
	/// Contains basic win32 values.
	/// </summary>
	public static class BasicValues
	{
		/// <summary>
		/// Represents the TRUE value as <see cref="IntPtr"/>.
		/// </summary>
		public static readonly IntPtr TRUE = new IntPtr(1);
		/// <summary>
		/// Represents the FALSE value as <see cref="IntPtr"/>.
		/// </summary>
		public static readonly IntPtr FALSE = IntPtr.Zero;

        /// <summary>
        /// The max file path length.
        /// </summary>
        public const int MAX_PATH = 260;
	}
}
