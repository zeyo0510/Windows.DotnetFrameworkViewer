﻿using System;
using System.Text;
using System.Windows.Forms;
using Windows.DotnetFrameworkViewer.Core;
/************************************************/
namespace Windows.DotnetFrameworkViewer.Main
{
  internal partial class MainForm : Form
  {
    public MainForm()
    {
      this.InitializeComponent();
    }
    /************************************************/
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      /************************************************/
      this.BuildEntity();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ExitApp();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CopyEntity();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.BuildEntity();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void statusbarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ToggleStatusBar();
      /************************************************/
      this.UpdateUI();
    }
    /************************************************/
    private void messageToolStripStatusLabel_TextChanged(object sender, EventArgs e)
    {
      // do nothing...
    }
    /************************************************/
    private void guiTimer_Tick(object sender, EventArgs e)
    {
      this.UpdateUI();
    }
    /************************************************/
    private void BuildEntity()
    {
      this.entityListView.Items.Clear();
      /************************************************/
      foreach (DotnetFramework framework in DotnetFramework.Items)
      {
        ListViewItem item = this.entityListView.Items.Add(new ListViewItem(new string[] { framework.Name, framework.Version, framework.ServicePack, framework.Install }));
        {
          item.Tag = framework;
        }
      }
      /************************************************/
      this.entityListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
      /************************************************/
      this.entityListView.Sort();
    }
    /************************************************/
    private void CopyEntity()
    {
      StringBuilder buffer = new StringBuilder();
      /************************************************/
      foreach (ListViewItem item in this.entityListView.SelectedItems)
      {
        buffer.AppendLine(string.Format("{0}\t{1}\t{2}\t{3}", item.SubItems[0].Text,
                                                              item.SubItems[1].Text,
                                                              item.SubItems[2].Text,
                                                              item.SubItems[3].Text));
      }
      /************************************************/
      Clipboard.SetText(buffer.ToString());
    }
    /************************************************/
    private void ExitApp()
    {
      base.Close();
    }
    /************************************************/
    private void ToggleStatusBar()
    {
      this.bottomStatusStrip.Visible = !this.bottomStatusStrip.Visible;
    }
    /************************************************/
    private void UpdateUI()
    {
      this.fileToolStripMenuItem.Checked = this.fileToolStripMenuItem.Checked;
      this.fileToolStripMenuItem.Enabled = this.fileToolStripMenuItem.Enabled;
      /************************************************/
      this.exitToolStripMenuItem.Checked = this.exitToolStripMenuItem.Checked;
      this.exitToolStripMenuItem.Enabled = this.exitToolStripMenuItem.Enabled;
      /************************************************/
      this.editToolStripMenuItem.Checked = this.editToolStripMenuItem.Checked;
      this.editToolStripMenuItem.Enabled = this.editToolStripMenuItem.Enabled;
      /************************************************/
      this.copyToolStripMenuItem.Checked = this.copyToolStripMenuItem.Checked;
      this.copyToolStripMenuItem.Enabled = this.entityListView.SelectedItems.Count > 0;
      /************************************************/
      this.viewToolStripMenuItem.Checked = this.viewToolStripMenuItem.Checked;
      this.viewToolStripMenuItem.Enabled = this.viewToolStripMenuItem.Enabled;
      /************************************************/
      this.refreshToolStripMenuItem.Checked = this.refreshToolStripMenuItem.Checked;
      this.refreshToolStripMenuItem.Enabled = this.refreshToolStripMenuItem.Enabled;
      /************************************************/
      this.statusbarToolStripMenuItem.Checked = this.bottomStatusStrip.Visible;
      this.statusbarToolStripMenuItem.Enabled = this.statusbarToolStripMenuItem.Enabled;
      /************************************************/
      this.messageToolStripStatusLabel.Text = this.entityListView.SelectedItems.Count == 0 ? string.Format("{0}"         , "Ready"                               ) : this.messageToolStripStatusLabel.Text;
      this.messageToolStripStatusLabel.Text = this.entityListView.SelectedItems.Count >= 1 ? string.Format("{0} selected", this.entityListView.SelectedItems.Count) : this.messageToolStripStatusLabel.Text;
    }
  }
}