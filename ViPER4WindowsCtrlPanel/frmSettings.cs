using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
	// Token: 0x02000038 RID: 56
	public partial class frmSettings : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000271 RID: 625 RVA: 0x0001FA0C File Offset: 0x0001DC0C
		private string EffectModeToString(int nMode)
		{
			if (nMode == 0)
			{
				return GlobalMessages.MUSIC_MODE;
			}
			if (nMode == 1)
			{
				return GlobalMessages.MOVIE_MODE;
			}
			if (nMode == 2)
			{
				return GlobalMessages.FREESTYLE_MODE;
			}
			return "";
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001FA30 File Offset: 0x0001DC30
		public void SetPresetPath(string szPath)
		{
			this.m_szPresetPath = szPath;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001FA39 File Offset: 0x0001DC39
		public void SetCloseToTray(bool bValue)
		{
			this.m_bCloseToTray = bValue;
			this.onOffSwitch_CloseToTray.Checked = this.m_bCloseToTray;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001FA53 File Offset: 0x0001DC53
		public bool GetCloseToTray()
		{
			return this.m_bCloseToTray;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public void SetTrayMenuPresetList(List<TrayMenuPreset> lstTrayMenuPreset)
		{
			this.m_lstTrayMenuPreset.Clear();
			this.listView_TrayMenuSetting.Items.Clear();
			if (lstTrayMenuPreset == null)
			{
				return;
			}
			if (lstTrayMenuPreset.Count <= 0)
			{
				return;
			}
			foreach (TrayMenuPreset trayMenuPreset in lstTrayMenuPreset)
			{
				if (trayMenuPreset.Valid())
				{
					if (string.IsNullOrEmpty(trayMenuPreset.PresetName))
					{
						trayMenuPreset.PresetName = GlobalMessages.UNNAMED;
					}
					TrayMenuPreset trayMenuPreset2 = trayMenuPreset.Clone();
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = trayMenuPreset2.PresetName;
					listViewItem.SubItems.Add(this.EffectModeToString(trayMenuPreset2.PresetMode));
					listViewItem.SubItems.Add(trayMenuPreset2.PresetFileShort);
					listViewItem.Tag = trayMenuPreset2;
					this.listView_TrayMenuSetting.Items.Add(listViewItem);
					this.m_lstTrayMenuPreset.Add(trayMenuPreset2);
				}
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001FB60 File Offset: 0x0001DD60
		public List<TrayMenuPreset> GetTrayMenuPresetList()
		{
			return this.m_lstTrayMenuPreset;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001FB68 File Offset: 0x0001DD68
		public bool GetAPOCoexistEnabled()
		{
			return this.onOffSwitch_EnableCoexist.Checked;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001FB78 File Offset: 0x0001DD78
		public frmSettings()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.SETTINGS;
			this.label_CloseToTray.Text = GlobalMessages.CLOSE_TO_TRAY;
			this.groupBox_TrayMenuSetting.Text = GlobalMessages.TRAY_MENU_SETTING;
			this.listView_TrayMenuSetting.Items.Clear();
			this.listView_TrayMenuSetting.Columns[0].Text = GlobalMessages.TRAY_MENU_PRESETNAME;
			this.listView_TrayMenuSetting.Columns[1].Text = GlobalMessages.TRAY_MENU_PRESETMODE;
			this.listView_TrayMenuSetting.Columns[2].Text = GlobalMessages.TRAY_MENU_PRESETFILE;
			this.singleButton_AddNewItem.Text = GlobalMessages.ADD_NEW_ITEM;
			this.singleButton_OK.Text = GlobalMessages.OK;
			this.singleButton_Cancel.Text = GlobalMessages.CANCEL;
			this.toolStripMenuItem_RemoveItem.Text = GlobalMessages.REMOVE_ITEM;
			this.toolStripMenuItem_Name.Text = GlobalMessages.MENU_TIPS_NAME;
			this.toolStripMenuItem_Mode.Text = GlobalMessages.MENU_TIPS_MODE;
			this.toolStripMenuItem_Preset.Text = GlobalMessages.SELECT_PRESET_FILE;
			this.toolStripComboBox_Mode.Items.Clear();
			this.toolStripComboBox_Mode.Items.Add(new frmSettings.PresetModeItem(0));
			this.toolStripComboBox_Mode.Items.Add(new frmSettings.PresetModeItem(1));
			this.toolStripComboBox_Mode.Items.Add(new frmSettings.PresetModeItem(2));
			this.m_lstTrayMenuPreset.Clear();
			this.m_bCloseToTray = false;
			this.onOffSwitch_CloseToTray.Checked = false;
			this.label_EnableCoexist.Text = GlobalMessages.ENABLE_APO_COEXIST;
			if (RegHelper.QueryDWORD("LoadChildAPO", 0u) == 1u)
			{
				this.onOffSwitch_EnableCoexist.Checked = true;
				return;
			}
			this.onOffSwitch_EnableCoexist.Checked = false;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001FD50 File Offset: 0x0001DF50
		private void RefreshList()
		{
			this.listView_TrayMenuSetting.Items.Clear();
			foreach (TrayMenuPreset trayMenuPreset in this.m_lstTrayMenuPreset)
			{
				if (trayMenuPreset.Valid())
				{
					if (string.IsNullOrEmpty(trayMenuPreset.PresetName))
					{
						trayMenuPreset.PresetName = GlobalMessages.UNNAMED;
					}
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = trayMenuPreset.PresetName;
					listViewItem.SubItems.Add(this.EffectModeToString(trayMenuPreset.PresetMode));
					listViewItem.SubItems.Add(trayMenuPreset.PresetFileShort);
					listViewItem.Tag = trayMenuPreset;
					this.listView_TrayMenuSetting.Items.Add(listViewItem);
				}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001FE60 File Offset: 0x0001E060
		private void listView_TrayMenuSetting_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (this.listView_TrayMenuSetting.SelectedItems.Count != 1)
				{
					return;
				}
				if (this.listView_TrayMenuSetting.SelectedItems[0].Tag == null)
				{
					return;
				}
				if (this.listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
				{
					return;
				}
				TrayMenuPreset trayMenuPreset = this.listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
				this.toolStripTextBox_Name.Text = trayMenuPreset.PresetName;
				for (int i = 0; i < this.toolStripComboBox_Mode.Items.Count; i++)
				{
					if (this.toolStripComboBox_Mode.Items[i] != null && this.toolStripComboBox_Mode.Items[i].GetType() == typeof(frmSettings.PresetModeItem))
					{
						frmSettings.PresetModeItem presetModeItem = this.toolStripComboBox_Mode.Items[i] as frmSettings.PresetModeItem;
						if (presetModeItem.PresetMode == trayMenuPreset.PresetMode)
						{
							this.toolStripComboBox_Mode.SelectedIndex = i;
							break;
						}
					}
				}
				this.contextMenuStrip_TrayItem.Show(this.listView_TrayMenuSetting, e.Location);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001FF9C File Offset: 0x0001E19C
		private void toolStripMenuItem_RemoveItem_Click(object sender, EventArgs e)
		{
			if (this.listView_TrayMenuSetting.SelectedItems.Count != 1)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag == null)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
			{
				return;
			}
			if (MessageBox.Show(GlobalMessages.REMOVE_ITEM_QUESTION, GlobalMessages.REMOVE_ITEM, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			TrayMenuPreset item = this.listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
			if (this.m_lstTrayMenuPreset.Contains(item))
			{
				this.m_lstTrayMenuPreset.Remove(item);
			}
			this.RefreshList();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00020054 File Offset: 0x0001E254
		private void toolStripTextBox_Name_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.listView_TrayMenuSetting.SelectedItems.Count != 1)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag == null)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
			{
				return;
			}
			TrayMenuPreset trayMenuPreset = this.listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
			trayMenuPreset.PresetName = this.toolStripTextBox_Name.Text;
			if (string.IsNullOrEmpty(trayMenuPreset.PresetName))
			{
				trayMenuPreset.PresetName = GlobalMessages.UNNAMED;
			}
			this.listView_TrayMenuSetting.SelectedItems[0].Text = trayMenuPreset.PresetName;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00020118 File Offset: 0x0001E318
		private void toolStripComboBox_Mode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listView_TrayMenuSetting.SelectedItems.Count != 1)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag == null)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
			{
				return;
			}
			TrayMenuPreset trayMenuPreset = this.listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
			if (this.toolStripComboBox_Mode.SelectedItem == null)
			{
				return;
			}
			if (this.toolStripComboBox_Mode.SelectedItem.GetType() != typeof(frmSettings.PresetModeItem))
			{
				return;
			}
			frmSettings.PresetModeItem presetModeItem = this.toolStripComboBox_Mode.SelectedItem as frmSettings.PresetModeItem;
			trayMenuPreset.PresetMode = presetModeItem.PresetMode;
			this.listView_TrayMenuSetting.SelectedItems[0].SubItems[1].Text = this.EffectModeToString(trayMenuPreset.PresetMode);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002020C File Offset: 0x0001E40C
		private void toolStripMenuItem_Preset_Click(object sender, EventArgs e)
		{
			if (this.listView_TrayMenuSetting.SelectedItems.Count != 1)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag == null)
			{
				return;
			}
			if (this.listView_TrayMenuSetting.SelectedItems[0].Tag.GetType() != typeof(TrayMenuPreset))
			{
				return;
			}
			TrayMenuPreset trayMenuPreset = this.listView_TrayMenuSetting.SelectedItems[0].Tag as TrayMenuPreset;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = GlobalMessages.LOAD_PRESET;
			openFileDialog.Filter = "*.vpf|*.vpf";
			openFileDialog.DefaultExt = "vpf";
			openFileDialog.InitialDirectory = this.m_szPresetPath;
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			trayMenuPreset.PresetFile = openFileDialog.FileName;
			this.RefreshList();
		}

		// Token: 0x040002D6 RID: 726
		private List<TrayMenuPreset> m_lstTrayMenuPreset = new List<TrayMenuPreset>();

		// Token: 0x040002D7 RID: 727
		private bool m_bCloseToTray;

		// Token: 0x040002D8 RID: 728
		private string m_szPresetPath = "";

		// Token: 0x02000039 RID: 57
		private class PresetModeItem
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000285 RID: 645 RVA: 0x00020D0E File Offset: 0x0001EF0E
			// (set) Token: 0x06000286 RID: 646 RVA: 0x00020D16 File Offset: 0x0001EF16
			public int PresetMode
			{
				get
				{
					return this.m_nPresetMode;
				}
				set
				{
					this.m_nPresetMode = value;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000287 RID: 647 RVA: 0x00020D1F File Offset: 0x0001EF1F
			public string PresetModeString
			{
				get
				{
					if (this.m_nPresetMode == 0)
					{
						return GlobalMessages.MUSIC_MODE;
					}
					if (this.m_nPresetMode == 1)
					{
						return GlobalMessages.MOVIE_MODE;
					}
					if (this.m_nPresetMode == 2)
					{
						return GlobalMessages.FREESTYLE_MODE;
					}
					return "";
				}
			}

			// Token: 0x06000288 RID: 648 RVA: 0x00020D52 File Offset: 0x0001EF52
			public PresetModeItem(int nMode)
			{
				this.m_nPresetMode = nMode;
			}

			// Token: 0x06000289 RID: 649 RVA: 0x00020D68 File Offset: 0x0001EF68
			public override bool Equals(object obj)
			{
				if (obj == null)
				{
					return false;
				}
				if (obj.GetType() != typeof(frmSettings.PresetModeItem))
				{
					return false;
				}
				frmSettings.PresetModeItem presetModeItem = obj as frmSettings.PresetModeItem;
				return presetModeItem.PresetMode == this.m_nPresetMode;
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00020DA6 File Offset: 0x0001EFA6
			public override int GetHashCode()
			{
				return this.m_nPresetMode;
			}

			// Token: 0x0600028B RID: 651 RVA: 0x00020DAE File Offset: 0x0001EFAE
			public override string ToString()
			{
				return this.PresetModeString;
			}

			// Token: 0x040002F0 RID: 752
			private int m_nPresetMode = -1;
		}

        private void SingleButton_OK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void SingleButton_Cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void SingleButton_AddNewItem_Click(object sender, EventArgs e)
        {
            TrayMenuPreset item = new TrayMenuPreset(GlobalMessages.UNNAMED, 0, "");
            this.m_lstTrayMenuPreset.Add(item);
            this.RefreshList();
        }

        private void OnOffSwitch_CloseToTray_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bCloseToTray = isChecked;
        }
    }
}
