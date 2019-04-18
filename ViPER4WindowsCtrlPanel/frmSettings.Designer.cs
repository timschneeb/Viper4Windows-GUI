namespace ViPER4WindowsBin
{
	// Token: 0x02000038 RID: 56
	public partial class frmSettings : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000283 RID: 643 RVA: 0x000202EB File Offset: 0x0001E4EB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0002030C File Offset: 0x0001E50C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmSettings));
			this.label_CloseToTray = new global::System.Windows.Forms.Label();
			this.onOffSwitch_CloseToTray = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.groupBox_TrayMenuSetting = new global::System.Windows.Forms.GroupBox();
			this.singleButton_AddNewItem = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.listView_TrayMenuSetting = new global::System.Windows.Forms.ListView();
			this.columnHeader_PresetName = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_PresetMode = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_PresetFile = new global::System.Windows.Forms.ColumnHeader();
			this.singleButton_OK = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.singleButton_Cancel = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.contextMenuStrip_TrayItem = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_RemoveItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Name = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox_Name = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Mode = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox_Mode = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Preset = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label_EnableCoexist = new global::System.Windows.Forms.Label();
			this.onOffSwitch_EnableCoexist = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.groupBox_TrayMenuSetting.SuspendLayout();
			this.contextMenuStrip_TrayItem.SuspendLayout();
			base.SuspendLayout();
			this.label_CloseToTray.AutoSize = true;
			this.label_CloseToTray.Location = new global::System.Drawing.Point(12, 28);
			this.label_CloseToTray.Name = "label_CloseToTray";
			this.label_CloseToTray.Size = new global::System.Drawing.Size(89, 12);
			this.label_CloseToTray.TabIndex = 0;
			this.label_CloseToTray.Text = "$CLOSE_TO_TRAY";
			this.onOffSwitch_CloseToTray.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_CloseToTray.Location = new global::System.Drawing.Point(277, 22);
			this.onOffSwitch_CloseToTray.Name = "onOffSwitch_CloseToTray";
			this.onOffSwitch_CloseToTray.Size = new global::System.Drawing.Size(66, 23);
			this.onOffSwitch_CloseToTray.SwitchedOn = false;
			this.onOffSwitch_CloseToTray.TabIndex = 1;
			this.onOffSwitch_CloseToTray.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_CloseToTray_SwitchChangeNotify);
			this.groupBox_TrayMenuSetting.Controls.Add(this.singleButton_AddNewItem);
			this.groupBox_TrayMenuSetting.Controls.Add(this.listView_TrayMenuSetting);
			this.groupBox_TrayMenuSetting.Location = new global::System.Drawing.Point(14, 59);
			this.groupBox_TrayMenuSetting.Name = "groupBox_TrayMenuSetting";
			this.groupBox_TrayMenuSetting.Size = new global::System.Drawing.Size(329, 320);
			this.groupBox_TrayMenuSetting.TabIndex = 2;
			this.groupBox_TrayMenuSetting.TabStop = false;
			this.groupBox_TrayMenuSetting.Text = "$TRAY_MENU_SETTING";
			this.singleButton_AddNewItem.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_AddNewItem.ButtonText = "$ADD_NEW_ITEM";
			this.singleButton_AddNewItem.Location = new global::System.Drawing.Point(6, 282);
			this.singleButton_AddNewItem.Name = "singleButton_AddNewItem";
			this.singleButton_AddNewItem.Size = new global::System.Drawing.Size(132, 29);
			this.singleButton_AddNewItem.TabIndex = 1;
			this.singleButton_AddNewItem.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_AddNewItem_ButtonClickNotify);
			this.listView_TrayMenuSetting.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_PresetName,
				this.columnHeader_PresetMode,
				this.columnHeader_PresetFile
			});
			this.listView_TrayMenuSetting.FullRowSelect = true;
			this.listView_TrayMenuSetting.GridLines = true;
			this.listView_TrayMenuSetting.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView_TrayMenuSetting.HideSelection = false;
			this.listView_TrayMenuSetting.Location = new global::System.Drawing.Point(6, 20);
			this.listView_TrayMenuSetting.MultiSelect = false;
			this.listView_TrayMenuSetting.Name = "listView_TrayMenuSetting";
			this.listView_TrayMenuSetting.Size = new global::System.Drawing.Size(317, 256);
			this.listView_TrayMenuSetting.TabIndex = 0;
			this.listView_TrayMenuSetting.UseCompatibleStateImageBehavior = false;
			this.listView_TrayMenuSetting.View = global::System.Windows.Forms.View.Details;
			this.listView_TrayMenuSetting.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView_TrayMenuSetting_MouseUp);
			this.columnHeader_PresetName.Text = "$TRAY_MENU_PRESETNAME";
			this.columnHeader_PresetName.Width = 89;
			this.columnHeader_PresetMode.Text = "$TRAY_MENU_PRESETMODE";
			this.columnHeader_PresetMode.Width = 81;
			this.columnHeader_PresetFile.Text = "$TRAY_MENU_PRESETFILE";
			this.columnHeader_PresetFile.Width = 136;
			this.singleButton_OK.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_OK.ButtonText = "$OK";
			this.singleButton_OK.Location = new global::System.Drawing.Point(14, 447);
			this.singleButton_OK.Name = "singleButton_OK";
			this.singleButton_OK.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_OK.TabIndex = 3;
			this.singleButton_OK.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_OK_ButtonClickNotify);
			this.singleButton_Cancel.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Cancel.ButtonText = "$CANCEL";
			this.singleButton_Cancel.Location = new global::System.Drawing.Point(231, 447);
			this.singleButton_Cancel.Name = "singleButton_Cancel";
			this.singleButton_Cancel.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_Cancel.TabIndex = 4;
			this.singleButton_Cancel.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Cancel_ButtonClickNotify);
			this.contextMenuStrip_TrayItem.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_RemoveItem,
				this.toolStripSeparator1,
				this.toolStripMenuItem_Name,
				this.toolStripTextBox_Name,
				this.toolStripSeparator2,
				this.toolStripMenuItem_Mode,
				this.toolStripComboBox_Mode,
				this.toolStripSeparator3,
				this.toolStripMenuItem_Preset
			});
			this.contextMenuStrip_TrayItem.Name = "contextMenuStrip_TrayItem";
			this.contextMenuStrip_TrayItem.Size = new global::System.Drawing.Size(202, 164);
			this.toolStripMenuItem_RemoveItem.Name = "toolStripMenuItem_RemoveItem";
			this.toolStripMenuItem_RemoveItem.Size = new global::System.Drawing.Size(201, 22);
			this.toolStripMenuItem_RemoveItem.Text = "$REMOVE_ITEM";
			this.toolStripMenuItem_RemoveItem.Click += new global::System.EventHandler(this.toolStripMenuItem_RemoveItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(198, 6);
			this.toolStripMenuItem_Name.Enabled = false;
			this.toolStripMenuItem_Name.Name = "toolStripMenuItem_Name";
			this.toolStripMenuItem_Name.Size = new global::System.Drawing.Size(201, 22);
			this.toolStripMenuItem_Name.Text = "$MENU_TIPS_NAME";
			this.toolStripTextBox_Name.Name = "toolStripTextBox_Name";
			this.toolStripTextBox_Name.Size = new global::System.Drawing.Size(100, 23);
			this.toolStripTextBox_Name.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_Name_KeyUp);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(198, 6);
			this.toolStripMenuItem_Mode.Enabled = false;
			this.toolStripMenuItem_Mode.Name = "toolStripMenuItem_Mode";
			this.toolStripMenuItem_Mode.Size = new global::System.Drawing.Size(201, 22);
			this.toolStripMenuItem_Mode.Text = "$MENU_TIPS_MODE";
			this.toolStripComboBox_Mode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox_Mode.Name = "toolStripComboBox_Mode";
			this.toolStripComboBox_Mode.Size = new global::System.Drawing.Size(121, 25);
			this.toolStripComboBox_Mode.SelectedIndexChanged += new global::System.EventHandler(this.toolStripComboBox_Mode_SelectedIndexChanged);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(198, 6);
			this.toolStripMenuItem_Preset.Name = "toolStripMenuItem_Preset";
			this.toolStripMenuItem_Preset.Size = new global::System.Drawing.Size(201, 22);
			this.toolStripMenuItem_Preset.Text = "$SELECT_PRESET_FILE";
			this.toolStripMenuItem_Preset.Click += new global::System.EventHandler(this.toolStripMenuItem_Preset_Click);
			this.label_EnableCoexist.AutoSize = true;
			this.label_EnableCoexist.Location = new global::System.Drawing.Point(12, 407);
			this.label_EnableCoexist.Name = "label_EnableCoexist";
			this.label_EnableCoexist.Size = new global::System.Drawing.Size(119, 12);
			this.label_EnableCoexist.TabIndex = 5;
			this.label_EnableCoexist.Text = "$ENABLE_APO_COEXIST";
			this.onOffSwitch_EnableCoexist.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_EnableCoexist.Location = new global::System.Drawing.Point(277, 401);
			this.onOffSwitch_EnableCoexist.Name = "onOffSwitch_EnableCoexist";
			this.onOffSwitch_EnableCoexist.Size = new global::System.Drawing.Size(66, 23);
			this.onOffSwitch_EnableCoexist.SwitchedOn = false;
			this.onOffSwitch_EnableCoexist.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(356, 498);
			base.Controls.Add(this.onOffSwitch_EnableCoexist);
			base.Controls.Add(this.label_EnableCoexist);
			base.Controls.Add(this.singleButton_Cancel);
			base.Controls.Add(this.singleButton_OK);
			base.Controls.Add(this.groupBox_TrayMenuSetting);
			base.Controls.Add(this.label_CloseToTray);
			base.Controls.Add(this.onOffSwitch_CloseToTray);
			this.DoubleBuffered = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmSettings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$SETTINGS";
			this.groupBox_TrayMenuSetting.ResumeLayout(false);
			this.contextMenuStrip_TrayItem.ResumeLayout(false);
			this.contextMenuStrip_TrayItem.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002D9 RID: 729
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.Label label_CloseToTray;

		// Token: 0x040002DB RID: 731
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_CloseToTray;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.GroupBox groupBox_TrayMenuSetting;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.ListView listView_TrayMenuSetting;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.ColumnHeader columnHeader_PresetName;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.ColumnHeader columnHeader_PresetMode;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.ColumnHeader columnHeader_PresetFile;

		// Token: 0x040002E1 RID: 737
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_AddNewItem;

		// Token: 0x040002E2 RID: 738
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_OK;

		// Token: 0x040002E3 RID: 739
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Cancel;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip_TrayItem;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_RemoveItem;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Name;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.ToolStripTextBox toolStripTextBox_Name;

		// Token: 0x040002E9 RID: 745
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Mode;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Forms.ToolStripComboBox toolStripComboBox_Mode;

		// Token: 0x040002EC RID: 748
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040002ED RID: 749
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Preset;

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Forms.Label label_EnableCoexist;

		// Token: 0x040002EF RID: 751
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_EnableCoexist;
	}
}
