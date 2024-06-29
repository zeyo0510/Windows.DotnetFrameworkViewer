﻿using System;
using System.Windows.Forms;
using Windows.DotnetFrameworkViewer.Main;
/************************************************/
namespace Windows.DotnetFrameworkViewer
{
  internal sealed class App
  {
    [STAThread]
    private static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}