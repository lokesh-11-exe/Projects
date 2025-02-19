private void mouseClick(int x, int y)
{
    SetCursorPos(x, y);
    Thread.Sleep(5000);
    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
}

[DllImport("user32.dll")]
private static extern bool SetCursorPos(int X, int Y);

[DllImport("user32.dll", SetLastError = true)]
private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
private const uint MOUSEEVENTF_LEFTUP = 0x0004;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;