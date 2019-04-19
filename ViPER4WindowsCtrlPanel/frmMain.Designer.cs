namespace ViPER4WindowsBin
{
    // Token: 0x02000015 RID: 21
    public partial class frmMain : global::Syncfusion.WinForms.Controls.SfForm
    {
        // Token: 0x0600013B RID: 315 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600013C RID: 316 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_MasterPower = new System.Windows.Forms.Label();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LatencySetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ChannelPan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Virtualization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ResetEffect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.panel_Freestyle = new System.Windows.Forms.Panel();
            this.Freestyle_groupBox_SmartVolume = new System.Windows.Forms.GroupBox();
            this.Freestyle_hSlider_SmartVolumeLevel = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_SmartVolume_Level = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_SmartVolumeMaxLevel = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_SmartVolume_MaxLevel = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_SmartVolumeRatio = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_SmartVolume_ControlStrength = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_SmartVolume = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_3DSurround = new System.Windows.Forms.GroupBox();
            this.Freestyle_hSlider_SurroundImage = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Surround_Image = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_Surround3D = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Surround_3D = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Surround3D = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_Reverb = new System.Windows.Forms.GroupBox();
            this.Freestyle_singleButton_ReverbPreset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Freestyle_hSlider_ReverbMix = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_Mix = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbEarlyMix = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_EarlyMix = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbPreDelay = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_PreDelay = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbDecay = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_Decay = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbBandWidth = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_BandWidth = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbDensity = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_Density = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbDamping = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_Damping = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbSize = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Reverb_Size = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Reverb = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_Cure = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_CureLevel = new System.Windows.Forms.ListBox();
            this.Freestyle_onOffSwitch_Cure = new MetroSuite.MetroSwitch();
            this.Freestyle_label_Tube = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Tube = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_Clarity = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_ClarityMode = new System.Windows.Forms.ListBox();
            this.Freestyle_hSlider_Clarity = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Clarity = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Clarity = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_Bass = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_BassMode = new System.Windows.Forms.ListBox();
            this.Freestyle_hSlider_BassGain = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Bass_Gain = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_BassSpkSize = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_Bass_SpkSize = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Bass = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_VHESurround = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_SurroundVHERoomSize = new System.Windows.Forms.ListBox();
            this.Freestyle_onOffSwitch_SurroundVHE = new MetroSuite.MetroSwitch();
            this.Freestyle_groupBox_Convolver = new System.Windows.Forms.GroupBox();
            this.Freestyle_irShape_ConvIR = new ViPER4WindowsBin.UIControls.IRShape();
            this.Freestyle_onOffSwitch_Convolver = new MetroSuite.MetroSwitch();
            this.Freestyle_hSlider_ConvIRGain = new MetroSuite.MetroTrackbar();
            this.Freestyle_openFileBox_ConvIRS = new ViPER4WindowsBin.UIControls.OpenFileBox();
            this.Freestyle_label_ConvolverIRGain = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_PostVolume = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_PostVolume = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_PreVolume = new MetroSuite.MetroTrackbar();
            this.Freestyle_label_PreVolume = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPreset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.onOffSwitch_Master = new MetroSuite.MetroSwitch();
            this.savePreset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.Freestyle_singleButton_Compressor = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Freestyle_singleButton_Equalizer = new Syncfusion.Windows.Forms.ButtonAdv();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Main.SuspendLayout();
            this.panel_Freestyle.SuspendLayout();
            this.Freestyle_groupBox_SmartVolume.SuspendLayout();
            this.Freestyle_groupBox_3DSurround.SuspendLayout();
            this.Freestyle_groupBox_Reverb.SuspendLayout();
            this.Freestyle_groupBox_Cure.SuspendLayout();
            this.Freestyle_groupBox_Clarity.SuspendLayout();
            this.Freestyle_groupBox_Bass.SuspendLayout();
            this.Freestyle_groupBox_VHESurround.SuspendLayout();
            this.Freestyle_groupBox_Convolver.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_MasterPower
            // 
            this.label_MasterPower.AutoSize = true;
            this.label_MasterPower.Location = new System.Drawing.Point(18, 47);
            this.label_MasterPower.Name = "label_MasterPower";
            this.label_MasterPower.Size = new System.Drawing.Size(105, 13);
            this.label_MasterPower.TabIndex = 1;
            this.label_MasterPower.Text = "$MASTER_POWER";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Language,
            this.toolStripMenuItem_Setting});
            this.menuStrip_Main.Location = new System.Drawing.Point(2, 2);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip_Main.TabIndex = 4;
            // 
            // toolStripMenuItem_Language
            // 
            this.toolStripMenuItem_Language.Name = "toolStripMenuItem_Language";
            this.toolStripMenuItem_Language.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem_Language.Text = "$MENU_LANGUAGE";
            // 
            // toolStripMenuItem_Setting
            // 
            this.toolStripMenuItem_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LatencySetting,
            this.toolStripMenuItem_ChannelPan,
            this.toolStripMenuItem_Virtualization,
            this.toolStripMenuItem_ResetEffect,
            this.toolStripMenuItem_Settings});
            this.toolStripMenuItem_Setting.Name = "toolStripMenuItem_Setting";
            this.toolStripMenuItem_Setting.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItem_Setting.Text = "$MENU_SETTING";
            // 
            // toolStripMenuItem_LatencySetting
            // 
            this.toolStripMenuItem_LatencySetting.Name = "toolStripMenuItem_LatencySetting";
            this.toolStripMenuItem_LatencySetting.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_LatencySetting.Text = "$LATENCY_SETTING";
            this.toolStripMenuItem_LatencySetting.Click += new System.EventHandler(this.toolStripMenuItem_LatencySetting_Click);
            // 
            // toolStripMenuItem_ChannelPan
            // 
            this.toolStripMenuItem_ChannelPan.Name = "toolStripMenuItem_ChannelPan";
            this.toolStripMenuItem_ChannelPan.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_ChannelPan.Text = "$CHANNEL_PAN";
            this.toolStripMenuItem_ChannelPan.Click += new System.EventHandler(this.toolStripMenuItem_ChannelPan_Click);
            // 
            // toolStripMenuItem_Virtualization
            // 
            this.toolStripMenuItem_Virtualization.Name = "toolStripMenuItem_Virtualization";
            this.toolStripMenuItem_Virtualization.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_Virtualization.Text = "$VIRTUALIZATION";
            this.toolStripMenuItem_Virtualization.Click += new System.EventHandler(this.toolStripMenuItem_Virtualization_Click);
            // 
            // toolStripMenuItem_ResetEffect
            // 
            this.toolStripMenuItem_ResetEffect.Name = "toolStripMenuItem_ResetEffect";
            this.toolStripMenuItem_ResetEffect.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_ResetEffect.Text = "$RESET_EFFECT";
            this.toolStripMenuItem_ResetEffect.Click += new System.EventHandler(this.toolStripMenuItem_ResetEffect_Click);
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_Settings.Text = "$SETTINGS";
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.panel_Freestyle);
            this.groupBox_Main.Location = new System.Drawing.Point(186, 30);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Size = new System.Drawing.Size(841, 620);
            this.groupBox_Main.TabIndex = 5;
            this.groupBox_Main.TabStop = false;
            // 
            // panel_Freestyle
            // 
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_SmartVolume);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_3DSurround);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_Reverb);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_Cure);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_Clarity);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_Bass);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_VHESurround);
            this.panel_Freestyle.Controls.Add(this.Freestyle_groupBox_Convolver);
            this.panel_Freestyle.Controls.Add(this.Freestyle_hSlider_PostVolume);
            this.panel_Freestyle.Controls.Add(this.Freestyle_label_PostVolume);
            this.panel_Freestyle.Controls.Add(this.Freestyle_hSlider_PreVolume);
            this.panel_Freestyle.Controls.Add(this.Freestyle_label_PreVolume);
            this.panel_Freestyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Freestyle.Location = new System.Drawing.Point(3, 16);
            this.panel_Freestyle.Name = "panel_Freestyle";
            this.panel_Freestyle.Size = new System.Drawing.Size(835, 601);
            this.panel_Freestyle.TabIndex = 10;
            // 
            // Freestyle_groupBox_SmartVolume
            // 
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_hSlider_SmartVolumeLevel);
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_label_SmartVolume_Level);
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_hSlider_SmartVolumeMaxLevel);
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_label_SmartVolume_MaxLevel);
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_hSlider_SmartVolumeRatio);
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_label_SmartVolume_ControlStrength);
            this.Freestyle_groupBox_SmartVolume.Controls.Add(this.Freestyle_onOffSwitch_SmartVolume);
            this.Freestyle_groupBox_SmartVolume.Location = new System.Drawing.Point(216, 424);
            this.Freestyle_groupBox_SmartVolume.Name = "Freestyle_groupBox_SmartVolume";
            this.Freestyle_groupBox_SmartVolume.Size = new System.Drawing.Size(384, 160);
            this.Freestyle_groupBox_SmartVolume.TabIndex = 23;
            this.Freestyle_groupBox_SmartVolume.TabStop = false;
            this.Freestyle_groupBox_SmartVolume.Text = "$SMART_VOLUME";
            // 
            // Freestyle_hSlider_SmartVolumeLevel
            // 
            this.Freestyle_hSlider_SmartVolumeLevel.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SmartVolumeLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_SmartVolumeLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_SmartVolumeLevel.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_SmartVolumeLevel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SmartVolumeLevel.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_SmartVolumeLevel.Location = new System.Drawing.Point(195, 92);
            this.Freestyle_hSlider_SmartVolumeLevel.Name = "Freestyle_hSlider_SmartVolumeLevel";
            this.Freestyle_hSlider_SmartVolumeLevel.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SmartVolumeLevel.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_SmartVolumeLevel.Size = new System.Drawing.Size(174, 42);
            this.Freestyle_hSlider_SmartVolumeLevel.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SmartVolumeLevel.TabIndex = 23;
            this.Freestyle_hSlider_SmartVolumeLevel.Value = 0;
            this.Freestyle_hSlider_SmartVolumeLevel.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_SmartVolumeLevel_Scroll);
            // 
            // Freestyle_label_SmartVolume_Level
            // 
            this.Freestyle_label_SmartVolume_Level.AutoSize = true;
            this.Freestyle_label_SmartVolume_Level.Location = new System.Drawing.Point(214, 73);
            this.Freestyle_label_SmartVolume_Level.Name = "Freestyle_label_SmartVolume_Level";
            this.Freestyle_label_SmartVolume_Level.Size = new System.Drawing.Size(169, 13);
            this.Freestyle_label_SmartVolume_Level.TabIndex = 22;
            this.Freestyle_label_SmartVolume_Level.Text = "$SMART_VOLUME_LEVEL : 0dB";
            // 
            // Freestyle_hSlider_SmartVolumeMaxLevel
            // 
            this.Freestyle_hSlider_SmartVolumeMaxLevel.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Location = new System.Drawing.Point(9, 125);
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Name = "Freestyle_hSlider_SmartVolumeMaxLevel";
            this.Freestyle_hSlider_SmartVolumeMaxLevel.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_SmartVolumeMaxLevel.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.TabIndex = 21;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Value = 0;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_SmartVolumeMaxLevel_Scroll);
            // 
            // Freestyle_label_SmartVolume_MaxLevel
            // 
            this.Freestyle_label_SmartVolume_MaxLevel.AutoSize = true;
            this.Freestyle_label_SmartVolume_MaxLevel.Location = new System.Drawing.Point(19, 108);
            this.Freestyle_label_SmartVolume_MaxLevel.Name = "Freestyle_label_SmartVolume_MaxLevel";
            this.Freestyle_label_SmartVolume_MaxLevel.Size = new System.Drawing.Size(184, 13);
            this.Freestyle_label_SmartVolume_MaxLevel.TabIndex = 20;
            this.Freestyle_label_SmartVolume_MaxLevel.Text = "$SMART_VOLUME_MAXLEVEL : 1x";
            // 
            // Freestyle_hSlider_SmartVolumeRatio
            // 
            this.Freestyle_hSlider_SmartVolumeRatio.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SmartVolumeRatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_SmartVolumeRatio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_SmartVolumeRatio.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_SmartVolumeRatio.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SmartVolumeRatio.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_SmartVolumeRatio.Location = new System.Drawing.Point(9, 79);
            this.Freestyle_hSlider_SmartVolumeRatio.Name = "Freestyle_hSlider_SmartVolumeRatio";
            this.Freestyle_hSlider_SmartVolumeRatio.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SmartVolumeRatio.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_SmartVolumeRatio.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_SmartVolumeRatio.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SmartVolumeRatio.TabIndex = 19;
            this.Freestyle_hSlider_SmartVolumeRatio.Value = 0;
            this.Freestyle_hSlider_SmartVolumeRatio.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_SmartVolumeRatio_Scroll);
            // 
            // Freestyle_label_SmartVolume_ControlStrength
            // 
            this.Freestyle_label_SmartVolume_ControlStrength.AutoSize = true;
            this.Freestyle_label_SmartVolume_ControlStrength.Location = new System.Drawing.Point(19, 63);
            this.Freestyle_label_SmartVolume_ControlStrength.Name = "Freestyle_label_SmartVolume_ControlStrength";
            this.Freestyle_label_SmartVolume_ControlStrength.Size = new System.Drawing.Size(226, 13);
            this.Freestyle_label_SmartVolume_ControlStrength.TabIndex = 18;
            this.Freestyle_label_SmartVolume_ControlStrength.Text = "$SMART_VOLUME_CONTROL_STRENGTH";
            // 
            // Freestyle_onOffSwitch_SmartVolume
            // 
            this.Freestyle_onOffSwitch_SmartVolume.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_SmartVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_SmartVolume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_SmartVolume.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_SmartVolume.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_SmartVolume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_SmartVolume.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_SmartVolume.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_SmartVolume.Name = "Freestyle_onOffSwitch_SmartVolume";
            this.Freestyle_onOffSwitch_SmartVolume.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_SmartVolume.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_SmartVolume.TabIndex = 17;
            this.Freestyle_onOffSwitch_SmartVolume.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_SmartVolume_CheckedChanged);
            // 
            // Freestyle_groupBox_3DSurround
            // 
            this.Freestyle_groupBox_3DSurround.Controls.Add(this.Freestyle_hSlider_SurroundImage);
            this.Freestyle_groupBox_3DSurround.Controls.Add(this.Freestyle_label_Surround_Image);
            this.Freestyle_groupBox_3DSurround.Controls.Add(this.Freestyle_hSlider_Surround3D);
            this.Freestyle_groupBox_3DSurround.Controls.Add(this.Freestyle_label_Surround_3D);
            this.Freestyle_groupBox_3DSurround.Controls.Add(this.Freestyle_onOffSwitch_Surround3D);
            this.Freestyle_groupBox_3DSurround.Location = new System.Drawing.Point(476, 7);
            this.Freestyle_groupBox_3DSurround.Name = "Freestyle_groupBox_3DSurround";
            this.Freestyle_groupBox_3DSurround.Size = new System.Drawing.Size(121, 194);
            this.Freestyle_groupBox_3DSurround.TabIndex = 22;
            this.Freestyle_groupBox_3DSurround.TabStop = false;
            this.Freestyle_groupBox_3DSurround.Text = "$3D_SURROUND";
            // 
            // Freestyle_hSlider_SurroundImage
            // 
            this.Freestyle_hSlider_SurroundImage.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SurroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_SurroundImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_SurroundImage.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_SurroundImage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SurroundImage.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_SurroundImage.Location = new System.Drawing.Point(6, 137);
            this.Freestyle_hSlider_SurroundImage.Name = "Freestyle_hSlider_SurroundImage";
            this.Freestyle_hSlider_SurroundImage.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_SurroundImage.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_SurroundImage.Size = new System.Drawing.Size(110, 26);
            this.Freestyle_hSlider_SurroundImage.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_SurroundImage.TabIndex = 25;
            this.Freestyle_hSlider_SurroundImage.Value = 0;
            this.Freestyle_hSlider_SurroundImage.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_SurroundImage_Scroll);
            // 
            // Freestyle_label_Surround_Image
            // 
            this.Freestyle_label_Surround_Image.AutoSize = true;
            this.Freestyle_label_Surround_Image.Location = new System.Drawing.Point(16, 120);
            this.Freestyle_label_Surround_Image.Name = "Freestyle_label_Surround_Image";
            this.Freestyle_label_Surround_Image.Size = new System.Drawing.Size(116, 13);
            this.Freestyle_label_Surround_Image.TabIndex = 24;
            this.Freestyle_label_Surround_Image.Text = "$SURROUND_IMAGE";
            // 
            // Freestyle_hSlider_Surround3D
            // 
            this.Freestyle_hSlider_Surround3D.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_Surround3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_Surround3D.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_Surround3D.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_Surround3D.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_Surround3D.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_Surround3D.Location = new System.Drawing.Point(6, 91);
            this.Freestyle_hSlider_Surround3D.Name = "Freestyle_hSlider_Surround3D";
            this.Freestyle_hSlider_Surround3D.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_Surround3D.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_Surround3D.Size = new System.Drawing.Size(110, 26);
            this.Freestyle_hSlider_Surround3D.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_Surround3D.TabIndex = 23;
            this.Freestyle_hSlider_Surround3D.Value = 0;
            this.Freestyle_hSlider_Surround3D.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_Surround3D_Scroll);
            // 
            // Freestyle_label_Surround_3D
            // 
            this.Freestyle_label_Surround_3D.AutoSize = true;
            this.Freestyle_label_Surround_3D.Location = new System.Drawing.Point(16, 75);
            this.Freestyle_label_Surround_3D.Name = "Freestyle_label_Surround_3D";
            this.Freestyle_label_Surround_3D.Size = new System.Drawing.Size(96, 13);
            this.Freestyle_label_Surround_3D.TabIndex = 22;
            this.Freestyle_label_Surround_3D.Text = "$SURROUND_3D";
            // 
            // Freestyle_onOffSwitch_Surround3D
            // 
            this.Freestyle_onOffSwitch_Surround3D.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Surround3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Surround3D.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Surround3D.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Surround3D.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Surround3D.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Surround3D.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Surround3D.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Surround3D.Name = "Freestyle_onOffSwitch_Surround3D";
            this.Freestyle_onOffSwitch_Surround3D.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Surround3D.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Surround3D.TabIndex = 6;
            this.Freestyle_onOffSwitch_Surround3D.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Surround3D_CheckedChanged);
            // 
            // Freestyle_groupBox_Reverb
            // 
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_singleButton_ReverbPreset);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbMix);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_Mix);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbEarlyMix);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_EarlyMix);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbPreDelay);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_PreDelay);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbDecay);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_Decay);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbBandWidth);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_BandWidth);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbDensity);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_Density);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbDamping);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_Damping);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_hSlider_ReverbSize);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_label_Reverb_Size);
            this.Freestyle_groupBox_Reverb.Controls.Add(this.Freestyle_onOffSwitch_Reverb);
            this.Freestyle_groupBox_Reverb.Location = new System.Drawing.Point(606, 163);
            this.Freestyle_groupBox_Reverb.Name = "Freestyle_groupBox_Reverb";
            this.Freestyle_groupBox_Reverb.Size = new System.Drawing.Size(208, 421);
            this.Freestyle_groupBox_Reverb.TabIndex = 19;
            this.Freestyle_groupBox_Reverb.TabStop = false;
            this.Freestyle_groupBox_Reverb.Text = "$REVERB";
            // 
            // Freestyle_singleButton_ReverbPreset
            // 
            this.Freestyle_singleButton_ReverbPreset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.Freestyle_singleButton_ReverbPreset.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_singleButton_ReverbPreset.BeforeTouchSize = new System.Drawing.Size(119, 31);
            this.Freestyle_singleButton_ReverbPreset.IsBackStageButton = false;
            this.Freestyle_singleButton_ReverbPreset.Location = new System.Drawing.Point(83, 15);
            this.Freestyle_singleButton_ReverbPreset.Name = "Freestyle_singleButton_ReverbPreset";
            this.Freestyle_singleButton_ReverbPreset.Size = new System.Drawing.Size(119, 31);
            this.Freestyle_singleButton_ReverbPreset.TabIndex = 36;
            this.Freestyle_singleButton_ReverbPreset.Text = "$PRESET";
            this.Freestyle_singleButton_ReverbPreset.ThemeName = "Office2016Colorful";
            this.Freestyle_singleButton_ReverbPreset.UseVisualStyle = true;
            this.Freestyle_singleButton_ReverbPreset.Click += new System.EventHandler(this.Freestyle_singleButton_ReverbPreset_Click);
            // 
            // Freestyle_hSlider_ReverbMix
            // 
            this.Freestyle_hSlider_ReverbMix.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbMix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbMix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbMix.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbMix.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbMix.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbMix.Location = new System.Drawing.Point(24, 386);
            this.Freestyle_hSlider_ReverbMix.Name = "Freestyle_hSlider_ReverbMix";
            this.Freestyle_hSlider_ReverbMix.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbMix.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbMix.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbMix.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbMix.TabIndex = 35;
            this.Freestyle_hSlider_ReverbMix.Value = 0;
            this.Freestyle_hSlider_ReverbMix.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbMix_Scroll);
            // 
            // Freestyle_label_Reverb_Mix
            // 
            this.Freestyle_label_Reverb_Mix.AutoSize = true;
            this.Freestyle_label_Reverb_Mix.Location = new System.Drawing.Point(34, 369);
            this.Freestyle_label_Reverb_Mix.Name = "Freestyle_label_Reverb_Mix";
            this.Freestyle_label_Reverb_Mix.Size = new System.Drawing.Size(82, 13);
            this.Freestyle_label_Reverb_Mix.TabIndex = 34;
            this.Freestyle_label_Reverb_Mix.Text = "$REVERB_MIX";
            // 
            // Freestyle_hSlider_ReverbEarlyMix
            // 
            this.Freestyle_hSlider_ReverbEarlyMix.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbEarlyMix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbEarlyMix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbEarlyMix.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbEarlyMix.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbEarlyMix.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbEarlyMix.Location = new System.Drawing.Point(24, 340);
            this.Freestyle_hSlider_ReverbEarlyMix.Name = "Freestyle_hSlider_ReverbEarlyMix";
            this.Freestyle_hSlider_ReverbEarlyMix.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbEarlyMix.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbEarlyMix.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbEarlyMix.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbEarlyMix.TabIndex = 33;
            this.Freestyle_hSlider_ReverbEarlyMix.Value = 0;
            this.Freestyle_hSlider_ReverbEarlyMix.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbEarlyMix_Scroll);
            // 
            // Freestyle_label_Reverb_EarlyMix
            // 
            this.Freestyle_label_Reverb_EarlyMix.AutoSize = true;
            this.Freestyle_label_Reverb_EarlyMix.Location = new System.Drawing.Point(34, 324);
            this.Freestyle_label_Reverb_EarlyMix.Name = "Freestyle_label_Reverb_EarlyMix";
            this.Freestyle_label_Reverb_EarlyMix.Size = new System.Drawing.Size(117, 13);
            this.Freestyle_label_Reverb_EarlyMix.TabIndex = 32;
            this.Freestyle_label_Reverb_EarlyMix.Text = "$REVERB_EARLYMIX";
            // 
            // Freestyle_hSlider_ReverbPreDelay
            // 
            this.Freestyle_hSlider_ReverbPreDelay.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbPreDelay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbPreDelay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbPreDelay.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbPreDelay.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbPreDelay.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbPreDelay.Location = new System.Drawing.Point(24, 295);
            this.Freestyle_hSlider_ReverbPreDelay.Name = "Freestyle_hSlider_ReverbPreDelay";
            this.Freestyle_hSlider_ReverbPreDelay.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbPreDelay.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbPreDelay.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbPreDelay.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbPreDelay.TabIndex = 31;
            this.Freestyle_hSlider_ReverbPreDelay.Value = 0;
            this.Freestyle_hSlider_ReverbPreDelay.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbPreDelay_Scroll);
            // 
            // Freestyle_label_Reverb_PreDelay
            // 
            this.Freestyle_label_Reverb_PreDelay.AutoSize = true;
            this.Freestyle_label_Reverb_PreDelay.Location = new System.Drawing.Point(34, 278);
            this.Freestyle_label_Reverb_PreDelay.Name = "Freestyle_label_Reverb_PreDelay";
            this.Freestyle_label_Reverb_PreDelay.Size = new System.Drawing.Size(120, 13);
            this.Freestyle_label_Reverb_PreDelay.TabIndex = 30;
            this.Freestyle_label_Reverb_PreDelay.Text = "$REVERB_PREDELAY";
            // 
            // Freestyle_hSlider_ReverbDecay
            // 
            this.Freestyle_hSlider_ReverbDecay.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbDecay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbDecay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbDecay.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbDecay.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbDecay.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbDecay.Location = new System.Drawing.Point(24, 249);
            this.Freestyle_hSlider_ReverbDecay.Name = "Freestyle_hSlider_ReverbDecay";
            this.Freestyle_hSlider_ReverbDecay.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbDecay.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbDecay.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbDecay.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbDecay.TabIndex = 29;
            this.Freestyle_hSlider_ReverbDecay.Value = 0;
            this.Freestyle_hSlider_ReverbDecay.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbDecay_Scroll);
            // 
            // Freestyle_label_Reverb_Decay
            // 
            this.Freestyle_label_Reverb_Decay.AutoSize = true;
            this.Freestyle_label_Reverb_Decay.Location = new System.Drawing.Point(34, 233);
            this.Freestyle_label_Reverb_Decay.Name = "Freestyle_label_Reverb_Decay";
            this.Freestyle_label_Reverb_Decay.Size = new System.Drawing.Size(99, 13);
            this.Freestyle_label_Reverb_Decay.TabIndex = 28;
            this.Freestyle_label_Reverb_Decay.Text = "$REVERB_DECAY";
            // 
            // Freestyle_hSlider_ReverbBandWidth
            // 
            this.Freestyle_hSlider_ReverbBandWidth.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbBandWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbBandWidth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbBandWidth.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbBandWidth.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbBandWidth.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbBandWidth.Location = new System.Drawing.Point(24, 204);
            this.Freestyle_hSlider_ReverbBandWidth.Name = "Freestyle_hSlider_ReverbBandWidth";
            this.Freestyle_hSlider_ReverbBandWidth.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbBandWidth.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbBandWidth.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbBandWidth.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbBandWidth.TabIndex = 27;
            this.Freestyle_hSlider_ReverbBandWidth.Value = 0;
            this.Freestyle_hSlider_ReverbBandWidth.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbBandWidth_Scroll);
            // 
            // Freestyle_label_Reverb_BandWidth
            // 
            this.Freestyle_label_Reverb_BandWidth.AutoSize = true;
            this.Freestyle_label_Reverb_BandWidth.Location = new System.Drawing.Point(34, 187);
            this.Freestyle_label_Reverb_BandWidth.Name = "Freestyle_label_Reverb_BandWidth";
            this.Freestyle_label_Reverb_BandWidth.Size = new System.Drawing.Size(130, 13);
            this.Freestyle_label_Reverb_BandWidth.TabIndex = 26;
            this.Freestyle_label_Reverb_BandWidth.Text = "$REVERB_BANDWIDTH";
            // 
            // Freestyle_hSlider_ReverbDensity
            // 
            this.Freestyle_hSlider_ReverbDensity.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbDensity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbDensity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbDensity.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbDensity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbDensity.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbDensity.Location = new System.Drawing.Point(24, 158);
            this.Freestyle_hSlider_ReverbDensity.Name = "Freestyle_hSlider_ReverbDensity";
            this.Freestyle_hSlider_ReverbDensity.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbDensity.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbDensity.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbDensity.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbDensity.TabIndex = 25;
            this.Freestyle_hSlider_ReverbDensity.Value = 0;
            this.Freestyle_hSlider_ReverbDensity.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbDensity_Scroll);
            // 
            // Freestyle_label_Reverb_Density
            // 
            this.Freestyle_label_Reverb_Density.AutoSize = true;
            this.Freestyle_label_Reverb_Density.Location = new System.Drawing.Point(34, 142);
            this.Freestyle_label_Reverb_Density.Name = "Freestyle_label_Reverb_Density";
            this.Freestyle_label_Reverb_Density.Size = new System.Drawing.Size(110, 13);
            this.Freestyle_label_Reverb_Density.TabIndex = 24;
            this.Freestyle_label_Reverb_Density.Text = "$REVERB_DENSITY";
            // 
            // Freestyle_hSlider_ReverbDamping
            // 
            this.Freestyle_hSlider_ReverbDamping.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbDamping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbDamping.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbDamping.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbDamping.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbDamping.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbDamping.Location = new System.Drawing.Point(24, 113);
            this.Freestyle_hSlider_ReverbDamping.Name = "Freestyle_hSlider_ReverbDamping";
            this.Freestyle_hSlider_ReverbDamping.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbDamping.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbDamping.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbDamping.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbDamping.TabIndex = 23;
            this.Freestyle_hSlider_ReverbDamping.Value = 0;
            this.Freestyle_hSlider_ReverbDamping.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbDamping_Scroll);
            // 
            // Freestyle_label_Reverb_Damping
            // 
            this.Freestyle_label_Reverb_Damping.AutoSize = true;
            this.Freestyle_label_Reverb_Damping.Location = new System.Drawing.Point(34, 96);
            this.Freestyle_label_Reverb_Damping.Name = "Freestyle_label_Reverb_Damping";
            this.Freestyle_label_Reverb_Damping.Size = new System.Drawing.Size(113, 13);
            this.Freestyle_label_Reverb_Damping.TabIndex = 22;
            this.Freestyle_label_Reverb_Damping.Text = "$REVERB_DAMPING";
            // 
            // Freestyle_hSlider_ReverbSize
            // 
            this.Freestyle_hSlider_ReverbSize.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ReverbSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ReverbSize.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ReverbSize.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbSize.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ReverbSize.Location = new System.Drawing.Point(24, 69);
            this.Freestyle_hSlider_ReverbSize.Name = "Freestyle_hSlider_ReverbSize";
            this.Freestyle_hSlider_ReverbSize.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ReverbSize.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ReverbSize.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbSize.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ReverbSize.TabIndex = 21;
            this.Freestyle_hSlider_ReverbSize.Value = 0;
            this.Freestyle_hSlider_ReverbSize.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ReverbSize_Scroll);
            // 
            // Freestyle_label_Reverb_Size
            // 
            this.Freestyle_label_Reverb_Size.AutoSize = true;
            this.Freestyle_label_Reverb_Size.Location = new System.Drawing.Point(34, 53);
            this.Freestyle_label_Reverb_Size.Name = "Freestyle_label_Reverb_Size";
            this.Freestyle_label_Reverb_Size.Size = new System.Drawing.Size(87, 13);
            this.Freestyle_label_Reverb_Size.TabIndex = 20;
            this.Freestyle_label_Reverb_Size.Text = "$REVERB_SIZE";
            // 
            // Freestyle_onOffSwitch_Reverb
            // 
            this.Freestyle_onOffSwitch_Reverb.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Reverb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Reverb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Reverb.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Reverb.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Reverb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Reverb.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Reverb.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Reverb.Name = "Freestyle_onOffSwitch_Reverb";
            this.Freestyle_onOffSwitch_Reverb.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Reverb.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Reverb.TabIndex = 7;
            this.Freestyle_onOffSwitch_Reverb.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Reverb_CheckedChanged);
            // 
            // Freestyle_groupBox_Cure
            // 
            this.Freestyle_groupBox_Cure.Controls.Add(this.Freestyle_buttonBox_CureLevel);
            this.Freestyle_groupBox_Cure.Controls.Add(this.Freestyle_onOffSwitch_Cure);
            this.Freestyle_groupBox_Cure.Controls.Add(this.Freestyle_label_Tube);
            this.Freestyle_groupBox_Cure.Controls.Add(this.Freestyle_onOffSwitch_Tube);
            this.Freestyle_groupBox_Cure.Location = new System.Drawing.Point(411, 232);
            this.Freestyle_groupBox_Cure.Name = "Freestyle_groupBox_Cure";
            this.Freestyle_groupBox_Cure.Size = new System.Drawing.Size(189, 160);
            this.Freestyle_groupBox_Cure.TabIndex = 18;
            this.Freestyle_groupBox_Cure.TabStop = false;
            this.Freestyle_groupBox_Cure.Text = "$CURE";
            // 
            // Freestyle_buttonBox_CureLevel
            // 
            this.Freestyle_buttonBox_CureLevel.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_buttonBox_CureLevel.Location = new System.Drawing.Point(75, 19);
            this.Freestyle_buttonBox_CureLevel.Name = "Freestyle_buttonBox_CureLevel";
            this.Freestyle_buttonBox_CureLevel.Size = new System.Drawing.Size(106, 43);
            this.Freestyle_buttonBox_CureLevel.TabIndex = 18;
            this.Freestyle_buttonBox_CureLevel.SelectedIndexChanged += new System.EventHandler(this.Freestyle_buttonBox_CureLevel_SelectedIndexChanged);
            // 
            // Freestyle_onOffSwitch_Cure
            // 
            this.Freestyle_onOffSwitch_Cure.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Cure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Cure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Cure.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Cure.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Cure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Cure.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Cure.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Cure.Name = "Freestyle_onOffSwitch_Cure";
            this.Freestyle_onOffSwitch_Cure.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Cure.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Cure.TabIndex = 17;
            this.Freestyle_onOffSwitch_Cure.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Cure_CheckedChanged);
            // 
            // Freestyle_label_Tube
            // 
            this.Freestyle_label_Tube.AutoSize = true;
            this.Freestyle_label_Tube.Location = new System.Drawing.Point(11, 122);
            this.Freestyle_label_Tube.Name = "Freestyle_label_Tube";
            this.Freestyle_label_Tube.Size = new System.Drawing.Size(42, 13);
            this.Freestyle_label_Tube.TabIndex = 14;
            this.Freestyle_label_Tube.Text = "$TUBE";
            // 
            // Freestyle_onOffSwitch_Tube
            // 
            this.Freestyle_onOffSwitch_Tube.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Tube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Tube.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Tube.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Tube.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Tube.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Tube.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Tube.Location = new System.Drawing.Point(121, 114);
            this.Freestyle_onOffSwitch_Tube.Name = "Freestyle_onOffSwitch_Tube";
            this.Freestyle_onOffSwitch_Tube.Size = new System.Drawing.Size(53, 28);
            this.Freestyle_onOffSwitch_Tube.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Tube.TabIndex = 15;
            this.Freestyle_onOffSwitch_Tube.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Tube_CheckedChanged);
            // 
            // Freestyle_groupBox_Clarity
            // 
            this.Freestyle_groupBox_Clarity.Controls.Add(this.Freestyle_buttonBox_ClarityMode);
            this.Freestyle_groupBox_Clarity.Controls.Add(this.Freestyle_hSlider_Clarity);
            this.Freestyle_groupBox_Clarity.Controls.Add(this.Freestyle_label_Clarity);
            this.Freestyle_groupBox_Clarity.Controls.Add(this.Freestyle_onOffSwitch_Clarity);
            this.Freestyle_groupBox_Clarity.Location = new System.Drawing.Point(216, 232);
            this.Freestyle_groupBox_Clarity.Name = "Freestyle_groupBox_Clarity";
            this.Freestyle_groupBox_Clarity.Size = new System.Drawing.Size(189, 160);
            this.Freestyle_groupBox_Clarity.TabIndex = 17;
            this.Freestyle_groupBox_Clarity.TabStop = false;
            this.Freestyle_groupBox_Clarity.Text = "$CLARITY";
            // 
            // Freestyle_buttonBox_ClarityMode
            // 
            this.Freestyle_buttonBox_ClarityMode.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_buttonBox_ClarityMode.Location = new System.Drawing.Point(68, 18);
            this.Freestyle_buttonBox_ClarityMode.Name = "Freestyle_buttonBox_ClarityMode";
            this.Freestyle_buttonBox_ClarityMode.Size = new System.Drawing.Size(106, 43);
            this.Freestyle_buttonBox_ClarityMode.TabIndex = 18;
            this.Freestyle_buttonBox_ClarityMode.SelectedIndexChanged += new System.EventHandler(this.Freestyle_buttonBox_ClarityMode_SelectedIndexChanged);
            // 
            // Freestyle_hSlider_Clarity
            // 
            this.Freestyle_hSlider_Clarity.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_Clarity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_Clarity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_Clarity.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_Clarity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_Clarity.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_Clarity.Location = new System.Drawing.Point(13, 125);
            this.Freestyle_hSlider_Clarity.Name = "Freestyle_hSlider_Clarity";
            this.Freestyle_hSlider_Clarity.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_Clarity.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_Clarity.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_Clarity.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_Clarity.TabIndex = 21;
            this.Freestyle_hSlider_Clarity.Value = 0;
            this.Freestyle_hSlider_Clarity.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_Clarity_Scroll);
            // 
            // Freestyle_label_Clarity
            // 
            this.Freestyle_label_Clarity.AutoSize = true;
            this.Freestyle_label_Clarity.Location = new System.Drawing.Point(23, 108);
            this.Freestyle_label_Clarity.Name = "Freestyle_label_Clarity";
            this.Freestyle_label_Clarity.Size = new System.Drawing.Size(86, 13);
            this.Freestyle_label_Clarity.TabIndex = 20;
            this.Freestyle_label_Clarity.Text = "$CLARITY : 0dB";
            // 
            // Freestyle_onOffSwitch_Clarity
            // 
            this.Freestyle_onOffSwitch_Clarity.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Clarity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Clarity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Clarity.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Clarity.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Clarity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Clarity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Clarity.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Clarity.Name = "Freestyle_onOffSwitch_Clarity";
            this.Freestyle_onOffSwitch_Clarity.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Clarity.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Clarity.TabIndex = 17;
            this.Freestyle_onOffSwitch_Clarity.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Clarity_CheckedChanged);
            // 
            // Freestyle_groupBox_Bass
            // 
            this.Freestyle_groupBox_Bass.Controls.Add(this.Freestyle_buttonBox_BassMode);
            this.Freestyle_groupBox_Bass.Controls.Add(this.Freestyle_hSlider_BassGain);
            this.Freestyle_groupBox_Bass.Controls.Add(this.Freestyle_label_Bass_Gain);
            this.Freestyle_groupBox_Bass.Controls.Add(this.Freestyle_hSlider_BassSpkSize);
            this.Freestyle_groupBox_Bass.Controls.Add(this.Freestyle_label_Bass_SpkSize);
            this.Freestyle_groupBox_Bass.Controls.Add(this.Freestyle_onOffSwitch_Bass);
            this.Freestyle_groupBox_Bass.Location = new System.Drawing.Point(21, 232);
            this.Freestyle_groupBox_Bass.Name = "Freestyle_groupBox_Bass";
            this.Freestyle_groupBox_Bass.Size = new System.Drawing.Size(189, 352);
            this.Freestyle_groupBox_Bass.TabIndex = 16;
            this.Freestyle_groupBox_Bass.TabStop = false;
            this.Freestyle_groupBox_Bass.Text = "$BASS";
            // 
            // Freestyle_buttonBox_BassMode
            // 
            this.Freestyle_buttonBox_BassMode.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_buttonBox_BassMode.Location = new System.Drawing.Point(21, 163);
            this.Freestyle_buttonBox_BassMode.Name = "Freestyle_buttonBox_BassMode";
            this.Freestyle_buttonBox_BassMode.Size = new System.Drawing.Size(143, 30);
            this.Freestyle_buttonBox_BassMode.TabIndex = 22;
            this.Freestyle_buttonBox_BassMode.SelectedIndexChanged += new System.EventHandler(this.Freestyle_buttonBox_BassMode_SelectedIndexChanged);
            // 
            // Freestyle_hSlider_BassGain
            // 
            this.Freestyle_hSlider_BassGain.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_BassGain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_BassGain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_BassGain.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_BassGain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_BassGain.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_BassGain.Location = new System.Drawing.Point(13, 125);
            this.Freestyle_hSlider_BassGain.Name = "Freestyle_hSlider_BassGain";
            this.Freestyle_hSlider_BassGain.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_BassGain.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_BassGain.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_BassGain.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_BassGain.TabIndex = 21;
            this.Freestyle_hSlider_BassGain.Value = 0;
            this.Freestyle_hSlider_BassGain.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_BassGain_Scroll);
            // 
            // Freestyle_label_Bass_Gain
            // 
            this.Freestyle_label_Bass_Gain.AutoSize = true;
            this.Freestyle_label_Bass_Gain.Location = new System.Drawing.Point(23, 108);
            this.Freestyle_label_Bass_Gain.Name = "Freestyle_label_Bass_Gain";
            this.Freestyle_label_Bass_Gain.Size = new System.Drawing.Size(101, 13);
            this.Freestyle_label_Bass_Gain.TabIndex = 20;
            this.Freestyle_label_Bass_Gain.Text = "$BASS_GAIN : 0dB";
            // 
            // Freestyle_hSlider_BassSpkSize
            // 
            this.Freestyle_hSlider_BassSpkSize.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_BassSpkSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_BassSpkSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_BassSpkSize.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_BassSpkSize.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_BassSpkSize.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_BassSpkSize.Location = new System.Drawing.Point(13, 79);
            this.Freestyle_hSlider_BassSpkSize.Name = "Freestyle_hSlider_BassSpkSize";
            this.Freestyle_hSlider_BassSpkSize.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_BassSpkSize.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_BassSpkSize.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_BassSpkSize.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_BassSpkSize.TabIndex = 19;
            this.Freestyle_hSlider_BassSpkSize.Value = 0;
            this.Freestyle_hSlider_BassSpkSize.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_BassSpkSize_Scroll);
            // 
            // Freestyle_label_Bass_SpkSize
            // 
            this.Freestyle_label_Bass_SpkSize.AutoSize = true;
            this.Freestyle_label_Bass_SpkSize.Location = new System.Drawing.Point(23, 63);
            this.Freestyle_label_Bass_SpkSize.Name = "Freestyle_label_Bass_SpkSize";
            this.Freestyle_label_Bass_SpkSize.Size = new System.Drawing.Size(92, 13);
            this.Freestyle_label_Bass_SpkSize.TabIndex = 18;
            this.Freestyle_label_Bass_SpkSize.Text = "$BASS_SPKSIZE";
            // 
            // Freestyle_onOffSwitch_Bass
            // 
            this.Freestyle_onOffSwitch_Bass.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Bass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Bass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Bass.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Bass.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Bass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Bass.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Bass.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Bass.Name = "Freestyle_onOffSwitch_Bass";
            this.Freestyle_onOffSwitch_Bass.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Bass.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Bass.TabIndex = 17;
            this.Freestyle_onOffSwitch_Bass.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Bass_CheckedChanged);
            // 
            // Freestyle_groupBox_VHESurround
            // 
            this.Freestyle_groupBox_VHESurround.Controls.Add(this.Freestyle_buttonBox_SurroundVHERoomSize);
            this.Freestyle_groupBox_VHESurround.Controls.Add(this.Freestyle_onOffSwitch_SurroundVHE);
            this.Freestyle_groupBox_VHESurround.Location = new System.Drawing.Point(606, 7);
            this.Freestyle_groupBox_VHESurround.Name = "Freestyle_groupBox_VHESurround";
            this.Freestyle_groupBox_VHESurround.Size = new System.Drawing.Size(208, 150);
            this.Freestyle_groupBox_VHESurround.TabIndex = 13;
            this.Freestyle_groupBox_VHESurround.TabStop = false;
            this.Freestyle_groupBox_VHESurround.Text = "$VHE_SURROUND";
            // 
            // Freestyle_buttonBox_SurroundVHERoomSize
            // 
            this.Freestyle_buttonBox_SurroundVHERoomSize.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_buttonBox_SurroundVHERoomSize.Location = new System.Drawing.Point(68, 25);
            this.Freestyle_buttonBox_SurroundVHERoomSize.Name = "Freestyle_buttonBox_SurroundVHERoomSize";
            this.Freestyle_buttonBox_SurroundVHERoomSize.Size = new System.Drawing.Size(127, 69);
            this.Freestyle_buttonBox_SurroundVHERoomSize.TabIndex = 7;
            this.Freestyle_buttonBox_SurroundVHERoomSize.SelectedIndexChanged += new System.EventHandler(this.Freestyle_buttonBox_SurroundVHERoomSize_SelectedIndexChanged);
            // 
            // Freestyle_onOffSwitch_SurroundVHE
            // 
            this.Freestyle_onOffSwitch_SurroundVHE.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_SurroundVHE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_SurroundVHE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_SurroundVHE.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_SurroundVHE.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_SurroundVHE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_SurroundVHE.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_SurroundVHE.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_SurroundVHE.Name = "Freestyle_onOffSwitch_SurroundVHE";
            this.Freestyle_onOffSwitch_SurroundVHE.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_SurroundVHE.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_SurroundVHE.TabIndex = 6;
            this.Freestyle_onOffSwitch_SurroundVHE.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_SurroundVHE_CheckedChanged);
            // 
            // Freestyle_groupBox_Convolver
            // 
            this.Freestyle_groupBox_Convolver.Controls.Add(this.Freestyle_irShape_ConvIR);
            this.Freestyle_groupBox_Convolver.Controls.Add(this.Freestyle_onOffSwitch_Convolver);
            this.Freestyle_groupBox_Convolver.Controls.Add(this.Freestyle_hSlider_ConvIRGain);
            this.Freestyle_groupBox_Convolver.Controls.Add(this.Freestyle_openFileBox_ConvIRS);
            this.Freestyle_groupBox_Convolver.Controls.Add(this.Freestyle_label_ConvolverIRGain);
            this.Freestyle_groupBox_Convolver.Location = new System.Drawing.Point(235, 7);
            this.Freestyle_groupBox_Convolver.Name = "Freestyle_groupBox_Convolver";
            this.Freestyle_groupBox_Convolver.Size = new System.Drawing.Size(235, 194);
            this.Freestyle_groupBox_Convolver.TabIndex = 12;
            this.Freestyle_groupBox_Convolver.TabStop = false;
            this.Freestyle_groupBox_Convolver.Text = "$CONVOLVER";
            // 
            // Freestyle_irShape_ConvIR
            // 
            this.Freestyle_irShape_ConvIR.Location = new System.Drawing.Point(13, 66);
            this.Freestyle_irShape_ConvIR.Name = "Freestyle_irShape_ConvIR";
            this.Freestyle_irShape_ConvIR.ShapeBackColor = System.Drawing.Color.White;
            this.Freestyle_irShape_ConvIR.ShapeForeColor = System.Drawing.Color.Black;
            this.Freestyle_irShape_ConvIR.Size = new System.Drawing.Size(209, 68);
            this.Freestyle_irShape_ConvIR.TabIndex = 8;
            // 
            // Freestyle_onOffSwitch_Convolver
            // 
            this.Freestyle_onOffSwitch_Convolver.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Convolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_onOffSwitch_Convolver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_onOffSwitch_Convolver.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_onOffSwitch_Convolver.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_onOffSwitch_Convolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Freestyle_onOffSwitch_Convolver.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_onOffSwitch_Convolver.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Convolver.Name = "Freestyle_onOffSwitch_Convolver";
            this.Freestyle_onOffSwitch_Convolver.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Convolver.SwitchColor = System.Drawing.Color.White;
            this.Freestyle_onOffSwitch_Convolver.TabIndex = 5;
            this.Freestyle_onOffSwitch_Convolver.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.Freestyle_onOffSwitch_Convolver_CheckedChanged);
            // 
            // Freestyle_hSlider_ConvIRGain
            // 
            this.Freestyle_hSlider_ConvIRGain.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ConvIRGain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_ConvIRGain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_ConvIRGain.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_ConvIRGain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ConvIRGain.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_ConvIRGain.Location = new System.Drawing.Point(85, 34);
            this.Freestyle_hSlider_ConvIRGain.Name = "Freestyle_hSlider_ConvIRGain";
            this.Freestyle_hSlider_ConvIRGain.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_ConvIRGain.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_ConvIRGain.Size = new System.Drawing.Size(137, 26);
            this.Freestyle_hSlider_ConvIRGain.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_ConvIRGain.TabIndex = 7;
            this.Freestyle_hSlider_ConvIRGain.Value = 0;
            this.Freestyle_hSlider_ConvIRGain.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_ConvIRGain_Scroll);
            // 
            // Freestyle_openFileBox_ConvIRS
            // 
            this.Freestyle_openFileBox_ConvIRS.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_openFileBox_ConvIRS.FilePathName = "";
            this.Freestyle_openFileBox_ConvIRS.Location = new System.Drawing.Point(13, 147);
            this.Freestyle_openFileBox_ConvIRS.Name = "Freestyle_openFileBox_ConvIRS";
            this.Freestyle_openFileBox_ConvIRS.Size = new System.Drawing.Size(209, 31);
            this.Freestyle_openFileBox_ConvIRS.TabIndex = 9;
            this.Freestyle_openFileBox_ConvIRS.FileChangeNotify += new ViPER4WindowsBin.UIControls.OpenFileBox.FileChangeEventDelegate(this.Freestyle_openFileBox_ConvIRS_FileChangeNotify);
            // 
            // Freestyle_label_ConvolverIRGain
            // 
            this.Freestyle_label_ConvolverIRGain.AutoSize = true;
            this.Freestyle_label_ConvolverIRGain.Location = new System.Drawing.Point(95, 17);
            this.Freestyle_label_ConvolverIRGain.Name = "Freestyle_label_ConvolverIRGain";
            this.Freestyle_label_ConvolverIRGain.Size = new System.Drawing.Size(120, 13);
            this.Freestyle_label_ConvolverIRGain.TabIndex = 6;
            this.Freestyle_label_ConvolverIRGain.Text = "$CONV_IR_GAIN : 0dB";
            // 
            // Freestyle_hSlider_PostVolume
            // 
            this.Freestyle_hSlider_PostVolume.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_PostVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_PostVolume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_PostVolume.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_PostVolume.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_PostVolume.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_PostVolume.Location = new System.Drawing.Point(21, 128);
            this.Freestyle_hSlider_PostVolume.Name = "Freestyle_hSlider_PostVolume";
            this.Freestyle_hSlider_PostVolume.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_PostVolume.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_PostVolume.Size = new System.Drawing.Size(208, 42);
            this.Freestyle_hSlider_PostVolume.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_PostVolume.TabIndex = 3;
            this.Freestyle_hSlider_PostVolume.Value = 0;
            this.Freestyle_hSlider_PostVolume.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_PostVolume_Scroll);
            // 
            // Freestyle_label_PostVolume
            // 
            this.Freestyle_label_PostVolume.AutoSize = true;
            this.Freestyle_label_PostVolume.Location = new System.Drawing.Point(40, 108);
            this.Freestyle_label_PostVolume.Name = "Freestyle_label_PostVolume";
            this.Freestyle_label_PostVolume.Size = new System.Drawing.Size(121, 13);
            this.Freestyle_label_PostVolume.TabIndex = 2;
            this.Freestyle_label_PostVolume.Text = "$POST_VOLUME : 0dB";
            // 
            // Freestyle_hSlider_PreVolume
            // 
            this.Freestyle_hSlider_PreVolume.BackColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_PreVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Freestyle_hSlider_PreVolume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Freestyle_hSlider_PreVolume.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.Freestyle_hSlider_PreVolume.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_PreVolume.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Freestyle_hSlider_PreVolume.Location = new System.Drawing.Point(21, 42);
            this.Freestyle_hSlider_PreVolume.Name = "Freestyle_hSlider_PreVolume";
            this.Freestyle_hSlider_PreVolume.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Freestyle_hSlider_PreVolume.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Freestyle_hSlider_PreVolume.Size = new System.Drawing.Size(208, 40);
            this.Freestyle_hSlider_PreVolume.SliderColor = System.Drawing.Color.White;
            this.Freestyle_hSlider_PreVolume.TabIndex = 1;
            this.Freestyle_hSlider_PreVolume.Value = 0;
            this.Freestyle_hSlider_PreVolume.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.Freestyle_hSlider_PreVolume_Scroll);
            // 
            // Freestyle_label_PreVolume
            // 
            this.Freestyle_label_PreVolume.AutoSize = true;
            this.Freestyle_label_PreVolume.Location = new System.Drawing.Point(40, 23);
            this.Freestyle_label_PreVolume.Name = "Freestyle_label_PreVolume";
            this.Freestyle_label_PreVolume.Size = new System.Drawing.Size(114, 13);
            this.Freestyle_label_PreVolume.TabIndex = 0;
            this.Freestyle_label_PreVolume.Text = "$PRE_VOLUME : 0dB";
            // 
            // label_Copyright
            // 
            this.label_Copyright.Location = new System.Drawing.Point(472, 654);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(555, 25);
            this.label_Copyright.TabIndex = 6;
            this.label_Copyright.Text = "$COPYRIGHT";
            this.label_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.contextMenuStrip_TrayMenu;
            this.notifyIcon_Main.Text = "ViPER4Windows";
            this.notifyIcon_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Main_MouseUp);
            // 
            // contextMenuStrip_TrayMenu
            // 
            this.contextMenuStrip_TrayMenu.Name = "contextMenuStrip_TrayMenu";
            this.contextMenuStrip_TrayMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // loadPreset
            // 
            this.loadPreset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.loadPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.loadPreset.BeforeTouchSize = new System.Drawing.Size(164, 23);
            this.loadPreset.IsBackStageButton = false;
            this.loadPreset.Location = new System.Drawing.Point(16, 78);
            this.loadPreset.Name = "loadPreset";
            this.loadPreset.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.loadPreset.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.loadPreset.Size = new System.Drawing.Size(164, 23);
            this.loadPreset.TabIndex = 9;
            this.loadPreset.Text = "$LOAD_PRESET";
            this.loadPreset.ThemeName = "Office2016Colorful";
            this.loadPreset.UseVisualStyle = true;
            this.loadPreset.Click += new System.EventHandler(this.Load_Click);
            // 
            // onOffSwitch_Master
            // 
            this.onOffSwitch_Master.AutoStyle = false;
            this.onOffSwitch_Master.BackColor = System.Drawing.Color.White;
            this.onOffSwitch_Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_Master.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_Master.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_Master.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_Master.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_Master.ForeColor = System.Drawing.Color.Black;
            this.onOffSwitch_Master.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_Master.Location = new System.Drawing.Point(143, 46);
            this.onOffSwitch_Master.Name = "onOffSwitch_Master";
            this.onOffSwitch_Master.Size = new System.Drawing.Size(37, 19);
            this.onOffSwitch_Master.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_Master.TabIndex = 11;
            this.onOffSwitch_Master.Text = "metroSwitch1";
            this.onOffSwitch_Master.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.MetroSwitch1_CheckedChanged);
            // 
            // savePreset
            // 
            this.savePreset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.savePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.savePreset.BeforeTouchSize = new System.Drawing.Size(164, 23);
            this.savePreset.IsBackStageButton = false;
            this.savePreset.Location = new System.Drawing.Point(16, 105);
            this.savePreset.Name = "savePreset";
            this.savePreset.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.savePreset.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.savePreset.Size = new System.Drawing.Size(164, 23);
            this.savePreset.TabIndex = 12;
            this.savePreset.Text = "$SAVE_PRESET";
            this.savePreset.ThemeName = "Office2016Colorful";
            this.savePreset.UseVisualStyle = true;
            this.savePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // Freestyle_singleButton_Compressor
            // 
            this.Freestyle_singleButton_Compressor.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.Freestyle_singleButton_Compressor.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_singleButton_Compressor.BeforeTouchSize = new System.Drawing.Size(164, 29);
            this.Freestyle_singleButton_Compressor.IsBackStageButton = false;
            this.Freestyle_singleButton_Compressor.Location = new System.Drawing.Point(16, 174);
            this.Freestyle_singleButton_Compressor.Name = "Freestyle_singleButton_Compressor";
            this.Freestyle_singleButton_Compressor.Size = new System.Drawing.Size(164, 29);
            this.Freestyle_singleButton_Compressor.TabIndex = 21;
            this.Freestyle_singleButton_Compressor.Text = "$COMPRESSOR_ADJUST";
            this.Freestyle_singleButton_Compressor.ThemeName = "Office2016Colorful";
            this.Freestyle_singleButton_Compressor.UseVisualStyle = true;
            this.Freestyle_singleButton_Compressor.Click += new System.EventHandler(this.Freestyle_singleButton_Compressor_Click);
            // 
            // Freestyle_singleButton_Equalizer
            // 
            this.Freestyle_singleButton_Equalizer.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.Freestyle_singleButton_Equalizer.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_singleButton_Equalizer.BeforeTouchSize = new System.Drawing.Size(164, 29);
            this.Freestyle_singleButton_Equalizer.IsBackStageButton = false;
            this.Freestyle_singleButton_Equalizer.Location = new System.Drawing.Point(16, 141);
            this.Freestyle_singleButton_Equalizer.Name = "Freestyle_singleButton_Equalizer";
            this.Freestyle_singleButton_Equalizer.Size = new System.Drawing.Size(164, 29);
            this.Freestyle_singleButton_Equalizer.TabIndex = 20;
            this.Freestyle_singleButton_Equalizer.Text = "$EQUALIZER_ADJUST";
            this.Freestyle_singleButton_Equalizer.ThemeName = "Office2016Colorful";
            this.Freestyle_singleButton_Equalizer.UseVisualStyle = true;
            this.Freestyle_singleButton_Equalizer.Click += new System.EventHandler(this.Freestyle_singleButton_Equalizer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 686);
            this.Controls.Add(this.savePreset);
            this.Controls.Add(this.Freestyle_singleButton_Compressor);
            this.Controls.Add(this.Freestyle_singleButton_Equalizer);
            this.Controls.Add(this.onOffSwitch_Master);
            this.Controls.Add(this.loadPreset);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.groupBox_Main);
            this.Controls.Add(this.label_MasterPower);
            this.Controls.Add(this.menuStrip_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViPER4Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_Main.ResumeLayout(false);
            this.panel_Freestyle.ResumeLayout(false);
            this.panel_Freestyle.PerformLayout();
            this.Freestyle_groupBox_SmartVolume.ResumeLayout(false);
            this.Freestyle_groupBox_SmartVolume.PerformLayout();
            this.Freestyle_groupBox_3DSurround.ResumeLayout(false);
            this.Freestyle_groupBox_3DSurround.PerformLayout();
            this.Freestyle_groupBox_Reverb.ResumeLayout(false);
            this.Freestyle_groupBox_Reverb.PerformLayout();
            this.Freestyle_groupBox_Cure.ResumeLayout(false);
            this.Freestyle_groupBox_Cure.PerformLayout();
            this.Freestyle_groupBox_Clarity.ResumeLayout(false);
            this.Freestyle_groupBox_Clarity.PerformLayout();
            this.Freestyle_groupBox_Bass.ResumeLayout(false);
            this.Freestyle_groupBox_Bass.PerformLayout();
            this.Freestyle_groupBox_VHESurround.ResumeLayout(false);
            this.Freestyle_groupBox_Convolver.ResumeLayout(false);
            this.Freestyle_groupBox_Convolver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x040000AD RID: 173
        private global::System.ComponentModel.IContainer components;

        // Token: 0x040000AF RID: 175
        private global::System.Windows.Forms.Label label_MasterPower;

        // Token: 0x040000B2 RID: 178
        private global::System.Windows.Forms.MenuStrip menuStrip_Main;

        // Token: 0x040000B3 RID: 179
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Language;

        // Token: 0x040000B4 RID: 180
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Setting;

        // Token: 0x040000B8 RID: 184
        private global::System.Windows.Forms.GroupBox groupBox_Main;

        // Token: 0x040000B9 RID: 185
        private global::System.Windows.Forms.Label label_Copyright;

        // Token: 0x040000BA RID: 186
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LatencySetting;

        // Token: 0x040000BB RID: 187
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ResetEffect;

        // Token: 0x040000BD RID: 189
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ChannelPan;



        // Token: 0x0400012A RID: 298
        private global::System.Windows.Forms.Panel panel_Freestyle;

        // Token: 0x0400012B RID: 299
        private global::Syncfusion.Windows.Forms.ButtonAdv Freestyle_singleButton_Compressor;

        // Token: 0x0400012C RID: 300
        private global::Syncfusion.Windows.Forms.ButtonAdv Freestyle_singleButton_Equalizer;

        // Token: 0x0400012D RID: 301
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Reverb;

        // Token: 0x0400012E RID: 302
        private global::Syncfusion.Windows.Forms.ButtonAdv Freestyle_singleButton_ReverbPreset;

        // Token: 0x0400012F RID: 303
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbMix;

        // Token: 0x04000130 RID: 304
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Mix;

        // Token: 0x04000131 RID: 305
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbEarlyMix;

        // Token: 0x04000132 RID: 306
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_EarlyMix;

        // Token: 0x04000133 RID: 307
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbPreDelay;

        // Token: 0x04000134 RID: 308
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_PreDelay;

        // Token: 0x04000135 RID: 309
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbDecay;

        // Token: 0x04000136 RID: 310
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Decay;

        // Token: 0x04000137 RID: 311
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbBandWidth;

        // Token: 0x04000138 RID: 312
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_BandWidth;

        // Token: 0x04000139 RID: 313
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbDensity;

        // Token: 0x0400013A RID: 314
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Density;

        // Token: 0x0400013B RID: 315
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbDamping;

        // Token: 0x0400013C RID: 316
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Damping;

        // Token: 0x0400013D RID: 317
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ReverbSize;

        // Token: 0x0400013E RID: 318
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Size;

        // Token: 0x0400013F RID: 319
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Reverb;

        // Token: 0x04000140 RID: 320
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Cure;

        // Token: 0x04000141 RID: 321
        private global::System.Windows.Forms.ListBox Freestyle_buttonBox_CureLevel;

        // Token: 0x04000142 RID: 322
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Cure;

        // Token: 0x04000143 RID: 323
        private global::System.Windows.Forms.Label Freestyle_label_Tube;

        // Token: 0x04000144 RID: 324
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Tube;

        // Token: 0x04000145 RID: 325
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Clarity;

        // Token: 0x04000146 RID: 326
        private global::System.Windows.Forms.ListBox Freestyle_buttonBox_ClarityMode;

        // Token: 0x04000147 RID: 327
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_Clarity;

        // Token: 0x04000148 RID: 328
        private global::System.Windows.Forms.Label Freestyle_label_Clarity;

        // Token: 0x04000149 RID: 329
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Clarity;

        // Token: 0x0400014A RID: 330
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Bass;

        // Token: 0x0400014B RID: 331
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_BassGain;

        // Token: 0x0400014C RID: 332
        private global::System.Windows.Forms.Label Freestyle_label_Bass_Gain;

        // Token: 0x0400014D RID: 333
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_BassSpkSize;

        // Token: 0x0400014E RID: 334
        private global::System.Windows.Forms.Label Freestyle_label_Bass_SpkSize;

        // Token: 0x0400014F RID: 335
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Bass;

        // Token: 0x04000150 RID: 336
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_VHESurround;

        // Token: 0x04000151 RID: 337
        private global::System.Windows.Forms.ListBox Freestyle_buttonBox_SurroundVHERoomSize;

        // Token: 0x04000152 RID: 338
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_SurroundVHE;

        // Token: 0x04000153 RID: 339
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Convolver;

        // Token: 0x04000154 RID: 340
        private global::ViPER4WindowsBin.UIControls.IRShape Freestyle_irShape_ConvIR;

        // Token: 0x04000155 RID: 341
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Convolver;

        // Token: 0x04000156 RID: 342
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_ConvIRGain;

        // Token: 0x04000157 RID: 343
        private global::ViPER4WindowsBin.UIControls.OpenFileBox Freestyle_openFileBox_ConvIRS;

        // Token: 0x04000158 RID: 344
        private global::System.Windows.Forms.Label Freestyle_label_ConvolverIRGain;

        // Token: 0x04000159 RID: 345
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_PostVolume;

        // Token: 0x0400015A RID: 346
        private global::System.Windows.Forms.Label Freestyle_label_PostVolume;

        // Token: 0x0400015B RID: 347
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_PreVolume;

        // Token: 0x0400015C RID: 348
        private global::System.Windows.Forms.Label Freestyle_label_PreVolume;

        // Token: 0x0400015D RID: 349
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_3DSurround;

        // Token: 0x0400015E RID: 350
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_SurroundImage;

        // Token: 0x0400015F RID: 351
        private global::System.Windows.Forms.Label Freestyle_label_Surround_Image;

        // Token: 0x04000160 RID: 352
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_Surround3D;

        // Token: 0x04000161 RID: 353
        private global::System.Windows.Forms.Label Freestyle_label_Surround_3D;

        // Token: 0x04000162 RID: 354
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_Surround3D;

        // Token: 0x04000163 RID: 355
        private global::System.Windows.Forms.ListBox Freestyle_buttonBox_BassMode;

        // Token: 0x04000164 RID: 356
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_SmartVolume;

        // Token: 0x04000165 RID: 357
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_SmartVolumeLevel;

        // Token: 0x04000166 RID: 358
        private global::System.Windows.Forms.Label Freestyle_label_SmartVolume_Level;

        // Token: 0x04000167 RID: 359
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_SmartVolumeMaxLevel;

        // Token: 0x04000168 RID: 360
        private global::System.Windows.Forms.Label Freestyle_label_SmartVolume_MaxLevel;

        // Token: 0x04000169 RID: 361
        private global::MetroSuite.MetroTrackbar Freestyle_hSlider_SmartVolumeRatio;

        // Token: 0x0400016A RID: 362
        private global::System.Windows.Forms.Label Freestyle_label_SmartVolume_ControlStrength;

        // Token: 0x0400016B RID: 363
        private global::MetroSuite.MetroSwitch Freestyle_onOffSwitch_SmartVolume;

        // Token: 0x0400016C RID: 364
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Virtualization;

        // Token: 0x0400016D RID: 365
        private global::System.Windows.Forms.NotifyIcon notifyIcon_Main;

        // Token: 0x0400016E RID: 366
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;

        // Token: 0x0400016F RID: 367
        private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip_TrayMenu;
        private Syncfusion.Windows.Forms.ButtonAdv loadPreset;
        private MetroSuite.MetroSwitch onOffSwitch_Master;
        private Syncfusion.Windows.Forms.ButtonAdv savePreset;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
    }
}
