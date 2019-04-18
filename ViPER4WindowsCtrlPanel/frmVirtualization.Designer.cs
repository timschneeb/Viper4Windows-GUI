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
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmVirtualization));
			this.label_AudioSystemConfig = new global::System.Windows.Forms.Label();
			this.groupBox_VirtApplied = new global::System.Windows.Forms.GroupBox();
			this.checkBox_Freestyle = new global::System.Windows.Forms.CheckBox();
			this.checkBox_MovieMode = new global::System.Windows.Forms.CheckBox();
			this.checkBox_MusicMode = new global::System.Windows.Forms.CheckBox();
			this.listView_Speaker = new global::System.Windows.Forms.ListView();
			this.columnHeader_Speaker = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_Angle = new global::System.Windows.Forms.ColumnHeader();
			this.groupBox_VirtEnv = new global::System.Windows.Forms.GroupBox();
			this.label_PrePostProcess = new global::System.Windows.Forms.Label();
			this.comboBox_EnvRealizePreset = new global::System.Windows.Forms.ComboBox();
			this.contextMenuStrip_SpeakerAngle = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_SpeakerAngle = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator_Angle = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox_SpeakerAngle = new global::System.Windows.Forms.ToolStripComboBox();
			this.singleButton_Cancel = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.twoSelector_PrePostProcess = new global::ViPER4WindowsBin.UIControls.TwoSelector();
			this.hSlider_EnvRealizeDrySignal = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.onOffSwitch_EnvRealize = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.singleButton_ResetConfig = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.singleButton_OK = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.buttonBox_AudioSystemConfig = new global::ViPER4WindowsBin.UIControls.ButtonBox();
			this.groupBox_VirtApplied.SuspendLayout();
			this.groupBox_VirtEnv.SuspendLayout();
			this.contextMenuStrip_SpeakerAngle.SuspendLayout();
			base.SuspendLayout();
			this.label_AudioSystemConfig.AutoSize = true;
			this.label_AudioSystemConfig.Location = new global::System.Drawing.Point(12, 17);
			this.label_AudioSystemConfig.Name = "label_AudioSystemConfig";
			this.label_AudioSystemConfig.Size = new global::System.Drawing.Size(125, 12);
			this.label_AudioSystemConfig.TabIndex = 0;
			this.label_AudioSystemConfig.Text = "$AUDIO_SYSTEM_CONFIG";
			this.groupBox_VirtApplied.Controls.Add(this.checkBox_Freestyle);
			this.groupBox_VirtApplied.Controls.Add(this.checkBox_MovieMode);
			this.groupBox_VirtApplied.Controls.Add(this.checkBox_MusicMode);
			this.groupBox_VirtApplied.Location = new global::System.Drawing.Point(151, 292);
			this.groupBox_VirtApplied.Name = "groupBox_VirtApplied";
			this.groupBox_VirtApplied.Size = new global::System.Drawing.Size(167, 88);
			this.groupBox_VirtApplied.TabIndex = 2;
			this.groupBox_VirtApplied.TabStop = false;
			this.groupBox_VirtApplied.Text = "$VIRT_APPLIED";
			this.checkBox_Freestyle.AutoSize = true;
			this.checkBox_Freestyle.Location = new global::System.Drawing.Point(16, 64);
			this.checkBox_Freestyle.Name = "checkBox_Freestyle";
			this.checkBox_Freestyle.Size = new global::System.Drawing.Size(114, 16);
			this.checkBox_Freestyle.TabIndex = 5;
			this.checkBox_Freestyle.Text = "$FREESTYLE_MODE";
			this.checkBox_Freestyle.UseVisualStyleBackColor = true;
			this.checkBox_MovieMode.AutoSize = true;
			this.checkBox_MovieMode.Location = new global::System.Drawing.Point(16, 42);
			this.checkBox_MovieMode.Name = "checkBox_MovieMode";
			this.checkBox_MovieMode.Size = new global::System.Drawing.Size(90, 16);
			this.checkBox_MovieMode.TabIndex = 4;
			this.checkBox_MovieMode.Text = "$MOVIE_MODE";
			this.checkBox_MovieMode.UseVisualStyleBackColor = true;
			this.checkBox_MusicMode.AutoSize = true;
			this.checkBox_MusicMode.Location = new global::System.Drawing.Point(16, 20);
			this.checkBox_MusicMode.Name = "checkBox_MusicMode";
			this.checkBox_MusicMode.Size = new global::System.Drawing.Size(90, 16);
			this.checkBox_MusicMode.TabIndex = 3;
			this.checkBox_MusicMode.Text = "$MUSIC_MODE";
			this.checkBox_MusicMode.UseVisualStyleBackColor = true;
			this.listView_Speaker.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_Speaker,
				this.columnHeader_Angle
			});
			this.listView_Speaker.FullRowSelect = true;
			this.listView_Speaker.GridLines = true;
			this.listView_Speaker.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView_Speaker.HideSelection = false;
			this.listView_Speaker.Location = new global::System.Drawing.Point(151, 71);
			this.listView_Speaker.MultiSelect = false;
			this.listView_Speaker.Name = "listView_Speaker";
			this.listView_Speaker.Size = new global::System.Drawing.Size(167, 215);
			this.listView_Speaker.TabIndex = 3;
			this.listView_Speaker.UseCompatibleStateImageBehavior = false;
			this.listView_Speaker.View = global::System.Windows.Forms.View.Details;
			this.listView_Speaker.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView_Speaker_MouseUp);
			this.columnHeader_Speaker.Text = "$VIRT_SPEAKER";
			this.columnHeader_Speaker.Width = 95;
			this.columnHeader_Angle.Text = "$VIRT_SPEAKER_ANGLE";
			this.groupBox_VirtEnv.Controls.Add(this.twoSelector_PrePostProcess);
			this.groupBox_VirtEnv.Controls.Add(this.label_PrePostProcess);
			this.groupBox_VirtEnv.Controls.Add(this.hSlider_EnvRealizeDrySignal);
			this.groupBox_VirtEnv.Controls.Add(this.comboBox_EnvRealizePreset);
			this.groupBox_VirtEnv.Controls.Add(this.onOffSwitch_EnvRealize);
			this.groupBox_VirtEnv.Location = new global::System.Drawing.Point(324, 36);
			this.groupBox_VirtEnv.Name = "groupBox_VirtEnv";
			this.groupBox_VirtEnv.Size = new global::System.Drawing.Size(222, 106);
			this.groupBox_VirtEnv.TabIndex = 5;
			this.groupBox_VirtEnv.TabStop = false;
			this.groupBox_VirtEnv.Text = "$VIRTUAL_ENVIRONMENT";
			this.label_PrePostProcess.AutoSize = true;
			this.label_PrePostProcess.Location = new global::System.Drawing.Point(6, 79);
			this.label_PrePostProcess.Name = "label_PrePostProcess";
			this.label_PrePostProcess.Size = new global::System.Drawing.Size(107, 12);
			this.label_PrePostProcess.TabIndex = 3;
			this.label_PrePostProcess.Text = "$PRE_POST_PROCESS";
			this.comboBox_EnvRealizePreset.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_EnvRealizePreset.FormattingEnabled = true;
			this.comboBox_EnvRealizePreset.Location = new global::System.Drawing.Point(6, 20);
			this.comboBox_EnvRealizePreset.Name = "comboBox_EnvRealizePreset";
			this.comboBox_EnvRealizePreset.Size = new global::System.Drawing.Size(210, 20);
			this.comboBox_EnvRealizePreset.TabIndex = 1;
			this.contextMenuStrip_SpeakerAngle.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_SpeakerAngle,
				this.toolStripSeparator_Angle,
				this.toolStripComboBox_SpeakerAngle
			});
			this.contextMenuStrip_SpeakerAngle.Name = "contextMenuStrip_SpeakerAngle";
			this.contextMenuStrip_SpeakerAngle.Size = new global::System.Drawing.Size(182, 61);
			this.contextMenuStrip_SpeakerAngle.Closed += new global::System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip_SpeakerAngle_Closed);
			this.toolStripMenuItem_SpeakerAngle.Enabled = false;
			this.toolStripMenuItem_SpeakerAngle.Name = "toolStripMenuItem_SpeakerAngle";
			this.toolStripMenuItem_SpeakerAngle.Size = new global::System.Drawing.Size(181, 22);
			this.toolStripMenuItem_SpeakerAngle.Text = "$SPEAKER_ANGLE";
			this.toolStripSeparator_Angle.Name = "toolStripSeparator_Angle";
			this.toolStripSeparator_Angle.Size = new global::System.Drawing.Size(178, 6);
			this.toolStripComboBox_SpeakerAngle.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox_SpeakerAngle.Name = "toolStripComboBox_SpeakerAngle";
			this.toolStripComboBox_SpeakerAngle.Size = new global::System.Drawing.Size(121, 25);
			this.toolStripComboBox_SpeakerAngle.SelectedIndexChanged += new global::System.EventHandler(this.toolStripComboBox_SpeakerAngle_SelectedIndexChanged);
			this.singleButton_Cancel.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Cancel.ButtonText = "$CANCEL";
			this.singleButton_Cancel.Location = new global::System.Drawing.Point(446, 347);
			this.singleButton_Cancel.Name = "singleButton_Cancel";
			this.singleButton_Cancel.Size = new global::System.Drawing.Size(100, 33);
			this.singleButton_Cancel.TabIndex = 8;
			this.singleButton_Cancel.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Cancel_ButtonClickNotify);
			this.twoSelector_PrePostProcess.BackColor = global::System.Drawing.Color.Transparent;
			this.twoSelector_PrePostProcess.CurrentObject = null;
			this.twoSelector_PrePostProcess.LeftObject = null;
			this.twoSelector_PrePostProcess.Location = new global::System.Drawing.Point(146, 74);
			this.twoSelector_PrePostProcess.Name = "twoSelector_PrePostProcess";
			this.twoSelector_PrePostProcess.RightObject = null;
			this.twoSelector_PrePostProcess.Selector = global::ViPER4WindowsBin.UIControls.TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
			this.twoSelector_PrePostProcess.Size = new global::System.Drawing.Size(70, 22);
			this.twoSelector_PrePostProcess.TabIndex = 9;
			this.hSlider_EnvRealizeDrySignal.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_EnvRealizeDrySignal.Location = new global::System.Drawing.Point(68, 48);
			this.hSlider_EnvRealizeDrySignal.MoveDelta = 1u;
			this.hSlider_EnvRealizeDrySignal.Name = "hSlider_EnvRealizeDrySignal";
			this.hSlider_EnvRealizeDrySignal.Position = 0u;
			this.hSlider_EnvRealizeDrySignal.PositionFloat = 0f;
			this.hSlider_EnvRealizeDrySignal.Size = new global::System.Drawing.Size(148, 20);
			this.hSlider_EnvRealizeDrySignal.TabIndex = 2;
			this.onOffSwitch_EnvRealize.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_EnvRealize.Location = new global::System.Drawing.Point(6, 46);
			this.onOffSwitch_EnvRealize.Name = "onOffSwitch_EnvRealize";
			this.onOffSwitch_EnvRealize.Size = new global::System.Drawing.Size(53, 22);
			this.onOffSwitch_EnvRealize.SwitchedOn = false;
			this.onOffSwitch_EnvRealize.TabIndex = 0;
			this.singleButton_ResetConfig.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_ResetConfig.ButtonText = "$VIRT_RESET";
			this.singleButton_ResetConfig.Location = new global::System.Drawing.Point(151, 36);
			this.singleButton_ResetConfig.Name = "singleButton_ResetConfig";
			this.singleButton_ResetConfig.Size = new global::System.Drawing.Size(167, 26);
			this.singleButton_ResetConfig.TabIndex = 4;
			this.singleButton_ResetConfig.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_ResetConfig_ButtonClickNotify);
			this.singleButton_OK.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_OK.ButtonText = "$OK";
			this.singleButton_OK.Location = new global::System.Drawing.Point(324, 347);
			this.singleButton_OK.Name = "singleButton_OK";
			this.singleButton_OK.Size = new global::System.Drawing.Size(100, 33);
			this.singleButton_OK.TabIndex = 6;
			this.singleButton_OK.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_OK_ButtonClickNotify);
			this.buttonBox_AudioSystemConfig.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonBox_AudioSystemConfig.Location = new global::System.Drawing.Point(14, 36);
			this.buttonBox_AudioSystemConfig.Name = "buttonBox_AudioSystemConfig";
			this.buttonBox_AudioSystemConfig.Size = new global::System.Drawing.Size(131, 344);
			this.buttonBox_AudioSystemConfig.TabIndex = 1;
			this.buttonBox_AudioSystemConfig.ItemSelectedNotify += new global::ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.buttonBox_AudioSystemConfig_ItemSelectedNotify);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(562, 394);
			base.Controls.Add(this.singleButton_Cancel);
			base.Controls.Add(this.groupBox_VirtEnv);
			base.Controls.Add(this.singleButton_ResetConfig);
			base.Controls.Add(this.singleButton_OK);
			base.Controls.Add(this.listView_Speaker);
			base.Controls.Add(this.groupBox_VirtApplied);
			base.Controls.Add(this.buttonBox_AudioSystemConfig);
			base.Controls.Add(this.label_AudioSystemConfig);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmVirtualization";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$VIRTUALIZATION";
			this.groupBox_VirtApplied.ResumeLayout(false);
			this.groupBox_VirtApplied.PerformLayout();
			this.groupBox_VirtEnv.ResumeLayout(false);
			this.groupBox_VirtEnv.PerformLayout();
			this.contextMenuStrip_SpeakerAngle.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.Label label_AudioSystemConfig;

		// Token: 0x04000175 RID: 373
		private global::ViPER4WindowsBin.UIControls.ButtonBox buttonBox_AudioSystemConfig;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.GroupBox groupBox_VirtApplied;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.CheckBox checkBox_MusicMode;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.CheckBox checkBox_Freestyle;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.CheckBox checkBox_MovieMode;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.ListView listView_Speaker;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.ColumnHeader columnHeader_Speaker;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.ColumnHeader columnHeader_Angle;

		// Token: 0x0400017D RID: 381
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_ResetConfig;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.GroupBox groupBox_VirtEnv;

		// Token: 0x0400017F RID: 383
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_EnvRealize;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.ComboBox comboBox_EnvRealizePreset;

		// Token: 0x04000181 RID: 385
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_EnvRealizeDrySignal;

		// Token: 0x04000182 RID: 386
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_OK;

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
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Cancel;

		// Token: 0x04000189 RID: 393
		private global::ViPER4WindowsBin.UIControls.TwoSelector twoSelector_PrePostProcess;
	}
}
