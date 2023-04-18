using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RTM_Tool_Base_By_iixFi
{
  public static class ModifyProgressBarColor
  {
    private const int WM_USER = 1024;
    private const int PBM_SETSTATE = 1040;
    private const int PBM_GETSTATE = 1041;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(
      IntPtr hWnd,
      uint Msg,
      IntPtr wParam,
      IntPtr lParam);

    public static ModifyProgressBarColor.ProgressBarStateEnum GetState(
      this ProgressBar pBar)
    {
      return (ModifyProgressBarColor.ProgressBarStateEnum) (int) ModifyProgressBarColor.SendMessage(pBar.Handle, 1041U, IntPtr.Zero, IntPtr.Zero);
    }

    public static void SetState(
      this ProgressBar pBar,
      ModifyProgressBarColor.ProgressBarStateEnum state)
    {
      ModifyProgressBarColor.SendMessage(pBar.Handle, 1040U, (IntPtr) (int) state, IntPtr.Zero);
    }

    public enum ProgressBarStateEnum
    {
      Normal = 1,
      Error = 2,
      Paused = 3,
    }
  }
}
