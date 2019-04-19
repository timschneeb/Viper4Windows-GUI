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
            this.components = new System.ComponentModel.Container();
            this.label_CloseToTray = new System.Windows.Forms.Label();
            this.onOffSwitch_CloseToTray = new MetroSuite.MetroSwitch();
            this.groupBox_TrayMenuSetting = new System.Windows.Forms.GroupBox();
            this.singleButton_AddNewItem = new Syncfusion.Windows.Forms.ButtonAdv();
            this.listView_TrayMenuSetting = new System.Windows.Forms.ListView();
            this.columnHeader_PresetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_PresetMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_PresetFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singleButton_OK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.contextMenuStrip_TrayItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_RemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Name = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_Mode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Preset = new System.Windows.Forms.ToolStripMenuItem();
            this.label_EnableCoexist = new System.Windows.Forms.Label();
            this.onOffSwitch_EnableCoexist = new MetroSuite.MetroSwitch();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.groupBox_TrayMenuSetting.SuspendLayout();
            this.contextMenuStrip_TrayItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CloseToTray
            // 
            this.label_CloseToTray.AutoSize = true;
            this.label_CloseToTray.Location = new System.Drawing.Point(11, 22);
            this.label_CloseToTray.Name = "label_CloseToTray";
            this.label_CloseToTray.Size = new System.Drawing.Size(104, 13);
            this.label_CloseToTray.TabIndex = 0;
            this.label_CloseToTray.Text = "$CLOSE_TO_TRAY";
            // 
            // onOffSwitch_CloseToTray
            // 
            this.onOffSwitch_CloseToTray.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_CloseToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_CloseToTray.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_CloseToTray.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_CloseToTray.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_CloseToTray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_CloseToTray.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_CloseToTray.Location = new System.Drawing.Point(304, 19);
            this.onOffSwitch_CloseToTray.Name = "onOffSwitch_CloseToTray";
            this.onOffSwitch_CloseToTray.Size = new System.Drawing.Size(38, 25);
            this.onOffSwitch_CloseToTray.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_CloseToTray.TabIndex = 1;
            this.onOffSwitch_CloseToTray.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_CloseToTray_CheckedChanged);
            // 
            // groupBox_TrayMenuSetting
            // 
            this.groupBox_TrayMenuSetting.Controls.Add(this.singleButton_AddNewItem);
            this.groupBox_TrayMenuSetting.Controls.Add(this.listView_TrayMenuSetting);
            this.groupBox_TrayMenuSetting.Location = new System.Drawing.Point(14, 81);
            this.groupBox_TrayMenuSetting.Name = "groupBox_TrayMenuSetting";
            this.groupBox_TrayMenuSetting.Size = new System.Drawing.Size(329, 339);
            this.groupBox_TrayMenuSetting.TabIndex = 2;
            this.groupBox_TrayMenuSetting.TabStop = false;
            this.groupBox_TrayMenuSetting.Text = "$TRAY_MENU_SETTING";
            // 
            // singleButton_AddNewItem
            // 
            this.singleButton_AddNewItem.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_AddNewItem.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_AddNewItem.BeforeTouchSize = new System.Drawing.Size(132, 25);
            this.singleButton_AddNewItem.IsBackStageButton = false;
            this.singleButton_AddNewItem.Location = new System.Drawing.Point(191, 305);
            this.singleButton_AddNewItem.Name = "singleButton_AddNewItem";
            this.singleButton_AddNewItem.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_AddNewItem.Size = new System.Drawing.Size(132, 25);
            this.singleButton_AddNewItem.TabIndex = 1;
            this.singleButton_AddNewItem.Text = "$ADD_NEW_ITEM";
            this.singleButton_AddNewItem.ThemeName = "Office2016Colorful";
            this.singleButton_AddNewItem.UseVisualStyle = true;
            this.singleButton_AddNewItem.Click += new System.EventHandler(this.SingleButton_AddNewItem_Click);
            // 
            // listView_TrayMenuSetting
            // 
            this.listView_TrayMenuSetting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_PresetName,
            this.columnHeader_PresetMode,
            this.columnHeader_PresetFile});
            this.listView_TrayMenuSetting.FullRowSelect = true;
            this.listView_TrayMenuSetting.GridLines = true;
            this.listView_TrayMenuSetting.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_TrayMenuSetting.HideSelection = false;
            this.listView_TrayMenuSetting.Location = new System.Drawing.Point(6, 22);
            this.listView_TrayMenuSetting.MultiSelect = false;
            this.listView_TrayMenuSetting.Name = "listView_TrayMenuSetting";
            this.listView_TrayMenuSetting.Size = new System.Drawing.Size(317, 277);
            this.listView_TrayMenuSetting.TabIndex = 0;
            this.listView_TrayMenuSetting.UseCompatibleStateImageBehavior = false;
            this.listView_TrayMenuSetting.View = System.Windows.Forms.View.Details;
            this.listView_TrayMenuSetting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_TrayMenuSetting_MouseUp);
            // 
            // columnHeader_PresetName
            // 
            this.columnHeader_PresetName.Text = "$TRAY_MENU_PRESETNAME";
            this.columnHeader_PresetName.Width = 89;
            // 
            // columnHeader_PresetMode
            // 
            this.columnHeader_PresetMode.Text = "$TRAY_MENU_PRESETMODE";
            this.columnHeader_PresetMode.Width = 81;
            // 
            // columnHeader_PresetFile
            // 
            this.columnHeader_PresetFile.Text = "$TRAY_MENU_PRESETFILE";
            this.columnHeader_PresetFile.Width = 136;
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.singleButton_OK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_OK.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_OK.BeforeTouchSize = new System.Drawing.Size(102, 28);
            this.singleButton_OK.IsBackStageButton = false;
            this.singleButton_OK.Location = new System.Drawing.Point(241, 432);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_OK.Size = new System.Drawing.Size(102, 28);
            this.singleButton_OK.TabIndex = 3;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "Office2016Colorful";
            this.singleButton_OK.UseVisualStyle = true;
            this.singleButton_OK.Click += new System.EventHandler(this.SingleButton_OK_Click);
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.singleButton_Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Cancel.BeforeTouchSize = new System.Drawing.Size(94, 28);
            this.singleButton_Cancel.IsBackStageButton = false;
            this.singleButton_Cancel.Location = new System.Drawing.Point(141, 432);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Cancel.Size = new System.Drawing.Size(94, 28);
            this.singleButton_Cancel.TabIndex = 4;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "Office2016Colorful";
            this.singleButton_Cancel.UseVisualStyle = true;
            this.singleButton_Cancel.Click += new System.EventHandler(this.SingleButton_Cancel_Click);
            // 
            // contextMenuStrip_TrayItem
            // 
            this.contextMenuStrip_TrayItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_RemoveItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem_Name,
            this.toolStripTextBox_Name,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Mode,
            this.toolStripComboBox_Mode,
            this.toolStripSeparator3,
            this.toolStripMenuItem_Preset});
            this.contextMenuStrip_TrayItem.Name = "contextMenuStrip_TrayItem";
            this.contextMenuStrip_TrayItem.Size = new System.Drawing.Size(190, 162);
            // 
            // toolStripMenuItem_RemoveItem
            // 
            this.toolStripMenuItem_RemoveItem.Name = "toolStripMenuItem_RemoveItem";
            this.toolStripMenuItem_RemoveItem.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem_RemoveItem.Text = "$REMOVE_ITEM";
            this.toolStripMenuItem_RemoveItem.Click += new System.EventHandler(this.toolStripMenuItem_RemoveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStripMenuItem_Name
            // 
            this.toolStripMenuItem_Name.Enabled = false;
            this.toolStripMenuItem_Name.Name = "toolStripMenuItem_Name";
            this.toolStripMenuItem_Name.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem_Name.Text = "$MENU_TIPS_NAME";
            // 
            // toolStripTextBox_Name
            // 
            this.toolStripTextBox_Name.Name = "toolStripTextBox_Name";
            this.toolStripTextBox_Name.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_Name_KeyUp);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStripMenuItem_Mode
            // 
            this.toolStripMenuItem_Mode.Enabled = false;
            this.toolStripMenuItem_Mode.Name = "toolStripMenuItem_Mode";
            this.toolStripMenuItem_Mode.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem_Mode.Text = "$MENU_TIPS_MODE";
            // 
            // toolStripComboBox_Mode
            // 
            this.toolStripComboBox_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_Mode.Name = "toolStripComboBox_Mode";
            this.toolStripComboBox_Mode.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_Mode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_Mode_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStripMenuItem_Preset
            // 
            this.toolStripMenuItem_Preset.Name = "toolStripMenuItem_Preset";
            this.toolStripMenuItem_Preset.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem_Preset.Text = "$SELECT_PRESET_FILE";
            this.toolStripMenuItem_Preset.Click += new System.EventHandler(this.toolStripMenuItem_Preset_Click);
            // 
            // label_EnableCoexist
            // 
            this.label_EnableCoexist.AutoSize = true;
            this.label_EnableCoexist.Location = new System.Drawing.Point(11, 50);
            this.label_EnableCoexist.Name = "label_EnableCoexist";
            this.label_EnableCoexist.Size = new System.Drawing.Size(135, 13);
            this.label_EnableCoexist.TabIndex = 5;
            this.label_EnableCoexist.Text = "$ENABLE_APO_COEXIST";
            // 
            // onOffSwitch_EnableCoexist
            // 
            this.onOffSwitch_EnableCoexist.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_EnableCoexist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_EnableCoexist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_EnableCoexist.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_EnableCoexist.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_EnableCoexist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_EnableCoexist.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_EnableCoexist.Location = new System.Drawing.Point(304, 50);
            this.onOffSwitch_EnableCoexist.Name = "onOffSwitch_EnableCoexist";
            this.onOffSwitch_EnableCoexist.Size = new System.Drawing.Size(38, 25);
            this.onOffSwitch_EnableCoexist.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_EnableCoexist.TabIndex = 6;
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 473);
            this.Controls.Add(this.onOffSwitch_EnableCoexist);
            this.Controls.Add(this.label_EnableCoexist);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.groupBox_TrayMenuSetting);
            this.Controls.Add(this.label_CloseToTray);
            this.Controls.Add(this.onOffSwitch_CloseToTray);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$SETTINGS";
            this.groupBox_TrayMenuSetting.ResumeLayout(false);
            this.contextMenuStrip_TrayItem.ResumeLayout(false);
            this.contextMenuStrip_TrayItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040002D9 RID: 729
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.Label label_CloseToTray;

		// Token: 0x040002DB RID: 731
		private global::MetroSuite.MetroSwitch onOffSwitch_CloseToTray;

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
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_AddNewItem;

		// Token: 0x040002E2 RID: 738
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_OK;

		// Token: 0x040002E3 RID: 739
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_Cancel;

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
		private global::MetroSuite.MetroSwitch onOffSwitch_EnableCoexist;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
    }
}
