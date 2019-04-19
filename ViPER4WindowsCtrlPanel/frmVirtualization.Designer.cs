namespace ViPER4WindowsBin
{
	// Token: 0x02000017 RID: 23
	public partial class frmVirtualization : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x0600014C RID: 332 RVA: 0x00016067 File Offset: 0x00014267
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00016088 File Offset: 0x00014288
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label_AudioSystemConfig = new System.Windows.Forms.Label();
            this.groupBox_VirtApplied = new System.Windows.Forms.GroupBox();
            this.checkBox_Freestyle = new System.Windows.Forms.CheckBox();
            this.listView_Speaker = new System.Windows.Forms.ListView();
            this.columnHeader_Speaker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Angle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_VirtEnv = new System.Windows.Forms.GroupBox();
            this.twoSelector_PrePostProcess = new MetroSuite.MetroSwitch();
            this.label_PrePostProcess = new System.Windows.Forms.Label();
            this.hSlider_EnvRealizeDrySignal = new MetroSuite.MetroTrackbar();
            this.comboBox_EnvRealizePreset = new System.Windows.Forms.ComboBox();
            this.onOffSwitch_EnvRealize = new MetroSuite.MetroSwitch();
            this.contextMenuStrip_SpeakerAngle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_SpeakerAngle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_Angle = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox_SpeakerAngle = new System.Windows.Forms.ToolStripComboBox();
            this.singleButton_Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_ResetConfig = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_OK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonBox_AudioSystemConfig = new System.Windows.Forms.ListBox();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.groupBox_VirtApplied.SuspendLayout();
            this.groupBox_VirtEnv.SuspendLayout();
            this.contextMenuStrip_SpeakerAngle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AudioSystemConfig
            // 
            this.label_AudioSystemConfig.AutoSize = true;
            this.label_AudioSystemConfig.Location = new System.Drawing.Point(12, 18);
            this.label_AudioSystemConfig.Name = "label_AudioSystemConfig";
            this.label_AudioSystemConfig.Size = new System.Drawing.Size(143, 13);
            this.label_AudioSystemConfig.TabIndex = 0;
            this.label_AudioSystemConfig.Text = "$AUDIO_SYSTEM_CONFIG";
            // 
            // groupBox_VirtApplied
            // 
            this.groupBox_VirtApplied.Controls.Add(this.checkBox_Freestyle);
            this.groupBox_VirtApplied.Location = new System.Drawing.Point(324, 160);
            this.groupBox_VirtApplied.Name = "groupBox_VirtApplied";
            this.groupBox_VirtApplied.Size = new System.Drawing.Size(216, 54);
            this.groupBox_VirtApplied.TabIndex = 2;
            this.groupBox_VirtApplied.TabStop = false;
            this.groupBox_VirtApplied.Text = "$VIRT_APPLIED";
            // 
            // checkBox_Freestyle
            // 
            this.checkBox_Freestyle.AutoSize = true;
            this.checkBox_Freestyle.Location = new System.Drawing.Point(10, 24);
            this.checkBox_Freestyle.Name = "checkBox_Freestyle";
            this.checkBox_Freestyle.Size = new System.Drawing.Size(132, 17);
            this.checkBox_Freestyle.TabIndex = 5;
            this.checkBox_Freestyle.Text = "$FREESTYLE_MODE";
            this.checkBox_Freestyle.UseVisualStyleBackColor = true;
            // 
            // listView_Speaker
            // 
            this.listView_Speaker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Speaker,
            this.columnHeader_Angle});
            this.listView_Speaker.FullRowSelect = true;
            this.listView_Speaker.GridLines = true;
            this.listView_Speaker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Speaker.HideSelection = false;
            this.listView_Speaker.Location = new System.Drawing.Point(151, 39);
            this.listView_Speaker.MultiSelect = false;
            this.listView_Speaker.Name = "listView_Speaker";
            this.listView_Speaker.Size = new System.Drawing.Size(167, 212);
            this.listView_Speaker.TabIndex = 3;
            this.listView_Speaker.UseCompatibleStateImageBehavior = false;
            this.listView_Speaker.View = System.Windows.Forms.View.Details;
            this.listView_Speaker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_Speaker_MouseUp);
            // 
            // columnHeader_Speaker
            // 
            this.columnHeader_Speaker.Text = "$VIRT_SPEAKER";
            this.columnHeader_Speaker.Width = 95;
            // 
            // columnHeader_Angle
            // 
            this.columnHeader_Angle.Text = "$VIRT_SPEAKER_ANGLE";
            // 
            // groupBox_VirtEnv
            // 
            this.groupBox_VirtEnv.Controls.Add(this.twoSelector_PrePostProcess);
            this.groupBox_VirtEnv.Controls.Add(this.label_PrePostProcess);
            this.groupBox_VirtEnv.Controls.Add(this.hSlider_EnvRealizeDrySignal);
            this.groupBox_VirtEnv.Controls.Add(this.comboBox_EnvRealizePreset);
            this.groupBox_VirtEnv.Controls.Add(this.onOffSwitch_EnvRealize);
            this.groupBox_VirtEnv.Location = new System.Drawing.Point(324, 39);
            this.groupBox_VirtEnv.Name = "groupBox_VirtEnv";
            this.groupBox_VirtEnv.Size = new System.Drawing.Size(222, 115);
            this.groupBox_VirtEnv.TabIndex = 5;
            this.groupBox_VirtEnv.TabStop = false;
            this.groupBox_VirtEnv.Text = "$VIRTUAL_ENVIRONMENT";
            // 
            // twoSelector_PrePostProcess
            // 
            this.twoSelector_PrePostProcess.BackColor = System.Drawing.Color.Transparent;
            this.twoSelector_PrePostProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.twoSelector_PrePostProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.twoSelector_PrePostProcess.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.twoSelector_PrePostProcess.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.twoSelector_PrePostProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.twoSelector_PrePostProcess.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.twoSelector_PrePostProcess.Location = new System.Drawing.Point(173, 85);
            this.twoSelector_PrePostProcess.Name = "twoSelector_PrePostProcess";
            this.twoSelector_PrePostProcess.Size = new System.Drawing.Size(43, 24);
            this.twoSelector_PrePostProcess.SwitchColor = System.Drawing.Color.White;
            this.twoSelector_PrePostProcess.TabIndex = 9;
            // 
            // label_PrePostProcess
            // 
            this.label_PrePostProcess.AutoSize = true;
            this.label_PrePostProcess.Location = new System.Drawing.Point(6, 86);
            this.label_PrePostProcess.Name = "label_PrePostProcess";
            this.label_PrePostProcess.Size = new System.Drawing.Size(127, 13);
            this.label_PrePostProcess.TabIndex = 3;
            this.label_PrePostProcess.Text = "$PRE_POST_PROCESS";
            // 
            // hSlider_EnvRealizeDrySignal
            // 
            this.hSlider_EnvRealizeDrySignal.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_EnvRealizeDrySignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_EnvRealizeDrySignal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_EnvRealizeDrySignal.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_EnvRealizeDrySignal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_EnvRealizeDrySignal.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_EnvRealizeDrySignal.Location = new System.Drawing.Point(68, 52);
            this.hSlider_EnvRealizeDrySignal.Name = "hSlider_EnvRealizeDrySignal";
            this.hSlider_EnvRealizeDrySignal.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_EnvRealizeDrySignal.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_EnvRealizeDrySignal.Size = new System.Drawing.Size(148, 22);
            this.hSlider_EnvRealizeDrySignal.SliderColor = System.Drawing.Color.White;
            this.hSlider_EnvRealizeDrySignal.TabIndex = 2;
            this.hSlider_EnvRealizeDrySignal.Value = 0;
            this.hSlider_EnvRealizeDrySignal.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_EnvRealizeDrySignal_Scroll);
            // 
            // comboBox_EnvRealizePreset
            // 
            this.comboBox_EnvRealizePreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EnvRealizePreset.FormattingEnabled = true;
            this.comboBox_EnvRealizePreset.Location = new System.Drawing.Point(6, 22);
            this.comboBox_EnvRealizePreset.Name = "comboBox_EnvRealizePreset";
            this.comboBox_EnvRealizePreset.Size = new System.Drawing.Size(210, 21);
            this.comboBox_EnvRealizePreset.TabIndex = 1;
            // 
            // onOffSwitch_EnvRealize
            // 
            this.onOffSwitch_EnvRealize.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_EnvRealize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_EnvRealize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_EnvRealize.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_EnvRealize.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_EnvRealize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_EnvRealize.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_EnvRealize.Location = new System.Drawing.Point(8, 54);
            this.onOffSwitch_EnvRealize.Name = "onOffSwitch_EnvRealize";
            this.onOffSwitch_EnvRealize.Size = new System.Drawing.Size(40, 24);
            this.onOffSwitch_EnvRealize.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_EnvRealize.TabIndex = 0;
            // 
            // contextMenuStrip_SpeakerAngle
            // 
            this.contextMenuStrip_SpeakerAngle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SpeakerAngle,
            this.toolStripSeparator_Angle,
            this.toolStripComboBox_SpeakerAngle});
            this.contextMenuStrip_SpeakerAngle.Name = "contextMenuStrip_SpeakerAngle";
            this.contextMenuStrip_SpeakerAngle.Size = new System.Drawing.Size(182, 59);
            this.contextMenuStrip_SpeakerAngle.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip_SpeakerAngle_Closed);
            // 
            // toolStripMenuItem_SpeakerAngle
            // 
            this.toolStripMenuItem_SpeakerAngle.Enabled = false;
            this.toolStripMenuItem_SpeakerAngle.Name = "toolStripMenuItem_SpeakerAngle";
            this.toolStripMenuItem_SpeakerAngle.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_SpeakerAngle.Text = "$SPEAKER_ANGLE";
            // 
            // toolStripSeparator_Angle
            // 
            this.toolStripSeparator_Angle.Name = "toolStripSeparator_Angle";
            this.toolStripSeparator_Angle.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox_SpeakerAngle
            // 
            this.toolStripComboBox_SpeakerAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_SpeakerAngle.Name = "toolStripComboBox_SpeakerAngle";
            this.toolStripComboBox_SpeakerAngle.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_SpeakerAngle.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SpeakerAngle_SelectedIndexChanged);
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.singleButton_Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Cancel.BeforeTouchSize = new System.Drawing.Size(95, 25);
            this.singleButton_Cancel.IsBackStageButton = false;
            this.singleButton_Cancel.Location = new System.Drawing.Point(346, 269);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Cancel.Size = new System.Drawing.Size(95, 25);
            this.singleButton_Cancel.TabIndex = 8;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "Office2016Colorful";
            this.singleButton_Cancel.UseVisualStyle = true;
            this.singleButton_Cancel.Click += new System.EventHandler(this.SingleButton_Cancel_Click);
            // 
            // singleButton_ResetConfig
            // 
            this.singleButton_ResetConfig.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_ResetConfig.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_ResetConfig.BeforeTouchSize = new System.Drawing.Size(216, 31);
            this.singleButton_ResetConfig.IsBackStageButton = false;
            this.singleButton_ResetConfig.Location = new System.Drawing.Point(324, 220);
            this.singleButton_ResetConfig.Name = "singleButton_ResetConfig";
            this.singleButton_ResetConfig.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_ResetConfig.Size = new System.Drawing.Size(216, 31);
            this.singleButton_ResetConfig.TabIndex = 4;
            this.singleButton_ResetConfig.Text = "$VIRT_RESET";
            this.singleButton_ResetConfig.ThemeName = "Office2016Colorful";
            this.singleButton_ResetConfig.UseVisualStyle = true;
            this.singleButton_ResetConfig.Click += new System.EventHandler(this.SingleButton_ResetConfig_Click);
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.singleButton_OK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_OK.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_OK.BeforeTouchSize = new System.Drawing.Size(95, 25);
            this.singleButton_OK.IsBackStageButton = false;
            this.singleButton_OK.Location = new System.Drawing.Point(447, 269);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_OK.Size = new System.Drawing.Size(95, 25);
            this.singleButton_OK.TabIndex = 6;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "Office2016Colorful";
            this.singleButton_OK.UseVisualStyle = true;
            this.singleButton_OK.Click += new System.EventHandler(this.SingleButton_OK_Click);
            // 
            // buttonBox_AudioSystemConfig
            // 
            this.buttonBox_AudioSystemConfig.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBox_AudioSystemConfig.Location = new System.Drawing.Point(14, 39);
            this.buttonBox_AudioSystemConfig.Name = "buttonBox_AudioSystemConfig";
            this.buttonBox_AudioSystemConfig.Size = new System.Drawing.Size(131, 212);
            this.buttonBox_AudioSystemConfig.TabIndex = 1;
            this.buttonBox_AudioSystemConfig.SelectedIndexChanged += new System.EventHandler(this.ButtonBox_AudioSystemConfig_SelectedIndexChanged);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // frmVirtualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 309);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.groupBox_VirtEnv);
            this.Controls.Add(this.singleButton_ResetConfig);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.listView_Speaker);
            this.Controls.Add(this.groupBox_VirtApplied);
            this.Controls.Add(this.buttonBox_AudioSystemConfig);
            this.Controls.Add(this.label_AudioSystemConfig);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVirtualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$VIRTUALIZATION";
            this.groupBox_VirtApplied.ResumeLayout(false);
            this.groupBox_VirtApplied.PerformLayout();
            this.groupBox_VirtEnv.ResumeLayout(false);
            this.groupBox_VirtEnv.PerformLayout();
            this.contextMenuStrip_SpeakerAngle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.Label label_AudioSystemConfig;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.ListBox buttonBox_AudioSystemConfig;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.GroupBox groupBox_VirtApplied;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.CheckBox checkBox_Freestyle;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.ListView listView_Speaker;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.ColumnHeader columnHeader_Speaker;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.ColumnHeader columnHeader_Angle;

		// Token: 0x0400017D RID: 381
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_ResetConfig;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.GroupBox groupBox_VirtEnv;

		// Token: 0x0400017F RID: 383
		private global::MetroSuite.MetroSwitch onOffSwitch_EnvRealize;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.ComboBox comboBox_EnvRealizePreset;

		// Token: 0x04000181 RID: 385
		private global::MetroSuite.MetroTrackbar hSlider_EnvRealizeDrySignal;

		// Token: 0x04000182 RID: 386
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_OK;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Label label_PrePostProcess;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip_SpeakerAngle;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SpeakerAngle;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator_Angle;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.ToolStripComboBox toolStripComboBox_SpeakerAngle;

		// Token: 0x04000188 RID: 392
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_Cancel;

		// Token: 0x04000189 RID: 393
		private global::MetroSuite.MetroSwitch twoSelector_PrePostProcess;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
    }
}
