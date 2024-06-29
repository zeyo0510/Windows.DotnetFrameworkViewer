﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
/************************************************/
namespace Windows.DotnetFrameworkViewer.Main
{
  partial class MainForm
  {
    private IContainer components = null;
    /************************************************/
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.components != null)
        {
          this.components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    /************************************************/
    private void InitializeComponent()
    {
      this.components = new Container();
      /************************************************/
      this.mainToolStripContainer      = new ToolStripContainer();
      this.entityListView               = new ListView();
      this.nameColumnHeader            = new ColumnHeader();
      this.versionColumnHeader         = new ColumnHeader();
      this.servicepackColumnHeader     = new ColumnHeader();
      this.installColumnHeader         = new ColumnHeader();
      this.topMenuStrip                = new MenuStrip();
      this.fileToolStripMenuItem       = new ToolStripMenuItem();
      this.exitToolStripMenuItem       = new ToolStripMenuItem();
      this.editToolStripMenuItem       = new ToolStripMenuItem();
      this.copyToolStripMenuItem       = new ToolStripMenuItem();
      this.viewToolStripMenuItem       = new ToolStripMenuItem();
      this.refreshToolStripMenuItem    = new ToolStripMenuItem();
      this.statusbarToolStripMenuItem  = new ToolStripMenuItem();
      this.bottomStatusStrip           = new StatusStrip();
      this.messageToolStripStatusLabel = new ToolStripStatusLabel();
      /************************************************/
      this.guiTimer = new Timer(this.components);
      /************************************************/
      // mainToolStripContainer
      {
        this.mainToolStripContainer.Name = "mainToolStripContainer";
        this.mainToolStripContainer.Dock = DockStyle.Fill;
        /************************************************/
        this.mainToolStripContainer.ContentPanel.Font       = new Font(FontFamily.GenericMonospace, 8f);
        this.mainToolStripContainer.ContentPanel.RenderMode = ToolStripRenderMode.System;
        /************************************************/
        this.mainToolStripContainer.ContentPanel.Controls.Add(this.entityListView);
      }
      // entityListView
      {
        this.entityListView.Name          = "entityListView";
        this.entityListView.Dock          = DockStyle.Fill;
        this.entityListView.FullRowSelect = true;
        this.entityListView.GridLines     = true;
        this.entityListView.HeaderStyle   = ColumnHeaderStyle.Nonclickable;
        this.entityListView.MultiSelect   = true;
        this.entityListView.Sorting       = SortOrder.Ascending;
        this.entityListView.View          = View.Details;
        /************************************************/
        this.entityListView.Columns.Add(this.nameColumnHeader);
        this.entityListView.Columns.Add(this.versionColumnHeader);
        this.entityListView.Columns.Add(this.servicepackColumnHeader);
        this.entityListView.Columns.Add(this.installColumnHeader);
      }
      // nameColumnHeader
      {
        this.nameColumnHeader.Name = "nameColumnHeader";
        this.nameColumnHeader.Text = "Name";
      }
      // versionColumnHeader
      {
        this.versionColumnHeader.Name = "versionColumnHeader";
        this.versionColumnHeader.Text = "Version";
      }
      // servicepackColumnHeader
      {
        this.servicepackColumnHeader.Name = "servicepackColumnHeader";
        this.servicepackColumnHeader.Text = "Service pack";
      }
      // installColumnHeader
      {
        this.installColumnHeader.Name = "installColumnHeader";
        this.installColumnHeader.Text = "Install";
      }
      // topMenuStrip
      {
        this.topMenuStrip.Name       = "topMenuStrip";
        this.topMenuStrip.Dock       = DockStyle.Top;
        this.topMenuStrip.Font       = new Font(FontFamily.GenericMonospace, 8f);
        this.topMenuStrip.RenderMode = ToolStripRenderMode.System;
        /************************************************/
        this.topMenuStrip.Items.Add(this.fileToolStripMenuItem);
        this.topMenuStrip.Items.Add(this.editToolStripMenuItem);
        this.topMenuStrip.Items.Add(this.viewToolStripMenuItem);
      }
      // fileToolStripMenuItem
      {
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Text = "File";
        /************************************************/
        this.fileToolStripMenuItem.DropDownItems.Add(this.exitToolStripMenuItem);
        /************************************************/
        this.fileToolStripMenuItem.DropDownOpening += this.fileToolStripMenuItem_DropDownOpening;
      }
      // exitToolStripMenuItem
      {
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Text = "Exit";
        /************************************************/
        this.exitToolStripMenuItem.Click += this.exitToolStripMenuItem_Click;
      }
      // editToolStripMenuItem
      {
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Text = "Edit";
        /************************************************/
        this.editToolStripMenuItem.DropDownItems.Add(this.copyToolStripMenuItem);
        /************************************************/
        this.editToolStripMenuItem.DropDownOpening += this.editToolStripMenuItem_DropDownOpening;
      }
      // copyToolStripMenuItem
      {
        this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        this.copyToolStripMenuItem.Text = "Copy";
        /************************************************/
        this.copyToolStripMenuItem.Click += this.copyToolStripMenuItem_Click;
      }
      // viewToolStripMenuItem
      {
        this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        this.viewToolStripMenuItem.Text = "View";
        /************************************************/
        this.viewToolStripMenuItem.DropDownItems.Add(this.refreshToolStripMenuItem);
        this.viewToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
        this.viewToolStripMenuItem.DropDownItems.Add(this.statusbarToolStripMenuItem);
        /************************************************/
        this.viewToolStripMenuItem.DropDownOpening += this.viewToolStripMenuItem_DropDownOpening;
      }
      // refreshToolStripMenuItem
      {
        this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
        this.refreshToolStripMenuItem.Text = "Refresh";
        /************************************************/
        this.refreshToolStripMenuItem.Click += this.refreshToolStripMenuItem_Click;
      }
      // statusbarToolStripMenuItem
      {
        this.statusbarToolStripMenuItem.Name = "statusbarToolStripMenuItem";
        this.statusbarToolStripMenuItem.Text = "Status Bar";
        /************************************************/
        this.statusbarToolStripMenuItem.Click += this.statusbarToolStripMenuItem_Click;
      }
      // bottomStatusStrip
      {
        this.bottomStatusStrip.Name       = "bottomStatusStrip";
        this.bottomStatusStrip.Dock       = DockStyle.Bottom;
        this.bottomStatusStrip.Font       = new Font(FontFamily.GenericMonospace, 8f);
        this.bottomStatusStrip.RenderMode = ToolStripRenderMode.System;
        this.bottomStatusStrip.SizingGrip = true;
        /************************************************/
        this.bottomStatusStrip.Items.Add(this.messageToolStripStatusLabel);
      }
      // messageToolStripStatusLabel
      {
        this.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel";
        this.messageToolStripStatusLabel.Text = "Ready";
        /************************************************/
        this.messageToolStripStatusLabel.TextChanged += this.messageToolStripStatusLabel_TextChanged;
      }
      // guiTimer
      {
        this.guiTimer.Enabled  = true;
        this.guiTimer.Interval = 100;
        /************************************************/
        this.guiTimer.Tick += this.guiTimer_Tick;
      }
      // MainForm
      {
        base.Name          = "MainForm";
        base.AutoScaleMode = AutoScaleMode.Font;
        base.Font          = new Font(FontFamily.GenericMonospace, 8f);
        base.StartPosition = FormStartPosition.CenterScreen;
        base.Size          = Size.Round(new SizeF(Screen.PrimaryScreen.WorkingArea.Size.Width  * 0.7f,
                                                  Screen.PrimaryScreen.WorkingArea.Size.Height * 0.7f));
        base.Text          = "Windows.DotnetFrameworkViewer";
        /************************************************/
        base.Controls.Add(this.mainToolStripContainer);
        base.Controls.Add(this.topMenuStrip);
        base.Controls.Add(this.bottomStatusStrip);
      }
    }
    /************************************************/
    private ToolStripContainer   mainToolStripContainer      = null;
    private ListView             entityListView               = null;
    private ColumnHeader         nameColumnHeader            = null;
    private ColumnHeader         versionColumnHeader         = null;
    private ColumnHeader         servicepackColumnHeader     = null;
    private ColumnHeader         installColumnHeader         = null;
    private MenuStrip            topMenuStrip                = null;
    private ToolStripMenuItem    fileToolStripMenuItem       = null;
    private ToolStripMenuItem    exitToolStripMenuItem       = null;
    private ToolStripMenuItem    editToolStripMenuItem       = null;
    private ToolStripMenuItem    copyToolStripMenuItem       = null;
    private ToolStripMenuItem    viewToolStripMenuItem       = null;
    private ToolStripMenuItem    refreshToolStripMenuItem    = null;
    private ToolStripMenuItem    statusbarToolStripMenuItem  = null;
    private StatusStrip          bottomStatusStrip           = null;
    private ToolStripStatusLabel messageToolStripStatusLabel = null;
    /************************************************/
    private Timer guiTimer = null;
  }
}