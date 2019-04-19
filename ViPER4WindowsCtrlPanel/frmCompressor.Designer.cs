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
            this.components = new System.ComponentModel.Container();
            this.onOffSwitch_Compressor = new MetroSuite.MetroSwitch();
            this.label_Compressor_Enable = new System.Windows.Forms.Label();
            this.hSlider_Threshold = new MetroSuite.MetroTrackbar();
            this.label_Threshold = new System.Windows.Forms.Label();
            this.groupBox_Knee = new System.Windows.Forms.GroupBox();
            this.hSlider_Knee = new MetroSuite.MetroTrackbar();
            this.onOffSwitch_AutoKnee = new MetroSuite.MetroSwitch();
            this.label_Knee = new System.Windows.Forms.Label();
            this.label_AutoKnee = new System.Windows.Forms.Label();
            this.label_Ratio = new System.Windows.Forms.Label();
            this.hSlider_Ratio = new MetroSuite.MetroTrackbar();
            this.groupBox_Release = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoRelease = new MetroSuite.MetroSwitch();
            this.label_AutoRelease = new System.Windows.Forms.Label();
            this.label_Release = new System.Windows.Forms.Label();
            this.hSlider_Release = new MetroSuite.MetroTrackbar();
            this.groupBox_Attack = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoAttack = new MetroSuite.MetroSwitch();
            this.label_AutoAttack = new System.Windows.Forms.Label();
            this.label_Attack = new System.Windows.Forms.Label();
            this.hSlider_Attack = new MetroSuite.MetroTrackbar();
            this.singleButton_Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_OK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox_MakeUpGain = new System.Windows.Forms.GroupBox();
            this.onOffSwitch_AutoGain = new MetroSuite.MetroSwitch();
            this.label_AutoGain = new System.Windows.Forms.Label();
            this.label_Gain = new System.Windows.Forms.Label();
            this.hSlider_Gain = new MetroSuite.MetroTrackbar();
            this.label_NoClip = new System.Windows.Forms.Label();
            this.onOffSwitch_NoClip = new MetroSuite.MetroSwitch();
            this.groupBox_Misc = new System.Windows.Forms.GroupBox();
            this.label_Adapt = new System.Windows.Forms.Label();
            this.label_AdaptValue = new System.Windows.Forms.Label();
            this.hSlider_Adapt = new MetroSuite.MetroTrackbar();
            this.label_Crest = new System.Windows.Forms.Label();
            this.label_CrestValue = new System.Windows.Forms.Label();
            this.hSlider_Crest = new MetroSuite.MetroTrackbar();
            this.label_KneeMult = new System.Windows.Forms.Label();
            this.label_KneeMultValue = new System.Windows.Forms.Label();
            this.hSlider_KneeMult = new MetroSuite.MetroTrackbar();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.groupBox_Threshold = new System.Windows.Forms.Label();
            this.groupBox_Ratio = new System.Windows.Forms.Label();
            this.groupBox_Knee.SuspendLayout();
            this.groupBox_Release.SuspendLayout();
            this.groupBox_Attack.SuspendLayout();
            this.groupBox_MakeUpGain.SuspendLayout();
            this.groupBox_Misc.SuspendLayout();
            this.SuspendLayout();
            // 
            // onOffSwitch_Compressor
            // 
            this.onOffSwitch_Compressor.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_Compressor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_Compressor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_Compressor.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_Compressor.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_Compressor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_Compressor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_Compressor.Location = new System.Drawing.Point(70, 19);
            this.onOffSwitch_Compressor.Name = "onOffSwitch_Compressor";
            this.onOffSwitch_Compressor.Size = new System.Drawing.Size(41, 22);
            this.onOffSwitch_Compressor.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_Compressor.TabIndex = 3;
            this.onOffSwitch_Compressor.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_Compressor_CheckedChanged);
            // 
            // label_Compressor_Enable
            // 
            this.label_Compressor_Enable.AutoSize = true;
            this.label_Compressor_Enable.Location = new System.Drawing.Point(9, 22);
            this.label_Compressor_Enable.Name = "label_Compressor_Enable";
            this.label_Compressor_Enable.Size = new System.Drawing.Size(55, 13);
            this.label_Compressor_Enable.TabIndex = 2;
            this.label_Compressor_Enable.Text = "$ENABLE";
            // 
            // hSlider_Threshold
            // 
            this.hSlider_Threshold.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Threshold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Threshold.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Threshold.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Threshold.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Threshold.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Threshold.Location = new System.Drawing.Point(95, 52);
            this.hSlider_Threshold.Name = "hSlider_Threshold";
            this.hSlider_Threshold.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Threshold.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Threshold.SecondValue = 0;
            this.hSlider_Threshold.Size = new System.Drawing.Size(412, 23);
            this.hSlider_Threshold.SliderColor = System.Drawing.Color.White;
            this.hSlider_Threshold.TabIndex = 6;
            this.hSlider_Threshold.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Threshold_Scroll);
            // 
            // label_Threshold
            // 
            this.label_Threshold.Location = new System.Drawing.Point(510, 57);
            this.label_Threshold.Name = "label_Threshold";
            this.label_Threshold.Size = new System.Drawing.Size(50, 13);
            this.label_Threshold.TabIndex = 5;
            this.label_Threshold.Text = "0dB";
            this.label_Threshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_Knee
            // 
            this.groupBox_Knee.Controls.Add(this.hSlider_Knee);
            this.groupBox_Knee.Controls.Add(this.onOffSwitch_AutoKnee);
            this.groupBox_Knee.Controls.Add(this.label_Knee);
            this.groupBox_Knee.Controls.Add(this.label_AutoKnee);
            this.groupBox_Knee.Location = new System.Drawing.Point(12, 112);
            this.groupBox_Knee.Name = "groupBox_Knee";
            this.groupBox_Knee.Size = new System.Drawing.Size(271, 82);
            this.groupBox_Knee.TabIndex = 5;
            this.groupBox_Knee.TabStop = false;
            this.groupBox_Knee.Text = "$COMPRESSOR_KNEEWIDTH";
            // 
            // hSlider_Knee
            // 
            this.hSlider_Knee.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Knee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Knee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Knee.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Knee.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Knee.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Knee.Location = new System.Drawing.Point(7, 50);
            this.hSlider_Knee.Name = "hSlider_Knee";
            this.hSlider_Knee.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Knee.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Knee.Size = new System.Drawing.Size(167, 23);
            this.hSlider_Knee.SliderColor = System.Drawing.Color.White;
            this.hSlider_Knee.TabIndex = 5;
            this.hSlider_Knee.Value = 0;
            this.hSlider_Knee.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Knee_Scroll);
            // 
            // onOffSwitch_AutoKnee
            // 
            this.onOffSwitch_AutoKnee.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoKnee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_AutoKnee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_AutoKnee.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_AutoKnee.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_AutoKnee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_AutoKnee.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_AutoKnee.Location = new System.Drawing.Point(224, 19);
            this.onOffSwitch_AutoKnee.Name = "onOffSwitch_AutoKnee";
            this.onOffSwitch_AutoKnee.Size = new System.Drawing.Size(41, 24);
            this.onOffSwitch_AutoKnee.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_AutoKnee.TabIndex = 6;
            this.onOffSwitch_AutoKnee.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_AutoKnee_CheckedChanged);
            // 
            // label_Knee
            // 
            this.label_Knee.Location = new System.Drawing.Point(182, 50);
            this.label_Knee.Name = "label_Knee";
            this.label_Knee.Size = new System.Drawing.Size(83, 18);
            this.label_Knee.TabIndex = 5;
            this.label_Knee.Text = "0dB";
            this.label_Knee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_AutoKnee
            // 
            this.label_AutoKnee.AutoSize = true;
            this.label_AutoKnee.Location = new System.Drawing.Point(6, 25);
            this.label_AutoKnee.Name = "label_AutoKnee";
            this.label_AutoKnee.Size = new System.Drawing.Size(154, 13);
            this.label_AutoKnee.TabIndex = 6;
            this.label_AutoKnee.Text = "$COMPRESSOR_AUTOKNEE";
            // 
            // label_Ratio
            // 
            this.label_Ratio.Location = new System.Drawing.Point(513, 85);
            this.label_Ratio.Name = "label_Ratio";
            this.label_Ratio.Size = new System.Drawing.Size(47, 13);
            this.label_Ratio.TabIndex = 5;
            this.label_Ratio.Text = "1.00:1";
            this.label_Ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hSlider_Ratio
            // 
            this.hSlider_Ratio.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Ratio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Ratio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Ratio.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Ratio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Ratio.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Ratio.Location = new System.Drawing.Point(95, 81);
            this.hSlider_Ratio.Name = "hSlider_Ratio";
            this.hSlider_Ratio.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Ratio.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Ratio.Size = new System.Drawing.Size(412, 23);
            this.hSlider_Ratio.SliderColor = System.Drawing.Color.White;
            this.hSlider_Ratio.TabIndex = 5;
            this.hSlider_Ratio.Value = 0;
            this.hSlider_Ratio.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Ratio_Scroll);
            // 
            // groupBox_Release
            // 
            this.groupBox_Release.Controls.Add(this.onOffSwitch_AutoRelease);
            this.groupBox_Release.Controls.Add(this.label_AutoRelease);
            this.groupBox_Release.Controls.Add(this.label_Release);
            this.groupBox_Release.Controls.Add(this.hSlider_Release);
            this.groupBox_Release.Location = new System.Drawing.Point(296, 200);
            this.groupBox_Release.Name = "groupBox_Release";
            this.groupBox_Release.Size = new System.Drawing.Size(264, 84);
            this.groupBox_Release.TabIndex = 8;
            this.groupBox_Release.TabStop = false;
            this.groupBox_Release.Text = "$COMPRESSOR_RELEASE";
            // 
            // onOffSwitch_AutoRelease
            // 
            this.onOffSwitch_AutoRelease.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_AutoRelease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_AutoRelease.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_AutoRelease.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_AutoRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_AutoRelease.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_AutoRelease.Location = new System.Drawing.Point(217, 22);
            this.onOffSwitch_AutoRelease.Name = "onOffSwitch_AutoRelease";
            this.onOffSwitch_AutoRelease.Size = new System.Drawing.Size(41, 24);
            this.onOffSwitch_AutoRelease.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_AutoRelease.TabIndex = 6;
            this.onOffSwitch_AutoRelease.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_AutoRelease_CheckedChanged);
            // 
            // label_AutoRelease
            // 
            this.label_AutoRelease.AutoSize = true;
            this.label_AutoRelease.Location = new System.Drawing.Point(6, 25);
            this.label_AutoRelease.Name = "label_AutoRelease";
            this.label_AutoRelease.Size = new System.Drawing.Size(174, 13);
            this.label_AutoRelease.TabIndex = 6;
            this.label_AutoRelease.Text = "$COMPRESSOR_AUTORELEASE";
            // 
            // label_Release
            // 
            this.label_Release.Location = new System.Drawing.Point(197, 52);
            this.label_Release.Name = "label_Release";
            this.label_Release.Size = new System.Drawing.Size(61, 18);
            this.label_Release.TabIndex = 5;
            this.label_Release.Text = "5.00ms";
            this.label_Release.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hSlider_Release
            // 
            this.hSlider_Release.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Release.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Release.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Release.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Release.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Release.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Release.Location = new System.Drawing.Point(9, 51);
            this.hSlider_Release.Maximum = 1000;
            this.hSlider_Release.Name = "hSlider_Release";
            this.hSlider_Release.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Release.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Release.Size = new System.Drawing.Size(171, 23);
            this.hSlider_Release.SliderColor = System.Drawing.Color.White;
            this.hSlider_Release.TabIndex = 5;
            this.hSlider_Release.Value = 0;
            this.hSlider_Release.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Release_Scroll);
            // 
            // groupBox_Attack
            // 
            this.groupBox_Attack.Controls.Add(this.onOffSwitch_AutoAttack);
            this.groupBox_Attack.Controls.Add(this.label_AutoAttack);
            this.groupBox_Attack.Controls.Add(this.label_Attack);
            this.groupBox_Attack.Controls.Add(this.hSlider_Attack);
            this.groupBox_Attack.Location = new System.Drawing.Point(12, 200);
            this.groupBox_Attack.Name = "groupBox_Attack";
            this.groupBox_Attack.Size = new System.Drawing.Size(271, 84);
            this.groupBox_Attack.TabIndex = 7;
            this.groupBox_Attack.TabStop = false;
            this.groupBox_Attack.Text = "$COMPRESSOR_ATTACK";
            // 
            // onOffSwitch_AutoAttack
            // 
            this.onOffSwitch_AutoAttack.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_AutoAttack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_AutoAttack.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_AutoAttack.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_AutoAttack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_AutoAttack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_AutoAttack.Location = new System.Drawing.Point(223, 22);
            this.onOffSwitch_AutoAttack.Name = "onOffSwitch_AutoAttack";
            this.onOffSwitch_AutoAttack.Size = new System.Drawing.Size(42, 24);
            this.onOffSwitch_AutoAttack.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_AutoAttack.TabIndex = 6;
            this.onOffSwitch_AutoAttack.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_AutoAttack_CheckedChanged);
            // 
            // label_AutoAttack
            // 
            this.label_AutoAttack.AutoSize = true;
            this.label_AutoAttack.Location = new System.Drawing.Point(6, 24);
            this.label_AutoAttack.Name = "label_AutoAttack";
            this.label_AutoAttack.Size = new System.Drawing.Size(167, 13);
            this.label_AutoAttack.TabIndex = 6;
            this.label_AutoAttack.Text = "$COMPRESSOR_AUTOATTACK";
            // 
            // label_Attack
            // 
            this.label_Attack.Location = new System.Drawing.Point(182, 55);
            this.label_Attack.Name = "label_Attack";
            this.label_Attack.Size = new System.Drawing.Size(83, 13);
            this.label_Attack.TabIndex = 5;
            this.label_Attack.Text = "0.10ms";
            this.label_Attack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hSlider_Attack
            // 
            this.hSlider_Attack.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Attack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Attack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Attack.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Attack.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Attack.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Attack.Location = new System.Drawing.Point(7, 51);
            this.hSlider_Attack.Maximum = 1000;
            this.hSlider_Attack.Name = "hSlider_Attack";
            this.hSlider_Attack.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Attack.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Attack.Size = new System.Drawing.Size(169, 23);
            this.hSlider_Attack.SliderColor = System.Drawing.Color.White;
            this.hSlider_Attack.TabIndex = 5;
            this.hSlider_Attack.Value = 0;
            this.hSlider_Attack.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Attack_Scroll);
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Cancel.BeforeTouchSize = new System.Drawing.Size(87, 25);
            this.singleButton_Cancel.IsBackStageButton = false;
            this.singleButton_Cancel.Location = new System.Drawing.Point(379, 16);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Cancel.Size = new System.Drawing.Size(87, 25);
            this.singleButton_Cancel.TabIndex = 9;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "Office2016Colorful";
            this.singleButton_Cancel.UseVisualStyle = true;
            this.singleButton_Cancel.Click += new System.EventHandler(this.SingleButton_Cancel_Click);
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_OK.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_OK.BeforeTouchSize = new System.Drawing.Size(87, 25);
            this.singleButton_OK.IsBackStageButton = false;
            this.singleButton_OK.Location = new System.Drawing.Point(473, 16);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_OK.Size = new System.Drawing.Size(87, 25);
            this.singleButton_OK.TabIndex = 10;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "Office2016Colorful";
            this.singleButton_OK.UseVisualStyle = true;
            this.singleButton_OK.Click += new System.EventHandler(this.SingleButton_OK_Click);
            // 
            // groupBox_MakeUpGain
            // 
            this.groupBox_MakeUpGain.Controls.Add(this.onOffSwitch_AutoGain);
            this.groupBox_MakeUpGain.Controls.Add(this.label_AutoGain);
            this.groupBox_MakeUpGain.Controls.Add(this.label_Gain);
            this.groupBox_MakeUpGain.Controls.Add(this.hSlider_Gain);
            this.groupBox_MakeUpGain.Location = new System.Drawing.Point(296, 112);
            this.groupBox_MakeUpGain.Name = "groupBox_MakeUpGain";
            this.groupBox_MakeUpGain.Size = new System.Drawing.Size(264, 82);
            this.groupBox_MakeUpGain.TabIndex = 11;
            this.groupBox_MakeUpGain.TabStop = false;
            this.groupBox_MakeUpGain.Text = "$COMPRESSOR_MAKEUPGAIN";
            this.groupBox_MakeUpGain.Enter += new System.EventHandler(this.GroupBox_MakeUpGain_Enter);
            // 
            // onOffSwitch_AutoGain
            // 
            this.onOffSwitch_AutoGain.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_AutoGain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_AutoGain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_AutoGain.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_AutoGain.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_AutoGain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_AutoGain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_AutoGain.Location = new System.Drawing.Point(216, 19);
            this.onOffSwitch_AutoGain.Name = "onOffSwitch_AutoGain";
            this.onOffSwitch_AutoGain.Size = new System.Drawing.Size(42, 24);
            this.onOffSwitch_AutoGain.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_AutoGain.TabIndex = 8;
            this.onOffSwitch_AutoGain.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_AutoGain_CheckedChanged);
            // 
            // label_AutoGain
            // 
            this.label_AutoGain.AutoSize = true;
            this.label_AutoGain.Location = new System.Drawing.Point(6, 25);
            this.label_AutoGain.Name = "label_AutoGain";
            this.label_AutoGain.Size = new System.Drawing.Size(151, 13);
            this.label_AutoGain.TabIndex = 7;
            this.label_AutoGain.Text = "$COMPRESSOR_AUTOGAIN";
            // 
            // label_Gain
            // 
            this.label_Gain.Location = new System.Drawing.Point(194, 55);
            this.label_Gain.Name = "label_Gain";
            this.label_Gain.Size = new System.Drawing.Size(64, 13);
            this.label_Gain.TabIndex = 5;
            this.label_Gain.Text = "0dB";
            this.label_Gain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hSlider_Gain
            // 
            this.hSlider_Gain.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Gain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Gain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Gain.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Gain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Gain.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Gain.Location = new System.Drawing.Point(9, 50);
            this.hSlider_Gain.Name = "hSlider_Gain";
            this.hSlider_Gain.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Gain.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Gain.Size = new System.Drawing.Size(170, 23);
            this.hSlider_Gain.SliderColor = System.Drawing.Color.White;
            this.hSlider_Gain.TabIndex = 5;
            this.hSlider_Gain.Value = 0;
            this.hSlider_Gain.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Gain_Scroll);
            // 
            // label_NoClip
            // 
            this.label_NoClip.AutoSize = true;
            this.label_NoClip.Location = new System.Drawing.Point(164, 22);
            this.label_NoClip.Name = "label_NoClip";
            this.label_NoClip.Size = new System.Drawing.Size(134, 13);
            this.label_NoClip.TabIndex = 12;
            this.label_NoClip.Text = "$COMPRESSOR_NOCLIP";
            // 
            // onOffSwitch_NoClip
            // 
            this.onOffSwitch_NoClip.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_NoClip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_NoClip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_NoClip.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_NoClip.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_NoClip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_NoClip.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_NoClip.Location = new System.Drawing.Point(257, 19);
            this.onOffSwitch_NoClip.Name = "onOffSwitch_NoClip";
            this.onOffSwitch_NoClip.Size = new System.Drawing.Size(41, 30);
            this.onOffSwitch_NoClip.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_NoClip.TabIndex = 13;
            this.onOffSwitch_NoClip.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_NoClip_CheckedChanged);
            // 
            // groupBox_Misc
            // 
            this.groupBox_Misc.Controls.Add(this.label_Adapt);
            this.groupBox_Misc.Controls.Add(this.label_AdaptValue);
            this.groupBox_Misc.Controls.Add(this.hSlider_Adapt);
            this.groupBox_Misc.Controls.Add(this.label_Crest);
            this.groupBox_Misc.Controls.Add(this.label_CrestValue);
            this.groupBox_Misc.Controls.Add(this.hSlider_Crest);
            this.groupBox_Misc.Controls.Add(this.label_KneeMult);
            this.groupBox_Misc.Controls.Add(this.label_KneeMultValue);
            this.groupBox_Misc.Controls.Add(this.hSlider_KneeMult);
            this.groupBox_Misc.Location = new System.Drawing.Point(12, 290);
            this.groupBox_Misc.Name = "groupBox_Misc";
            this.groupBox_Misc.Size = new System.Drawing.Size(548, 139);
            this.groupBox_Misc.TabIndex = 14;
            this.groupBox_Misc.TabStop = false;
            this.groupBox_Misc.Text = "$COMPRESSOR_MISC";
            // 
            // label_Adapt
            // 
            this.label_Adapt.AutoSize = true;
            this.label_Adapt.Location = new System.Drawing.Point(290, 23);
            this.label_Adapt.Name = "label_Adapt";
            this.label_Adapt.Size = new System.Drawing.Size(157, 13);
            this.label_Adapt.TabIndex = 12;
            this.label_Adapt.Text = "$COMPRESSOR_ADAPTTIME";
            // 
            // label_AdaptValue
            // 
            this.label_AdaptValue.Location = new System.Drawing.Point(470, 44);
            this.label_AdaptValue.Name = "label_AdaptValue";
            this.label_AdaptValue.Size = new System.Drawing.Size(72, 13);
            this.label_AdaptValue.TabIndex = 11;
            this.label_AdaptValue.Text = "0.00ms";
            this.label_AdaptValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hSlider_Adapt
            // 
            this.hSlider_Adapt.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Adapt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Adapt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Adapt.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Adapt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Adapt.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Adapt.Location = new System.Drawing.Point(293, 41);
            this.hSlider_Adapt.Maximum = 1000;
            this.hSlider_Adapt.Name = "hSlider_Adapt";
            this.hSlider_Adapt.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Adapt.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Adapt.Size = new System.Drawing.Size(171, 22);
            this.hSlider_Adapt.SliderColor = System.Drawing.Color.White;
            this.hSlider_Adapt.TabIndex = 10;
            this.hSlider_Adapt.Value = 0;
            this.hSlider_Adapt.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Adapt_Scroll);
            // 
            // label_Crest
            // 
            this.label_Crest.AutoSize = true;
            this.label_Crest.Location = new System.Drawing.Point(6, 23);
            this.label_Crest.Name = "label_Crest";
            this.label_Crest.Size = new System.Drawing.Size(157, 13);
            this.label_Crest.TabIndex = 9;
            this.label_Crest.Text = "$COMPRESSOR_CRESTTIME";
            // 
            // label_CrestValue
            // 
            this.label_CrestValue.Location = new System.Drawing.Point(185, 44);
            this.label_CrestValue.Name = "label_CrestValue";
            this.label_CrestValue.Size = new System.Drawing.Size(80, 13);
            this.label_CrestValue.TabIndex = 8;
            this.label_CrestValue.Text = "0.00ms";
            this.label_CrestValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_CrestValue.Click += new System.EventHandler(this.Label_CrestValue_Click);
            // 
            // hSlider_Crest
            // 
            this.hSlider_Crest.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Crest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Crest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Crest.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Crest.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Crest.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Crest.Location = new System.Drawing.Point(7, 39);
            this.hSlider_Crest.Maximum = 1000;
            this.hSlider_Crest.Name = "hSlider_Crest";
            this.hSlider_Crest.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Crest.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Crest.Size = new System.Drawing.Size(172, 23);
            this.hSlider_Crest.SliderColor = System.Drawing.Color.White;
            this.hSlider_Crest.TabIndex = 7;
            this.hSlider_Crest.Value = 0;
            this.hSlider_Crest.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Crest_Scroll);
            // 
            // label_KneeMult
            // 
            this.label_KneeMult.AutoSize = true;
            this.label_KneeMult.Location = new System.Drawing.Point(6, 74);
            this.label_KneeMult.Name = "label_KneeMult";
            this.label_KneeMult.Size = new System.Drawing.Size(154, 13);
            this.label_KneeMult.TabIndex = 6;
            this.label_KneeMult.Text = "$COMPRESSOR_KNEEMULT";
            this.label_KneeMult.Click += new System.EventHandler(this.Label_KneeMult_Click);
            // 
            // label_KneeMultValue
            // 
            this.label_KneeMultValue.Location = new System.Drawing.Point(473, 95);
            this.label_KneeMultValue.Name = "label_KneeMultValue";
            this.label_KneeMultValue.Size = new System.Drawing.Size(69, 20);
            this.label_KneeMultValue.TabIndex = 5;
            this.label_KneeMultValue.Text = "2.00x";
            this.label_KneeMultValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hSlider_KneeMult
            // 
            this.hSlider_KneeMult.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_KneeMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_KneeMult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_KneeMult.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_KneeMult.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_KneeMult.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_KneeMult.Location = new System.Drawing.Point(7, 95);
            this.hSlider_KneeMult.Name = "hSlider_KneeMult";
            this.hSlider_KneeMult.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_KneeMult.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_KneeMult.Size = new System.Drawing.Size(457, 23);
            this.hSlider_KneeMult.SliderColor = System.Drawing.Color.White;
            this.hSlider_KneeMult.TabIndex = 5;
            this.hSlider_KneeMult.Value = 0;
            this.hSlider_KneeMult.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_KneeMult_Scroll);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // groupBox_Threshold
            // 
            this.groupBox_Threshold.AutoSize = true;
            this.groupBox_Threshold.Location = new System.Drawing.Point(9, 57);
            this.groupBox_Threshold.Name = "groupBox_Threshold";
            this.groupBox_Threshold.Size = new System.Drawing.Size(80, 13);
            this.groupBox_Threshold.TabIndex = 15;
            this.groupBox_Threshold.Text = "$THRESHOLD";
            // 
            // groupBox_Ratio
            // 
            this.groupBox_Ratio.AutoSize = true;
            this.groupBox_Ratio.Location = new System.Drawing.Point(9, 85);
            this.groupBox_Ratio.Name = "groupBox_Ratio";
            this.groupBox_Ratio.Size = new System.Drawing.Size(46, 13);
            this.groupBox_Ratio.TabIndex = 16;
            this.groupBox_Ratio.Text = "$RATIO";
            // 
            // frmCompressor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 439);
            this.Controls.Add(this.groupBox_Ratio);
            this.Controls.Add(this.label_Ratio);
            this.Controls.Add(this.groupBox_Threshold);
            this.Controls.Add(this.hSlider_Ratio);
            this.Controls.Add(this.groupBox_MakeUpGain);
            this.Controls.Add(this.label_Threshold);
            this.Controls.Add(this.hSlider_Threshold);
            this.Controls.Add(this.groupBox_Misc);
            this.Controls.Add(this.onOffSwitch_NoClip);
            this.Controls.Add(this.label_NoClip);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.groupBox_Release);
            this.Controls.Add(this.groupBox_Attack);
            this.Controls.Add(this.groupBox_Knee);
            this.Controls.Add(this.onOffSwitch_Compressor);
            this.Controls.Add(this.label_Compressor_Enable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCompressor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$COMPRESSOR";
            this.groupBox_Knee.ResumeLayout(false);
            this.groupBox_Knee.PerformLayout();
            this.groupBox_Release.ResumeLayout(false);
            this.groupBox_Release.PerformLayout();
            this.groupBox_Attack.ResumeLayout(false);
            this.groupBox_Attack.PerformLayout();
            this.groupBox_MakeUpGain.ResumeLayout(false);
            this.groupBox_MakeUpGain.PerformLayout();
            this.groupBox_Misc.ResumeLayout(false);
            this.groupBox_Misc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400027D RID: 637
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400027E RID: 638
		private global::MetroSuite.MetroSwitch onOffSwitch_Compressor;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.Label label_Compressor_Enable;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Label label_Threshold;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.GroupBox groupBox_Knee;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.Label label_Knee;

		// Token: 0x04000285 RID: 645
		private global::MetroSuite.MetroTrackbar hSlider_Knee;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.Label label_AutoKnee;

		// Token: 0x04000287 RID: 647
		private global::MetroSuite.MetroSwitch onOffSwitch_AutoKnee;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.Label label_Ratio;

		// Token: 0x0400028A RID: 650
		private global::MetroSuite.MetroTrackbar hSlider_Ratio;

		// Token: 0x0400028B RID: 651
		private global::System.Windows.Forms.GroupBox groupBox_Release;

		// Token: 0x0400028C RID: 652
		private global::MetroSuite.MetroSwitch onOffSwitch_AutoRelease;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.Label label_AutoRelease;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.Label label_Release;

		// Token: 0x0400028F RID: 655
		private global::MetroSuite.MetroTrackbar hSlider_Release;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.GroupBox groupBox_Attack;

		// Token: 0x04000291 RID: 657
		private global::MetroSuite.MetroSwitch onOffSwitch_AutoAttack;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.Label label_AutoAttack;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.Label label_Attack;

		// Token: 0x04000294 RID: 660
		private global::MetroSuite.MetroTrackbar hSlider_Attack;

		// Token: 0x04000295 RID: 661
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_Cancel;

		// Token: 0x04000296 RID: 662
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_OK;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.GroupBox groupBox_MakeUpGain;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.Label label_Gain;

		// Token: 0x04000299 RID: 665
		private global::MetroSuite.MetroTrackbar hSlider_Gain;

		// Token: 0x0400029A RID: 666
		private global::MetroSuite.MetroSwitch onOffSwitch_AutoGain;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.Label label_AutoGain;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.Label label_NoClip;

		// Token: 0x0400029D RID: 669
		private global::MetroSuite.MetroSwitch onOffSwitch_NoClip;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.GroupBox groupBox_Misc;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.Label label_KneeMult;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.Label label_KneeMultValue;

		// Token: 0x040002A1 RID: 673
		private global::MetroSuite.MetroTrackbar hSlider_KneeMult;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.Label label_Adapt;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.Label label_AdaptValue;

		// Token: 0x040002A4 RID: 676
		private global::MetroSuite.MetroTrackbar hSlider_Adapt;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Forms.Label label_Crest;

		// Token: 0x040002A6 RID: 678
		private global::System.Windows.Forms.Label label_CrestValue;

		// Token: 0x040002A7 RID: 679
		private global::MetroSuite.MetroTrackbar hSlider_Crest;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private MetroSuite.MetroTrackbar hSlider_Threshold;
        private System.Windows.Forms.Label groupBox_Threshold;
        private System.Windows.Forms.Label groupBox_Ratio;
    }
}
