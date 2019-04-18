namespace ViPER4WindowsBin
{
	// Token: 0x02000032 RID: 50
	public partial class frmCompressor : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000223 RID: 547 RVA: 0x0001C6CE File Offset: 0x0001A8CE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmCompressor));
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
			this.label_NoClip = new global::System.Windows.Forms.Label();
			this.onOffSwitch_NoClip = new global::ViPER4WindowsBin.UIControls.OnOffSwitch();
			this.groupBox_Misc = new global::System.Windows.Forms.GroupBox();
			this.label_Adapt = new global::System.Windows.Forms.Label();
			this.label_AdaptValue = new global::System.Windows.Forms.Label();
			this.hSlider_Adapt = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.label_Crest = new global::System.Windows.Forms.Label();
			this.label_CrestValue = new global::System.Windows.Forms.Label();
			this.hSlider_Crest = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.label_KneeMult = new global::System.Windows.Forms.Label();
			this.label_KneeMultValue = new global::System.Windows.Forms.Label();
			this.hSlider_KneeMult = new global::ViPER4WindowsBin.UIControls.HSlider();
			this.groupBox_Threshold.SuspendLayout();
			this.groupBox_Knee.SuspendLayout();
			this.groupBox_Ratio.SuspendLayout();
			this.groupBox_Release.SuspendLayout();
			this.groupBox_Attack.SuspendLayout();
			this.groupBox_MakeUpGain.SuspendLayout();
			this.groupBox_Misc.SuspendLayout();
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
			this.groupBox_Threshold.Size = new global::System.Drawing.Size(548, 61);
			this.groupBox_Threshold.TabIndex = 4;
			this.groupBox_Threshold.TabStop = false;
			this.groupBox_Threshold.Text = "$COMPRESSOR_THRESHOLD";
			this.label_Threshold.AutoSize = true;
			this.label_Threshold.Location = new global::System.Drawing.Point(475, 29);
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
			this.hSlider_Threshold.Size = new global::System.Drawing.Size(463, 29);
			this.hSlider_Threshold.TabIndex = 5;
			this.hSlider_Threshold.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Threshold_PositionChangeNotify);
			this.groupBox_Knee.Controls.Add(this.onOffSwitch_AutoKnee);
			this.groupBox_Knee.Controls.Add(this.label_AutoKnee);
			this.groupBox_Knee.Controls.Add(this.label_Knee);
			this.groupBox_Knee.Controls.Add(this.hSlider_Knee);
			this.groupBox_Knee.Location = new global::System.Drawing.Point(12, 140);
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
			this.groupBox_Ratio.Location = new global::System.Drawing.Point(289, 140);
			this.groupBox_Ratio.Name = "groupBox_Ratio";
			this.groupBox_Ratio.Size = new global::System.Drawing.Size(271, 115);
			this.groupBox_Ratio.TabIndex = 6;
			this.groupBox_Ratio.TabStop = false;
			this.groupBox_Ratio.Text = "$COMPRESSOR_RATIO";
			this.label_Ratio.AutoSize = true;
			this.label_Ratio.Location = new global::System.Drawing.Point(198, 54);
			this.label_Ratio.Name = "label_Ratio";
			this.label_Ratio.Size = new global::System.Drawing.Size(41, 12);
			this.label_Ratio.TabIndex = 5;
			this.label_Ratio.Text = "1.00:1";
			this.hSlider_Ratio.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Ratio.Location = new global::System.Drawing.Point(7, 45);
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
			this.groupBox_Release.Location = new global::System.Drawing.Point(289, 261);
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
			this.groupBox_Attack.Location = new global::System.Drawing.Point(12, 261);
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
			this.groupBox_MakeUpGain.Location = new global::System.Drawing.Point(12, 516);
			this.groupBox_MakeUpGain.Name = "groupBox_MakeUpGain";
			this.groupBox_MakeUpGain.Size = new global::System.Drawing.Size(548, 110);
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
			this.label_Gain.Location = new global::System.Drawing.Point(475, 79);
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
			this.hSlider_Gain.Size = new global::System.Drawing.Size(462, 29);
			this.hSlider_Gain.TabIndex = 5;
			this.hSlider_Gain.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Gain_PositionChangeNotify);
			this.label_NoClip.AutoSize = true;
			this.label_NoClip.Location = new global::System.Drawing.Point(163, 14);
			this.label_NoClip.Name = "label_NoClip";
			this.label_NoClip.Size = new global::System.Drawing.Size(113, 12);
			this.label_NoClip.TabIndex = 12;
			this.label_NoClip.Text = "$COMPRESSOR_NOCLIP";
			this.onOffSwitch_NoClip.BackColor = global::System.Drawing.Color.Transparent;
			this.onOffSwitch_NoClip.Location = new global::System.Drawing.Point(165, 29);
			this.onOffSwitch_NoClip.Name = "onOffSwitch_NoClip";
			this.onOffSwitch_NoClip.Size = new global::System.Drawing.Size(107, 28);
			this.onOffSwitch_NoClip.SwitchedOn = false;
			this.onOffSwitch_NoClip.TabIndex = 13;
			this.onOffSwitch_NoClip.SwitchChangeNotify += new global::ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.onOffSwitch_NoClip_SwitchChangeNotify);
			this.groupBox_Misc.Controls.Add(this.label_Adapt);
			this.groupBox_Misc.Controls.Add(this.label_AdaptValue);
			this.groupBox_Misc.Controls.Add(this.hSlider_Adapt);
			this.groupBox_Misc.Controls.Add(this.label_Crest);
			this.groupBox_Misc.Controls.Add(this.label_CrestValue);
			this.groupBox_Misc.Controls.Add(this.hSlider_Crest);
			this.groupBox_Misc.Controls.Add(this.label_KneeMult);
			this.groupBox_Misc.Controls.Add(this.label_KneeMultValue);
			this.groupBox_Misc.Controls.Add(this.hSlider_KneeMult);
			this.groupBox_Misc.Location = new global::System.Drawing.Point(12, 382);
			this.groupBox_Misc.Name = "groupBox_Misc";
			this.groupBox_Misc.Size = new global::System.Drawing.Size(548, 128);
			this.groupBox_Misc.TabIndex = 14;
			this.groupBox_Misc.TabStop = false;
			this.groupBox_Misc.Text = "$COMPRESSOR_MISC";
			this.label_Adapt.AutoSize = true;
			this.label_Adapt.Location = new global::System.Drawing.Point(297, 76);
			this.label_Adapt.Name = "label_Adapt";
			this.label_Adapt.Size = new global::System.Drawing.Size(131, 12);
			this.label_Adapt.TabIndex = 12;
			this.label_Adapt.Text = "$COMPRESSOR_ADAPTTIME";
			this.label_AdaptValue.AutoSize = true;
			this.label_AdaptValue.Location = new global::System.Drawing.Point(475, 100);
			this.label_AdaptValue.Name = "label_AdaptValue";
			this.label_AdaptValue.Size = new global::System.Drawing.Size(41, 12);
			this.label_AdaptValue.TabIndex = 11;
			this.label_AdaptValue.Text = "0.00ms";
			this.hSlider_Adapt.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Adapt.Location = new global::System.Drawing.Point(284, 91);
			this.hSlider_Adapt.MoveDelta = 1u;
			this.hSlider_Adapt.Name = "hSlider_Adapt";
			this.hSlider_Adapt.Position = 0u;
			this.hSlider_Adapt.PositionFloat = 0f;
			this.hSlider_Adapt.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_Adapt.TabIndex = 10;
			this.hSlider_Adapt.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Adapt_PositionChangeNotify);
			this.label_Crest.AutoSize = true;
			this.label_Crest.Location = new global::System.Drawing.Point(297, 20);
			this.label_Crest.Name = "label_Crest";
			this.label_Crest.Size = new global::System.Drawing.Size(131, 12);
			this.label_Crest.TabIndex = 9;
			this.label_Crest.Text = "$COMPRESSOR_CRESTTIME";
			this.label_CrestValue.AutoSize = true;
			this.label_CrestValue.Location = new global::System.Drawing.Point(475, 44);
			this.label_CrestValue.Name = "label_CrestValue";
			this.label_CrestValue.Size = new global::System.Drawing.Size(41, 12);
			this.label_CrestValue.TabIndex = 8;
			this.label_CrestValue.Text = "0.00ms";
			this.hSlider_Crest.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_Crest.Location = new global::System.Drawing.Point(284, 35);
			this.hSlider_Crest.MoveDelta = 1u;
			this.hSlider_Crest.Name = "hSlider_Crest";
			this.hSlider_Crest.Position = 0u;
			this.hSlider_Crest.PositionFloat = 0f;
			this.hSlider_Crest.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_Crest.TabIndex = 7;
			this.hSlider_Crest.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_Crest_PositionChangeNotify);
			this.label_KneeMult.AutoSize = true;
			this.label_KneeMult.Location = new global::System.Drawing.Point(20, 43);
			this.label_KneeMult.Name = "label_KneeMult";
			this.label_KneeMult.Size = new global::System.Drawing.Size(125, 12);
			this.label_KneeMult.TabIndex = 6;
			this.label_KneeMult.Text = "$COMPRESSOR_KNEEMULT";
			this.label_KneeMultValue.AutoSize = true;
			this.label_KneeMultValue.Location = new global::System.Drawing.Point(198, 67);
			this.label_KneeMultValue.Name = "label_KneeMultValue";
			this.label_KneeMultValue.Size = new global::System.Drawing.Size(35, 12);
			this.label_KneeMultValue.TabIndex = 5;
			this.label_KneeMultValue.Text = "2.00x";
			this.hSlider_KneeMult.BackColor = global::System.Drawing.SystemColors.Control;
			this.hSlider_KneeMult.Location = new global::System.Drawing.Point(7, 58);
			this.hSlider_KneeMult.MoveDelta = 1u;
			this.hSlider_KneeMult.Name = "hSlider_KneeMult";
			this.hSlider_KneeMult.Position = 0u;
			this.hSlider_KneeMult.PositionFloat = 0f;
			this.hSlider_KneeMult.Size = new global::System.Drawing.Size(185, 31);
			this.hSlider_KneeMult.TabIndex = 5;
			this.hSlider_KneeMult.PositionChangeNotify += new global::ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.hSlider_KneeMult_PositionChangeNotify);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(574, 637);
			base.Controls.Add(this.groupBox_Misc);
			base.Controls.Add(this.onOffSwitch_NoClip);
			base.Controls.Add(this.label_NoClip);
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
			base.Name = "frmCompressor";
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
			this.groupBox_Misc.ResumeLayout(false);
			this.groupBox_Misc.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400027D RID: 637
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400027E RID: 638
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_Compressor;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.Label label_Compressor_Enable;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Forms.GroupBox groupBox_Threshold;

		// Token: 0x04000281 RID: 641
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Threshold;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Label label_Threshold;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.GroupBox groupBox_Knee;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.Label label_Knee;

		// Token: 0x04000285 RID: 645
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Knee;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.Label label_AutoKnee;

		// Token: 0x04000287 RID: 647
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoKnee;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.GroupBox groupBox_Ratio;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.Label label_Ratio;

		// Token: 0x0400028A RID: 650
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Ratio;

		// Token: 0x0400028B RID: 651
		private global::System.Windows.Forms.GroupBox groupBox_Release;

		// Token: 0x0400028C RID: 652
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoRelease;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.Label label_AutoRelease;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.Label label_Release;

		// Token: 0x0400028F RID: 655
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Release;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.GroupBox groupBox_Attack;

		// Token: 0x04000291 RID: 657
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoAttack;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.Label label_AutoAttack;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.Label label_Attack;

		// Token: 0x04000294 RID: 660
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Attack;

		// Token: 0x04000295 RID: 661
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Cancel;

		// Token: 0x04000296 RID: 662
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_OK;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.GroupBox groupBox_MakeUpGain;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.Label label_Gain;

		// Token: 0x04000299 RID: 665
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Gain;

		// Token: 0x0400029A RID: 666
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_AutoGain;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.Label label_AutoGain;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.Label label_NoClip;

		// Token: 0x0400029D RID: 669
		private global::ViPER4WindowsBin.UIControls.OnOffSwitch onOffSwitch_NoClip;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.GroupBox groupBox_Misc;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.Label label_KneeMult;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.Label label_KneeMultValue;

		// Token: 0x040002A1 RID: 673
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_KneeMult;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.Label label_Adapt;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.Label label_AdaptValue;

		// Token: 0x040002A4 RID: 676
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Adapt;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Forms.Label label_Crest;

		// Token: 0x040002A6 RID: 678
		private global::System.Windows.Forms.Label label_CrestValue;

		// Token: 0x040002A7 RID: 679
		private global::ViPER4WindowsBin.UIControls.HSlider hSlider_Crest;
	}
}
