// Decompiled with JetBrains decompiler
// Type: RTM_Tool_Base_By_iixFi.Program
// Assembly: RTM Tool Base By iixFi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D462C60C-740A-4B65-B3A7-684BB0243394
// Assembly location: C:\Users\ASUS\AppData\Local\Apps\2.0\JYQ4NGYL.GND\RVQK7D1N.5WL\rtmt..tion_74f0c54d6dbc06bb_0001.0000_151f05620aa72b1c\RTM Tool Base By iixFi.exe

using System;
using System.Windows.Forms;

namespace RTM_Tool_Base_By_iixFi
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
