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
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_AboutV4W = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.panel_Freestyle = new System.Windows.Forms.Panel();
            this.Freestyle_groupBox_SmartVolume = new System.Windows.Forms.GroupBox();
            this.Freestyle_hSlider_SmartVolumeLevel = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_SmartVolume_Level = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_SmartVolumeMaxLevel = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_SmartVolume_MaxLevel = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_SmartVolumeRatio = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_SmartVolume_ControlStrength = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_SmartVolume = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_groupBox_3DSurround = new System.Windows.Forms.GroupBox();
            this.Freestyle_hSlider_SurroundImage = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Surround_Image = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_Surround3D = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Surround_3D = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Surround3D = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_singleButton_Compressor = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Freestyle_singleButton_Equalizer = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Freestyle_groupBox_Reverb = new System.Windows.Forms.GroupBox();
            this.Freestyle_singleButton_ReverbPreset = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Freestyle_hSlider_ReverbMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_Mix = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbEarlyMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_EarlyMix = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbPreDelay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_PreDelay = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbDecay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_Decay = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbBandWidth = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_BandWidth = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbDensity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_Density = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbDamping = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_Damping = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_ReverbSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Reverb_Size = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Reverb = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_groupBox_Cure = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_CureLevel = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Freestyle_onOffSwitch_Cure = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_label_Tube = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Tube = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_groupBox_Clarity = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_ClarityMode = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Freestyle_hSlider_Clarity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Clarity = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Clarity = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_groupBox_Bass = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_BassMode = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Freestyle_hSlider_BassGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Bass_Gain = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_BassSpkSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_Bass_SpkSize = new System.Windows.Forms.Label();
            this.Freestyle_onOffSwitch_Bass = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_groupBox_VHESurround = new System.Windows.Forms.GroupBox();
            this.Freestyle_buttonBox_SurroundVHERoomSize = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Freestyle_onOffSwitch_SurroundVHE = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_groupBox_Convolver = new System.Windows.Forms.GroupBox();
            this.Freestyle_irShape_ConvIR = new ViPER4WindowsBin.UIControls.IRShape();
            this.Freestyle_onOffSwitch_Convolver = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Freestyle_hSlider_ConvIRGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_openFileBox_ConvIRS = new ViPER4WindowsBin.UIControls.OpenFileBox();
            this.Freestyle_label_ConvolverIRGain = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_PostVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_PostVolume = new System.Windows.Forms.Label();
            this.Freestyle_hSlider_PreVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Freestyle_label_PreVolume = new System.Windows.Forms.Label();
            this.panel_MusicMode = new System.Windows.Forms.Panel();
            this.panel_MovieMode = new System.Windows.Forms.Panel();
            this.Movie_groupBox_SmartVolume = new System.Windows.Forms.GroupBox();
            this.Movie_hSlider_SmartVolumeLevel = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_SmartVolume_Level = new System.Windows.Forms.Label();
            this.Movie_hSlider_SmartVolumeMaxLevel = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_SmartVolume_MaxLevel = new System.Windows.Forms.Label();
            this.Movie_hSlider_SmartVolumeRatio = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_SmartVolume_ControlStrength = new System.Windows.Forms.Label();
            this.Movie_onOffSwitch_SmartVolume = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Movie_singleButton_Compressor = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Movie_singleButton_Equalizer = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Movie_groupBox_Reverb = new System.Windows.Forms.GroupBox();
            this.Movie_singleButton_ReverbPreset = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Movie_hSlider_ReverbMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_Mix = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbEarlyMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_EarlyMix = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbPreDelay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_PreDelay = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbDecay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_Decay = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbBandWidth = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_BandWidth = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbDensity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_Density = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbDamping = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_Damping = new System.Windows.Forms.Label();
            this.Movie_hSlider_ReverbSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Reverb_Size = new System.Windows.Forms.Label();
            this.Movie_onOffSwitch_Reverb = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Movie_groupBox_Clarity = new System.Windows.Forms.GroupBox();
            this.Movie_hSlider_Clarity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Clarity = new System.Windows.Forms.Label();
            this.Movie_onOffSwitch_Clarity = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Movie_groupBox_Bass = new System.Windows.Forms.GroupBox();
            this.Movie_hSlider_BassGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Bass_Gain = new System.Windows.Forms.Label();
            this.Movie_hSlider_BassSpkSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Bass_SpkSize = new System.Windows.Forms.Label();
            this.Movie_onOffSwitch_Bass = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Movie_groupBox_Surround = new System.Windows.Forms.GroupBox();
            this.Movie_hSlider_SurroundImage = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Surround_Image = new System.Windows.Forms.Label();
            this.Movie_hSlider_Surround3D = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_Surround_3D = new System.Windows.Forms.Label();
            this.Movie_onOffSwitch_Surround = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Movie_groupBox_Convolver = new System.Windows.Forms.GroupBox();
            this.Movie_irShape_ConvIR = new ViPER4WindowsBin.UIControls.IRShape();
            this.Movie_onOffSwitch_Convolver = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Movie_hSlider_ConvIRGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_openFileBox_ConvIRS = new ViPER4WindowsBin.UIControls.OpenFileBox();
            this.Movie_label_ConvolverIRGain = new System.Windows.Forms.Label();
            this.Movie_hSlider_PostVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_PostVolume = new System.Windows.Forms.Label();
            this.Movie_hSlider_PreVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Movie_label_PreVolume = new System.Windows.Forms.Label();
            this.Music_singleButton_Compressor = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Music_singleButton_Equalizer = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Music_groupBox_Reverb = new System.Windows.Forms.GroupBox();
            this.Music_singleButton_ReverbPreset = new ViPER4WindowsBin.UIControls.SingleButton();
            this.Music_hSlider_ReverbMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_Mix = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbEarlyMix = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_EarlyMix = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbPreDelay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_PreDelay = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbDecay = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_Decay = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbBandWidth = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_BandWidth = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbDensity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_Density = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbDamping = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_Damping = new System.Windows.Forms.Label();
            this.Music_hSlider_ReverbSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Reverb_Size = new System.Windows.Forms.Label();
            this.Music_onOffSwitch_Reverb = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_groupBox_Cure = new System.Windows.Forms.GroupBox();
            this.Music_buttonBox_CureLevel = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Music_onOffSwitch_Cure = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_label_Tube = new System.Windows.Forms.Label();
            this.Music_onOffSwitch_Tube = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_groupBox_Clarity = new System.Windows.Forms.GroupBox();
            this.Music_buttonBox_ClarityMode = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Music_hSlider_Clarity = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Clarity = new System.Windows.Forms.Label();
            this.Music_onOffSwitch_Clarity = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_groupBox_Bass = new System.Windows.Forms.GroupBox();
            this.Music_hSlider_BassGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Bass_Gain = new System.Windows.Forms.Label();
            this.Music_hSlider_BassSpkSize = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_Bass_SpkSize = new System.Windows.Forms.Label();
            this.Music_onOffSwitch_Bass = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_groupBox_Surround = new System.Windows.Forms.GroupBox();
            this.Music_buttonBox_SurroundRoomSize = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.Music_onOffSwitch_Surround = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_groupBox_Convolver = new System.Windows.Forms.GroupBox();
            this.Music_irShape_ConvIR = new ViPER4WindowsBin.UIControls.IRShape();
            this.Music_onOffSwitch_Convolver = new ViPER4WindowsBin.UIControls.OnOffSwitch();
            this.Music_hSlider_ConvIRGain = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_openFileBox_ConvIRS = new ViPER4WindowsBin.UIControls.OpenFileBox();
            this.Music_label_ConvolverIRGain = new System.Windows.Forms.Label();
            this.Music_hSlider_PostVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_PostVolume = new System.Windows.Forms.Label();
            this.Music_hSlider_PreVolume = new ViPER4WindowsBin.UIControls.HSlider();
            this.Music_label_PreVolume = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPreset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.onOffSwitch_Master = new MetroSuite.MetroSwitch();
            this.buttonBox_Mode = new ViPER4WindowsBin.UIControls.ButtonBox();
            this.savePreset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
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
            this.panel_MusicMode.SuspendLayout();
            this.panel_MovieMode.SuspendLayout();
            this.Movie_groupBox_SmartVolume.SuspendLayout();
            this.Movie_groupBox_Reverb.SuspendLayout();
            this.Movie_groupBox_Clarity.SuspendLayout();
            this.Movie_groupBox_Bass.SuspendLayout();
            this.Movie_groupBox_Surround.SuspendLayout();
            this.Movie_groupBox_Convolver.SuspendLayout();
            this.Music_groupBox_Reverb.SuspendLayout();
            this.Music_groupBox_Cure.SuspendLayout();
            this.Music_groupBox_Clarity.SuspendLayout();
            this.Music_groupBox_Bass.SuspendLayout();
            this.Music_groupBox_Surround.SuspendLayout();
            this.Music_groupBox_Convolver.SuspendLayout();
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
            this.toolStripMenuItem_Setting,
            this.toolStripMenuItem_Help});
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
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_CheckUpdate,
            this.toolStripMenuItem_AboutV4W});
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem_Help.Text = "$MENU_HELP";
            // 
            // toolStripMenuItem_CheckUpdate
            // 
            this.toolStripMenuItem_CheckUpdate.Name = "toolStripMenuItem_CheckUpdate";
            this.toolStripMenuItem_CheckUpdate.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem_CheckUpdate.Text = "$CHECK_UPDATE";
            this.toolStripMenuItem_CheckUpdate.Click += new System.EventHandler(this.toolStripMenuItem_CheckUpdate_Click);
            // 
            // toolStripMenuItem_AboutV4W
            // 
            this.toolStripMenuItem_AboutV4W.Name = "toolStripMenuItem_AboutV4W";
            this.toolStripMenuItem_AboutV4W.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem_AboutV4W.Text = "$ABOUT";
            this.toolStripMenuItem_AboutV4W.Click += new System.EventHandler(this.toolStripMenuItem_AboutV4W_Click);
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.panel_Freestyle);
            this.groupBox_Main.Controls.Add(this.panel_MusicMode);
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
            this.panel_Freestyle.Controls.Add(this.Freestyle_singleButton_Compressor);
            this.panel_Freestyle.Controls.Add(this.Freestyle_singleButton_Equalizer);
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
            this.Freestyle_hSlider_SmartVolumeLevel.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_SmartVolumeLevel.Location = new System.Drawing.Point(195, 92);
            this.Freestyle_hSlider_SmartVolumeLevel.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SmartVolumeLevel.Name = "Freestyle_hSlider_SmartVolumeLevel";
            this.Freestyle_hSlider_SmartVolumeLevel.Position = ((uint)(0u));
            this.Freestyle_hSlider_SmartVolumeLevel.PositionFloat = 0F;
            this.Freestyle_hSlider_SmartVolumeLevel.Size = new System.Drawing.Size(174, 42);
            this.Freestyle_hSlider_SmartVolumeLevel.TabIndex = 23;
            this.Freestyle_hSlider_SmartVolumeLevel.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SmartVolumeLevel_PositionChangeNotify);
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
            this.Freestyle_hSlider_SmartVolumeMaxLevel.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Location = new System.Drawing.Point(9, 125);
            this.Freestyle_hSlider_SmartVolumeMaxLevel.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Name = "Freestyle_hSlider_SmartVolumeMaxLevel";
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Position = ((uint)(0u));
            this.Freestyle_hSlider_SmartVolumeMaxLevel.PositionFloat = 0F;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_SmartVolumeMaxLevel.TabIndex = 21;
            this.Freestyle_hSlider_SmartVolumeMaxLevel.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SmartVolumeMaxLevel_PositionChangeNotify);
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
            this.Freestyle_hSlider_SmartVolumeRatio.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_SmartVolumeRatio.Location = new System.Drawing.Point(9, 79);
            this.Freestyle_hSlider_SmartVolumeRatio.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SmartVolumeRatio.Name = "Freestyle_hSlider_SmartVolumeRatio";
            this.Freestyle_hSlider_SmartVolumeRatio.Position = ((uint)(0u));
            this.Freestyle_hSlider_SmartVolumeRatio.PositionFloat = 0F;
            this.Freestyle_hSlider_SmartVolumeRatio.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_SmartVolumeRatio.TabIndex = 19;
            this.Freestyle_hSlider_SmartVolumeRatio.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SmartVolumeRatio_PositionChangeNotify);
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
            this.Freestyle_onOffSwitch_SmartVolume.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_SmartVolume.Name = "Freestyle_onOffSwitch_SmartVolume";
            this.Freestyle_onOffSwitch_SmartVolume.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_SmartVolume.SwitchedOn = false;
            this.Freestyle_onOffSwitch_SmartVolume.TabIndex = 17;
            this.Freestyle_onOffSwitch_SmartVolume.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_SmartVolume_SwitchChangeNotify);
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
            this.Freestyle_hSlider_SurroundImage.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_SurroundImage.Location = new System.Drawing.Point(6, 137);
            this.Freestyle_hSlider_SurroundImage.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_SurroundImage.Name = "Freestyle_hSlider_SurroundImage";
            this.Freestyle_hSlider_SurroundImage.Position = ((uint)(0u));
            this.Freestyle_hSlider_SurroundImage.PositionFloat = 0F;
            this.Freestyle_hSlider_SurroundImage.Size = new System.Drawing.Size(110, 26);
            this.Freestyle_hSlider_SurroundImage.TabIndex = 25;
            this.Freestyle_hSlider_SurroundImage.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_SurroundImage_PositionChangeNotify);
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
            this.Freestyle_hSlider_Surround3D.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_Surround3D.Location = new System.Drawing.Point(6, 91);
            this.Freestyle_hSlider_Surround3D.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_Surround3D.Name = "Freestyle_hSlider_Surround3D";
            this.Freestyle_hSlider_Surround3D.Position = ((uint)(0u));
            this.Freestyle_hSlider_Surround3D.PositionFloat = 0F;
            this.Freestyle_hSlider_Surround3D.Size = new System.Drawing.Size(110, 26);
            this.Freestyle_hSlider_Surround3D.TabIndex = 23;
            this.Freestyle_hSlider_Surround3D.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_Surround3D_PositionChangeNotify);
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
            this.Freestyle_onOffSwitch_Surround3D.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Surround3D.Name = "Freestyle_onOffSwitch_Surround3D";
            this.Freestyle_onOffSwitch_Surround3D.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Surround3D.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Surround3D.TabIndex = 6;
            this.Freestyle_onOffSwitch_Surround3D.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Surround3D_SwitchChangeNotify);
            // 
            // Freestyle_singleButton_Compressor
            // 
            this.Freestyle_singleButton_Compressor.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_singleButton_Compressor.ButtonText = "$COMPRESSOR_ADJUST";
            this.Freestyle_singleButton_Compressor.Location = new System.Drawing.Point(30, 542);
            this.Freestyle_singleButton_Compressor.Name = "Freestyle_singleButton_Compressor";
            this.Freestyle_singleButton_Compressor.Size = new System.Drawing.Size(174, 42);
            this.Freestyle_singleButton_Compressor.TabIndex = 21;
            this.Freestyle_singleButton_Compressor.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Freestyle_singleButton_Compressor_ButtonClickNotify);
            // 
            // Freestyle_singleButton_Equalizer
            // 
            this.Freestyle_singleButton_Equalizer.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_singleButton_Equalizer.ButtonText = "$EQUALIZER_ADJUST";
            this.Freestyle_singleButton_Equalizer.Location = new System.Drawing.Point(30, 493);
            this.Freestyle_singleButton_Equalizer.Name = "Freestyle_singleButton_Equalizer";
            this.Freestyle_singleButton_Equalizer.Size = new System.Drawing.Size(174, 42);
            this.Freestyle_singleButton_Equalizer.TabIndex = 20;
            this.Freestyle_singleButton_Equalizer.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Freestyle_singleButton_Equalizer_ButtonClickNotify);
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
            this.Freestyle_singleButton_ReverbPreset.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_singleButton_ReverbPreset.ButtonText = "$PRESET";
            this.Freestyle_singleButton_ReverbPreset.Location = new System.Drawing.Point(121, 15);
            this.Freestyle_singleButton_ReverbPreset.Name = "Freestyle_singleButton_ReverbPreset";
            this.Freestyle_singleButton_ReverbPreset.Size = new System.Drawing.Size(81, 31);
            this.Freestyle_singleButton_ReverbPreset.TabIndex = 36;
            this.Freestyle_singleButton_ReverbPreset.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Freestyle_singleButton_ReverbPreset_ButtonClickNotify);
            // 
            // Freestyle_hSlider_ReverbMix
            // 
            this.Freestyle_hSlider_ReverbMix.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbMix.Location = new System.Drawing.Point(24, 386);
            this.Freestyle_hSlider_ReverbMix.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbMix.Name = "Freestyle_hSlider_ReverbMix";
            this.Freestyle_hSlider_ReverbMix.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbMix.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbMix.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbMix.TabIndex = 35;
            this.Freestyle_hSlider_ReverbMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbMix_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbEarlyMix.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbEarlyMix.Location = new System.Drawing.Point(24, 340);
            this.Freestyle_hSlider_ReverbEarlyMix.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbEarlyMix.Name = "Freestyle_hSlider_ReverbEarlyMix";
            this.Freestyle_hSlider_ReverbEarlyMix.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbEarlyMix.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbEarlyMix.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbEarlyMix.TabIndex = 33;
            this.Freestyle_hSlider_ReverbEarlyMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbEarlyMix_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbPreDelay.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbPreDelay.Location = new System.Drawing.Point(24, 295);
            this.Freestyle_hSlider_ReverbPreDelay.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbPreDelay.Name = "Freestyle_hSlider_ReverbPreDelay";
            this.Freestyle_hSlider_ReverbPreDelay.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbPreDelay.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbPreDelay.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbPreDelay.TabIndex = 31;
            this.Freestyle_hSlider_ReverbPreDelay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbPreDelay_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbDecay.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbDecay.Location = new System.Drawing.Point(24, 249);
            this.Freestyle_hSlider_ReverbDecay.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbDecay.Name = "Freestyle_hSlider_ReverbDecay";
            this.Freestyle_hSlider_ReverbDecay.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbDecay.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbDecay.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbDecay.TabIndex = 29;
            this.Freestyle_hSlider_ReverbDecay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbDecay_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbBandWidth.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbBandWidth.Location = new System.Drawing.Point(24, 204);
            this.Freestyle_hSlider_ReverbBandWidth.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbBandWidth.Name = "Freestyle_hSlider_ReverbBandWidth";
            this.Freestyle_hSlider_ReverbBandWidth.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbBandWidth.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbBandWidth.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbBandWidth.TabIndex = 27;
            this.Freestyle_hSlider_ReverbBandWidth.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbBandWidth_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbDensity.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbDensity.Location = new System.Drawing.Point(24, 158);
            this.Freestyle_hSlider_ReverbDensity.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbDensity.Name = "Freestyle_hSlider_ReverbDensity";
            this.Freestyle_hSlider_ReverbDensity.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbDensity.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbDensity.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbDensity.TabIndex = 25;
            this.Freestyle_hSlider_ReverbDensity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbDensity_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbDamping.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbDamping.Location = new System.Drawing.Point(24, 113);
            this.Freestyle_hSlider_ReverbDamping.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbDamping.Name = "Freestyle_hSlider_ReverbDamping";
            this.Freestyle_hSlider_ReverbDamping.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbDamping.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbDamping.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbDamping.TabIndex = 23;
            this.Freestyle_hSlider_ReverbDamping.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbDamping_PositionChangeNotify);
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
            this.Freestyle_hSlider_ReverbSize.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ReverbSize.Location = new System.Drawing.Point(24, 69);
            this.Freestyle_hSlider_ReverbSize.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ReverbSize.Name = "Freestyle_hSlider_ReverbSize";
            this.Freestyle_hSlider_ReverbSize.Position = ((uint)(0u));
            this.Freestyle_hSlider_ReverbSize.PositionFloat = 0F;
            this.Freestyle_hSlider_ReverbSize.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_ReverbSize.TabIndex = 21;
            this.Freestyle_hSlider_ReverbSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ReverbSize_PositionChangeNotify);
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
            this.Freestyle_onOffSwitch_Reverb.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Reverb.Name = "Freestyle_onOffSwitch_Reverb";
            this.Freestyle_onOffSwitch_Reverb.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Reverb.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Reverb.TabIndex = 7;
            this.Freestyle_onOffSwitch_Reverb.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Reverb_SwitchChangeNotify);
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
            this.Freestyle_buttonBox_CureLevel.Location = new System.Drawing.Point(68, 18);
            this.Freestyle_buttonBox_CureLevel.Name = "Freestyle_buttonBox_CureLevel";
            this.Freestyle_buttonBox_CureLevel.Size = new System.Drawing.Size(106, 76);
            this.Freestyle_buttonBox_CureLevel.TabIndex = 18;
            this.Freestyle_buttonBox_CureLevel.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_CureLevel_ItemSelectedNotify);
            // 
            // Freestyle_onOffSwitch_Cure
            // 
            this.Freestyle_onOffSwitch_Cure.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_Cure.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Cure.Name = "Freestyle_onOffSwitch_Cure";
            this.Freestyle_onOffSwitch_Cure.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Cure.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Cure.TabIndex = 17;
            this.Freestyle_onOffSwitch_Cure.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Cure_SwitchChangeNotify);
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
            this.Freestyle_onOffSwitch_Tube.Location = new System.Drawing.Point(121, 114);
            this.Freestyle_onOffSwitch_Tube.Name = "Freestyle_onOffSwitch_Tube";
            this.Freestyle_onOffSwitch_Tube.Size = new System.Drawing.Size(53, 28);
            this.Freestyle_onOffSwitch_Tube.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Tube.TabIndex = 15;
            this.Freestyle_onOffSwitch_Tube.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Tube_SwitchChangeNotify);
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
            this.Freestyle_buttonBox_ClarityMode.Size = new System.Drawing.Size(106, 76);
            this.Freestyle_buttonBox_ClarityMode.TabIndex = 18;
            this.Freestyle_buttonBox_ClarityMode.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_ClarityMode_ItemSelectedNotify);
            // 
            // Freestyle_hSlider_Clarity
            // 
            this.Freestyle_hSlider_Clarity.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_Clarity.Location = new System.Drawing.Point(13, 125);
            this.Freestyle_hSlider_Clarity.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_Clarity.Name = "Freestyle_hSlider_Clarity";
            this.Freestyle_hSlider_Clarity.Position = ((uint)(0u));
            this.Freestyle_hSlider_Clarity.PositionFloat = 0F;
            this.Freestyle_hSlider_Clarity.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_Clarity.TabIndex = 21;
            this.Freestyle_hSlider_Clarity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_Clarity_PositionChangeNotify);
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
            this.Freestyle_onOffSwitch_Clarity.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Clarity.Name = "Freestyle_onOffSwitch_Clarity";
            this.Freestyle_onOffSwitch_Clarity.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Clarity.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Clarity.TabIndex = 17;
            this.Freestyle_onOffSwitch_Clarity.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Clarity_SwitchChangeNotify);
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
            this.Freestyle_groupBox_Bass.Size = new System.Drawing.Size(189, 242);
            this.Freestyle_groupBox_Bass.TabIndex = 16;
            this.Freestyle_groupBox_Bass.TabStop = false;
            this.Freestyle_groupBox_Bass.Text = "$BASS";
            // 
            // Freestyle_buttonBox_BassMode
            // 
            this.Freestyle_buttonBox_BassMode.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_buttonBox_BassMode.Location = new System.Drawing.Point(21, 163);
            this.Freestyle_buttonBox_BassMode.Name = "Freestyle_buttonBox_BassMode";
            this.Freestyle_buttonBox_BassMode.Size = new System.Drawing.Size(143, 66);
            this.Freestyle_buttonBox_BassMode.TabIndex = 22;
            this.Freestyle_buttonBox_BassMode.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_BassMode_ItemSelectedNotify);
            // 
            // Freestyle_hSlider_BassGain
            // 
            this.Freestyle_hSlider_BassGain.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_BassGain.Location = new System.Drawing.Point(13, 125);
            this.Freestyle_hSlider_BassGain.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_BassGain.Name = "Freestyle_hSlider_BassGain";
            this.Freestyle_hSlider_BassGain.Position = ((uint)(0u));
            this.Freestyle_hSlider_BassGain.PositionFloat = 0F;
            this.Freestyle_hSlider_BassGain.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_BassGain.TabIndex = 21;
            this.Freestyle_hSlider_BassGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_BassGain_PositionChangeNotify);
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
            this.Freestyle_hSlider_BassSpkSize.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_BassSpkSize.Location = new System.Drawing.Point(13, 79);
            this.Freestyle_hSlider_BassSpkSize.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_BassSpkSize.Name = "Freestyle_hSlider_BassSpkSize";
            this.Freestyle_hSlider_BassSpkSize.Position = ((uint)(0u));
            this.Freestyle_hSlider_BassSpkSize.PositionFloat = 0F;
            this.Freestyle_hSlider_BassSpkSize.Size = new System.Drawing.Size(161, 26);
            this.Freestyle_hSlider_BassSpkSize.TabIndex = 19;
            this.Freestyle_hSlider_BassSpkSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_BassSpkSize_PositionChangeNotify);
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
            this.Freestyle_onOffSwitch_Bass.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Bass.Name = "Freestyle_onOffSwitch_Bass";
            this.Freestyle_onOffSwitch_Bass.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Bass.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Bass.TabIndex = 17;
            this.Freestyle_onOffSwitch_Bass.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Bass_SwitchChangeNotify);
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
            this.Freestyle_buttonBox_SurroundVHERoomSize.Size = new System.Drawing.Size(127, 109);
            this.Freestyle_buttonBox_SurroundVHERoomSize.TabIndex = 7;
            this.Freestyle_buttonBox_SurroundVHERoomSize.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Freestyle_buttonBox_SurroundVHERoomSize_ItemSelectedNotify);
            // 
            // Freestyle_onOffSwitch_SurroundVHE
            // 
            this.Freestyle_onOffSwitch_SurroundVHE.BackColor = System.Drawing.Color.Transparent;
            this.Freestyle_onOffSwitch_SurroundVHE.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_SurroundVHE.Name = "Freestyle_onOffSwitch_SurroundVHE";
            this.Freestyle_onOffSwitch_SurroundVHE.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_SurroundVHE.SwitchedOn = false;
            this.Freestyle_onOffSwitch_SurroundVHE.TabIndex = 6;
            this.Freestyle_onOffSwitch_SurroundVHE.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_SurroundVHE_SwitchChangeNotify);
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
            this.Freestyle_onOffSwitch_Convolver.Location = new System.Drawing.Point(13, 25);
            this.Freestyle_onOffSwitch_Convolver.Name = "Freestyle_onOffSwitch_Convolver";
            this.Freestyle_onOffSwitch_Convolver.Size = new System.Drawing.Size(49, 22);
            this.Freestyle_onOffSwitch_Convolver.SwitchedOn = false;
            this.Freestyle_onOffSwitch_Convolver.TabIndex = 5;
            this.Freestyle_onOffSwitch_Convolver.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Freestyle_onOffSwitch_Convolver_SwitchChangeNotify);
            // 
            // Freestyle_hSlider_ConvIRGain
            // 
            this.Freestyle_hSlider_ConvIRGain.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_ConvIRGain.Location = new System.Drawing.Point(85, 34);
            this.Freestyle_hSlider_ConvIRGain.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_ConvIRGain.Name = "Freestyle_hSlider_ConvIRGain";
            this.Freestyle_hSlider_ConvIRGain.Position = ((uint)(0u));
            this.Freestyle_hSlider_ConvIRGain.PositionFloat = 0F;
            this.Freestyle_hSlider_ConvIRGain.Size = new System.Drawing.Size(137, 26);
            this.Freestyle_hSlider_ConvIRGain.TabIndex = 7;
            this.Freestyle_hSlider_ConvIRGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_ConvIRGain_PositionChangeNotify);
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
            this.Freestyle_hSlider_PostVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_PostVolume.Location = new System.Drawing.Point(21, 128);
            this.Freestyle_hSlider_PostVolume.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_PostVolume.Name = "Freestyle_hSlider_PostVolume";
            this.Freestyle_hSlider_PostVolume.Position = ((uint)(0u));
            this.Freestyle_hSlider_PostVolume.PositionFloat = 0F;
            this.Freestyle_hSlider_PostVolume.Size = new System.Drawing.Size(208, 42);
            this.Freestyle_hSlider_PostVolume.TabIndex = 3;
            this.Freestyle_hSlider_PostVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_PostVolume_PositionChangeNotify);
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
            this.Freestyle_hSlider_PreVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Freestyle_hSlider_PreVolume.Location = new System.Drawing.Point(21, 42);
            this.Freestyle_hSlider_PreVolume.MoveDelta = ((uint)(1u));
            this.Freestyle_hSlider_PreVolume.Name = "Freestyle_hSlider_PreVolume";
            this.Freestyle_hSlider_PreVolume.Position = ((uint)(0u));
            this.Freestyle_hSlider_PreVolume.PositionFloat = 0F;
            this.Freestyle_hSlider_PreVolume.Size = new System.Drawing.Size(208, 42);
            this.Freestyle_hSlider_PreVolume.TabIndex = 1;
            this.Freestyle_hSlider_PreVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Freestyle_hSlider_PreVolume_PositionChangeNotify);
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
            // panel_MusicMode
            // 
            this.panel_MusicMode.Controls.Add(this.panel_MovieMode);
            this.panel_MusicMode.Controls.Add(this.Music_singleButton_Compressor);
            this.panel_MusicMode.Controls.Add(this.Music_singleButton_Equalizer);
            this.panel_MusicMode.Controls.Add(this.Music_groupBox_Reverb);
            this.panel_MusicMode.Controls.Add(this.Music_groupBox_Cure);
            this.panel_MusicMode.Controls.Add(this.Music_groupBox_Clarity);
            this.panel_MusicMode.Controls.Add(this.Music_groupBox_Bass);
            this.panel_MusicMode.Controls.Add(this.Music_groupBox_Surround);
            this.panel_MusicMode.Controls.Add(this.Music_groupBox_Convolver);
            this.panel_MusicMode.Controls.Add(this.Music_hSlider_PostVolume);
            this.panel_MusicMode.Controls.Add(this.Music_label_PostVolume);
            this.panel_MusicMode.Controls.Add(this.Music_hSlider_PreVolume);
            this.panel_MusicMode.Controls.Add(this.Music_label_PreVolume);
            this.panel_MusicMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MusicMode.Location = new System.Drawing.Point(3, 16);
            this.panel_MusicMode.Name = "panel_MusicMode";
            this.panel_MusicMode.Size = new System.Drawing.Size(835, 601);
            this.panel_MusicMode.TabIndex = 0;
            // 
            // panel_MovieMode
            // 
            this.panel_MovieMode.Controls.Add(this.Movie_groupBox_SmartVolume);
            this.panel_MovieMode.Controls.Add(this.Movie_singleButton_Compressor);
            this.panel_MovieMode.Controls.Add(this.Movie_singleButton_Equalizer);
            this.panel_MovieMode.Controls.Add(this.Movie_groupBox_Reverb);
            this.panel_MovieMode.Controls.Add(this.Movie_groupBox_Clarity);
            this.panel_MovieMode.Controls.Add(this.Movie_groupBox_Bass);
            this.panel_MovieMode.Controls.Add(this.Movie_groupBox_Surround);
            this.panel_MovieMode.Controls.Add(this.Movie_groupBox_Convolver);
            this.panel_MovieMode.Controls.Add(this.Movie_hSlider_PostVolume);
            this.panel_MovieMode.Controls.Add(this.Movie_label_PostVolume);
            this.panel_MovieMode.Controls.Add(this.Movie_hSlider_PreVolume);
            this.panel_MovieMode.Controls.Add(this.Movie_label_PreVolume);
            this.panel_MovieMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MovieMode.Location = new System.Drawing.Point(0, 0);
            this.panel_MovieMode.Name = "panel_MovieMode";
            this.panel_MovieMode.Size = new System.Drawing.Size(835, 601);
            this.panel_MovieMode.TabIndex = 9;
            // 
            // Movie_groupBox_SmartVolume
            // 
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_hSlider_SmartVolumeLevel);
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_label_SmartVolume_Level);
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_hSlider_SmartVolumeMaxLevel);
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_label_SmartVolume_MaxLevel);
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_hSlider_SmartVolumeRatio);
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_label_SmartVolume_ControlStrength);
            this.Movie_groupBox_SmartVolume.Controls.Add(this.Movie_onOffSwitch_SmartVolume);
            this.Movie_groupBox_SmartVolume.Location = new System.Drawing.Point(21, 424);
            this.Movie_groupBox_SmartVolume.Name = "Movie_groupBox_SmartVolume";
            this.Movie_groupBox_SmartVolume.Size = new System.Drawing.Size(579, 160);
            this.Movie_groupBox_SmartVolume.TabIndex = 22;
            this.Movie_groupBox_SmartVolume.TabStop = false;
            this.Movie_groupBox_SmartVolume.Text = "$SMART_VOLUME";
            // 
            // Movie_hSlider_SmartVolumeLevel
            // 
            this.Movie_hSlider_SmartVolumeLevel.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_SmartVolumeLevel.Location = new System.Drawing.Point(254, 85);
            this.Movie_hSlider_SmartVolumeLevel.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_SmartVolumeLevel.Name = "Movie_hSlider_SmartVolumeLevel";
            this.Movie_hSlider_SmartVolumeLevel.Position = ((uint)(0u));
            this.Movie_hSlider_SmartVolumeLevel.PositionFloat = 0F;
            this.Movie_hSlider_SmartVolumeLevel.Size = new System.Drawing.Size(319, 42);
            this.Movie_hSlider_SmartVolumeLevel.TabIndex = 23;
            this.Movie_hSlider_SmartVolumeLevel.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_SmartVolumeLevel_PositionChangeNotify);
            // 
            // Movie_label_SmartVolume_Level
            // 
            this.Movie_label_SmartVolume_Level.AutoSize = true;
            this.Movie_label_SmartVolume_Level.Location = new System.Drawing.Point(273, 65);
            this.Movie_label_SmartVolume_Level.Name = "Movie_label_SmartVolume_Level";
            this.Movie_label_SmartVolume_Level.Size = new System.Drawing.Size(169, 13);
            this.Movie_label_SmartVolume_Level.TabIndex = 22;
            this.Movie_label_SmartVolume_Level.Text = "$SMART_VOLUME_LEVEL : 0dB";
            // 
            // Movie_hSlider_SmartVolumeMaxLevel
            // 
            this.Movie_hSlider_SmartVolumeMaxLevel.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_SmartVolumeMaxLevel.Location = new System.Drawing.Point(13, 125);
            this.Movie_hSlider_SmartVolumeMaxLevel.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_SmartVolumeMaxLevel.Name = "Movie_hSlider_SmartVolumeMaxLevel";
            this.Movie_hSlider_SmartVolumeMaxLevel.Position = ((uint)(0u));
            this.Movie_hSlider_SmartVolumeMaxLevel.PositionFloat = 0F;
            this.Movie_hSlider_SmartVolumeMaxLevel.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_SmartVolumeMaxLevel.TabIndex = 21;
            this.Movie_hSlider_SmartVolumeMaxLevel.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_SmartVolumeMaxLevel_PositionChangeNotify);
            // 
            // Movie_label_SmartVolume_MaxLevel
            // 
            this.Movie_label_SmartVolume_MaxLevel.AutoSize = true;
            this.Movie_label_SmartVolume_MaxLevel.Location = new System.Drawing.Point(23, 108);
            this.Movie_label_SmartVolume_MaxLevel.Name = "Movie_label_SmartVolume_MaxLevel";
            this.Movie_label_SmartVolume_MaxLevel.Size = new System.Drawing.Size(184, 13);
            this.Movie_label_SmartVolume_MaxLevel.TabIndex = 20;
            this.Movie_label_SmartVolume_MaxLevel.Text = "$SMART_VOLUME_MAXLEVEL : 1x";
            // 
            // Movie_hSlider_SmartVolumeRatio
            // 
            this.Movie_hSlider_SmartVolumeRatio.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_SmartVolumeRatio.Location = new System.Drawing.Point(13, 79);
            this.Movie_hSlider_SmartVolumeRatio.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_SmartVolumeRatio.Name = "Movie_hSlider_SmartVolumeRatio";
            this.Movie_hSlider_SmartVolumeRatio.Position = ((uint)(0u));
            this.Movie_hSlider_SmartVolumeRatio.PositionFloat = 0F;
            this.Movie_hSlider_SmartVolumeRatio.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_SmartVolumeRatio.TabIndex = 19;
            this.Movie_hSlider_SmartVolumeRatio.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_SmartVolumeRatio_PositionChangeNotify);
            // 
            // Movie_label_SmartVolume_ControlStrength
            // 
            this.Movie_label_SmartVolume_ControlStrength.AutoSize = true;
            this.Movie_label_SmartVolume_ControlStrength.Location = new System.Drawing.Point(23, 63);
            this.Movie_label_SmartVolume_ControlStrength.Name = "Movie_label_SmartVolume_ControlStrength";
            this.Movie_label_SmartVolume_ControlStrength.Size = new System.Drawing.Size(226, 13);
            this.Movie_label_SmartVolume_ControlStrength.TabIndex = 18;
            this.Movie_label_SmartVolume_ControlStrength.Text = "$SMART_VOLUME_CONTROL_STRENGTH";
            // 
            // Movie_onOffSwitch_SmartVolume
            // 
            this.Movie_onOffSwitch_SmartVolume.BackColor = System.Drawing.Color.Transparent;
            this.Movie_onOffSwitch_SmartVolume.Location = new System.Drawing.Point(13, 25);
            this.Movie_onOffSwitch_SmartVolume.Name = "Movie_onOffSwitch_SmartVolume";
            this.Movie_onOffSwitch_SmartVolume.Size = new System.Drawing.Size(49, 22);
            this.Movie_onOffSwitch_SmartVolume.SwitchedOn = false;
            this.Movie_onOffSwitch_SmartVolume.TabIndex = 17;
            this.Movie_onOffSwitch_SmartVolume.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Movie_onOffSwitch_SmartVolume_SwitchChangeNotify);
            // 
            // Movie_singleButton_Compressor
            // 
            this.Movie_singleButton_Compressor.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_singleButton_Compressor.ButtonText = "$COMPRESSOR_ADJUST";
            this.Movie_singleButton_Compressor.Location = new System.Drawing.Point(420, 326);
            this.Movie_singleButton_Compressor.Name = "Movie_singleButton_Compressor";
            this.Movie_singleButton_Compressor.Size = new System.Drawing.Size(174, 42);
            this.Movie_singleButton_Compressor.TabIndex = 21;
            this.Movie_singleButton_Compressor.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Movie_singleButton_Compressor_ButtonClickNotify);
            // 
            // Movie_singleButton_Equalizer
            // 
            this.Movie_singleButton_Equalizer.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_singleButton_Equalizer.ButtonText = "$EQUALIZER_ADJUST";
            this.Movie_singleButton_Equalizer.Location = new System.Drawing.Point(420, 265);
            this.Movie_singleButton_Equalizer.Name = "Movie_singleButton_Equalizer";
            this.Movie_singleButton_Equalizer.Size = new System.Drawing.Size(174, 42);
            this.Movie_singleButton_Equalizer.TabIndex = 20;
            this.Movie_singleButton_Equalizer.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Movie_singleButton_Equalizer_ButtonClickNotify);
            // 
            // Movie_groupBox_Reverb
            // 
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_singleButton_ReverbPreset);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbMix);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_Mix);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbEarlyMix);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_EarlyMix);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbPreDelay);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_PreDelay);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbDecay);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_Decay);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbBandWidth);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_BandWidth);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbDensity);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_Density);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbDamping);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_Damping);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_hSlider_ReverbSize);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_label_Reverb_Size);
            this.Movie_groupBox_Reverb.Controls.Add(this.Movie_onOffSwitch_Reverb);
            this.Movie_groupBox_Reverb.Location = new System.Drawing.Point(606, 163);
            this.Movie_groupBox_Reverb.Name = "Movie_groupBox_Reverb";
            this.Movie_groupBox_Reverb.Size = new System.Drawing.Size(208, 421);
            this.Movie_groupBox_Reverb.TabIndex = 19;
            this.Movie_groupBox_Reverb.TabStop = false;
            this.Movie_groupBox_Reverb.Text = "$REVERB";
            // 
            // Movie_singleButton_ReverbPreset
            // 
            this.Movie_singleButton_ReverbPreset.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_singleButton_ReverbPreset.ButtonText = "$PRESET";
            this.Movie_singleButton_ReverbPreset.Location = new System.Drawing.Point(121, 15);
            this.Movie_singleButton_ReverbPreset.Name = "Movie_singleButton_ReverbPreset";
            this.Movie_singleButton_ReverbPreset.Size = new System.Drawing.Size(81, 31);
            this.Movie_singleButton_ReverbPreset.TabIndex = 36;
            this.Movie_singleButton_ReverbPreset.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Movie_singleButton_ReverbPreset_ButtonClickNotify);
            // 
            // Movie_hSlider_ReverbMix
            // 
            this.Movie_hSlider_ReverbMix.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbMix.Location = new System.Drawing.Point(24, 386);
            this.Movie_hSlider_ReverbMix.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbMix.Name = "Movie_hSlider_ReverbMix";
            this.Movie_hSlider_ReverbMix.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbMix.PositionFloat = 0F;
            this.Movie_hSlider_ReverbMix.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbMix.TabIndex = 35;
            this.Movie_hSlider_ReverbMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbMix_PositionChangeNotify);
            // 
            // Movie_label_Reverb_Mix
            // 
            this.Movie_label_Reverb_Mix.AutoSize = true;
            this.Movie_label_Reverb_Mix.Location = new System.Drawing.Point(34, 369);
            this.Movie_label_Reverb_Mix.Name = "Movie_label_Reverb_Mix";
            this.Movie_label_Reverb_Mix.Size = new System.Drawing.Size(82, 13);
            this.Movie_label_Reverb_Mix.TabIndex = 34;
            this.Movie_label_Reverb_Mix.Text = "$REVERB_MIX";
            // 
            // Movie_hSlider_ReverbEarlyMix
            // 
            this.Movie_hSlider_ReverbEarlyMix.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbEarlyMix.Location = new System.Drawing.Point(24, 340);
            this.Movie_hSlider_ReverbEarlyMix.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbEarlyMix.Name = "Movie_hSlider_ReverbEarlyMix";
            this.Movie_hSlider_ReverbEarlyMix.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbEarlyMix.PositionFloat = 0F;
            this.Movie_hSlider_ReverbEarlyMix.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbEarlyMix.TabIndex = 33;
            this.Movie_hSlider_ReverbEarlyMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbEarlyMix_PositionChangeNotify);
            // 
            // Movie_label_Reverb_EarlyMix
            // 
            this.Movie_label_Reverb_EarlyMix.AutoSize = true;
            this.Movie_label_Reverb_EarlyMix.Location = new System.Drawing.Point(34, 324);
            this.Movie_label_Reverb_EarlyMix.Name = "Movie_label_Reverb_EarlyMix";
            this.Movie_label_Reverb_EarlyMix.Size = new System.Drawing.Size(117, 13);
            this.Movie_label_Reverb_EarlyMix.TabIndex = 32;
            this.Movie_label_Reverb_EarlyMix.Text = "$REVERB_EARLYMIX";
            // 
            // Movie_hSlider_ReverbPreDelay
            // 
            this.Movie_hSlider_ReverbPreDelay.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbPreDelay.Location = new System.Drawing.Point(24, 295);
            this.Movie_hSlider_ReverbPreDelay.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbPreDelay.Name = "Movie_hSlider_ReverbPreDelay";
            this.Movie_hSlider_ReverbPreDelay.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbPreDelay.PositionFloat = 0F;
            this.Movie_hSlider_ReverbPreDelay.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbPreDelay.TabIndex = 31;
            this.Movie_hSlider_ReverbPreDelay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbPreDelay_PositionChangeNotify);
            // 
            // Movie_label_Reverb_PreDelay
            // 
            this.Movie_label_Reverb_PreDelay.AutoSize = true;
            this.Movie_label_Reverb_PreDelay.Location = new System.Drawing.Point(34, 278);
            this.Movie_label_Reverb_PreDelay.Name = "Movie_label_Reverb_PreDelay";
            this.Movie_label_Reverb_PreDelay.Size = new System.Drawing.Size(120, 13);
            this.Movie_label_Reverb_PreDelay.TabIndex = 30;
            this.Movie_label_Reverb_PreDelay.Text = "$REVERB_PREDELAY";
            // 
            // Movie_hSlider_ReverbDecay
            // 
            this.Movie_hSlider_ReverbDecay.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbDecay.Location = new System.Drawing.Point(24, 249);
            this.Movie_hSlider_ReverbDecay.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbDecay.Name = "Movie_hSlider_ReverbDecay";
            this.Movie_hSlider_ReverbDecay.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbDecay.PositionFloat = 0F;
            this.Movie_hSlider_ReverbDecay.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbDecay.TabIndex = 29;
            this.Movie_hSlider_ReverbDecay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbDecay_PositionChangeNotify);
            // 
            // Movie_label_Reverb_Decay
            // 
            this.Movie_label_Reverb_Decay.AutoSize = true;
            this.Movie_label_Reverb_Decay.Location = new System.Drawing.Point(34, 233);
            this.Movie_label_Reverb_Decay.Name = "Movie_label_Reverb_Decay";
            this.Movie_label_Reverb_Decay.Size = new System.Drawing.Size(99, 13);
            this.Movie_label_Reverb_Decay.TabIndex = 28;
            this.Movie_label_Reverb_Decay.Text = "$REVERB_DECAY";
            // 
            // Movie_hSlider_ReverbBandWidth
            // 
            this.Movie_hSlider_ReverbBandWidth.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbBandWidth.Location = new System.Drawing.Point(24, 204);
            this.Movie_hSlider_ReverbBandWidth.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbBandWidth.Name = "Movie_hSlider_ReverbBandWidth";
            this.Movie_hSlider_ReverbBandWidth.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbBandWidth.PositionFloat = 0F;
            this.Movie_hSlider_ReverbBandWidth.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbBandWidth.TabIndex = 27;
            this.Movie_hSlider_ReverbBandWidth.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbBandWidth_PositionChangeNotify);
            // 
            // Movie_label_Reverb_BandWidth
            // 
            this.Movie_label_Reverb_BandWidth.AutoSize = true;
            this.Movie_label_Reverb_BandWidth.Location = new System.Drawing.Point(34, 187);
            this.Movie_label_Reverb_BandWidth.Name = "Movie_label_Reverb_BandWidth";
            this.Movie_label_Reverb_BandWidth.Size = new System.Drawing.Size(130, 13);
            this.Movie_label_Reverb_BandWidth.TabIndex = 26;
            this.Movie_label_Reverb_BandWidth.Text = "$REVERB_BANDWIDTH";
            // 
            // Movie_hSlider_ReverbDensity
            // 
            this.Movie_hSlider_ReverbDensity.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbDensity.Location = new System.Drawing.Point(24, 158);
            this.Movie_hSlider_ReverbDensity.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbDensity.Name = "Movie_hSlider_ReverbDensity";
            this.Movie_hSlider_ReverbDensity.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbDensity.PositionFloat = 0F;
            this.Movie_hSlider_ReverbDensity.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbDensity.TabIndex = 25;
            this.Movie_hSlider_ReverbDensity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbDensity_PositionChangeNotify);
            // 
            // Movie_label_Reverb_Density
            // 
            this.Movie_label_Reverb_Density.AutoSize = true;
            this.Movie_label_Reverb_Density.Location = new System.Drawing.Point(34, 142);
            this.Movie_label_Reverb_Density.Name = "Movie_label_Reverb_Density";
            this.Movie_label_Reverb_Density.Size = new System.Drawing.Size(110, 13);
            this.Movie_label_Reverb_Density.TabIndex = 24;
            this.Movie_label_Reverb_Density.Text = "$REVERB_DENSITY";
            // 
            // Movie_hSlider_ReverbDamping
            // 
            this.Movie_hSlider_ReverbDamping.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbDamping.Location = new System.Drawing.Point(24, 113);
            this.Movie_hSlider_ReverbDamping.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbDamping.Name = "Movie_hSlider_ReverbDamping";
            this.Movie_hSlider_ReverbDamping.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbDamping.PositionFloat = 0F;
            this.Movie_hSlider_ReverbDamping.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbDamping.TabIndex = 23;
            this.Movie_hSlider_ReverbDamping.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbDamping_PositionChangeNotify);
            // 
            // Movie_label_Reverb_Damping
            // 
            this.Movie_label_Reverb_Damping.AutoSize = true;
            this.Movie_label_Reverb_Damping.Location = new System.Drawing.Point(34, 96);
            this.Movie_label_Reverb_Damping.Name = "Movie_label_Reverb_Damping";
            this.Movie_label_Reverb_Damping.Size = new System.Drawing.Size(113, 13);
            this.Movie_label_Reverb_Damping.TabIndex = 22;
            this.Movie_label_Reverb_Damping.Text = "$REVERB_DAMPING";
            // 
            // Movie_hSlider_ReverbSize
            // 
            this.Movie_hSlider_ReverbSize.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ReverbSize.Location = new System.Drawing.Point(24, 69);
            this.Movie_hSlider_ReverbSize.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ReverbSize.Name = "Movie_hSlider_ReverbSize";
            this.Movie_hSlider_ReverbSize.Position = ((uint)(0u));
            this.Movie_hSlider_ReverbSize.PositionFloat = 0F;
            this.Movie_hSlider_ReverbSize.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_ReverbSize.TabIndex = 21;
            this.Movie_hSlider_ReverbSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ReverbSize_PositionChangeNotify);
            // 
            // Movie_label_Reverb_Size
            // 
            this.Movie_label_Reverb_Size.AutoSize = true;
            this.Movie_label_Reverb_Size.Location = new System.Drawing.Point(34, 53);
            this.Movie_label_Reverb_Size.Name = "Movie_label_Reverb_Size";
            this.Movie_label_Reverb_Size.Size = new System.Drawing.Size(87, 13);
            this.Movie_label_Reverb_Size.TabIndex = 20;
            this.Movie_label_Reverb_Size.Text = "$REVERB_SIZE";
            // 
            // Movie_onOffSwitch_Reverb
            // 
            this.Movie_onOffSwitch_Reverb.BackColor = System.Drawing.Color.Transparent;
            this.Movie_onOffSwitch_Reverb.Location = new System.Drawing.Point(13, 25);
            this.Movie_onOffSwitch_Reverb.Name = "Movie_onOffSwitch_Reverb";
            this.Movie_onOffSwitch_Reverb.Size = new System.Drawing.Size(49, 22);
            this.Movie_onOffSwitch_Reverb.SwitchedOn = false;
            this.Movie_onOffSwitch_Reverb.TabIndex = 7;
            this.Movie_onOffSwitch_Reverb.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Movie_onOffSwitch_Reverb_SwitchChangeNotify);
            // 
            // Movie_groupBox_Clarity
            // 
            this.Movie_groupBox_Clarity.Controls.Add(this.Movie_hSlider_Clarity);
            this.Movie_groupBox_Clarity.Controls.Add(this.Movie_label_Clarity);
            this.Movie_groupBox_Clarity.Controls.Add(this.Movie_onOffSwitch_Clarity);
            this.Movie_groupBox_Clarity.Location = new System.Drawing.Point(216, 231);
            this.Movie_groupBox_Clarity.Name = "Movie_groupBox_Clarity";
            this.Movie_groupBox_Clarity.Size = new System.Drawing.Size(189, 160);
            this.Movie_groupBox_Clarity.TabIndex = 17;
            this.Movie_groupBox_Clarity.TabStop = false;
            this.Movie_groupBox_Clarity.Text = "$CLARITY";
            // 
            // Movie_hSlider_Clarity
            // 
            this.Movie_hSlider_Clarity.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_Clarity.Location = new System.Drawing.Point(13, 101);
            this.Movie_hSlider_Clarity.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_Clarity.Name = "Movie_hSlider_Clarity";
            this.Movie_hSlider_Clarity.Position = ((uint)(0u));
            this.Movie_hSlider_Clarity.PositionFloat = 0F;
            this.Movie_hSlider_Clarity.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_Clarity.TabIndex = 21;
            this.Movie_hSlider_Clarity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_Clarity_PositionChangeNotify);
            // 
            // Movie_label_Clarity
            // 
            this.Movie_label_Clarity.AutoSize = true;
            this.Movie_label_Clarity.Location = new System.Drawing.Point(23, 85);
            this.Movie_label_Clarity.Name = "Movie_label_Clarity";
            this.Movie_label_Clarity.Size = new System.Drawing.Size(86, 13);
            this.Movie_label_Clarity.TabIndex = 20;
            this.Movie_label_Clarity.Text = "$CLARITY : 0dB";
            // 
            // Movie_onOffSwitch_Clarity
            // 
            this.Movie_onOffSwitch_Clarity.BackColor = System.Drawing.Color.Transparent;
            this.Movie_onOffSwitch_Clarity.Location = new System.Drawing.Point(13, 25);
            this.Movie_onOffSwitch_Clarity.Name = "Movie_onOffSwitch_Clarity";
            this.Movie_onOffSwitch_Clarity.Size = new System.Drawing.Size(49, 22);
            this.Movie_onOffSwitch_Clarity.SwitchedOn = false;
            this.Movie_onOffSwitch_Clarity.TabIndex = 17;
            this.Movie_onOffSwitch_Clarity.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Movie_onOffSwitch_Clarity_SwitchChangeNotify);
            // 
            // Movie_groupBox_Bass
            // 
            this.Movie_groupBox_Bass.Controls.Add(this.Movie_hSlider_BassGain);
            this.Movie_groupBox_Bass.Controls.Add(this.Movie_label_Bass_Gain);
            this.Movie_groupBox_Bass.Controls.Add(this.Movie_hSlider_BassSpkSize);
            this.Movie_groupBox_Bass.Controls.Add(this.Movie_label_Bass_SpkSize);
            this.Movie_groupBox_Bass.Controls.Add(this.Movie_onOffSwitch_Bass);
            this.Movie_groupBox_Bass.Location = new System.Drawing.Point(21, 231);
            this.Movie_groupBox_Bass.Name = "Movie_groupBox_Bass";
            this.Movie_groupBox_Bass.Size = new System.Drawing.Size(189, 160);
            this.Movie_groupBox_Bass.TabIndex = 16;
            this.Movie_groupBox_Bass.TabStop = false;
            this.Movie_groupBox_Bass.Text = "$BASS";
            // 
            // Movie_hSlider_BassGain
            // 
            this.Movie_hSlider_BassGain.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_BassGain.Location = new System.Drawing.Point(13, 125);
            this.Movie_hSlider_BassGain.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_BassGain.Name = "Movie_hSlider_BassGain";
            this.Movie_hSlider_BassGain.Position = ((uint)(0u));
            this.Movie_hSlider_BassGain.PositionFloat = 0F;
            this.Movie_hSlider_BassGain.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_BassGain.TabIndex = 21;
            this.Movie_hSlider_BassGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_BassGain_PositionChangeNotify);
            // 
            // Movie_label_Bass_Gain
            // 
            this.Movie_label_Bass_Gain.AutoSize = true;
            this.Movie_label_Bass_Gain.Location = new System.Drawing.Point(23, 108);
            this.Movie_label_Bass_Gain.Name = "Movie_label_Bass_Gain";
            this.Movie_label_Bass_Gain.Size = new System.Drawing.Size(101, 13);
            this.Movie_label_Bass_Gain.TabIndex = 20;
            this.Movie_label_Bass_Gain.Text = "$BASS_GAIN : 0dB";
            // 
            // Movie_hSlider_BassSpkSize
            // 
            this.Movie_hSlider_BassSpkSize.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_BassSpkSize.Location = new System.Drawing.Point(13, 79);
            this.Movie_hSlider_BassSpkSize.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_BassSpkSize.Name = "Movie_hSlider_BassSpkSize";
            this.Movie_hSlider_BassSpkSize.Position = ((uint)(0u));
            this.Movie_hSlider_BassSpkSize.PositionFloat = 0F;
            this.Movie_hSlider_BassSpkSize.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_BassSpkSize.TabIndex = 19;
            this.Movie_hSlider_BassSpkSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_BassSpkSize_PositionChangeNotify);
            // 
            // Movie_label_Bass_SpkSize
            // 
            this.Movie_label_Bass_SpkSize.AutoSize = true;
            this.Movie_label_Bass_SpkSize.Location = new System.Drawing.Point(23, 63);
            this.Movie_label_Bass_SpkSize.Name = "Movie_label_Bass_SpkSize";
            this.Movie_label_Bass_SpkSize.Size = new System.Drawing.Size(92, 13);
            this.Movie_label_Bass_SpkSize.TabIndex = 18;
            this.Movie_label_Bass_SpkSize.Text = "$BASS_SPKSIZE";
            // 
            // Movie_onOffSwitch_Bass
            // 
            this.Movie_onOffSwitch_Bass.BackColor = System.Drawing.Color.Transparent;
            this.Movie_onOffSwitch_Bass.Location = new System.Drawing.Point(13, 25);
            this.Movie_onOffSwitch_Bass.Name = "Movie_onOffSwitch_Bass";
            this.Movie_onOffSwitch_Bass.Size = new System.Drawing.Size(49, 22);
            this.Movie_onOffSwitch_Bass.SwitchedOn = false;
            this.Movie_onOffSwitch_Bass.TabIndex = 17;
            this.Movie_onOffSwitch_Bass.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Movie_onOffSwitch_Bass_SwitchChangeNotify);
            // 
            // Movie_groupBox_Surround
            // 
            this.Movie_groupBox_Surround.Controls.Add(this.Movie_hSlider_SurroundImage);
            this.Movie_groupBox_Surround.Controls.Add(this.Movie_label_Surround_Image);
            this.Movie_groupBox_Surround.Controls.Add(this.Movie_hSlider_Surround3D);
            this.Movie_groupBox_Surround.Controls.Add(this.Movie_label_Surround_3D);
            this.Movie_groupBox_Surround.Controls.Add(this.Movie_onOffSwitch_Surround);
            this.Movie_groupBox_Surround.Location = new System.Drawing.Point(606, 7);
            this.Movie_groupBox_Surround.Name = "Movie_groupBox_Surround";
            this.Movie_groupBox_Surround.Size = new System.Drawing.Size(208, 150);
            this.Movie_groupBox_Surround.TabIndex = 13;
            this.Movie_groupBox_Surround.TabStop = false;
            this.Movie_groupBox_Surround.Text = "$SURROUND";
            // 
            // Movie_hSlider_SurroundImage
            // 
            this.Movie_hSlider_SurroundImage.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_SurroundImage.Location = new System.Drawing.Point(24, 118);
            this.Movie_hSlider_SurroundImage.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_SurroundImage.Name = "Movie_hSlider_SurroundImage";
            this.Movie_hSlider_SurroundImage.Position = ((uint)(0u));
            this.Movie_hSlider_SurroundImage.PositionFloat = 0F;
            this.Movie_hSlider_SurroundImage.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_SurroundImage.TabIndex = 25;
            this.Movie_hSlider_SurroundImage.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_SurroundImage_PositionChangeNotify);
            // 
            // Movie_label_Surround_Image
            // 
            this.Movie_label_Surround_Image.AutoSize = true;
            this.Movie_label_Surround_Image.Location = new System.Drawing.Point(34, 102);
            this.Movie_label_Surround_Image.Name = "Movie_label_Surround_Image";
            this.Movie_label_Surround_Image.Size = new System.Drawing.Size(116, 13);
            this.Movie_label_Surround_Image.TabIndex = 24;
            this.Movie_label_Surround_Image.Text = "$SURROUND_IMAGE";
            // 
            // Movie_hSlider_Surround3D
            // 
            this.Movie_hSlider_Surround3D.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_Surround3D.Location = new System.Drawing.Point(24, 73);
            this.Movie_hSlider_Surround3D.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_Surround3D.Name = "Movie_hSlider_Surround3D";
            this.Movie_hSlider_Surround3D.Position = ((uint)(0u));
            this.Movie_hSlider_Surround3D.PositionFloat = 0F;
            this.Movie_hSlider_Surround3D.Size = new System.Drawing.Size(161, 26);
            this.Movie_hSlider_Surround3D.TabIndex = 23;
            this.Movie_hSlider_Surround3D.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_Surround3D_PositionChangeNotify);
            // 
            // Movie_label_Surround_3D
            // 
            this.Movie_label_Surround_3D.AutoSize = true;
            this.Movie_label_Surround_3D.Location = new System.Drawing.Point(34, 56);
            this.Movie_label_Surround_3D.Name = "Movie_label_Surround_3D";
            this.Movie_label_Surround_3D.Size = new System.Drawing.Size(96, 13);
            this.Movie_label_Surround_3D.TabIndex = 22;
            this.Movie_label_Surround_3D.Text = "$SURROUND_3D";
            // 
            // Movie_onOffSwitch_Surround
            // 
            this.Movie_onOffSwitch_Surround.BackColor = System.Drawing.Color.Transparent;
            this.Movie_onOffSwitch_Surround.Location = new System.Drawing.Point(13, 25);
            this.Movie_onOffSwitch_Surround.Name = "Movie_onOffSwitch_Surround";
            this.Movie_onOffSwitch_Surround.Size = new System.Drawing.Size(49, 22);
            this.Movie_onOffSwitch_Surround.SwitchedOn = false;
            this.Movie_onOffSwitch_Surround.TabIndex = 6;
            this.Movie_onOffSwitch_Surround.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Movie_onOffSwitch_Surround_SwitchChangeNotify);
            // 
            // Movie_groupBox_Convolver
            // 
            this.Movie_groupBox_Convolver.Controls.Add(this.Movie_irShape_ConvIR);
            this.Movie_groupBox_Convolver.Controls.Add(this.Movie_onOffSwitch_Convolver);
            this.Movie_groupBox_Convolver.Controls.Add(this.Movie_hSlider_ConvIRGain);
            this.Movie_groupBox_Convolver.Controls.Add(this.Movie_openFileBox_ConvIRS);
            this.Movie_groupBox_Convolver.Controls.Add(this.Movie_label_ConvolverIRGain);
            this.Movie_groupBox_Convolver.Location = new System.Drawing.Point(312, 7);
            this.Movie_groupBox_Convolver.Name = "Movie_groupBox_Convolver";
            this.Movie_groupBox_Convolver.Size = new System.Drawing.Size(288, 194);
            this.Movie_groupBox_Convolver.TabIndex = 12;
            this.Movie_groupBox_Convolver.TabStop = false;
            this.Movie_groupBox_Convolver.Text = "$CONVOLVER";
            // 
            // Movie_irShape_ConvIR
            // 
            this.Movie_irShape_ConvIR.Location = new System.Drawing.Point(13, 66);
            this.Movie_irShape_ConvIR.Name = "Movie_irShape_ConvIR";
            this.Movie_irShape_ConvIR.ShapeBackColor = System.Drawing.Color.White;
            this.Movie_irShape_ConvIR.ShapeForeColor = System.Drawing.Color.Black;
            this.Movie_irShape_ConvIR.Size = new System.Drawing.Size(260, 68);
            this.Movie_irShape_ConvIR.TabIndex = 8;
            // 
            // Movie_onOffSwitch_Convolver
            // 
            this.Movie_onOffSwitch_Convolver.BackColor = System.Drawing.Color.Transparent;
            this.Movie_onOffSwitch_Convolver.Location = new System.Drawing.Point(13, 25);
            this.Movie_onOffSwitch_Convolver.Name = "Movie_onOffSwitch_Convolver";
            this.Movie_onOffSwitch_Convolver.Size = new System.Drawing.Size(49, 22);
            this.Movie_onOffSwitch_Convolver.SwitchedOn = false;
            this.Movie_onOffSwitch_Convolver.TabIndex = 5;
            this.Movie_onOffSwitch_Convolver.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Movie_onOffSwitch_Convolver_SwitchChangeNotify);
            // 
            // Movie_hSlider_ConvIRGain
            // 
            this.Movie_hSlider_ConvIRGain.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_ConvIRGain.Location = new System.Drawing.Point(85, 34);
            this.Movie_hSlider_ConvIRGain.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_ConvIRGain.Name = "Movie_hSlider_ConvIRGain";
            this.Movie_hSlider_ConvIRGain.Position = ((uint)(0u));
            this.Movie_hSlider_ConvIRGain.PositionFloat = 0F;
            this.Movie_hSlider_ConvIRGain.Size = new System.Drawing.Size(188, 26);
            this.Movie_hSlider_ConvIRGain.TabIndex = 7;
            this.Movie_hSlider_ConvIRGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_ConvIRGain_PositionChangeNotify);
            // 
            // Movie_openFileBox_ConvIRS
            // 
            this.Movie_openFileBox_ConvIRS.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_openFileBox_ConvIRS.FilePathName = "";
            this.Movie_openFileBox_ConvIRS.Location = new System.Drawing.Point(13, 147);
            this.Movie_openFileBox_ConvIRS.Name = "Movie_openFileBox_ConvIRS";
            this.Movie_openFileBox_ConvIRS.Size = new System.Drawing.Size(260, 31);
            this.Movie_openFileBox_ConvIRS.TabIndex = 9;
            this.Movie_openFileBox_ConvIRS.FileChangeNotify += new ViPER4WindowsBin.UIControls.OpenFileBox.FileChangeEventDelegate(this.Movie_openFileBox_ConvIRS_FileChangeNotify);
            // 
            // Movie_label_ConvolverIRGain
            // 
            this.Movie_label_ConvolverIRGain.AutoSize = true;
            this.Movie_label_ConvolverIRGain.Location = new System.Drawing.Point(95, 17);
            this.Movie_label_ConvolverIRGain.Name = "Movie_label_ConvolverIRGain";
            this.Movie_label_ConvolverIRGain.Size = new System.Drawing.Size(120, 13);
            this.Movie_label_ConvolverIRGain.TabIndex = 6;
            this.Movie_label_ConvolverIRGain.Text = "$CONV_IR_GAIN : 0dB";
            // 
            // Movie_hSlider_PostVolume
            // 
            this.Movie_hSlider_PostVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_PostVolume.Location = new System.Drawing.Point(21, 128);
            this.Movie_hSlider_PostVolume.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_PostVolume.Name = "Movie_hSlider_PostVolume";
            this.Movie_hSlider_PostVolume.Position = ((uint)(0u));
            this.Movie_hSlider_PostVolume.PositionFloat = 0F;
            this.Movie_hSlider_PostVolume.Size = new System.Drawing.Size(285, 42);
            this.Movie_hSlider_PostVolume.TabIndex = 3;
            this.Movie_hSlider_PostVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_PostVolume_PositionChangeNotify);
            // 
            // Movie_label_PostVolume
            // 
            this.Movie_label_PostVolume.AutoSize = true;
            this.Movie_label_PostVolume.Location = new System.Drawing.Point(40, 108);
            this.Movie_label_PostVolume.Name = "Movie_label_PostVolume";
            this.Movie_label_PostVolume.Size = new System.Drawing.Size(121, 13);
            this.Movie_label_PostVolume.TabIndex = 2;
            this.Movie_label_PostVolume.Text = "$POST_VOLUME : 0dB";
            // 
            // Movie_hSlider_PreVolume
            // 
            this.Movie_hSlider_PreVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Movie_hSlider_PreVolume.Location = new System.Drawing.Point(21, 42);
            this.Movie_hSlider_PreVolume.MoveDelta = ((uint)(1u));
            this.Movie_hSlider_PreVolume.Name = "Movie_hSlider_PreVolume";
            this.Movie_hSlider_PreVolume.Position = ((uint)(0u));
            this.Movie_hSlider_PreVolume.PositionFloat = 0F;
            this.Movie_hSlider_PreVolume.Size = new System.Drawing.Size(285, 42);
            this.Movie_hSlider_PreVolume.TabIndex = 1;
            this.Movie_hSlider_PreVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Movie_hSlider_PreVolume_PositionChangeNotify);
            // 
            // Movie_label_PreVolume
            // 
            this.Movie_label_PreVolume.AutoSize = true;
            this.Movie_label_PreVolume.Location = new System.Drawing.Point(40, 23);
            this.Movie_label_PreVolume.Name = "Movie_label_PreVolume";
            this.Movie_label_PreVolume.Size = new System.Drawing.Size(114, 13);
            this.Movie_label_PreVolume.TabIndex = 0;
            this.Movie_label_PreVolume.Text = "$PRE_VOLUME : 0dB";
            // 
            // Music_singleButton_Compressor
            // 
            this.Music_singleButton_Compressor.BackColor = System.Drawing.SystemColors.Control;
            this.Music_singleButton_Compressor.ButtonText = "$COMPRESSOR_ADJUST";
            this.Music_singleButton_Compressor.Location = new System.Drawing.Point(216, 498);
            this.Music_singleButton_Compressor.Name = "Music_singleButton_Compressor";
            this.Music_singleButton_Compressor.Size = new System.Drawing.Size(174, 42);
            this.Music_singleButton_Compressor.TabIndex = 21;
            this.Music_singleButton_Compressor.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Music_singleButton_Compressor_ButtonClickNotify);
            // 
            // Music_singleButton_Equalizer
            // 
            this.Music_singleButton_Equalizer.BackColor = System.Drawing.SystemColors.Control;
            this.Music_singleButton_Equalizer.ButtonText = "$EQUALIZER_ADJUST";
            this.Music_singleButton_Equalizer.Location = new System.Drawing.Point(216, 438);
            this.Music_singleButton_Equalizer.Name = "Music_singleButton_Equalizer";
            this.Music_singleButton_Equalizer.Size = new System.Drawing.Size(174, 42);
            this.Music_singleButton_Equalizer.TabIndex = 20;
            this.Music_singleButton_Equalizer.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Music_singleButton_Equalizer_ButtonClickNotify);
            // 
            // Music_groupBox_Reverb
            // 
            this.Music_groupBox_Reverb.Controls.Add(this.Music_singleButton_ReverbPreset);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbMix);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_Mix);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbEarlyMix);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_EarlyMix);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbPreDelay);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_PreDelay);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbDecay);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_Decay);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbBandWidth);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_BandWidth);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbDensity);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_Density);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbDamping);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_Damping);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_hSlider_ReverbSize);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_label_Reverb_Size);
            this.Music_groupBox_Reverb.Controls.Add(this.Music_onOffSwitch_Reverb);
            this.Music_groupBox_Reverb.Location = new System.Drawing.Point(606, 163);
            this.Music_groupBox_Reverb.Name = "Music_groupBox_Reverb";
            this.Music_groupBox_Reverb.Size = new System.Drawing.Size(208, 421);
            this.Music_groupBox_Reverb.TabIndex = 19;
            this.Music_groupBox_Reverb.TabStop = false;
            this.Music_groupBox_Reverb.Text = "$REVERB";
            // 
            // Music_singleButton_ReverbPreset
            // 
            this.Music_singleButton_ReverbPreset.BackColor = System.Drawing.SystemColors.Control;
            this.Music_singleButton_ReverbPreset.ButtonText = "$PRESET";
            this.Music_singleButton_ReverbPreset.Location = new System.Drawing.Point(121, 15);
            this.Music_singleButton_ReverbPreset.Name = "Music_singleButton_ReverbPreset";
            this.Music_singleButton_ReverbPreset.Size = new System.Drawing.Size(81, 31);
            this.Music_singleButton_ReverbPreset.TabIndex = 36;
            this.Music_singleButton_ReverbPreset.ButtonClickNotify += new ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.Music_singleButton_ReverbPreset_ButtonClickNotify);
            // 
            // Music_hSlider_ReverbMix
            // 
            this.Music_hSlider_ReverbMix.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbMix.Location = new System.Drawing.Point(24, 386);
            this.Music_hSlider_ReverbMix.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbMix.Name = "Music_hSlider_ReverbMix";
            this.Music_hSlider_ReverbMix.Position = ((uint)(0u));
            this.Music_hSlider_ReverbMix.PositionFloat = 0F;
            this.Music_hSlider_ReverbMix.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbMix.TabIndex = 35;
            this.Music_hSlider_ReverbMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbMix_PositionChangeNotify);
            // 
            // Music_label_Reverb_Mix
            // 
            this.Music_label_Reverb_Mix.AutoSize = true;
            this.Music_label_Reverb_Mix.Location = new System.Drawing.Point(34, 369);
            this.Music_label_Reverb_Mix.Name = "Music_label_Reverb_Mix";
            this.Music_label_Reverb_Mix.Size = new System.Drawing.Size(82, 13);
            this.Music_label_Reverb_Mix.TabIndex = 34;
            this.Music_label_Reverb_Mix.Text = "$REVERB_MIX";
            // 
            // Music_hSlider_ReverbEarlyMix
            // 
            this.Music_hSlider_ReverbEarlyMix.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbEarlyMix.Location = new System.Drawing.Point(24, 340);
            this.Music_hSlider_ReverbEarlyMix.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbEarlyMix.Name = "Music_hSlider_ReverbEarlyMix";
            this.Music_hSlider_ReverbEarlyMix.Position = ((uint)(0u));
            this.Music_hSlider_ReverbEarlyMix.PositionFloat = 0F;
            this.Music_hSlider_ReverbEarlyMix.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbEarlyMix.TabIndex = 33;
            this.Music_hSlider_ReverbEarlyMix.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbEarlyMix_PositionChangeNotify);
            // 
            // Music_label_Reverb_EarlyMix
            // 
            this.Music_label_Reverb_EarlyMix.AutoSize = true;
            this.Music_label_Reverb_EarlyMix.Location = new System.Drawing.Point(34, 324);
            this.Music_label_Reverb_EarlyMix.Name = "Music_label_Reverb_EarlyMix";
            this.Music_label_Reverb_EarlyMix.Size = new System.Drawing.Size(117, 13);
            this.Music_label_Reverb_EarlyMix.TabIndex = 32;
            this.Music_label_Reverb_EarlyMix.Text = "$REVERB_EARLYMIX";
            // 
            // Music_hSlider_ReverbPreDelay
            // 
            this.Music_hSlider_ReverbPreDelay.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbPreDelay.Location = new System.Drawing.Point(24, 295);
            this.Music_hSlider_ReverbPreDelay.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbPreDelay.Name = "Music_hSlider_ReverbPreDelay";
            this.Music_hSlider_ReverbPreDelay.Position = ((uint)(0u));
            this.Music_hSlider_ReverbPreDelay.PositionFloat = 0F;
            this.Music_hSlider_ReverbPreDelay.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbPreDelay.TabIndex = 31;
            this.Music_hSlider_ReverbPreDelay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbPreDelay_PositionChangeNotify);
            // 
            // Music_label_Reverb_PreDelay
            // 
            this.Music_label_Reverb_PreDelay.AutoSize = true;
            this.Music_label_Reverb_PreDelay.Location = new System.Drawing.Point(34, 278);
            this.Music_label_Reverb_PreDelay.Name = "Music_label_Reverb_PreDelay";
            this.Music_label_Reverb_PreDelay.Size = new System.Drawing.Size(120, 13);
            this.Music_label_Reverb_PreDelay.TabIndex = 30;
            this.Music_label_Reverb_PreDelay.Text = "$REVERB_PREDELAY";
            // 
            // Music_hSlider_ReverbDecay
            // 
            this.Music_hSlider_ReverbDecay.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbDecay.Location = new System.Drawing.Point(24, 249);
            this.Music_hSlider_ReverbDecay.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbDecay.Name = "Music_hSlider_ReverbDecay";
            this.Music_hSlider_ReverbDecay.Position = ((uint)(0u));
            this.Music_hSlider_ReverbDecay.PositionFloat = 0F;
            this.Music_hSlider_ReverbDecay.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbDecay.TabIndex = 29;
            this.Music_hSlider_ReverbDecay.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbDecay_PositionChangeNotify);
            // 
            // Music_label_Reverb_Decay
            // 
            this.Music_label_Reverb_Decay.AutoSize = true;
            this.Music_label_Reverb_Decay.Location = new System.Drawing.Point(34, 233);
            this.Music_label_Reverb_Decay.Name = "Music_label_Reverb_Decay";
            this.Music_label_Reverb_Decay.Size = new System.Drawing.Size(99, 13);
            this.Music_label_Reverb_Decay.TabIndex = 28;
            this.Music_label_Reverb_Decay.Text = "$REVERB_DECAY";
            // 
            // Music_hSlider_ReverbBandWidth
            // 
            this.Music_hSlider_ReverbBandWidth.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbBandWidth.Location = new System.Drawing.Point(24, 204);
            this.Music_hSlider_ReverbBandWidth.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbBandWidth.Name = "Music_hSlider_ReverbBandWidth";
            this.Music_hSlider_ReverbBandWidth.Position = ((uint)(0u));
            this.Music_hSlider_ReverbBandWidth.PositionFloat = 0F;
            this.Music_hSlider_ReverbBandWidth.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbBandWidth.TabIndex = 27;
            this.Music_hSlider_ReverbBandWidth.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbBandWidth_PositionChangeNotify);
            // 
            // Music_label_Reverb_BandWidth
            // 
            this.Music_label_Reverb_BandWidth.AutoSize = true;
            this.Music_label_Reverb_BandWidth.Location = new System.Drawing.Point(34, 187);
            this.Music_label_Reverb_BandWidth.Name = "Music_label_Reverb_BandWidth";
            this.Music_label_Reverb_BandWidth.Size = new System.Drawing.Size(130, 13);
            this.Music_label_Reverb_BandWidth.TabIndex = 26;
            this.Music_label_Reverb_BandWidth.Text = "$REVERB_BANDWIDTH";
            // 
            // Music_hSlider_ReverbDensity
            // 
            this.Music_hSlider_ReverbDensity.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbDensity.Location = new System.Drawing.Point(24, 158);
            this.Music_hSlider_ReverbDensity.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbDensity.Name = "Music_hSlider_ReverbDensity";
            this.Music_hSlider_ReverbDensity.Position = ((uint)(0u));
            this.Music_hSlider_ReverbDensity.PositionFloat = 0F;
            this.Music_hSlider_ReverbDensity.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbDensity.TabIndex = 25;
            this.Music_hSlider_ReverbDensity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbDensity_PositionChangeNotify);
            // 
            // Music_label_Reverb_Density
            // 
            this.Music_label_Reverb_Density.AutoSize = true;
            this.Music_label_Reverb_Density.Location = new System.Drawing.Point(34, 142);
            this.Music_label_Reverb_Density.Name = "Music_label_Reverb_Density";
            this.Music_label_Reverb_Density.Size = new System.Drawing.Size(110, 13);
            this.Music_label_Reverb_Density.TabIndex = 24;
            this.Music_label_Reverb_Density.Text = "$REVERB_DENSITY";
            // 
            // Music_hSlider_ReverbDamping
            // 
            this.Music_hSlider_ReverbDamping.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbDamping.Location = new System.Drawing.Point(24, 113);
            this.Music_hSlider_ReverbDamping.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbDamping.Name = "Music_hSlider_ReverbDamping";
            this.Music_hSlider_ReverbDamping.Position = ((uint)(0u));
            this.Music_hSlider_ReverbDamping.PositionFloat = 0F;
            this.Music_hSlider_ReverbDamping.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbDamping.TabIndex = 23;
            this.Music_hSlider_ReverbDamping.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbDamping_PositionChangeNotify);
            // 
            // Music_label_Reverb_Damping
            // 
            this.Music_label_Reverb_Damping.AutoSize = true;
            this.Music_label_Reverb_Damping.Location = new System.Drawing.Point(34, 96);
            this.Music_label_Reverb_Damping.Name = "Music_label_Reverb_Damping";
            this.Music_label_Reverb_Damping.Size = new System.Drawing.Size(113, 13);
            this.Music_label_Reverb_Damping.TabIndex = 22;
            this.Music_label_Reverb_Damping.Text = "$REVERB_DAMPING";
            // 
            // Music_hSlider_ReverbSize
            // 
            this.Music_hSlider_ReverbSize.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ReverbSize.Location = new System.Drawing.Point(24, 69);
            this.Music_hSlider_ReverbSize.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ReverbSize.Name = "Music_hSlider_ReverbSize";
            this.Music_hSlider_ReverbSize.Position = ((uint)(0u));
            this.Music_hSlider_ReverbSize.PositionFloat = 0F;
            this.Music_hSlider_ReverbSize.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_ReverbSize.TabIndex = 21;
            this.Music_hSlider_ReverbSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ReverbSize_PositionChangeNotify);
            // 
            // Music_label_Reverb_Size
            // 
            this.Music_label_Reverb_Size.AutoSize = true;
            this.Music_label_Reverb_Size.Location = new System.Drawing.Point(34, 53);
            this.Music_label_Reverb_Size.Name = "Music_label_Reverb_Size";
            this.Music_label_Reverb_Size.Size = new System.Drawing.Size(87, 13);
            this.Music_label_Reverb_Size.TabIndex = 20;
            this.Music_label_Reverb_Size.Text = "$REVERB_SIZE";
            // 
            // Music_onOffSwitch_Reverb
            // 
            this.Music_onOffSwitch_Reverb.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Reverb.Location = new System.Drawing.Point(13, 25);
            this.Music_onOffSwitch_Reverb.Name = "Music_onOffSwitch_Reverb";
            this.Music_onOffSwitch_Reverb.Size = new System.Drawing.Size(49, 22);
            this.Music_onOffSwitch_Reverb.SwitchedOn = false;
            this.Music_onOffSwitch_Reverb.TabIndex = 7;
            this.Music_onOffSwitch_Reverb.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Reverb_SwitchChangeNotify);
            // 
            // Music_groupBox_Cure
            // 
            this.Music_groupBox_Cure.Controls.Add(this.Music_buttonBox_CureLevel);
            this.Music_groupBox_Cure.Controls.Add(this.Music_onOffSwitch_Cure);
            this.Music_groupBox_Cure.Controls.Add(this.Music_label_Tube);
            this.Music_groupBox_Cure.Controls.Add(this.Music_onOffSwitch_Tube);
            this.Music_groupBox_Cure.Location = new System.Drawing.Point(411, 223);
            this.Music_groupBox_Cure.Name = "Music_groupBox_Cure";
            this.Music_groupBox_Cure.Size = new System.Drawing.Size(189, 160);
            this.Music_groupBox_Cure.TabIndex = 18;
            this.Music_groupBox_Cure.TabStop = false;
            this.Music_groupBox_Cure.Text = "$CURE";
            // 
            // Music_buttonBox_CureLevel
            // 
            this.Music_buttonBox_CureLevel.BackColor = System.Drawing.SystemColors.Control;
            this.Music_buttonBox_CureLevel.Location = new System.Drawing.Point(68, 18);
            this.Music_buttonBox_CureLevel.Name = "Music_buttonBox_CureLevel";
            this.Music_buttonBox_CureLevel.Size = new System.Drawing.Size(106, 76);
            this.Music_buttonBox_CureLevel.TabIndex = 18;
            this.Music_buttonBox_CureLevel.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Music_buttonBox_CureLevel_ItemSelectedNotify);
            // 
            // Music_onOffSwitch_Cure
            // 
            this.Music_onOffSwitch_Cure.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Cure.Location = new System.Drawing.Point(13, 25);
            this.Music_onOffSwitch_Cure.Name = "Music_onOffSwitch_Cure";
            this.Music_onOffSwitch_Cure.Size = new System.Drawing.Size(49, 22);
            this.Music_onOffSwitch_Cure.SwitchedOn = false;
            this.Music_onOffSwitch_Cure.TabIndex = 17;
            this.Music_onOffSwitch_Cure.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Cure_SwitchChangeNotify);
            // 
            // Music_label_Tube
            // 
            this.Music_label_Tube.AutoSize = true;
            this.Music_label_Tube.Location = new System.Drawing.Point(11, 121);
            this.Music_label_Tube.Name = "Music_label_Tube";
            this.Music_label_Tube.Size = new System.Drawing.Size(42, 13);
            this.Music_label_Tube.TabIndex = 14;
            this.Music_label_Tube.Text = "$TUBE";
            // 
            // Music_onOffSwitch_Tube
            // 
            this.Music_onOffSwitch_Tube.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Tube.Location = new System.Drawing.Point(121, 114);
            this.Music_onOffSwitch_Tube.Name = "Music_onOffSwitch_Tube";
            this.Music_onOffSwitch_Tube.Size = new System.Drawing.Size(53, 28);
            this.Music_onOffSwitch_Tube.SwitchedOn = false;
            this.Music_onOffSwitch_Tube.TabIndex = 15;
            this.Music_onOffSwitch_Tube.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Tube_SwitchChangeNotify);
            // 
            // Music_groupBox_Clarity
            // 
            this.Music_groupBox_Clarity.Controls.Add(this.Music_buttonBox_ClarityMode);
            this.Music_groupBox_Clarity.Controls.Add(this.Music_hSlider_Clarity);
            this.Music_groupBox_Clarity.Controls.Add(this.Music_label_Clarity);
            this.Music_groupBox_Clarity.Controls.Add(this.Music_onOffSwitch_Clarity);
            this.Music_groupBox_Clarity.Location = new System.Drawing.Point(216, 223);
            this.Music_groupBox_Clarity.Name = "Music_groupBox_Clarity";
            this.Music_groupBox_Clarity.Size = new System.Drawing.Size(189, 160);
            this.Music_groupBox_Clarity.TabIndex = 17;
            this.Music_groupBox_Clarity.TabStop = false;
            this.Music_groupBox_Clarity.Text = "$CLARITY";
            // 
            // Music_buttonBox_ClarityMode
            // 
            this.Music_buttonBox_ClarityMode.BackColor = System.Drawing.SystemColors.Control;
            this.Music_buttonBox_ClarityMode.Location = new System.Drawing.Point(68, 18);
            this.Music_buttonBox_ClarityMode.Name = "Music_buttonBox_ClarityMode";
            this.Music_buttonBox_ClarityMode.Size = new System.Drawing.Size(106, 76);
            this.Music_buttonBox_ClarityMode.TabIndex = 18;
            this.Music_buttonBox_ClarityMode.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Music_buttonBox_ClarityMode_ItemSelectedNotify);
            // 
            // Music_hSlider_Clarity
            // 
            this.Music_hSlider_Clarity.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_Clarity.Location = new System.Drawing.Point(13, 125);
            this.Music_hSlider_Clarity.MoveDelta = ((uint)(1u));
            this.Music_hSlider_Clarity.Name = "Music_hSlider_Clarity";
            this.Music_hSlider_Clarity.Position = ((uint)(0u));
            this.Music_hSlider_Clarity.PositionFloat = 0F;
            this.Music_hSlider_Clarity.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_Clarity.TabIndex = 21;
            this.Music_hSlider_Clarity.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_Clarity_PositionChangeNotify);
            // 
            // Music_label_Clarity
            // 
            this.Music_label_Clarity.AutoSize = true;
            this.Music_label_Clarity.Location = new System.Drawing.Point(23, 108);
            this.Music_label_Clarity.Name = "Music_label_Clarity";
            this.Music_label_Clarity.Size = new System.Drawing.Size(86, 13);
            this.Music_label_Clarity.TabIndex = 20;
            this.Music_label_Clarity.Text = "$CLARITY : 0dB";
            // 
            // Music_onOffSwitch_Clarity
            // 
            this.Music_onOffSwitch_Clarity.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Clarity.Location = new System.Drawing.Point(13, 25);
            this.Music_onOffSwitch_Clarity.Name = "Music_onOffSwitch_Clarity";
            this.Music_onOffSwitch_Clarity.Size = new System.Drawing.Size(49, 22);
            this.Music_onOffSwitch_Clarity.SwitchedOn = false;
            this.Music_onOffSwitch_Clarity.TabIndex = 17;
            this.Music_onOffSwitch_Clarity.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Clarity_SwitchChangeNotify);
            // 
            // Music_groupBox_Bass
            // 
            this.Music_groupBox_Bass.Controls.Add(this.Music_hSlider_BassGain);
            this.Music_groupBox_Bass.Controls.Add(this.Music_label_Bass_Gain);
            this.Music_groupBox_Bass.Controls.Add(this.Music_hSlider_BassSpkSize);
            this.Music_groupBox_Bass.Controls.Add(this.Music_label_Bass_SpkSize);
            this.Music_groupBox_Bass.Controls.Add(this.Music_onOffSwitch_Bass);
            this.Music_groupBox_Bass.Location = new System.Drawing.Point(21, 223);
            this.Music_groupBox_Bass.Name = "Music_groupBox_Bass";
            this.Music_groupBox_Bass.Size = new System.Drawing.Size(189, 160);
            this.Music_groupBox_Bass.TabIndex = 16;
            this.Music_groupBox_Bass.TabStop = false;
            this.Music_groupBox_Bass.Text = "$BASS";
            // 
            // Music_hSlider_BassGain
            // 
            this.Music_hSlider_BassGain.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_BassGain.Location = new System.Drawing.Point(13, 125);
            this.Music_hSlider_BassGain.MoveDelta = ((uint)(1u));
            this.Music_hSlider_BassGain.Name = "Music_hSlider_BassGain";
            this.Music_hSlider_BassGain.Position = ((uint)(0u));
            this.Music_hSlider_BassGain.PositionFloat = 0F;
            this.Music_hSlider_BassGain.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_BassGain.TabIndex = 21;
            this.Music_hSlider_BassGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_BassGain_PositionChangeNotify);
            // 
            // Music_label_Bass_Gain
            // 
            this.Music_label_Bass_Gain.AutoSize = true;
            this.Music_label_Bass_Gain.Location = new System.Drawing.Point(23, 108);
            this.Music_label_Bass_Gain.Name = "Music_label_Bass_Gain";
            this.Music_label_Bass_Gain.Size = new System.Drawing.Size(101, 13);
            this.Music_label_Bass_Gain.TabIndex = 20;
            this.Music_label_Bass_Gain.Text = "$BASS_GAIN : 0dB";
            // 
            // Music_hSlider_BassSpkSize
            // 
            this.Music_hSlider_BassSpkSize.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_BassSpkSize.Location = new System.Drawing.Point(13, 79);
            this.Music_hSlider_BassSpkSize.MoveDelta = ((uint)(1u));
            this.Music_hSlider_BassSpkSize.Name = "Music_hSlider_BassSpkSize";
            this.Music_hSlider_BassSpkSize.Position = ((uint)(0u));
            this.Music_hSlider_BassSpkSize.PositionFloat = 0F;
            this.Music_hSlider_BassSpkSize.Size = new System.Drawing.Size(161, 26);
            this.Music_hSlider_BassSpkSize.TabIndex = 19;
            this.Music_hSlider_BassSpkSize.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_BassSpkSize_PositionChangeNotify);
            // 
            // Music_label_Bass_SpkSize
            // 
            this.Music_label_Bass_SpkSize.AutoSize = true;
            this.Music_label_Bass_SpkSize.Location = new System.Drawing.Point(23, 63);
            this.Music_label_Bass_SpkSize.Name = "Music_label_Bass_SpkSize";
            this.Music_label_Bass_SpkSize.Size = new System.Drawing.Size(92, 13);
            this.Music_label_Bass_SpkSize.TabIndex = 18;
            this.Music_label_Bass_SpkSize.Text = "$BASS_SPKSIZE";
            // 
            // Music_onOffSwitch_Bass
            // 
            this.Music_onOffSwitch_Bass.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Bass.Location = new System.Drawing.Point(13, 25);
            this.Music_onOffSwitch_Bass.Name = "Music_onOffSwitch_Bass";
            this.Music_onOffSwitch_Bass.Size = new System.Drawing.Size(49, 22);
            this.Music_onOffSwitch_Bass.SwitchedOn = false;
            this.Music_onOffSwitch_Bass.TabIndex = 17;
            this.Music_onOffSwitch_Bass.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Bass_SwitchChangeNotify);
            // 
            // Music_groupBox_Surround
            // 
            this.Music_groupBox_Surround.Controls.Add(this.Music_buttonBox_SurroundRoomSize);
            this.Music_groupBox_Surround.Controls.Add(this.Music_onOffSwitch_Surround);
            this.Music_groupBox_Surround.Location = new System.Drawing.Point(606, 7);
            this.Music_groupBox_Surround.Name = "Music_groupBox_Surround";
            this.Music_groupBox_Surround.Size = new System.Drawing.Size(208, 150);
            this.Music_groupBox_Surround.TabIndex = 13;
            this.Music_groupBox_Surround.TabStop = false;
            this.Music_groupBox_Surround.Text = "$SURROUND";
            // 
            // Music_buttonBox_SurroundRoomSize
            // 
            this.Music_buttonBox_SurroundRoomSize.BackColor = System.Drawing.SystemColors.Control;
            this.Music_buttonBox_SurroundRoomSize.Location = new System.Drawing.Point(68, 25);
            this.Music_buttonBox_SurroundRoomSize.Name = "Music_buttonBox_SurroundRoomSize";
            this.Music_buttonBox_SurroundRoomSize.Size = new System.Drawing.Size(127, 109);
            this.Music_buttonBox_SurroundRoomSize.TabIndex = 7;
            this.Music_buttonBox_SurroundRoomSize.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.Music_buttonBox_SurroundRoomSize_ItemSelectedNotify);
            // 
            // Music_onOffSwitch_Surround
            // 
            this.Music_onOffSwitch_Surround.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Surround.Location = new System.Drawing.Point(13, 25);
            this.Music_onOffSwitch_Surround.Name = "Music_onOffSwitch_Surround";
            this.Music_onOffSwitch_Surround.Size = new System.Drawing.Size(49, 22);
            this.Music_onOffSwitch_Surround.SwitchedOn = false;
            this.Music_onOffSwitch_Surround.TabIndex = 6;
            this.Music_onOffSwitch_Surround.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Surround_SwitchChangeNotify);
            // 
            // Music_groupBox_Convolver
            // 
            this.Music_groupBox_Convolver.Controls.Add(this.Music_irShape_ConvIR);
            this.Music_groupBox_Convolver.Controls.Add(this.Music_onOffSwitch_Convolver);
            this.Music_groupBox_Convolver.Controls.Add(this.Music_hSlider_ConvIRGain);
            this.Music_groupBox_Convolver.Controls.Add(this.Music_openFileBox_ConvIRS);
            this.Music_groupBox_Convolver.Controls.Add(this.Music_label_ConvolverIRGain);
            this.Music_groupBox_Convolver.Location = new System.Drawing.Point(312, 7);
            this.Music_groupBox_Convolver.Name = "Music_groupBox_Convolver";
            this.Music_groupBox_Convolver.Size = new System.Drawing.Size(288, 194);
            this.Music_groupBox_Convolver.TabIndex = 12;
            this.Music_groupBox_Convolver.TabStop = false;
            this.Music_groupBox_Convolver.Text = "$CONVOLVER";
            // 
            // Music_irShape_ConvIR
            // 
            this.Music_irShape_ConvIR.Location = new System.Drawing.Point(13, 66);
            this.Music_irShape_ConvIR.Name = "Music_irShape_ConvIR";
            this.Music_irShape_ConvIR.ShapeBackColor = System.Drawing.Color.White;
            this.Music_irShape_ConvIR.ShapeForeColor = System.Drawing.Color.Black;
            this.Music_irShape_ConvIR.Size = new System.Drawing.Size(260, 68);
            this.Music_irShape_ConvIR.TabIndex = 8;
            // 
            // Music_onOffSwitch_Convolver
            // 
            this.Music_onOffSwitch_Convolver.BackColor = System.Drawing.Color.Transparent;
            this.Music_onOffSwitch_Convolver.Location = new System.Drawing.Point(13, 25);
            this.Music_onOffSwitch_Convolver.Name = "Music_onOffSwitch_Convolver";
            this.Music_onOffSwitch_Convolver.Size = new System.Drawing.Size(49, 22);
            this.Music_onOffSwitch_Convolver.SwitchedOn = false;
            this.Music_onOffSwitch_Convolver.TabIndex = 5;
            this.Music_onOffSwitch_Convolver.SwitchChangeNotify += new ViPER4WindowsBin.UIControls.OnOffSwitch.SwitchChangeEventDelegate(this.Music_onOffSwitch_Convolver_SwitchChangeNotify);
            // 
            // Music_hSlider_ConvIRGain
            // 
            this.Music_hSlider_ConvIRGain.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_ConvIRGain.Location = new System.Drawing.Point(85, 34);
            this.Music_hSlider_ConvIRGain.MoveDelta = ((uint)(1u));
            this.Music_hSlider_ConvIRGain.Name = "Music_hSlider_ConvIRGain";
            this.Music_hSlider_ConvIRGain.Position = ((uint)(0u));
            this.Music_hSlider_ConvIRGain.PositionFloat = 0F;
            this.Music_hSlider_ConvIRGain.Size = new System.Drawing.Size(188, 26);
            this.Music_hSlider_ConvIRGain.TabIndex = 7;
            this.Music_hSlider_ConvIRGain.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_ConvIRGain_PositionChangeNotify);
            // 
            // Music_openFileBox_ConvIRS
            // 
            this.Music_openFileBox_ConvIRS.BackColor = System.Drawing.SystemColors.Control;
            this.Music_openFileBox_ConvIRS.FilePathName = "";
            this.Music_openFileBox_ConvIRS.Location = new System.Drawing.Point(13, 147);
            this.Music_openFileBox_ConvIRS.Name = "Music_openFileBox_ConvIRS";
            this.Music_openFileBox_ConvIRS.Size = new System.Drawing.Size(260, 31);
            this.Music_openFileBox_ConvIRS.TabIndex = 9;
            this.Music_openFileBox_ConvIRS.FileChangeNotify += new ViPER4WindowsBin.UIControls.OpenFileBox.FileChangeEventDelegate(this.Music_openFileBox_ConvIRS_FileChangeNotify);
            // 
            // Music_label_ConvolverIRGain
            // 
            this.Music_label_ConvolverIRGain.AutoSize = true;
            this.Music_label_ConvolverIRGain.Location = new System.Drawing.Point(95, 17);
            this.Music_label_ConvolverIRGain.Name = "Music_label_ConvolverIRGain";
            this.Music_label_ConvolverIRGain.Size = new System.Drawing.Size(120, 13);
            this.Music_label_ConvolverIRGain.TabIndex = 6;
            this.Music_label_ConvolverIRGain.Text = "$CONV_IR_GAIN : 0dB";
            // 
            // Music_hSlider_PostVolume
            // 
            this.Music_hSlider_PostVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_PostVolume.Location = new System.Drawing.Point(21, 128);
            this.Music_hSlider_PostVolume.MoveDelta = ((uint)(1u));
            this.Music_hSlider_PostVolume.Name = "Music_hSlider_PostVolume";
            this.Music_hSlider_PostVolume.Position = ((uint)(0u));
            this.Music_hSlider_PostVolume.PositionFloat = 0F;
            this.Music_hSlider_PostVolume.Size = new System.Drawing.Size(285, 42);
            this.Music_hSlider_PostVolume.TabIndex = 3;
            this.Music_hSlider_PostVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_PostVolume_PositionChangeNotify);
            // 
            // Music_label_PostVolume
            // 
            this.Music_label_PostVolume.AutoSize = true;
            this.Music_label_PostVolume.Location = new System.Drawing.Point(40, 108);
            this.Music_label_PostVolume.Name = "Music_label_PostVolume";
            this.Music_label_PostVolume.Size = new System.Drawing.Size(121, 13);
            this.Music_label_PostVolume.TabIndex = 2;
            this.Music_label_PostVolume.Text = "$POST_VOLUME : 0dB";
            // 
            // Music_hSlider_PreVolume
            // 
            this.Music_hSlider_PreVolume.BackColor = System.Drawing.SystemColors.Control;
            this.Music_hSlider_PreVolume.Location = new System.Drawing.Point(21, 42);
            this.Music_hSlider_PreVolume.MoveDelta = ((uint)(1u));
            this.Music_hSlider_PreVolume.Name = "Music_hSlider_PreVolume";
            this.Music_hSlider_PreVolume.Position = ((uint)(0u));
            this.Music_hSlider_PreVolume.PositionFloat = 0F;
            this.Music_hSlider_PreVolume.Size = new System.Drawing.Size(285, 42);
            this.Music_hSlider_PreVolume.TabIndex = 1;
            this.Music_hSlider_PreVolume.PositionChangeNotify += new ViPER4WindowsBin.UIControls.HSlider.PositionChangeEventDelegate(this.Music_hSlider_PreVolume_PositionChangeNotify);
            // 
            // Music_label_PreVolume
            // 
            this.Music_label_PreVolume.AutoSize = true;
            this.Music_label_PreVolume.Location = new System.Drawing.Point(40, 23);
            this.Music_label_PreVolume.Name = "Music_label_PreVolume";
            this.Music_label_PreVolume.Size = new System.Drawing.Size(114, 13);
            this.Music_label_PreVolume.TabIndex = 0;
            this.Music_label_PreVolume.Text = "$PRE_VOLUME : 0dB";
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
            // buttonBox_Mode
            // 
            this.buttonBox_Mode.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBox_Mode.Location = new System.Drawing.Point(16, 144);
            this.buttonBox_Mode.Name = "buttonBox_Mode";
            this.buttonBox_Mode.Size = new System.Drawing.Size(164, 184);
            this.buttonBox_Mode.TabIndex = 3;
            this.buttonBox_Mode.ItemSelectedNotify += new ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.buttonBox_Mode_ItemSelectedNotify);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 686);
            this.Controls.Add(this.savePreset);
            this.Controls.Add(this.onOffSwitch_Master);
            this.Controls.Add(this.loadPreset);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.groupBox_Main);
            this.Controls.Add(this.buttonBox_Mode);
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
            this.panel_MusicMode.ResumeLayout(false);
            this.panel_MusicMode.PerformLayout();
            this.panel_MovieMode.ResumeLayout(false);
            this.panel_MovieMode.PerformLayout();
            this.Movie_groupBox_SmartVolume.ResumeLayout(false);
            this.Movie_groupBox_SmartVolume.PerformLayout();
            this.Movie_groupBox_Reverb.ResumeLayout(false);
            this.Movie_groupBox_Reverb.PerformLayout();
            this.Movie_groupBox_Clarity.ResumeLayout(false);
            this.Movie_groupBox_Clarity.PerformLayout();
            this.Movie_groupBox_Bass.ResumeLayout(false);
            this.Movie_groupBox_Bass.PerformLayout();
            this.Movie_groupBox_Surround.ResumeLayout(false);
            this.Movie_groupBox_Surround.PerformLayout();
            this.Movie_groupBox_Convolver.ResumeLayout(false);
            this.Movie_groupBox_Convolver.PerformLayout();
            this.Music_groupBox_Reverb.ResumeLayout(false);
            this.Music_groupBox_Reverb.PerformLayout();
            this.Music_groupBox_Cure.ResumeLayout(false);
            this.Music_groupBox_Cure.PerformLayout();
            this.Music_groupBox_Clarity.ResumeLayout(false);
            this.Music_groupBox_Clarity.PerformLayout();
            this.Music_groupBox_Bass.ResumeLayout(false);
            this.Music_groupBox_Bass.PerformLayout();
            this.Music_groupBox_Surround.ResumeLayout(false);
            this.Music_groupBox_Convolver.ResumeLayout(false);
            this.Music_groupBox_Convolver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x040000AD RID: 173
        private global::System.ComponentModel.IContainer components;

        // Token: 0x040000AF RID: 175
        private global::System.Windows.Forms.Label label_MasterPower;

        // Token: 0x040000B1 RID: 177
        private global::ViPER4WindowsBin.UIControls.ButtonBox buttonBox_Mode;

        // Token: 0x040000B2 RID: 178
        private global::System.Windows.Forms.MenuStrip menuStrip_Main;

        // Token: 0x040000B3 RID: 179
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Language;

        // Token: 0x040000B4 RID: 180
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Setting;

        // Token: 0x040000B5 RID: 181
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;

        // Token: 0x040000B6 RID: 182
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CheckUpdate;

        // Token: 0x040000B7 RID: 183
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AboutV4W;

        // Token: 0x040000B8 RID: 184
        private global::System.Windows.Forms.GroupBox groupBox_Main;

        // Token: 0x040000B9 RID: 185
        private global::System.Windows.Forms.Label label_Copyright;

        // Token: 0x040000BA RID: 186
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LatencySetting;

        // Token: 0x040000BB RID: 187
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ResetEffect;

        // Token: 0x040000BC RID: 188
        private global::System.Windows.Forms.Panel panel_MusicMode;

        // Token: 0x040000BD RID: 189
        private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ChannelPan;

        // Token: 0x040000BE RID: 190
        private global::System.Windows.Forms.Label Music_label_PreVolume;

        // Token: 0x040000BF RID: 191
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_PreVolume;

        // Token: 0x040000C0 RID: 192
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_PostVolume;

        // Token: 0x040000C1 RID: 193
        private global::System.Windows.Forms.Label Music_label_PostVolume;

        // Token: 0x040000C2 RID: 194
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Convolver;

        // Token: 0x040000C3 RID: 195
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ConvIRGain;

        // Token: 0x040000C4 RID: 196
        private global::System.Windows.Forms.Label Music_label_ConvolverIRGain;

        // Token: 0x040000C5 RID: 197
        private global::ViPER4WindowsBin.UIControls.OpenFileBox Music_openFileBox_ConvIRS;

        // Token: 0x040000C6 RID: 198
        private global::System.Windows.Forms.GroupBox Music_groupBox_Convolver;

        // Token: 0x040000C7 RID: 199
        private global::ViPER4WindowsBin.UIControls.IRShape Music_irShape_ConvIR;

        // Token: 0x040000C8 RID: 200
        private global::System.Windows.Forms.GroupBox Music_groupBox_Surround;

        // Token: 0x040000C9 RID: 201
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Surround;

        // Token: 0x040000CA RID: 202
        private global::ViPER4WindowsBin.UIControls.ButtonBox Music_buttonBox_SurroundRoomSize;

        // Token: 0x040000CB RID: 203
        private global::System.Windows.Forms.Label Music_label_Tube;

        // Token: 0x040000CC RID: 204
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Tube;

        // Token: 0x040000CD RID: 205
        private global::System.Windows.Forms.GroupBox Music_groupBox_Bass;

        // Token: 0x040000CE RID: 206
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Bass;

        // Token: 0x040000CF RID: 207
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_BassSpkSize;

        // Token: 0x040000D0 RID: 208
        private global::System.Windows.Forms.Label Music_label_Bass_SpkSize;

        // Token: 0x040000D1 RID: 209
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_BassGain;

        // Token: 0x040000D2 RID: 210
        private global::System.Windows.Forms.Label Music_label_Bass_Gain;

        // Token: 0x040000D3 RID: 211
        private global::System.Windows.Forms.GroupBox Music_groupBox_Clarity;

        // Token: 0x040000D4 RID: 212
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_Clarity;

        // Token: 0x040000D5 RID: 213
        private global::System.Windows.Forms.Label Music_label_Clarity;

        // Token: 0x040000D6 RID: 214
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Clarity;

        // Token: 0x040000D7 RID: 215
        private global::ViPER4WindowsBin.UIControls.ButtonBox Music_buttonBox_ClarityMode;

        // Token: 0x040000D8 RID: 216
        private global::System.Windows.Forms.GroupBox Music_groupBox_Cure;

        // Token: 0x040000D9 RID: 217
        private global::ViPER4WindowsBin.UIControls.ButtonBox Music_buttonBox_CureLevel;

        // Token: 0x040000DA RID: 218
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Cure;

        // Token: 0x040000DB RID: 219
        private global::System.Windows.Forms.GroupBox Music_groupBox_Reverb;

        // Token: 0x040000DC RID: 220
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Music_onOffSwitch_Reverb;

        // Token: 0x040000DD RID: 221
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbDensity;

        // Token: 0x040000DE RID: 222
        private global::System.Windows.Forms.Label Music_label_Reverb_Density;

        // Token: 0x040000DF RID: 223
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbDamping;

        // Token: 0x040000E0 RID: 224
        private global::System.Windows.Forms.Label Music_label_Reverb_Damping;

        // Token: 0x040000E1 RID: 225
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbSize;

        // Token: 0x040000E2 RID: 226
        private global::System.Windows.Forms.Label Music_label_Reverb_Size;

        // Token: 0x040000E3 RID: 227
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbMix;

        // Token: 0x040000E4 RID: 228
        private global::System.Windows.Forms.Label Music_label_Reverb_Mix;

        // Token: 0x040000E5 RID: 229
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbEarlyMix;

        // Token: 0x040000E6 RID: 230
        private global::System.Windows.Forms.Label Music_label_Reverb_EarlyMix;

        // Token: 0x040000E7 RID: 231
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbPreDelay;

        // Token: 0x040000E8 RID: 232
        private global::System.Windows.Forms.Label Music_label_Reverb_PreDelay;

        // Token: 0x040000E9 RID: 233
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbDecay;

        // Token: 0x040000EA RID: 234
        private global::System.Windows.Forms.Label Music_label_Reverb_Decay;

        // Token: 0x040000EB RID: 235
        private global::ViPER4WindowsBin.UIControls.HSlider Music_hSlider_ReverbBandWidth;

        // Token: 0x040000EC RID: 236
        private global::System.Windows.Forms.Label Music_label_Reverb_BandWidth;

        // Token: 0x040000ED RID: 237
        private global::ViPER4WindowsBin.UIControls.SingleButton Music_singleButton_ReverbPreset;

        // Token: 0x040000EE RID: 238
        private global::ViPER4WindowsBin.UIControls.SingleButton Music_singleButton_Equalizer;

        // Token: 0x040000EF RID: 239
        private global::ViPER4WindowsBin.UIControls.SingleButton Music_singleButton_Compressor;

        // Token: 0x040000F2 RID: 242
        private global::System.Windows.Forms.Panel panel_MovieMode;

        // Token: 0x040000F3 RID: 243
        private global::ViPER4WindowsBin.UIControls.SingleButton Movie_singleButton_Compressor;

        // Token: 0x040000F4 RID: 244
        private global::ViPER4WindowsBin.UIControls.SingleButton Movie_singleButton_Equalizer;

        // Token: 0x040000F5 RID: 245
        private global::System.Windows.Forms.GroupBox Movie_groupBox_Reverb;

        // Token: 0x040000F6 RID: 246
        private global::ViPER4WindowsBin.UIControls.SingleButton Movie_singleButton_ReverbPreset;

        // Token: 0x040000F7 RID: 247
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbMix;

        // Token: 0x040000F8 RID: 248
        private global::System.Windows.Forms.Label Movie_label_Reverb_Mix;

        // Token: 0x040000F9 RID: 249
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbEarlyMix;

        // Token: 0x040000FA RID: 250
        private global::System.Windows.Forms.Label Movie_label_Reverb_EarlyMix;

        // Token: 0x040000FB RID: 251
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbPreDelay;

        // Token: 0x040000FC RID: 252
        private global::System.Windows.Forms.Label Movie_label_Reverb_PreDelay;

        // Token: 0x040000FD RID: 253
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbDecay;

        // Token: 0x040000FE RID: 254
        private global::System.Windows.Forms.Label Movie_label_Reverb_Decay;

        // Token: 0x040000FF RID: 255
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbBandWidth;

        // Token: 0x04000100 RID: 256
        private global::System.Windows.Forms.Label Movie_label_Reverb_BandWidth;

        // Token: 0x04000101 RID: 257
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbDensity;

        // Token: 0x04000102 RID: 258
        private global::System.Windows.Forms.Label Movie_label_Reverb_Density;

        // Token: 0x04000103 RID: 259
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbDamping;

        // Token: 0x04000104 RID: 260
        private global::System.Windows.Forms.Label Movie_label_Reverb_Damping;

        // Token: 0x04000105 RID: 261
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ReverbSize;

        // Token: 0x04000106 RID: 262
        private global::System.Windows.Forms.Label Movie_label_Reverb_Size;

        // Token: 0x04000107 RID: 263
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Movie_onOffSwitch_Reverb;

        // Token: 0x04000108 RID: 264
        private global::System.Windows.Forms.GroupBox Movie_groupBox_Clarity;

        // Token: 0x04000109 RID: 265
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_Clarity;

        // Token: 0x0400010A RID: 266
        private global::System.Windows.Forms.Label Movie_label_Clarity;

        // Token: 0x0400010B RID: 267
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Movie_onOffSwitch_Clarity;

        // Token: 0x0400010C RID: 268
        private global::System.Windows.Forms.GroupBox Movie_groupBox_Bass;

        // Token: 0x0400010D RID: 269
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_BassGain;

        // Token: 0x0400010E RID: 270
        private global::System.Windows.Forms.Label Movie_label_Bass_Gain;

        // Token: 0x0400010F RID: 271
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_BassSpkSize;

        // Token: 0x04000110 RID: 272
        private global::System.Windows.Forms.Label Movie_label_Bass_SpkSize;

        // Token: 0x04000111 RID: 273
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Movie_onOffSwitch_Bass;

        // Token: 0x04000112 RID: 274
        private global::System.Windows.Forms.GroupBox Movie_groupBox_Surround;

        // Token: 0x04000113 RID: 275
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Movie_onOffSwitch_Surround;

        // Token: 0x04000114 RID: 276
        private global::System.Windows.Forms.GroupBox Movie_groupBox_Convolver;

        // Token: 0x04000115 RID: 277
        private global::ViPER4WindowsBin.UIControls.IRShape Movie_irShape_ConvIR;

        // Token: 0x04000116 RID: 278
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Movie_onOffSwitch_Convolver;

        // Token: 0x04000117 RID: 279
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_ConvIRGain;

        // Token: 0x04000118 RID: 280
        private global::ViPER4WindowsBin.UIControls.OpenFileBox Movie_openFileBox_ConvIRS;

        // Token: 0x04000119 RID: 281
        private global::System.Windows.Forms.Label Movie_label_ConvolverIRGain;

        // Token: 0x0400011A RID: 282
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_PostVolume;

        // Token: 0x0400011B RID: 283
        private global::System.Windows.Forms.Label Movie_label_PostVolume;

        // Token: 0x0400011C RID: 284
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_PreVolume;

        // Token: 0x0400011D RID: 285
        private global::System.Windows.Forms.Label Movie_label_PreVolume;

        // Token: 0x0400011E RID: 286
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_SurroundImage;

        // Token: 0x0400011F RID: 287
        private global::System.Windows.Forms.Label Movie_label_Surround_Image;

        // Token: 0x04000120 RID: 288
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_Surround3D;

        // Token: 0x04000121 RID: 289
        private global::System.Windows.Forms.Label Movie_label_Surround_3D;

        // Token: 0x04000122 RID: 290
        private global::System.Windows.Forms.GroupBox Movie_groupBox_SmartVolume;

        // Token: 0x04000123 RID: 291
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_SmartVolumeMaxLevel;

        // Token: 0x04000124 RID: 292
        private global::System.Windows.Forms.Label Movie_label_SmartVolume_MaxLevel;

        // Token: 0x04000125 RID: 293
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_SmartVolumeRatio;

        // Token: 0x04000126 RID: 294
        private global::System.Windows.Forms.Label Movie_label_SmartVolume_ControlStrength;

        // Token: 0x04000127 RID: 295
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Movie_onOffSwitch_SmartVolume;

        // Token: 0x04000128 RID: 296
        private global::ViPER4WindowsBin.UIControls.HSlider Movie_hSlider_SmartVolumeLevel;

        // Token: 0x04000129 RID: 297
        private global::System.Windows.Forms.Label Movie_label_SmartVolume_Level;

        // Token: 0x0400012A RID: 298
        private global::System.Windows.Forms.Panel panel_Freestyle;

        // Token: 0x0400012B RID: 299
        private global::ViPER4WindowsBin.UIControls.SingleButton Freestyle_singleButton_Compressor;

        // Token: 0x0400012C RID: 300
        private global::ViPER4WindowsBin.UIControls.SingleButton Freestyle_singleButton_Equalizer;

        // Token: 0x0400012D RID: 301
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Reverb;

        // Token: 0x0400012E RID: 302
        private global::ViPER4WindowsBin.UIControls.SingleButton Freestyle_singleButton_ReverbPreset;

        // Token: 0x0400012F RID: 303
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbMix;

        // Token: 0x04000130 RID: 304
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Mix;

        // Token: 0x04000131 RID: 305
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbEarlyMix;

        // Token: 0x04000132 RID: 306
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_EarlyMix;

        // Token: 0x04000133 RID: 307
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbPreDelay;

        // Token: 0x04000134 RID: 308
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_PreDelay;

        // Token: 0x04000135 RID: 309
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbDecay;

        // Token: 0x04000136 RID: 310
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Decay;

        // Token: 0x04000137 RID: 311
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbBandWidth;

        // Token: 0x04000138 RID: 312
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_BandWidth;

        // Token: 0x04000139 RID: 313
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbDensity;

        // Token: 0x0400013A RID: 314
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Density;

        // Token: 0x0400013B RID: 315
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbDamping;

        // Token: 0x0400013C RID: 316
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Damping;

        // Token: 0x0400013D RID: 317
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ReverbSize;

        // Token: 0x0400013E RID: 318
        private global::System.Windows.Forms.Label Freestyle_label_Reverb_Size;

        // Token: 0x0400013F RID: 319
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Reverb;

        // Token: 0x04000140 RID: 320
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Cure;

        // Token: 0x04000141 RID: 321
        private global::ViPER4WindowsBin.UIControls.ButtonBox Freestyle_buttonBox_CureLevel;

        // Token: 0x04000142 RID: 322
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Cure;

        // Token: 0x04000143 RID: 323
        private global::System.Windows.Forms.Label Freestyle_label_Tube;

        // Token: 0x04000144 RID: 324
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Tube;

        // Token: 0x04000145 RID: 325
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Clarity;

        // Token: 0x04000146 RID: 326
        private global::ViPER4WindowsBin.UIControls.ButtonBox Freestyle_buttonBox_ClarityMode;

        // Token: 0x04000147 RID: 327
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_Clarity;

        // Token: 0x04000148 RID: 328
        private global::System.Windows.Forms.Label Freestyle_label_Clarity;

        // Token: 0x04000149 RID: 329
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Clarity;

        // Token: 0x0400014A RID: 330
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Bass;

        // Token: 0x0400014B RID: 331
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_BassGain;

        // Token: 0x0400014C RID: 332
        private global::System.Windows.Forms.Label Freestyle_label_Bass_Gain;

        // Token: 0x0400014D RID: 333
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_BassSpkSize;

        // Token: 0x0400014E RID: 334
        private global::System.Windows.Forms.Label Freestyle_label_Bass_SpkSize;

        // Token: 0x0400014F RID: 335
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Bass;

        // Token: 0x04000150 RID: 336
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_VHESurround;

        // Token: 0x04000151 RID: 337
        private global::ViPER4WindowsBin.UIControls.ButtonBox Freestyle_buttonBox_SurroundVHERoomSize;

        // Token: 0x04000152 RID: 338
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_SurroundVHE;

        // Token: 0x04000153 RID: 339
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_Convolver;

        // Token: 0x04000154 RID: 340
        private global::ViPER4WindowsBin.UIControls.IRShape Freestyle_irShape_ConvIR;

        // Token: 0x04000155 RID: 341
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Convolver;

        // Token: 0x04000156 RID: 342
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_ConvIRGain;

        // Token: 0x04000157 RID: 343
        private global::ViPER4WindowsBin.UIControls.OpenFileBox Freestyle_openFileBox_ConvIRS;

        // Token: 0x04000158 RID: 344
        private global::System.Windows.Forms.Label Freestyle_label_ConvolverIRGain;

        // Token: 0x04000159 RID: 345
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_PostVolume;

        // Token: 0x0400015A RID: 346
        private global::System.Windows.Forms.Label Freestyle_label_PostVolume;

        // Token: 0x0400015B RID: 347
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_PreVolume;

        // Token: 0x0400015C RID: 348
        private global::System.Windows.Forms.Label Freestyle_label_PreVolume;

        // Token: 0x0400015D RID: 349
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_3DSurround;

        // Token: 0x0400015E RID: 350
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_SurroundImage;

        // Token: 0x0400015F RID: 351
        private global::System.Windows.Forms.Label Freestyle_label_Surround_Image;

        // Token: 0x04000160 RID: 352
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_Surround3D;

        // Token: 0x04000161 RID: 353
        private global::System.Windows.Forms.Label Freestyle_label_Surround_3D;

        // Token: 0x04000162 RID: 354
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_Surround3D;

        // Token: 0x04000163 RID: 355
        private global::ViPER4WindowsBin.UIControls.ButtonBox Freestyle_buttonBox_BassMode;

        // Token: 0x04000164 RID: 356
        private global::System.Windows.Forms.GroupBox Freestyle_groupBox_SmartVolume;

        // Token: 0x04000165 RID: 357
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_SmartVolumeLevel;

        // Token: 0x04000166 RID: 358
        private global::System.Windows.Forms.Label Freestyle_label_SmartVolume_Level;

        // Token: 0x04000167 RID: 359
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_SmartVolumeMaxLevel;

        // Token: 0x04000168 RID: 360
        private global::System.Windows.Forms.Label Freestyle_label_SmartVolume_MaxLevel;

        // Token: 0x04000169 RID: 361
        private global::ViPER4WindowsBin.UIControls.HSlider Freestyle_hSlider_SmartVolumeRatio;

        // Token: 0x0400016A RID: 362
        private global::System.Windows.Forms.Label Freestyle_label_SmartVolume_ControlStrength;

        // Token: 0x0400016B RID: 363
        private global::ViPER4WindowsBin.UIControls.OnOffSwitch Freestyle_onOffSwitch_SmartVolume;

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
