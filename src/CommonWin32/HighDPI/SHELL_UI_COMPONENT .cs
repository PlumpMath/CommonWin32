using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonWin32.HighDPI
{
    /// <summary>
    /// Identifies the type of UI component that is needed in the shell.
    /// </summary>
    public enum SHELL_UI_COMPONENT
    {
        /// <summary>
        /// This UI component is a taskbar icon.
        /// </summary>
        SHELL_UI_COMPONENT_TASKBARS = 0,
        /// <summary>
        /// This UI component is an icon in the notification area.
        /// </summary>
        SHELL_UI_COMPONENT_NOTIFICATIONAREA = 1,
        /// <summary>
        /// This UI component is a deskband icon.
        /// </summary>
        SHELL_UI_COMPONENT_DESKBAND = 2
    }
}