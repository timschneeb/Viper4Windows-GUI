namespace ViPER4WindowsBin
{
	// Token: 0x0200000A RID: 10
	public partial class frmCompressorLite : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x0600004C RID: 76 RVA: 0x000059F6 File Offset: 0x00003BF6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005A18 File Offset: 0x00003C18
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmCompressorLite));
			this.onOffSwitch_Compressor = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.label_Compressor_Enable = new global::System.Windows.Forms.Label();
			this.groupBox_Threshold = new global::System.Windows.Forms.GroupBox();
			this.label_Threshold = new global::System.Windows.Forms.Label();
			this.hSlider_Threshold = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.groupBox_Knee = new global::System.Windows.Forms.GroupBox();
			this.onOffSwitch_AutoKnee = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.label_AutoKnee = new global::System.Windows.Forms.Label();
			this.label_Knee = new global::System.Windows.Forms.Label();
			this.hSlider_Knee = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.groupBox_Ratio = new global::System.Windows.Forms.GroupBox();
			this.label_Ratio = new global::System.Windows.Forms.Label();
			this.hSlider_Ratio = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.groupBox_Release = new global::System.Windows.Forms.GroupBox();
			this.onOffSwitch_AutoRelease = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.label_AutoRelease = new global::System.Windows.Forms.Label();
			this.label_Release = new global::System.Windows.Forms.Label();
			this.hSlider_Release = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.groupBox_Attack = new global::System.Windows.Forms.GroupBox();
			this.onOffSwitch_AutoAttack = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.label_AutoAttack = new global::System.Windows.Forms.Label();
			this.label_Attack = new global::System.Windows.Forms.Label();
			this.hSlider_Attack = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.singleButton_Cancel = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.singleButton_OK = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.groupBox_MakeUpGain = new global::System.Windows.Forms.GroupBox();
			this.onOffSwitch_AutoGain = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.label_AutoGain = new global::System.Windows.Forms.Label();
			this.label_Gain = new global::System.Windows.Forms.Label();
			this.hSlider_Gain = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.groupBox_Threshold.SuspendLayout();
			this.groupBox_Knee.SuspendLayout();
			this.groupBox_Ratio.SuspendLayout();
			this.groupBox_Release.SuspendLayout();
			this.groupBox_Attack.SuspendLayout();
			this.groupBox_MakeUpGain.SuspendLayout();
			base.SuspendLayout();
			this.onOffSwitch_Compressor.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_Compressor.Location = new global::System.Drawing.Point(12, 29);
			this.onOffSwitch_Compressor.Name = "onOffSwitch_Compressor";
			this.onOffSwitch_Compressor.Size = new global::System.Drawing.Size(107, 28);
			this.onOffSwitch_Compressor.SwitchedOn = false;
			this.onOffSwitch_Compressor.TabIndex = 3;
			this.onOffSwitch_Compressor.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_Compressor_SwitchChangeNotify);
			this.label_Compressor_Enable.AutoSize = true;
			this.label_Compressor_Enable.Location = new global::System.Drawing.Point(12, 14);
			this.label_Compressor_Enable.Name = "label_Compressor_Enable";
			this.label_Compressor_Enable.Size = new global::System.Drawing.Size(47, 12);
			this.label_Compressor_Enable.TabIndex = 2;
			this.label_Compressor_Enable.Text = "$ENABLE";
			this.groupBox_Threshold.Controls.Add(this.label_Threshold);
			this.groupBox_Threshold.Controls.Add(this.hSlider_Threshold);
			this.groupBox_Threshold.Location = new global::System.Drawing.Point(12, 73);
			this.groupBox_Threshold.Name = "groupBox_Threshold";
			this.groupBox_Threshold.Size = new global::System.Drawing.Size(548, 82);
			this.groupBox_Threshold.TabIndex = 4;
			this.groupBox_Threshold.TabStop = false;
			this.groupBox_Threshold.Text = "$COMPRESSOR_THRESHOLD";
			this.label_Threshold.AutoSize = true;
			this.label_Threshold.Location = new global::System.Drawing.Point(475, 37);
			this.label_Threshold.Name = "label_Threshold";
			this.label_Threshold.Size = new global::System.Drawing.Size(23, 12);
			this.label_Threshold.TabIndex = 5;
			this.label_Threshold.Text = "0dB";
			this.hSlider_Threshold.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Threshold.Location = new global::System.Drawing.Point(6, 20);
			this.hSlider_Threshold.MoveDelta = 1u;
			this.hSlider_Threshold.Name = "hSlider_Threshold";
			this.hSlider_Threshold.Position = 0u;
			this.hSlider_Threshold.PositionFloat = 0f;
			this.hSlider_Threshold.Size = new global::System.Drawing.Size(463, 47);
			this.hSlider_Threshold.TabIndex = 5;
			this.hSlider_Threshold.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Threshold_PositionChangeNotify);
			this.groupBox_Knee.Controls.Add(this.onOffSwitch_AutoKnee);
			this.groupBox_Knee.Controls.Add(this.label_AutoKnee);
			this.groupBox_Knee.Controls.Add(this.label_Knee);
			this.groupBox_Knee.Controls.Add(this.hSlider_Knee);
			this.groupBox_Knee.Location = new global::System.Drawing.Point(12, 173);
			this.groupBox_Knee.Name = "groupBox_Knee";
			this.groupBox_Knee.Size = new global::System.Drawing.Size(271, 115);
			this.groupBox_Knee.TabIndex = 5;
			this.groupBox_Knee.TabStop = false;
			this.groupBox_Knee.Text = "$COMPRESSOR_KNEEWIDTH";
			this.onOffSwitch_AutoKnee.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_AutoKnee.Location = new global::System.Drawing.Point(22, 41);
			this.onOffSwitch_AutoKnee.Name = "onOffSwitch_AutoKnee";
			this.onOffSwitch_AutoKnee.Size = new global::System.Drawing.Size(49, 22);
			this.onOffSwitch_AutoKnee.SwitchedOn = false;
			this.onOffSwitch_AutoKnee.TabIndex = 6;
			this.onOffSwitch_AutoKnee.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoKnee_SwitchChangeNotify);
			this.label_AutoKnee.AutoSize = true;
			this.label_AutoKnee.Location = new global::System.Drawing.Point(20, 26);
			this.label_AutoKnee.Name = "label_AutoKnee";
			this.label_AutoKnee.Size = new global::System.Drawing.Size(125, 12);
			this.label_AutoKnee.TabIndex = 6;
			this.label_AutoKnee.Text = "$COMPRESSOR_AUTOKNEE";
			this.label_Knee.AutoSize = true;
			this.label_Knee.Location = new global::System.Drawing.Point(198, 81);
			this.label_Knee.Name = "label_Knee";
			this.label_Knee.Size = new global::System.Drawing.Size(23, 12);
			this.label_Knee.TabIndex = 5;
			this.label_Knee.Text = "0dB";
			this.hSlider_Knee.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Knee.Location = new global::System.Drawing.Point(7, 72);
			this.hSlider_Knee.MoveDelta = 1u;
			this.hSlider_Knee.Name = "hSlider_Knee";
			this.hSlider_Knee.Position = 0u;
			this.hSlider_Knee.PositionFloat = 0f;
			this.hSlider_Knee.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_Knee.TabIndex = 5;
			this.hSlider_Knee.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Knee_PositionChangeNotify);
			this.groupBox_Ratio.Controls.Add(this.label_Ratio);
			this.groupBox_Ratio.Controls.Add(this.hSlider_Ratio);
			this.groupBox_Ratio.Location = new global::System.Drawing.Point(289, 173);
			this.groupBox_Ratio.Name = "groupBox_Ratio";
			this.groupBox_Ratio.Size = new global::System.Drawing.Size(271, 115);
			this.groupBox_Ratio.TabIndex = 6;
			this.groupBox_Ratio.TabStop = false;
			this.groupBox_Ratio.Text = "$COMPRESSOR_RATIO";
			this.label_Ratio.AutoSize = true;
			this.label_Ratio.Location = new global::System.Drawing.Point(198, 52);
			this.label_Ratio.Name = "label_Ratio";
			this.label_Ratio.Size = new global::System.Drawing.Size(41, 12);
			this.label_Ratio.TabIndex = 5;
			this.label_Ratio.Text = "1.00:1";
			this.hSlider_Ratio.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Ratio.Location = new global::System.Drawing.Point(7, 43);
			this.hSlider_Ratio.MoveDelta = 1u;
			this.hSlider_Ratio.Name = "hSlider_Ratio";
			this.hSlider_Ratio.Position = 0u;
			this.hSlider_Ratio.PositionFloat = 0f;
			this.hSlider_Ratio.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_Ratio.TabIndex = 5;
			this.hSlider_Ratio.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Ratio_PositionChangeNotify);
			this.groupBox_Release.Controls.Add(this.onOffSwitch_AutoRelease);
			this.groupBox_Release.Controls.Add(this.label_AutoRelease);
			this.groupBox_Release.Controls.Add(this.label_Release);
			this.groupBox_Release.Controls.Add(this.hSlider_Release);
			this.groupBox_Release.Location = new global::System.Drawing.Point(289, 294);
			this.groupBox_Release.Name = "groupBox_Release";
			this.groupBox_Release.Size = new global::System.Drawing.Size(271, 115);
			this.groupBox_Release.TabIndex = 8;
			this.groupBox_Release.TabStop = false;
			this.groupBox_Release.Text = "$COMPRESSOR_RELEASE";
			this.onOffSwitch_AutoRelease.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_AutoRelease.Location = new global::System.Drawing.Point(22, 41);
			this.onOffSwitch_AutoRelease.Name = "onOffSwitch_AutoRelease";
			this.onOffSwitch_AutoRelease.Size = new global::System.Drawing.Size(49, 22);
			this.onOffSwitch_AutoRelease.SwitchedOn = false;
			this.onOffSwitch_AutoRelease.TabIndex = 6;
			this.onOffSwitch_AutoRelease.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoRelease_SwitchChangeNotify);
			this.label_AutoRelease.AutoSize = true;
			this.label_AutoRelease.Location = new global::System.Drawing.Point(20, 26);
			this.label_AutoRelease.Name = "label_AutoRelease";
			this.label_AutoRelease.Size = new global::System.Drawing.Size(143, 12);
			this.label_AutoRelease.TabIndex = 6;
			this.label_AutoRelease.Text = "$COMPRESSOR_AUTORELEASE";
			this.label_Release.AutoSize = true;
			this.label_Release.Location = new global::System.Drawing.Point(198, 81);
			this.label_Release.Name = "label_Release";
			this.label_Release.Size = new global::System.Drawing.Size(41, 12);
			this.label_Release.TabIndex = 5;
			this.label_Release.Text = "5.00ms";
			this.hSlider_Release.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Release.Location = new global::System.Drawing.Point(7, 72);
			this.hSlider_Release.MoveDelta = 1u;
			this.hSlider_Release.Name = "hSlider_Release";
			this.hSlider_Release.Position = 0u;
			this.hSlider_Release.PositionFloat = 0f;
			this.hSlider_Release.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_Release.TabIndex = 5;
			this.hSlider_Release.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Release_PositionChangeNotify);
			this.groupBox_Attack.Controls.Add(this.onOffSwitch_AutoAttack);
			this.groupBox_Attack.Controls.Add(this.label_AutoAttack);
			this.groupBox_Attack.Controls.Add(this.label_Attack);
			this.groupBox_Attack.Controls.Add(this.hSlider_Attack);
			this.groupBox_Attack.Location = new global::System.Drawing.Point(12, 294);
			this.groupBox_Attack.Name = "groupBox_Attack";
			this.groupBox_Attack.Size = new global::System.Drawing.Size(271, 115);
			this.groupBox_Attack.TabIndex = 7;
			this.groupBox_Attack.TabStop = false;
			this.groupBox_Attack.Text = "$COMPRESSOR_ATTACK";
			this.onOffSwitch_AutoAttack.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_AutoAttack.Location = new global::System.Drawing.Point(22, 41);
			this.onOffSwitch_AutoAttack.Name = "onOffSwitch_AutoAttack";
			this.onOffSwitch_AutoAttack.Size = new global::System.Drawing.Size(49, 22);
			this.onOffSwitch_AutoAttack.SwitchedOn = false;
			this.onOffSwitch_AutoAttack.TabIndex = 6;
			this.onOffSwitch_AutoAttack.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoAttack_SwitchChangeNotify);
			this.label_AutoAttack.AutoSize = true;
			this.label_AutoAttack.Location = new global::System.Drawing.Point(20, 26);
			this.label_AutoAttack.Name = "label_AutoAttack";
			this.label_AutoAttack.Size = new global::System.Drawing.Size(137, 12);
			this.label_AutoAttack.TabIndex = 6;
			this.label_AutoAttack.Text = "$COMPRESSOR_AUTOATTACK";
			this.label_Attack.AutoSize = true;
			this.label_Attack.Location = new global::System.Drawing.Point(198, 81);
			this.label_Attack.Name = "label_Attack";
			this.label_Attack.Size = new global::System.Drawing.Size(41, 12);
			this.label_Attack.TabIndex = 5;
			this.label_Attack.Text = "0.10ms";
			this.hSlider_Attack.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Attack.Location = new global::System.Drawing.Point(7, 72);
			this.hSlider_Attack.MoveDelta = 1u;
			this.hSlider_Attack.Name = "hSlider_Attack";
			this.hSlider_Attack.Position = 0u;
			this.hSlider_Attack.PositionFloat = 0f;
			this.hSlider_Attack.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_Attack.TabIndex = 5;
			this.hSlider_Attack.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Attack_PositionChangeNotify);
			this.singleButton_Cancel.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Cancel.ButtonText = "$CANCEL";
			this.singleButton_Cancel.Location = new global::System.Drawing.Point(448, 20);
			this.singleButton_Cancel.Name = "singleButton_Cancel";
			this.singleButton_Cancel.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_Cancel.TabIndex = 9;
			this.singleButton_Cancel.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Cancel_ButtonClickNotify);
			this.singleButton_OK.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_OK.ButtonText = "$OK";
			this.singleButton_OK.Location = new global::System.Drawing.Point(328, 20);
			this.singleButton_OK.Name = "singleButton_OK";
			this.singleButton_OK.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_OK.TabIndex = 10;
			this.singleButton_OK.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_OK_ButtonClickNotify);
			this.groupBox_MakeUpGain.Controls.Add(this.onOffSwitch_AutoGain);
			this.groupBox_MakeUpGain.Controls.Add(this.label_AutoGain);
			this.groupBox_MakeUpGain.Controls.Add(this.label_Gain);
			this.groupBox_MakeUpGain.Controls.Add(this.hSlider_Gain);
			this.groupBox_MakeUpGain.Location = new global::System.Drawing.Point(12, 415);
			this.groupBox_MakeUpGain.Name = "groupBox_MakeUpGain";
			this.groupBox_MakeUpGain.Size = new global::System.Drawing.Size(548, 121);
			this.groupBox_MakeUpGain.TabIndex = 11;
			this.groupBox_MakeUpGain.TabStop = false;
			this.groupBox_MakeUpGain.Text = "$COMPRESSOR_MAKEUPGAIN";
			this.onOffSwitch_AutoGain.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_AutoGain.Location = new global::System.Drawing.Point(22, 41);
			this.onOffSwitch_AutoGain.Name = "onOffSwitch_AutoGain";
			this.onOffSwitch_AutoGain.Size = new global::System.Drawing.Size(49, 22);
			this.onOffSwitch_AutoGain.SwitchedOn = false;
			this.onOffSwitch_AutoGain.TabIndex = 8;
			this.onOffSwitch_AutoGain.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_AutoGain_SwitchChangeNotify);
			this.label_AutoGain.AutoSize = true;
			this.label_AutoGain.Location = new global::System.Drawing.Point(20, 26);
			this.label_AutoGain.Name = "label_AutoGain";
			this.label_AutoGain.Size = new global::System.Drawing.Size(125, 12);
			this.label_AutoGain.TabIndex = 7;
			this.label_AutoGain.Text = "$COMPRESSOR_AUTOGAIN";
			this.label_Gain.AutoSize = true;
			this.label_Gain.Location = new global::System.Drawing.Point(475, 88);
			this.label_Gain.Name = "label_Gain";
			this.label_Gain.Size = new global::System.Drawing.Size(23, 12);
			this.label_Gain.TabIndex = 5;
			this.label_Gain.Text = "0dB";
			this.hSlider_Gain.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Gain.Location = new global::System.Drawing.Point(7, 71);
			this.hSlider_Gain.MoveDelta = 1u;
			this.hSlider_Gain.Name = "hSlider_Gain";
			this.hSlider_Gain.Position = 0u;
			this.hSlider_Gain.PositionFloat = 0f;
			this.hSlider_Gain.Size = new global::System.Drawing.Size(462, 47);
			this.hSlider_Gain.TabIndex = 5;
			this.hSlider_Gain.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Gain_PositionChangeNotify);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(574, 556);
			base.Controls.Add(this.groupBox_MakeUpGain);
			base.Controls.Add(this.singleButton_OK);
			base.Controls.Add(this.singleButton_Cancel);
			base.Controls.Add(this.groupBox_Release);
			base.Controls.Add(this.groupBox_Attack);
			base.Controls.Add(this.groupBox_Ratio);
			base.Controls.Add(this.groupBox_Knee);
			base.Controls.Add(this.groupBox_Threshold);
			base.Controls.Add(this.onOffSwitch_Compressor);
			base.Controls.Add(this.label_Compressor_Enable);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmCompressorLite";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$COMPRESSOR";
			this.groupBox_Threshold.ResumeLayout(false);
			this.groupBox_Threshold.PerformLayout();
			this.groupBox_Knee.ResumeLayout(false);
			this.groupBox_Knee.PerformLayout();
			this.groupBox_Ratio.ResumeLayout(false);
			this.groupBox_Ratio.PerformLayout();
			this.groupBox_Release.ResumeLayout(false);
			this.groupBox_Release.PerformLayout();
			this.groupBox_Attack.ResumeLayout(false);
			this.groupBox_Attack.PerformLayout();
			this.groupBox_MakeUpGain.ResumeLayout(false);
			this.groupBox_MakeUpGain.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400004B RID: 75
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400004C RID: 76
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_Compressor;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label_Compressor_Enable;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.GroupBox groupBox_Threshold;

		// Token: 0x0400004F RID: 79
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Threshold;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label_Threshold;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.GroupBox groupBox_Knee;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label_Knee;

		// Token: 0x04000053 RID: 83
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Knee;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label_AutoKnee;

		// Token: 0x04000055 RID: 85
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoKnee;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.GroupBox groupBox_Ratio;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label_Ratio;

		// Token: 0x04000058 RID: 88
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Ratio;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.GroupBox groupBox_Release;

		// Token: 0x0400005A RID: 90
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoRelease;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Label label_AutoRelease;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label label_Release;

		// Token: 0x0400005D RID: 93
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Release;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.GroupBox groupBox_Attack;

		// Token: 0x0400005F RID: 95
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoAttack;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label_AutoAttack;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label_Attack;

		// Token: 0x04000062 RID: 98
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Attack;

		// Token: 0x04000063 RID: 99
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Cancel;

		// Token: 0x04000064 RID: 100
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_OK;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.GroupBox groupBox_MakeUpGain;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label label_Gain;

		// Token: 0x04000067 RID: 103
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Gain;

		// Token: 0x04000068 RID: 104
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoGain;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label_AutoGain;
	}
}
