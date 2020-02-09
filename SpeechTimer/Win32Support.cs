using System;
using System.Runtime.InteropServices;

namespace SpeechTimer
{
    public static class Win32Support
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1); //窗体置顶
        public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2); //取消窗体置顶
        public const uint SWP_NOMOVE = 0x0002; //不调整窗体位置
        public const uint SWP_NOSIZE = 0x0001; //不调整窗体大小
    }
}
