using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ViPER4WindowsBin.Properties;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x02000015 RID: 21
	public partial class frmMain : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x060000B5 RID: 181 RVA: 0x00009230 File Offset: 0x00007430
		public static void SetLanguage(string szLanguagePath, string szLanguageFile)
		{
			frmMain.m_szLanguagePath = szLanguagePath;
			frmMain.m_szLanguageFile = szLanguageFile;
			if (frmMain.m_szLanguagePath == "" || frmMain.m_szLanguageFile == "")
			{
				frmMain.m_szLanguageName = "";
				return;
			}
			ConfigFile configFile = new ConfigFile(szLanguageFile);
			frmMain.m_szLanguageName = configFile.ReadConfig("$LANGUAGE_NAME");
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009290 File Offset: 0x00007490
		public frmMain(string[] szArgs)
		{
			this.InitializeComponent();
			this.m_bArgvStartupToMinimized = false;
			if (szArgs != null)
			{
				int num = szArgs.Length;
			}
			this.m_szLocalPreset = AppDomain.CurrentDomain.BaseDirectory;
			if (!this.m_szLocalPreset.EndsWith("\\"))
			{
				this.m_szLocalPreset += "\\";
			}
			this.m_szLocalPreset += this.m_szLocalPresetFileName;
			this.m_szIRSPath = AppDomain.CurrentDomain.BaseDirectory;
			if (!this.m_szIRSPath.EndsWith("\\"))
			{
				this.m_szIRSPath += "\\";
			}
			this.m_szIRSPath = this.m_szIRSPath + this.m_szImpulseResponsePath + "\\";
			if (!Directory.Exists(this.m_szIRSPath))
			{
				try
				{
					Directory.CreateDirectory(this.m_szIRSPath);
				}
				catch
				{
				}
			}
			this.m_szPresetsPath = AppDomain.CurrentDomain.BaseDirectory;
			if (!this.m_szPresetsPath.EndsWith("\\"))
			{
				this.m_szPresetsPath += "\\";
			}
			this.m_szPresetsPath = this.m_szPresetsPath + this.m_szUserPresetPath + "\\";
			if (!Directory.Exists(this.m_szPresetsPath))
			{
				try
				{
					Directory.CreateDirectory(this.m_szPresetsPath);
				}
				catch
				{
				}
			}
			string text = AppDomain.CurrentDomain.BaseDirectory;
			if (!text.EndsWith("\\"))
			{
				text += "\\";
			}
			ConfigFile configFile = new ConfigFile(text + "Config.ini");
			string text2 = configFile.ReadConfig("$CLOSE_APP_TO_TRAY");
			if (string.IsNullOrEmpty(text2))
			{
				this.m_bCloseToTray = false;
			}
			else if (text2.ToUpper() == "TRUE")
			{
				this.m_bCloseToTray = true;
			}
			else
			{
				this.m_bCloseToTray = false;
			}
			this.m_lstTrayMenuPreset.Clear();
			string text3 = configFile.ReadConfig("$TRAY_MENU_PRESET_COUNT");
			if (!string.IsNullOrEmpty(text3))
			{
				int num2 = 0;
				try
				{
					if (int.TryParse(text3, out num2))
					{
						for (int i = 0; i < num2; i++)
						{
							string text4 = configFile.ReadConfig("$TRAY_MENU_PRESET_NAME_" + i.ToString());
							string text5 = configFile.ReadConfig("$TRAY_MENU_PRESET_MODE_" + i.ToString());
							string szFile = configFile.ReadConfig("$TRAY_MENU_PRESET_FILE_" + i.ToString());
							if (string.IsNullOrEmpty(text4))
							{
								text4 = GlobalMessages.UNNAMED;
							}
							if (!string.IsNullOrEmpty(text5))
							{
								int num3 = -1;
								if (text5 == "EFFECT_MODE_MUSIC")
								{
									num3 = 0;
								}
								if (text5 == "EFFECT_MODE_MOVIE")
								{
									num3 = 1;
								}
								if (text5 == "EFFECT_MODE_FREESTYLE")
								{
									num3 = 2;
								}
								if (num3 != -1)
								{
									this.m_lstTrayMenuPreset.Add(new TrayMenuPreset(text4, num3, szFile));
								}
							}
						}
					}
				}
				catch
				{
					this.m_lstTrayMenuPreset.Clear();
				}
			}
			string config = RegHelper.GetConfig();
			if (!RuntimeUtils.ConfigProxy.CheckConfigVersion(config))
			{
				RuntimeUtils.ConfigProxy.UpdateConfigToCurrent(config);
			}
			this.m_cpConfigProxy = new RuntimeUtils.ConfigProxy(config);
			Parameters.LoadDefaultParameter(ref this.m_paramBaseSystem);
			Parameters.LoadDefaultParameter(ref this.m_paramMusicMode);
			Parameters.LoadDefaultParameter(ref this.m_paramMovieMode);
			Parameters.LoadDefaultParameter(ref this.m_paramFreestyle);
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			if (!Parameters.ReadPreset(this.m_szLocalPreset, ref this.m_paramBaseSystem, ref this.m_paramMusicMode, ref this.m_paramMovieMode, ref this.m_paramFreestyle, out flag, out flag2, out flag3, out flag4))
			{
				Parameters.LoadDefaultParameter(ref this.m_paramBaseSystem);
				Parameters.LoadDefaultParameter(ref this.m_paramMusicMode);
				Parameters.LoadDefaultParameter(ref this.m_paramMovieMode);
				Parameters.LoadDefaultParameter(ref this.m_paramFreestyle);
			}
			else
			{
				if (!flag)
				{
					Parameters.LoadDefaultParameter(ref this.m_paramBaseSystem);
				}
				if (!flag2)
				{
					Parameters.LoadDefaultParameter(ref this.m_paramMusicMode);
				}
				if (!flag3)
				{
					Parameters.LoadDefaultParameter(ref this.m_paramMovieMode);
				}
				if (!flag4)
				{
					Parameters.LoadDefaultParameter(ref this.m_paramFreestyle);
				}
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramBaseSystem);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramMusicMode);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramMovieMode);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
			this.toolStripMenuItem_Language.Text = GlobalMessages.MENU_LANGUAGE;
			this.toolStripMenuItem_Setting.Text = GlobalMessages.MENU_SETTING;
			this.toolStripMenuItem_LatencySetting.Text = GlobalMessages.LATENCY_SETTING;
			this.toolStripMenuItem_ChannelPan.Text = GlobalMessages.CHANNEL_PAN;
			this.toolStripMenuItem_Virtualization.Text = GlobalMessages.VIRTUALIZATION;
			this.toolStripMenuItem_ResetEffect.Text = GlobalMessages.RESET_EFFECT;
			this.toolStripMenuItem_Settings.Text = GlobalMessages.SETTINGS;
			this.toolStripMenuItem_Help.Text = GlobalMessages.MENU_HELP;
			this.toolStripMenuItem_CheckUpdate.Text = GlobalMessages.CHECK_UPDATE;
			this.toolStripMenuItem_AboutV4W.Text = GlobalMessages.ABOUT;
			this.label_MasterPower.Text = GlobalMessages.MASTER_POWER;
			this.label_Copyright.Text = GlobalMessages.COPYRIGHT;
			if (Directory.Exists(this.m_szIRSPath))
			{
				this.Freestyle_openFileBox_ConvIRS.OpenDirectory = this.m_szIRSPath;
			}
			this.Freestyle_groupBox_3DSurround.Text = GlobalMessages.THREE_D_SURROUND;
			this.Freestyle_label_Surround_3D.Text = GlobalMessages.SURROUND_3D;
			this.Freestyle_label_Surround_Image.Text = GlobalMessages.SURROUND_IMAGE;
			this.Freestyle_groupBox_VHESurround.Text = GlobalMessages.VHE_SURROUND;
			this.Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_SMALLEST_ROOM, "0"));
			this.Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_SMALL_ROOM, "1"));
			this.Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_MID_ROOM, "2"));
			this.Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_LARGE_ROOM, "3"));
			this.Freestyle_buttonBox_SurroundVHERoomSize.AddItem(new ButtonBox.Item(GlobalMessages.VHE_LARGEST_ROOM, "4"));
			this.Freestyle_groupBox_Bass.Text = GlobalMessages.BASS;
			this.Freestyle_label_Bass_SpkSize.Text = GlobalMessages.BASS_SPKSIZE;
			this.Freestyle_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN;
			this.Freestyle_buttonBox_BassMode.AddItem(new ButtonBox.Item(GlobalMessages.NATURAL_BASS, "0"));
			this.Freestyle_buttonBox_BassMode.AddItem(new ButtonBox.Item(GlobalMessages.PURE_BASS, "1"));
			this.Freestyle_groupBox_Clarity.Text = GlobalMessages.CLARITY;
			this.Freestyle_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.NATURAL_CLARITY, "0"));
			this.Freestyle_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.OZONE_CLARITY, "1"));
			this.Freestyle_buttonBox_ClarityMode.AddItem(new ButtonBox.Item(GlobalMessages.XHIFI_CLARITY, "2"));
			this.Freestyle_label_Clarity.Text = GlobalMessages.CLARITY;
			this.Freestyle_groupBox_Cure.Text = GlobalMessages.CURE;
			this.Freestyle_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.SLIGHT_CURE, 6226570u.ToString()));
			this.Freestyle_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.MODERATE_CURE, 3932860u.ToString()));
			this.Freestyle_buttonBox_CureLevel.AddItem(new ButtonBox.Item(GlobalMessages.EXTREME_CURE, 2949820u.ToString()));
			this.Freestyle_label_Tube.Text = GlobalMessages.TUBE;
			this.Freestyle_groupBox_Reverb.Text = GlobalMessages.REVERB;
			this.Freestyle_label_Reverb_Size.Text = GlobalMessages.REVERB_SIZE;
			this.Freestyle_label_Reverb_Damping.Text = GlobalMessages.REVERB_DAMPING;
			this.Freestyle_label_Reverb_Density.Text = GlobalMessages.REVERB_DENSITY;
			this.Freestyle_label_Reverb_BandWidth.Text = GlobalMessages.REVERB_BANDWIDTH;
			this.Freestyle_label_Reverb_Decay.Text = GlobalMessages.REVERB_DECAY;
			this.Freestyle_label_Reverb_PreDelay.Text = GlobalMessages.REVERB_PREDELAY;
			this.Freestyle_label_Reverb_EarlyMix.Text = GlobalMessages.REVERB_EARLYMIX;
			this.Freestyle_label_Reverb_Mix.Text = GlobalMessages.REVERB_MIX;
			this.Freestyle_groupBox_SmartVolume.Text = GlobalMessages.SMART_VOLUME;
			this.Freestyle_label_SmartVolume_ControlStrength.Text = GlobalMessages.SMART_VOLUME_CONTROL_STRENGTH;
			this.Freestyle_label_SmartVolume_MaxLevel.Text = GlobalMessages.SMART_VOLUME_MAXLEVEL;
			this.Freestyle_label_SmartVolume_Level.Text = GlobalMessages.SMART_VOLUME_LEVEL;
			this.toolStripMenuItem_Language.DropDownItems.Clear();
			FolderExplorer folderExplorer = new FolderExplorer();
			string[] array = folderExplorer.ListFiles(frmMain.m_szLanguagePath);
			foreach (string text6 in array)
			{
				ConfigFile configFile2 = new ConfigFile(text6);
				string text7 = configFile2.ReadConfig("$LANGUAGE_NAME");
				ToolStripItem toolStripItem = new ToolStripMenuItem();
				toolStripItem.Text = text7;
				toolStripItem.Tag = text6;
				toolStripItem.Click += this.LanguageChanged;
				this.toolStripMenuItem_Language.DropDownItems.Add(toolStripItem);
			}
			this.groupBox_Main.Controls.Clear();
			this.groupBox_Main.Controls.Add(this.panel_Freestyle);
			this.panel_Freestyle.Dock = DockStyle.Fill;
			this.UpdateAllControlsFromParameters();
			if (szArgs == null)
			{
				return;
			}
			if (szArgs.Length <= 0)
			{
				return;
			}
			for (int k = 0; k < szArgs.Length; k++)
			{
				if (szArgs[k].ToLower().Trim() == "--hide")
				{
					if (!this.m_bCloseToTray)
					{
						this.m_bArgvStartupToMinimized = false;
					}
					else
					{
						this.m_bArgvStartupToMinimized = true;
					}
				}
				else if (szArgs[k].ToLower().Trim() == "-m")
				{
					if (!this.m_bCloseToTray)
					{
						this.m_bArgvStartupToMinimized = false;
					}
					else
					{
						this.m_bArgvStartupToMinimized = true;
					}
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000A2BC File Offset: 0x000084BC
		private void SaveAppSettings()
		{
			string text = AppDomain.CurrentDomain.BaseDirectory;
			if (!text.EndsWith("\\"))
			{
				text += "\\";
			}
			ConfigFile configFile = new ConfigFile(text + "Config.ini");
			if (this.m_bCloseToTray)
			{
				configFile.SetConfig("$CLOSE_APP_TO_TRAY", "TRUE");
			}
			else
			{
				configFile.SetConfig("$CLOSE_APP_TO_TRAY", "FALSE");
			}
			int num = 0;
			for (int i = 0; i < this.m_lstTrayMenuPreset.Count; i++)
			{
				if (this.m_lstTrayMenuPreset[i].Valid())
				{
					num++;
				}
			}
			configFile.SetConfig("$TRAY_MENU_PRESET_COUNT", num.ToString());
			int j = 0;
			int num2 = 0;
			while (j < this.m_lstTrayMenuPreset.Count)
			{
				if (this.m_lstTrayMenuPreset[j].Valid())
				{
					if (string.IsNullOrEmpty(this.m_lstTrayMenuPreset[j].PresetName))
					{
						this.m_lstTrayMenuPreset[j].PresetName = GlobalMessages.UNNAMED;
					}
					string szValue = "";
					if (this.m_lstTrayMenuPreset[j].PresetMode == 0)
					{
						szValue = "EFFECT_MODE_MUSIC";
					}
					if (this.m_lstTrayMenuPreset[j].PresetMode == 1)
					{
						szValue = "EFFECT_MODE_MOVIE";
					}
					if (this.m_lstTrayMenuPreset[j].PresetMode == 2)
					{
						szValue = "EFFECT_MODE_FREESTYLE";
					}
					configFile.SetConfig("$TRAY_MENU_PRESET_NAME_" + num2.ToString(), this.m_lstTrayMenuPreset[j].PresetName);
					configFile.SetConfig("$TRAY_MENU_PRESET_MODE_" + num2.ToString(), szValue);
					configFile.SetConfig("$TRAY_MENU_PRESET_FILE_" + num2.ToString(), this.m_lstTrayMenuPreset[j].PresetFile);
					num2++;
				}
				j++;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000A4A0 File Offset: 0x000086A0
		private void SetupTrayMenu()
		{
			this.contextMenuStrip_TrayMenu.Items.Clear();
			bool flag = false;
			for (int i = 0; i < this.m_lstTrayMenuPreset.Count; i++)
			{
				if (this.m_lstTrayMenuPreset[i].Valid())
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Text = this.m_lstTrayMenuPreset[i].PresetName;
					toolStripMenuItem.Tag = this.m_lstTrayMenuPreset[i];
					toolStripMenuItem.Click += this.TrayMenu_SelectPreset;
					this.contextMenuStrip_TrayMenu.Items.Add(toolStripMenuItem);
					flag = true;
				}
			}
			if (flag)
			{
				this.contextMenuStrip_TrayMenu.Items.Add(new ToolStripSeparator());
			}
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
			toolStripMenuItem2.Text = GlobalMessages.MUSIC_MODE;
			toolStripMenuItem2.Tag = "MUSIC_MODE";
			if (this.m_paramBaseSystem.m_nEffectMode == 0u)
			{
				toolStripMenuItem2.Checked = true;
			}
			toolStripMenuItem2.Click += this.TrayMenu_SwitchEffectMode;
			this.contextMenuStrip_TrayMenu.Items.Add(toolStripMenuItem2);
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
			toolStripMenuItem3.Text = GlobalMessages.MOVIE_MODE;
			toolStripMenuItem3.Tag = "MOVIE_MODE";
			if (this.m_paramBaseSystem.m_nEffectMode == 1u)
			{
				toolStripMenuItem3.Checked = true;
			}
			toolStripMenuItem3.Click += this.TrayMenu_SwitchEffectMode;
			this.contextMenuStrip_TrayMenu.Items.Add(toolStripMenuItem3);
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
			toolStripMenuItem4.Text = GlobalMessages.FREESTYLE_MODE;
			toolStripMenuItem4.Tag = "FREESTYLE_MODE";
			if (this.m_paramBaseSystem.m_nEffectMode == 2u)
			{
				toolStripMenuItem4.Checked = true;
			}
			toolStripMenuItem4.Click += this.TrayMenu_SwitchEffectMode;
			this.contextMenuStrip_TrayMenu.Items.Add(toolStripMenuItem4);
			this.contextMenuStrip_TrayMenu.Items.Add(new ToolStripSeparator());
			ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem();
			if (this.m_paramBaseSystem.m_bEffectEnabled == 0)
			{
				toolStripMenuItem5.Text = GlobalMessages.SWITCH_ON_EFFECT;
			}
			else
			{
				toolStripMenuItem5.Text = GlobalMessages.SWITCH_OFF_EFFECT;
			}
			toolStripMenuItem5.Click += this.TrayMenu_SwitchEffectOnOff;
			this.contextMenuStrip_TrayMenu.Items.Add(toolStripMenuItem5);
			this.contextMenuStrip_TrayMenu.Items.Add(new ToolStripSeparator());
			ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem();
			toolStripMenuItem6.Text = GlobalMessages.EXIT_APPLICTION;
			toolStripMenuItem6.Click += this.TrayMenu_ExitApplication;
			this.contextMenuStrip_TrayMenu.Items.Add(toolStripMenuItem6);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000A719 File Offset: 0x00008919
		private void TrayMenu_ExitApplication(object sender, EventArgs e)
		{
			Parameters.SaveLocalPreset(this.m_szLocalPreset, this.m_paramBaseSystem, this.m_paramMusicMode, this.m_paramMovieMode, this.m_paramFreestyle);
			this.SaveAppSettings();
			Application.Exit();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000A74C File Offset: 0x0000894C
		private void TrayMenu_SwitchEffectOnOff(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			if (sender.GetType() != typeof(ToolStripMenuItem))
			{
				return;
			}
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (this.m_paramBaseSystem.m_bEffectEnabled == 0)
			{
				this.m_paramBaseSystem.m_bEffectEnabled = 1;
			}
			else
			{
				this.m_paramBaseSystem.m_bEffectEnabled = 0;
			}
			if (this.m_paramBaseSystem.m_bEffectEnabled == 0)
			{
				toolStripMenuItem.Text = GlobalMessages.SWITCH_ON_EFFECT;
			}
			else
			{
				toolStripMenuItem.Text = GlobalMessages.SWITCH_OFF_EFFECT;
			}
			this.UpdateAllControlsFromParameters();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000A7CC File Offset: 0x000089CC
		private void TrayMenu_SwitchEffectMode(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			if (sender.GetType() != typeof(ToolStripMenuItem))
			{
				return;
			}
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem.Tag == null)
			{
				return;
			}
			if (toolStripMenuItem.Tag.GetType() != typeof(string))
			{
				return;
			}
			string text = toolStripMenuItem.Tag as string;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			ToolStripMenuItem toolStripMenuItem2 = null;
			ToolStripMenuItem toolStripMenuItem3 = null;
			ToolStripMenuItem toolStripMenuItem4 = null;
			foreach (object obj in this.contextMenuStrip_TrayMenu.Items)
			{
				if (obj != null && obj.GetType() == typeof(ToolStripMenuItem))
				{
					ToolStripMenuItem toolStripMenuItem5 = obj as ToolStripMenuItem;
					if (toolStripMenuItem5.Tag != null && toolStripMenuItem5.Tag.GetType() == typeof(string))
					{
						string text2 = toolStripMenuItem5.Tag as string;
						if (!string.IsNullOrEmpty(text2))
						{
							if (text2 == "MUSIC_MODE")
							{
								toolStripMenuItem2 = toolStripMenuItem5;
							}
							else if (text2 == "MOVIE_MODE")
							{
								toolStripMenuItem3 = toolStripMenuItem5;
							}
							else if (text2 == "FREESTYLE_MODE")
							{
								toolStripMenuItem4 = toolStripMenuItem5;
							}
						}
					}
				}
			}
			if (toolStripMenuItem2 == null || toolStripMenuItem3 == null || toolStripMenuItem4 == null)
			{
				return;
			}
			if (text == "MUSIC_MODE")
			{
				toolStripMenuItem2.Checked = true;
				toolStripMenuItem3.Checked = false;
				toolStripMenuItem4.Checked = false;
				this.m_paramBaseSystem.m_nEffectMode = 0u;
				this.UpdateAllControlsFromParameters();
				return;
			}
			if (text == "MOVIE_MODE")
			{
				toolStripMenuItem2.Checked = false;
				toolStripMenuItem3.Checked = true;
				toolStripMenuItem4.Checked = false;
				this.m_paramBaseSystem.m_nEffectMode = 1u;
				this.UpdateAllControlsFromParameters();
				return;
			}
			if (text == "FREESTYLE_MODE")
			{
				toolStripMenuItem2.Checked = false;
				toolStripMenuItem3.Checked = false;
				toolStripMenuItem4.Checked = true;
				this.m_paramBaseSystem.m_nEffectMode = 2u;
				this.UpdateAllControlsFromParameters();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		private void TrayMenu_SelectPreset(object sender, EventArgs e)
		{
			if (sender == null)
			{
				return;
			}
			if (sender.GetType() != typeof(ToolStripMenuItem))
			{
				return;
			}
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem.Tag == null)
			{
				return;
			}
			if (toolStripMenuItem.Tag.GetType() != typeof(TrayMenuPreset))
			{
				return;
			}
			TrayMenuPreset trayMenuPreset = toolStripMenuItem.Tag as TrayMenuPreset;
			if (!trayMenuPreset.Valid())
			{
				return;
			}
			this.m_paramBaseSystem.m_nEffectMode = (uint)trayMenuPreset.PresetMode;
			ToolStripMenuItem toolStripMenuItem2 = null;
			ToolStripMenuItem toolStripMenuItem3 = null;
			ToolStripMenuItem toolStripMenuItem4 = null;
			foreach (object obj in this.contextMenuStrip_TrayMenu.Items)
			{
				if (obj != null && obj.GetType() == typeof(ToolStripMenuItem))
				{
					ToolStripMenuItem toolStripMenuItem5 = obj as ToolStripMenuItem;
					if (toolStripMenuItem5.Tag != null && toolStripMenuItem5.Tag.GetType() == typeof(string))
					{
						string text = toolStripMenuItem5.Tag as string;
						if (!string.IsNullOrEmpty(text))
						{
							if (text == "MUSIC_MODE")
							{
								toolStripMenuItem2 = toolStripMenuItem5;
							}
							else if (text == "MOVIE_MODE")
							{
								toolStripMenuItem3 = toolStripMenuItem5;
							}
							else if (text == "FREESTYLE_MODE")
							{
								toolStripMenuItem4 = toolStripMenuItem5;
							}
						}
					}
				}
			}
			if (toolStripMenuItem2 == null || toolStripMenuItem3 == null || toolStripMenuItem4 == null)
			{
				return;
			}
			if (this.m_paramBaseSystem.m_nEffectMode == 0u)
			{
				toolStripMenuItem2.Checked = true;
				toolStripMenuItem3.Checked = false;
				toolStripMenuItem4.Checked = false;
			}
			else if (this.m_paramBaseSystem.m_nEffectMode == 1u)
			{
				toolStripMenuItem2.Checked = false;
				toolStripMenuItem3.Checked = true;
				toolStripMenuItem4.Checked = false;
			}
			else if (this.m_paramBaseSystem.m_nEffectMode == 2u)
			{
				toolStripMenuItem2.Checked = false;
				toolStripMenuItem3.Checked = false;
				toolStripMenuItem4.Checked = true;
			}
			if (trayMenuPreset.PresetLoadable())
			{
				RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramOfBaseSystem = default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);
				RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode = default(RuntimeUtils.ConfigProxy._ParamOfMusicMode);
				RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode = default(RuntimeUtils.ConfigProxy._ParamOfMovieMode);
				RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle = default(RuntimeUtils.ConfigProxy._ParamOfFreestyle);
				Parameters.LoadDefaultParameter(ref paramOfBaseSystem);
				Parameters.LoadDefaultParameter(ref paramMusicMode);
				Parameters.LoadDefaultParameter(ref paramMovieMode);
				Parameters.LoadDefaultParameter(ref paramFreestyle);
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				if (!Parameters.ReadPreset(trayMenuPreset.PresetFile, ref paramOfBaseSystem, ref paramMusicMode, ref paramMovieMode, ref paramFreestyle, out flag, out flag2, out flag3, out flag4))
				{
					MessageBox.Show(GlobalMessages.CANT_LOAD_PRESET, GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (!flag2 && !flag3 && !flag4)
				{
					return;
				}
				if (flag2)
				{
					this.m_paramMusicMode = paramMusicMode;
				}
				if (flag3)
				{
					this.m_paramMovieMode = paramMovieMode;
				}
				if (flag4)
				{
					this.m_paramFreestyle = paramFreestyle;
				}
				this.UpdateAllControlsFromParameters();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000AC5C File Offset: 0x00008E5C
		private void frmMain_Load(object sender, EventArgs e)
		{
			if (this.m_bArgvStartupToMinimized)
			{
				this.SetupTrayMenu();
				base.WindowState = FormWindowState.Minimized;
				base.Hide();
				base.ShowInTaskbar = false;
				this.notifyIcon_Main.Visible = true;
			}
        }

		// Token: 0x060000BE RID: 190 RVA: 0x0000AC8C File Offset: 0x00008E8C
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Parameters.SaveLocalPreset(this.m_szLocalPreset, this.m_paramBaseSystem, this.m_paramMusicMode, this.m_paramMovieMode, this.m_paramFreestyle);
			this.SaveAppSettings();
			if (this.m_bCloseToTray && e.CloseReason == CloseReason.UserClosing)
			{
				this.SetupTrayMenu();
				e.Cancel = true;
				base.WindowState = FormWindowState.Minimized;
				base.Hide();
				base.ShowInTaskbar = false;
				this.notifyIcon_Main.Visible = true;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000AD00 File Offset: 0x00008F00
		private void frmMain_SizeChanged(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				Parameters.SaveLocalPreset(this.m_szLocalPreset, this.m_paramBaseSystem, this.m_paramMusicMode, this.m_paramMovieMode, this.m_paramFreestyle);
				this.SetupTrayMenu();
				base.Hide();
				base.ShowInTaskbar = false;
				this.notifyIcon_Main.Visible = true;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000AD58 File Offset: 0x00008F58
		private void notifyIcon_Main_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && base.WindowState == FormWindowState.Minimized)
			{
				base.ShowInTaskbar = true;
				base.Show();
				base.WindowState = FormWindowState.Normal;
				base.Activate();
				this.notifyIcon_Main.Visible = false;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000AD96 File Offset: 0x00008F96
		private float PostVolumeToFloat(float fPostVolume)
		{
			return fPostVolume / 6f;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000AD9F File Offset: 0x00008F9F
		private float FloatToPostVolume(float fValue)
		{
			return fValue * 6f;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		private float BassSpeakerSizeToFloat(int nSpkSize)
		{
			float num = ((float)nSpkSize - 40f) / 85f;
			return 1f - num;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000ADCC File Offset: 0x00008FCC
		private int FloatToBassSpeakerSize(float fValue)
		{
			fValue = 1f - fValue;
			int num = (int)(fValue * 85f + 40f);
			if (num < 40)
			{
				num = 40;
			}
			if (num > 125)
			{
				num = 125;
			}
			return num;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000AE02 File Offset: 0x00009002
		private float BassGainToFloat(float fBassGain)
		{
			return fBassGain / 7f;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000AE0B File Offset: 0x0000900B
		private float FloatToBassGain(float fValue)
		{
			return fValue * 7f;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000AE14 File Offset: 0x00009014
		private float ClarityToFloat(float fClarity)
		{
			return fClarity / 2f;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000AE1D File Offset: 0x0000901D
		public float FloatToClarity(float fValue)
		{
			return fValue * 2f;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000AE28 File Offset: 0x00009028
		public float Surround3DToFloat(float fSurround3D)
		{
			float num = (fSurround3D - 1f) / 2f;
			if (num < 0f)
			{
				num = 0f;
			}
			if (num > 1f)
			{
				num = 1f;
			}
			return num;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000AE60 File Offset: 0x00009060
		public float FloatToSurround3D(float fValue)
		{
			return fValue * 2f + 1f;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000AE6F File Offset: 0x0000906F
		public float SVCSToFloat(float fSVCS)
		{
			return (fSVCS - 0.5f) / 4.5f;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000AE7E File Offset: 0x0000907E
		public float FloatToSVCS(float fValue)
		{
			return fValue * 4.5f + 0.5f;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000AE8D File Offset: 0x0000908D
		public float SVMaxLevelToFloat(float fSVMaxLevel)
		{
			return (fSVMaxLevel - 1f) / 9f;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000AE9C File Offset: 0x0000909C
		public float FloatToSVMaxLevel(float fValue)
		{
			return fValue * 9f + 1f;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000AEAB File Offset: 0x000090AB
		public float SVLevelToFloat(float fSVLevel)
		{
			return (fSVLevel - 0.2f) / 0.8f;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000AEBA File Offset: 0x000090BA
		public float FloatToSVLevel(float fValue)
		{
			return fValue * 0.8f + 0.2f;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000AECC File Offset: 0x000090CC
		private void LanguageChanged(object sender, EventArgs e)
		{
			try
			{
				ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
				string text = toolStripMenuItem.Tag as string;
				if (text != null && text != "")
				{
					ConfigFile configFile = new ConfigFile(text);
					string text2 = configFile.ReadConfig("$LANGUAGE_NAME");
					if (!(text2 == ""))
					{
						string text3 = AppDomain.CurrentDomain.BaseDirectory;
						if (!text3.EndsWith("\\"))
						{
							text3 += "\\";
						}
						ConfigFile configFile2 = new ConfigFile(text3 + "Config.ini");
						configFile2.SetConfig("$LANGUAGE_NAME", text2);
						if (MessageBox.Show(GlobalMessages.LANGUAGE_CHANGE_NOTICE, GlobalMessages.INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
						{
							Application.Exit();
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000AFA0 File Offset: 0x000091A0
		private void UpdateAllControlsFromParameters()
		{
			if (this.m_paramBaseSystem.m_bEffectEnabled == 0)
			{
				this.onOffSwitch_Master.Checked = false;
			}
			else
			{
				this.onOffSwitch_Master.Checked = true;
			}
			this.Freestyle_hSlider_PreVolume.PositionFloat = this.m_paramFreestyle.m_rPreVolume;
			this.Freestyle_hSlider_PostVolume.PositionFloat = this.PostVolumeToFloat(this.m_paramFreestyle.m_rPostVolume);
			if (this.m_paramFreestyle.m_bConvolverEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Convolver.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Convolver.SwitchedOn = true;
			}
			this.Freestyle_openFileBox_ConvIRS.FilePathName = RuntimeUtils.GeneralUtils.CharArrayToString(this.m_paramFreestyle.m_szConvolverIR);
			this.Freestyle_hSlider_ConvIRGain.PositionFloat = this.m_paramFreestyle.m_rConvolverIRGain;
			if (this.m_paramFreestyle.m_b3DSurroundEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Surround3D.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Surround3D.SwitchedOn = true;
			}
			this.Freestyle_hSlider_Surround3D.PositionFloat = this.Surround3DToFloat(this.m_paramFreestyle.m_r3DSurroundStereo);
			this.Freestyle_hSlider_SurroundImage.PositionFloat = this.Surround3DToFloat(this.m_paramFreestyle.m_r3DSurroundImage);
			if (this.m_paramFreestyle.m_bVHESurroundEnabled == 0)
			{
				this.Freestyle_onOffSwitch_SurroundVHE.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_SurroundVHE.SwitchedOn = true;
			}
			this.Freestyle_buttonBox_SurroundVHERoomSize.SelectItem(this.m_paramFreestyle.m_nVHERoomSize);
			if (this.m_paramFreestyle.m_bViPERBassEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Bass.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Bass.SwitchedOn = true;
			}
			this.Freestyle_buttonBox_BassMode.SelectItem(this.m_paramFreestyle.m_nViPERBassMode);
			this.Freestyle_hSlider_BassSpkSize.PositionFloat = this.BassSpeakerSizeToFloat(this.m_paramFreestyle.m_nViPERBassSpkSize);
			this.Freestyle_hSlider_BassGain.PositionFloat = this.BassGainToFloat(this.m_paramFreestyle.m_rViPERBassFactor);
			if (this.m_paramFreestyle.m_bViPERClarityEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Clarity.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Clarity.SwitchedOn = true;
			}
			this.Freestyle_buttonBox_ClarityMode.SelectItem(this.m_paramFreestyle.m_nViPERClarityMode);
			this.Freestyle_hSlider_Clarity.PositionFloat = this.ClarityToFloat(this.m_paramFreestyle.m_rViPERClarityFactor);
			if (this.m_paramFreestyle.m_bCureEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Cure.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Cure.SwitchedOn = true;
			}
			if (this.m_paramFreestyle.m_uiCureLevel == 6226570u)
			{
				this.Freestyle_buttonBox_CureLevel.SelectItem(0);
			}
			else if (this.m_paramFreestyle.m_uiCureLevel == 3932860u)
			{
				this.Freestyle_buttonBox_CureLevel.SelectItem(1);
			}
			else if (this.m_paramFreestyle.m_uiCureLevel == 2949820u)
			{
				this.Freestyle_buttonBox_CureLevel.SelectItem(2);
			}
			if (this.m_paramFreestyle.m_bTubeEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Tube.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Tube.SwitchedOn = true;
			}
			if (this.m_paramFreestyle.m_bSmartVolumeEnabled == 0)
			{
				this.Freestyle_onOffSwitch_SmartVolume.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_SmartVolume.SwitchedOn = true;
			}
			this.Freestyle_hSlider_SmartVolumeRatio.PositionFloat = this.SVCSToFloat(this.m_paramFreestyle.m_rSVRatio);
			this.Freestyle_hSlider_SmartVolumeMaxLevel.PositionFloat = this.SVMaxLevelToFloat(this.m_paramFreestyle.m_rSVMaxGain);
			this.Freestyle_hSlider_SmartVolumeLevel.PositionFloat = this.SVLevelToFloat(this.m_paramFreestyle.m_rSVVolume);
			if (this.m_paramFreestyle.m_bReverbEnabled == 0)
			{
				this.Freestyle_onOffSwitch_Reverb.SwitchedOn = false;
			}
			else
			{
				this.Freestyle_onOffSwitch_Reverb.SwitchedOn = true;
			}
			this.Freestyle_hSlider_ReverbSize.PositionFloat = this.m_paramFreestyle.m_rReverbSize;
			this.Freestyle_hSlider_ReverbDamping.PositionFloat = this.m_paramFreestyle.m_rReverbDamping;
			this.Freestyle_hSlider_ReverbDensity.PositionFloat = this.m_paramFreestyle.m_rReverbDensity;
			this.Freestyle_hSlider_ReverbBandWidth.PositionFloat = this.m_paramFreestyle.m_rReverbBandwidth;
			this.Freestyle_hSlider_ReverbDecay.PositionFloat = this.m_paramFreestyle.m_rReverbDecay;
			this.Freestyle_hSlider_ReverbPreDelay.PositionFloat = this.m_paramFreestyle.m_rReverbPredelay;
			this.Freestyle_hSlider_ReverbEarlyMix.PositionFloat = this.m_paramFreestyle.m_rReverbEarlyMix;
			this.Freestyle_hSlider_ReverbMix.PositionFloat = this.m_paramFreestyle.m_rReverbMix;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		private void toolStripMenuItem_LatencySetting_Click(object sender, EventArgs e)
		{
			frmLatency frmLatency = new frmLatency();
			frmLatency.ShortFilterLen = this.m_paramBaseSystem.m_nFilterShortLen;
			frmLatency.MiddleFilterLen = this.m_paramBaseSystem.m_nFilterMediumLen;
			frmLatency.LongFilterLen = this.m_paramBaseSystem.m_nFilterLongLen;
			if (frmLatency.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			this.m_paramBaseSystem.m_nFilterShortLen = frmLatency.ShortFilterLen;
			this.m_paramBaseSystem.m_nFilterMediumLen = frmLatency.MiddleFilterLen;
			this.m_paramBaseSystem.m_nFilterLongLen = frmLatency.LongFilterLen;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramBaseSystem);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000BA98 File Offset: 0x00009C98
		private void toolStripMenuItem_ChannelPan_Click(object sender, EventArgs e)
		{
			frmChannelPan frmChannelPan = new frmChannelPan();
			frmChannelPan.ChannelPan = this.m_paramBaseSystem.m_rChannelPan;
			frmChannelPan.ShowDialog();
			this.m_paramBaseSystem.m_rChannelPan = frmChannelPan.ChannelPan;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramBaseSystem);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		private void toolStripMenuItem_Virtualization_Click(object sender, EventArgs e)
		{
			frmVirtualization frmVirtualization = new frmVirtualization();
			frmVirtualization.SetBaseSystemParam(this.m_paramBaseSystem);
			if (frmVirtualization.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			this.m_paramBaseSystem = frmVirtualization.GetBaseSystemParam();
			this.m_cpConfigProxy.UpdateParameter(this.m_paramBaseSystem);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000BB41 File Offset: 0x00009D41
		private void toolStripMenuItem_ResetEffect_Click(object sender, EventArgs e)
		{
			Parameters.LoadDefaultParameter(ref this.m_paramMusicMode);
			Parameters.LoadDefaultParameter(ref this.m_paramMovieMode);
			Parameters.LoadDefaultParameter(ref this.m_paramFreestyle);
			this.UpdateAllControlsFromParameters();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000BB6C File Offset: 0x00009D6C
		private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
		{
			uint num = RegHelper.QueryDWORD("LoadChildAPO", 0u);
			frmSettings frmSettings = new frmSettings();
			frmSettings.SetPresetPath(this.m_szPresetsPath);
			frmSettings.SetCloseToTray(this.m_bCloseToTray);
			frmSettings.SetTrayMenuPresetList(this.m_lstTrayMenuPreset);
			if (frmSettings.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			this.m_bCloseToTray = frmSettings.GetCloseToTray();
			List<TrayMenuPreset> trayMenuPresetList = frmSettings.GetTrayMenuPresetList();
			this.m_lstTrayMenuPreset.Clear();
			foreach (TrayMenuPreset trayMenuPreset in trayMenuPresetList)
			{
				if (trayMenuPreset.Valid())
				{
					if (string.IsNullOrEmpty(trayMenuPreset.PresetName))
					{
						trayMenuPreset.PresetName = GlobalMessages.UNNAMED;
					}
					this.m_lstTrayMenuPreset.Add(trayMenuPreset.Clone());
				}
			}
			this.SaveAppSettings();
			uint num2;
			if (frmSettings.GetAPOCoexistEnabled())
			{
				num2 = 1u;
			}
			else
			{
				num2 = 0u;
			}
			if (num2 != num)
			{
				RegHelper.WriteDWORD("LoadChildAPO", num2);
				if (num2 == 1u)
				{
					MessageBox.Show(string.Concat(new string[]
					{
						GlobalMessages.ENABLE_APO_COEXIST_WRN_LINE1,
						"\n",
						GlobalMessages.ENABLE_APO_COEXIST_WRN_LINE2,
						"\n\n",
						GlobalMessages.ENABLE_APO_COEXIST_RESTART
					}), GlobalMessages.ENABLE_APO_COEXIST, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				MessageBox.Show(GlobalMessages.ENABLE_APO_COEXIST_RESTART, GlobalMessages.ENABLE_APO_COEXIST, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		private void toolStripMenuItem_CheckUpdate_Click(object sender, EventArgs e)
		{
			frmCheckUpdate frmCheckUpdate = new frmCheckUpdate();
			frmCheckUpdate.ShowDialog();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		private void toolStripMenuItem_AboutV4W_Click(object sender, EventArgs e)
		{
			frmAbout frmAbout = new frmAbout();
			frmAbout.ShowDialog();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000C03C File Offset: 0x0000A23C
		private void Freestyle_hSlider_PreVolume_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rPreVolume = fPercent;
			this.Freestyle_label_PreVolume.Text = GlobalMessages.PRE_VOLUME + " : " + (20.0 * Math.Log10((double)fPercent + 1E-06)).ToString("F02") + "dB";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		private void Freestyle_hSlider_PostVolume_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rPostVolume = this.FloatToPostVolume(fPercent);
			this.Freestyle_label_PostVolume.Text = GlobalMessages.POST_VOLUME + " : " + (20.0 * Math.Log10((double)this.FloatToPostVolume(fPercent) + 1E-06)).ToString("F02") + "dB";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000C140 File Offset: 0x0000A340
		private void Freestyle_onOffSwitch_Convolver_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bConvolverEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bConvolverEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000C17C File Offset: 0x0000A37C
		private void Freestyle_hSlider_ConvIRGain_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rConvolverIRGain = fPercent;
			this.Freestyle_label_ConvolverIRGain.Text = GlobalMessages.CONV_IR_GAIN + " : " + (20.0 * Math.Log10((double)fPercent + 1E-06)).ToString("F02") + "dB";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		private void Freestyle_openFileBox_ConvIRS_FileChangeNotify(string szFilePathName, OpenFileBox objSender)
		{
			this.m_paramFreestyle.m_szConvolverIR = Parameters.WriteStringToArray260(szFilePathName);
			int nChannels = 0;
			float[] fIRSamples = RuntimeUtils.ImpulseResponseUtils.EstimateImpulseResponseSample(szFilePathName, out nChannels);
			this.Freestyle_irShape_ConvIR.SetImpulseResponse(fIRSamples, nChannels);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000C24A File Offset: 0x0000A44A
		private void Freestyle_onOffSwitch_Surround3D_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_b3DSurroundEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_b3DSurroundEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000C285 File Offset: 0x0000A485
		private void Freestyle_hSlider_Surround3D_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_r3DSurroundStereo = this.FloatToSurround3D(fPercent);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000C2B5 File Offset: 0x0000A4B5
		private void Freestyle_hSlider_SurroundImage_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_r3DSurroundImage = this.FloatToSurround3D(fPercent);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000C2E5 File Offset: 0x0000A4E5
		private void Freestyle_onOffSwitch_SurroundVHE_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bVHESurroundEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bVHESurroundEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000C320 File Offset: 0x0000A520
		private void Freestyle_buttonBox_SurroundVHERoomSize_ItemSelectedNotify(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
		{
			if (itCurrItem == null)
			{
				return;
			}
			if (itCurrItem.Tag == null)
			{
				return;
			}
			string text = itCurrItem.Tag as string;
			if (text == null)
			{
				return;
			}
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			if (num < 0 || num > 4)
			{
				return;
			}
			this.m_paramFreestyle.m_nVHERoomSize = num;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000C388 File Offset: 0x0000A588
		private void Freestyle_onOffSwitch_Bass_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bViPERBassEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bViPERBassEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		private void Freestyle_hSlider_BassSpkSize_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_nViPERBassSpkSize = this.FloatToBassSpeakerSize(fPercent);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		private void Freestyle_hSlider_BassGain_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rViPERBassFactor = this.FloatToBassGain(fPercent);
			this.Freestyle_label_Bass_Gain.Text = GlobalMessages.BASS_GAIN + " : " + (20.0 * Math.Log10((double)this.FloatToBassGain(fPercent) + 1.0)).ToString("F02") + "dB";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000C47C File Offset: 0x0000A67C
		private void Freestyle_buttonBox_BassMode_ItemSelectedNotify(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
		{
			if (itCurrItem == null)
			{
				return;
			}
			if (itCurrItem.Tag == null)
			{
				return;
			}
			string text = itCurrItem.Tag as string;
			if (text == null)
			{
				return;
			}
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			if (num < 0 || num > 1)
			{
				return;
			}
			this.m_paramFreestyle.m_nViPERBassMode = num;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		private void Freestyle_onOffSwitch_Clarity_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bViPERClarityEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bViPERClarityEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000C520 File Offset: 0x0000A720
		private void Freestyle_buttonBox_ClarityMode_ItemSelectedNotify(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
		{
			if (itCurrItem == null)
			{
				return;
			}
			if (itCurrItem.Tag == null)
			{
				return;
			}
			string text = itCurrItem.Tag as string;
			if (text == null)
			{
				return;
			}
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			if (num < 0 || num > 2)
			{
				return;
			}
			this.m_paramFreestyle.m_nViPERClarityMode = num;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000C588 File Offset: 0x0000A788
		private void Freestyle_hSlider_Clarity_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rViPERClarityFactor = this.FloatToClarity(fPercent);
			this.Freestyle_label_Clarity.Text = GlobalMessages.CLARITY + " : " + (20.0 * Math.Log10((double)this.FloatToClarity(fPercent) + 1.0)).ToString("F02") + "dB";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000C610 File Offset: 0x0000A810
		private void Freestyle_onOffSwitch_Cure_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bCureEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCureEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000C64C File Offset: 0x0000A84C
		private void Freestyle_buttonBox_CureLevel_ItemSelectedNotify(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
		{
			if (itCurrItem == null)
			{
				return;
			}
			if (itCurrItem.Tag == null)
			{
				return;
			}
			string text = itCurrItem.Tag as string;
			if (text == null)
			{
				return;
			}
			if (text == 6226570u.ToString())
			{
				this.m_paramFreestyle.m_uiCureLevel = 6226570u;
				this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
				this.m_cpConfigProxy.SyncConfig();
				return;
			}
			if (text == 3932860u.ToString())
			{
				this.m_paramFreestyle.m_uiCureLevel = 3932860u;
				this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
				this.m_cpConfigProxy.SyncConfig();
				return;
			}
			if (text == 2949820u.ToString())
			{
				this.m_paramFreestyle.m_uiCureLevel = 2949820u;
				this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
				this.m_cpConfigProxy.SyncConfig();
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000C73B File Offset: 0x0000A93B
		private void Freestyle_onOffSwitch_Tube_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bTubeEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bTubeEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000C776 File Offset: 0x0000A976
		private void Freestyle_onOffSwitch_SmartVolume_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bSmartVolumeEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bSmartVolumeEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000C7B1 File Offset: 0x0000A9B1
		private void Freestyle_hSlider_SmartVolumeRatio_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rSVRatio = this.FloatToSVCS(fPercent);
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		private void Freestyle_hSlider_SmartVolumeMaxLevel_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rSVMaxGain = this.FloatToSVMaxLevel(fPercent);
			this.Freestyle_label_SmartVolume_MaxLevel.Text = GlobalMessages.SMART_VOLUME_MAXLEVEL + " : " + this.FloatToSVMaxLevel(fPercent).ToString("F02") + "x";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000C854 File Offset: 0x0000AA54
		private void Freestyle_hSlider_SmartVolumeLevel_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rSVVolume = this.FloatToSVLevel(fPercent);
			this.Freestyle_label_SmartVolume_Level.Text = GlobalMessages.SMART_VOLUME_LEVEL + " : " + (20.0 * Math.Log10((double)this.FloatToSVLevel(fPercent))).ToString("F02") + "dB";
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000C8D2 File Offset: 0x0000AAD2
		private void Freestyle_onOffSwitch_Reverb_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			if (bSwitchedOn)
			{
				this.m_paramFreestyle.m_bReverbEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bReverbEnabled = 0;
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C910 File Offset: 0x0000AB10
		private void Freestyle_singleButton_ReverbPreset_ButtonClickNotify(SingleButton objSender)
		{
			frmReverbPreset frmReverbPreset = new frmReverbPreset();
			frmReverbPreset.ReverbSize = this.m_paramFreestyle.m_rReverbSize;
			frmReverbPreset.ReverbDamping = this.m_paramFreestyle.m_rReverbDamping;
			frmReverbPreset.ReverbDensity = this.m_paramFreestyle.m_rReverbDensity;
			frmReverbPreset.ReverbBandwidth = this.m_paramFreestyle.m_rReverbBandwidth;
			frmReverbPreset.ReverbDecay = this.m_paramFreestyle.m_rReverbDecay;
			frmReverbPreset.ReverbPredelay = this.m_paramFreestyle.m_rReverbPredelay;
			frmReverbPreset.ReverbEarlyMix = this.m_paramFreestyle.m_rReverbEarlyMix;
			frmReverbPreset.ReverbMix = this.m_paramFreestyle.m_rReverbMix;
			if (frmReverbPreset.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			this.m_paramFreestyle.m_rReverbSize = frmReverbPreset.ReverbSize;
			this.m_paramFreestyle.m_rReverbDamping = frmReverbPreset.ReverbDamping;
			this.m_paramFreestyle.m_rReverbDensity = frmReverbPreset.ReverbDensity;
			this.m_paramFreestyle.m_rReverbBandwidth = frmReverbPreset.ReverbBandwidth;
			this.m_paramFreestyle.m_rReverbDecay = frmReverbPreset.ReverbDecay;
			this.m_paramFreestyle.m_rReverbPredelay = frmReverbPreset.ReverbPredelay;
			this.m_paramFreestyle.m_rReverbEarlyMix = frmReverbPreset.ReverbEarlyMix;
			this.m_paramFreestyle.m_rReverbMix = frmReverbPreset.ReverbMix;
			this.Freestyle_hSlider_ReverbSize.PositionFloat = this.m_paramFreestyle.m_rReverbSize;
			this.Freestyle_hSlider_ReverbDamping.PositionFloat = this.m_paramFreestyle.m_rReverbDamping;
			this.Freestyle_hSlider_ReverbDensity.PositionFloat = this.m_paramFreestyle.m_rReverbDensity;
			this.Freestyle_hSlider_ReverbBandWidth.PositionFloat = this.m_paramFreestyle.m_rReverbBandwidth;
			this.Freestyle_hSlider_ReverbDecay.PositionFloat = this.m_paramFreestyle.m_rReverbDecay;
			this.Freestyle_hSlider_ReverbPreDelay.PositionFloat = this.m_paramFreestyle.m_rReverbPredelay;
			this.Freestyle_hSlider_ReverbEarlyMix.PositionFloat = this.m_paramFreestyle.m_rReverbEarlyMix;
			this.Freestyle_hSlider_ReverbMix.PositionFloat = this.m_paramFreestyle.m_rReverbMix;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000CAED File Offset: 0x0000ACED
		private void Freestyle_hSlider_ReverbSize_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbSize = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000CB17 File Offset: 0x0000AD17
		private void Freestyle_hSlider_ReverbDamping_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbDamping = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000CB41 File Offset: 0x0000AD41
		private void Freestyle_hSlider_ReverbDensity_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbDensity = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000CB6B File Offset: 0x0000AD6B
		private void Freestyle_hSlider_ReverbBandWidth_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbBandwidth = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000CB95 File Offset: 0x0000AD95
		private void Freestyle_hSlider_ReverbDecay_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbDecay = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000CBBF File Offset: 0x0000ADBF
		private void Freestyle_hSlider_ReverbPreDelay_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbPredelay = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000CBE9 File Offset: 0x0000ADE9
		private void Freestyle_hSlider_ReverbEarlyMix_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbEarlyMix = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000CC13 File Offset: 0x0000AE13
		private void Freestyle_hSlider_ReverbMix_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_paramFreestyle.m_rReverbMix = fPercent;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000CC40 File Offset: 0x0000AE40
		private void Freestyle_singleButton_Equalizer_ButtonClickNotify(SingleButton objSender)
		{
			frmEqualizer frmEqualizer = new frmEqualizer();
			frmEqualizer.SetRealtimeParameters(this.m_paramBaseSystem, this.m_paramMusicMode, this.m_paramMovieMode, this.m_paramFreestyle, this.m_cpConfigProxy);
			if (this.m_paramFreestyle.m_bEqualizerEnabled == 0)
			{
				frmEqualizer.SetParameters(this.m_paramFreestyle.m_rpEqualizerBands, false);
			}
			else
			{
				frmEqualizer.SetParameters(this.m_paramFreestyle.m_rpEqualizerBands, true);
			}
			frmEqualizer.ShowDialog();
			if (frmEqualizer.GetEQEnabled())
			{
				this.m_paramFreestyle.m_bEqualizerEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bEqualizerEnabled = 0;
			}
			if (frmEqualizer.GetParameter() != null)
			{
				this.m_paramFreestyle.m_rpEqualizerBands = frmEqualizer.GetParameter();
			}
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000CD08 File Offset: 0x0000AF08
		private void Freestyle_singleButton_Compressor_ButtonClickNotify(SingleButton objSender)
		{
			frmCompressor frmCompressor = new frmCompressor();
			if (this.m_paramFreestyle.m_bCompressorEnabled == 0)
			{
				frmCompressor.CompressorEnabled = false;
			}
			else
			{
				frmCompressor.CompressorEnabled = true;
			}
			if (this.m_paramFreestyle.m_bCompAutoKnee == 0)
			{
				frmCompressor.AutoKnee = false;
			}
			else
			{
				frmCompressor.AutoKnee = true;
			}
			if (this.m_paramFreestyle.m_bCompAutoAttack == 0)
			{
				frmCompressor.AutoAttack = false;
			}
			else
			{
				frmCompressor.AutoAttack = true;
			}
			if (this.m_paramFreestyle.m_bCompAutoRelease == 0)
			{
				frmCompressor.AutoRelease = false;
			}
			else
			{
				frmCompressor.AutoRelease = true;
			}
			if (this.m_paramFreestyle.m_bCompAutoGain == 0)
			{
				frmCompressor.AutoGain = false;
			}
			else
			{
				frmCompressor.AutoGain = true;
			}
			if (this.m_paramFreestyle.m_bCompAutoMetaNoClipping == 0)
			{
				frmCompressor.NoClip = false;
			}
			else
			{
				frmCompressor.NoClip = true;
			}
			frmCompressor.Threshold = this.m_paramFreestyle.m_rCompThreshold;
			frmCompressor.KneeWidth = this.m_paramFreestyle.m_rCompKneeWidth;
			frmCompressor.Ratio = this.m_paramFreestyle.m_rCompRatio;
			frmCompressor.AttackTime = this.m_paramFreestyle.m_rCompAttack;
			frmCompressor.ReleaseTime = this.m_paramFreestyle.m_rCompRelease;
			frmCompressor.KneeMult = this.m_paramFreestyle.m_rCompMetaKneeMult;
			frmCompressor.CrestTime = this.m_paramFreestyle.m_rCompMetaCrest;
			frmCompressor.AdaptTime = this.m_paramFreestyle.m_rCompMetaAdapt;
			frmCompressor.MakeupGain = this.m_paramFreestyle.m_rCompGain;
			if (frmCompressor.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			if (frmCompressor.CompressorEnabled)
			{
				this.m_paramFreestyle.m_bCompressorEnabled = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCompressorEnabled = 0;
			}
			if (frmCompressor.AutoKnee)
			{
				this.m_paramFreestyle.m_bCompAutoKnee = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCompAutoKnee = 0;
			}
			if (frmCompressor.AutoAttack)
			{
				this.m_paramFreestyle.m_bCompAutoAttack = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCompAutoAttack = 0;
			}
			if (frmCompressor.AutoRelease)
			{
				this.m_paramFreestyle.m_bCompAutoRelease = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCompAutoRelease = 0;
			}
			if (frmCompressor.AutoGain)
			{
				this.m_paramFreestyle.m_bCompAutoGain = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCompAutoGain = 0;
			}
			if (frmCompressor.NoClip)
			{
				this.m_paramFreestyle.m_bCompAutoMetaNoClipping = 1;
			}
			else
			{
				this.m_paramFreestyle.m_bCompAutoMetaNoClipping = 0;
			}
			this.m_paramFreestyle.m_rCompThreshold = frmCompressor.Threshold;
			this.m_paramFreestyle.m_rCompKneeWidth = frmCompressor.KneeWidth;
			this.m_paramFreestyle.m_rCompRatio = frmCompressor.Ratio;
			this.m_paramFreestyle.m_rCompAttack = frmCompressor.AttackTime;
			this.m_paramFreestyle.m_rCompRelease = frmCompressor.ReleaseTime;
			this.m_paramFreestyle.m_rCompMetaKneeMult = frmCompressor.KneeMult;
			this.m_paramFreestyle.m_rCompMetaCrest = frmCompressor.CrestTime;
			this.m_paramFreestyle.m_rCompMetaAdapt = frmCompressor.AdaptTime;
			this.m_paramFreestyle.m_rCompGain = frmCompressor.MakeupGain;
			this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
			this.m_cpConfigProxy.SyncConfig();
		}

	

		// Token: 0x0400009C RID: 156
		private static string m_szLanguagePath = "";

		// Token: 0x0400009D RID: 157
		private static string m_szLanguageFile = "";

		// Token: 0x0400009E RID: 158
		private static string m_szLanguageName = "";

		// Token: 0x0400009F RID: 159
		private readonly string m_szLocalPresetFileName = "LocalPreset.bin";

		// Token: 0x040000A0 RID: 160
		private readonly string m_szImpulseResponsePath = "ImpulseResponse";

		// Token: 0x040000A1 RID: 161
		private readonly string m_szUserPresetPath = "Presets";

		// Token: 0x040000A2 RID: 162
		private bool m_bArgvStartupToMinimized;

		// Token: 0x040000A3 RID: 163
		private string m_szLocalPreset = "";

		// Token: 0x040000A4 RID: 164
		private string m_szIRSPath = "";

		// Token: 0x040000A5 RID: 165
		private string m_szPresetsPath = "";

		// Token: 0x040000A6 RID: 166
		private bool m_bCloseToTray;

		// Token: 0x040000A7 RID: 167
		private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramBaseSystem = default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);

		// Token: 0x040000A8 RID: 168
		private RuntimeUtils.ConfigProxy._ParamOfMusicMode m_paramMusicMode = default(RuntimeUtils.ConfigProxy._ParamOfMusicMode);

		// Token: 0x040000A9 RID: 169
		private RuntimeUtils.ConfigProxy._ParamOfMovieMode m_paramMovieMode = default(RuntimeUtils.ConfigProxy._ParamOfMovieMode);

		// Token: 0x040000AA RID: 170
		private RuntimeUtils.ConfigProxy._ParamOfFreestyle m_paramFreestyle = default(RuntimeUtils.ConfigProxy._ParamOfFreestyle);

		// Token: 0x040000AB RID: 171
		private RuntimeUtils.ConfigProxy m_cpConfigProxy;

		// Token: 0x040000AC RID: 172
		private List<TrayMenuPreset> m_lstTrayMenuPreset = new List<TrayMenuPreset>();

        private void SingleButton_LoadPreset_Load(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = GlobalMessages.LOAD_PRESET;
            openFileDialog.Filter = "*.vpf|*.vpf";
            openFileDialog.DefaultExt = "vpf";
            openFileDialog.InitialDirectory = this.m_szPresetsPath;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramOfBaseSystem = default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);
            RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode = default(RuntimeUtils.ConfigProxy._ParamOfMusicMode);
            RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode = default(RuntimeUtils.ConfigProxy._ParamOfMovieMode);
            RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle = default(RuntimeUtils.ConfigProxy._ParamOfFreestyle);
            Parameters.LoadDefaultParameter(ref paramOfBaseSystem);
            Parameters.LoadDefaultParameter(ref paramMusicMode);
            Parameters.LoadDefaultParameter(ref paramMovieMode);
            Parameters.LoadDefaultParameter(ref paramFreestyle);
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;
            if (!Parameters.ReadPreset(openFileDialog.FileName, ref paramOfBaseSystem, ref paramMusicMode, ref paramMovieMode, ref paramFreestyle, out flag, out flag2, out flag3, out flag4))
            {
                MessageBox.Show(GlobalMessages.CANT_LOAD_PRESET, GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!flag2 && !flag3 && !flag4)
            {
                return;
            }
            if (flag2)
            {
                this.m_paramMusicMode = paramMusicMode;
            }
            if (flag3)
            {
                this.m_paramMovieMode = paramMovieMode;
            }
            if (flag4)
            {
                this.m_paramFreestyle = paramFreestyle;
            }
            this.UpdateAllControlsFromParameters();
        }

        private void MetroSwitch1_CheckedChanged(object sender, bool isChecked)
        {
            if (isChecked)
            {
                this.m_paramBaseSystem.m_bEffectEnabled = 1;
            }
            else
            {
                this.m_paramBaseSystem.m_bEffectEnabled = 0;
            }
            this.m_cpConfigProxy.UpdateParameter(this.m_paramBaseSystem);
            this.m_cpConfigProxy.SyncConfig();

        }

        private void SavePreset_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = GlobalMessages.SAVE_PRESET;
            saveFileDialog.Filter = "*.vpf|*.vpf";
            saveFileDialog.DefaultExt = "vpf";
            saveFileDialog.InitialDirectory = this.m_szPresetsPath;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            switch (this.m_paramBaseSystem.m_nEffectMode)
            {
                case 0u:
                    Parameters.SavePreset(saveFileDialog.FileName, this.m_paramMusicMode);
                    return;
                case 1u:
                    Parameters.SavePreset(saveFileDialog.FileName, this.m_paramMovieMode);
                    return;
                case 2u:
                    Parameters.SavePreset(saveFileDialog.FileName, this.m_paramFreestyle);
                    return;
                default:
                    MessageBox.Show(GlobalMessages.CANT_SAVE_PRESET, GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
            }
        }

        private void ButtonBox_Mode_Load(object sender, EventArgs e)
        {

        }
    }
}
