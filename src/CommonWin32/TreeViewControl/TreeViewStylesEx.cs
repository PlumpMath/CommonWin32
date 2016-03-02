using System;
using System.Collections.Generic;
using System.Text;

namespace CommonWin32.TreeViewControl
{
	/// <summary>
	/// Extended style flags for treeview.
	/// </summary>
	[Flags]
	public enum TreeViewStylesEx : uint
	{
		/// <summary>
		/// Windows Vista. Remove the horizontal scroll bar and auto-scroll depending on mouse position.
		/// </summary>
		TVS_EX_AUTOHSCROLL = 0x0020,
		/// <summary>
		/// Windows Vista. Fade expando buttons in or out when the mouse moves away or into a state of hovering over the control.
		/// </summary>
		TVS_EX_FADEINOUTEXPANDOS = 0x0040,
		/// <summary>
		/// Windows Vista. Specifies how the background is erased or filled.
		/// </summary>
		TVS_EX_DOUBLEBUFFER = 0x0004,
	}
}
