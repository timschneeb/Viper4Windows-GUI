using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x02000017 RID: 23
	public partial class frmVirtualization : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x0600014E RID: 334 RVA: 0x00016C84 File Offset: 0x00014E84
		public void SetBaseSystemParam(RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramSystem)
		{
			this.m_paramSystem = paramSystem;
			int num3 = this.m_paramSystem.m_bVirtApplied >> 2 & 1;
			if (num3 == 1)
			{
				this.checkBox_Freestyle.Checked = true;
			}
			if (this.m_paramSystem.m_bEnvRealizeEnabled == 1)
			{
				this.onOffSwitch_EnvRealize.Checked = true;
			}
			else
			{
				this.onOffSwitch_EnvRealize.Checked = false;
			}
			this.hSlider_EnvRealizeDrySignal.Value = (int)this.m_paramSystem.m_rEnvRealizeDrySignal*100;
			if (this.m_paramSystem.m_bEnvRealizePreprocess == 1)
			{
				this.twoSelector_PrePostProcess.Checked=false;
			}
			else
			{
				this.twoSelector_PrePostProcess.Checked=true;
			}
			for (int i = 0; i < this.comboBox_EnvRealizePreset.Items.Count; i++)
			{
				frmVirtualization.EnvRealizePreset envRealizePreset = this.comboBox_EnvRealizePreset.Items[i] as frmVirtualization.EnvRealizePreset;
				if (envRealizePreset.PresetID == this.m_paramSystem.m_nEnvRealizePreset)
				{
					this.comboBox_EnvRealizePreset.SelectedIndex = i;
					return;
				}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00016DB0 File Offset: 0x00014FB0
		public RuntimeUtils.ConfigProxy._ParamOfBaseSystem GetBaseSystemParam()
		{
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            if (this.checkBox_Freestyle.Checked)
			{
				num3 = 1;
			}
			this.m_paramSystem.m_bVirtApplied = (num1 | num2 << 1 | num3 << 2);
			if (this.onOffSwitch_EnvRealize.Checked)
			{
				this.m_paramSystem.m_bEnvRealizeEnabled = 1;
			}
			else
			{
				this.m_paramSystem.m_bEnvRealizeEnabled = 0;
			}
			if (this.twoSelector_PrePostProcess.Checked == false)
			{
				this.m_paramSystem.m_bEnvRealizePreprocess = 1;
			}
			else
			{
				this.m_paramSystem.m_bEnvRealizePreprocess = 0;
			}
			this.m_paramSystem.m_rEnvRealizeDrySignal = this.hSlider_EnvRealizeDrySignal.Value/100f;
			if (this.comboBox_EnvRealizePreset.SelectedItem == null)
			{
				this.m_paramSystem.m_bEnvRealizeEnabled = 0;
			}
			else if (this.comboBox_EnvRealizePreset.SelectedItem.GetType() != typeof(frmVirtualization.EnvRealizePreset))
			{
				this.m_paramSystem.m_bEnvRealizeEnabled = 0;
			}
			else
			{
				frmVirtualization.EnvRealizePreset envRealizePreset = this.comboBox_EnvRealizePreset.SelectedItem as frmVirtualization.EnvRealizePreset;
				this.m_paramSystem.m_nEnvRealizePreset = envRealizePreset.PresetID;
			}
			return this.m_paramSystem;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00016ED8 File Offset: 0x000150D8
		public frmVirtualization()
		{
			Parameters.LoadDefaultParameter(ref this.m_paramSystem);
			this.m_nCurrentAudioSystem = -1;
			this.InitializeComponent();
			this.Text = GlobalMessages.VIRTUALIZATION;
			this.label_AudioSystemConfig.Text = GlobalMessages.AUDIO_SYSTEM_CONFIG;
			this.singleButton_ResetConfig.Text = GlobalMessages.VIRT_RESET;
			this.groupBox_VirtApplied.Text = GlobalMessages.VIRT_APPLIED;
			this.checkBox_Freestyle.Text = GlobalMessages.FREESTYLE_MODE;
			this.groupBox_VirtEnv.Text = GlobalMessages.VIRT_ENVIRONMENT;
			this.label_PrePostProcess.Text = GlobalMessages.VIRT_PREPOST_PROCESS;
			this.singleButton_OK.Text = GlobalMessages.OK;
			this.singleButton_Cancel.Text = GlobalMessages.CANCEL;
            this.buttonBox_AudioSystemConfig.Items.Clear();
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_MONO);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_STEREO);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_HEADSET);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_REARSTEREO);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_QUAD);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_X5P1);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_X6P1);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_X7P1);
            this.buttonBox_AudioSystemConfig.Items.Add(GlobalMessages.AUDIO_SYSTEM_X8P1);

			this.listView_Speaker.Columns[0].Text = GlobalMessages.VIRT_SPEAKER;
			this.listView_Speaker.Columns[1].Text = GlobalMessages.VIRT_SPEAKER_ANGLE;
			this.listView_Speaker.Items.Clear();
			this.checkBox_Freestyle.Checked = false;
			this.onOffSwitch_EnvRealize.Checked = false;
			this.hSlider_EnvRealizeDrySignal.Value = 70;
			this.twoSelector_PrePostProcess.Checked = false;
			this.comboBox_EnvRealizePreset.Items.Clear();
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_SMALLROOM, 2));
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_BATHROOM, 3));
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_LIVINGROOM, 4));
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_STONEROOM, 5));
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_AUDITORIUM, 6));
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_CONCERTHALL, 7));
			this.comboBox_EnvRealizePreset.Items.Add(new frmVirtualization.EnvRealizePreset(GlobalMessages.VIRT_ENVIR_HALLWAY, 12));
			this.toolStripMenuItem_SpeakerAngle.Text = GlobalMessages.VIRT_SPEAKER_ANGLE;
			this.toolStripComboBox_SpeakerAngle.Items.Clear();
			for (int i = -180; i <= 180; i += 10)
			{
				this.toolStripComboBox_SpeakerAngle.Items.Add(new frmVirtualization.SpeakerAngle((float)i));
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001726A File Offset: 0x0001546A
		private string FormatAngleString(float fAngle)
		{
			if (fAngle >= 0f)
			{
				return "+" + fAngle.ToString("F01");
			}
			return fAngle.ToString("F01");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00017298 File Offset: 0x00015498
		private void RefreshSpeakerList()
		{
			this.listView_Speaker.Items.Clear();
			switch (this.m_nCurrentAudioSystem)
			{
			case 0:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_00[0])
				}));
				return;
			case 1:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_01[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_01[1])
				}));
				return;
			case 2:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_02[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_02[1])
				}));
				return;
			case 3:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_03[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_03[1])
				}));
				return;
			case 4:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_04[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_04[1])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_04[2])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_04[3])
				}));
				return;
			case 5:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_05[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_05[1])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_05[2])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_LFE,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_05[3])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_05[4])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_05[5])
				}));
				return;
			case 6:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[1])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[2])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_LFE,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[3])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[4])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_SIDELEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[5])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_06[6])
				}));
				return;
			case 7:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[1])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[2])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_LFE,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[3])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[4])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[5])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_SIDELEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[7])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_07[7])
				}));
				return;
			case 8:
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[0])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[1])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_FRONTCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[2])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_LFE,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[3])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKLEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[4])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKRIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[5])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_BACKCENTER,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[6])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_SIDELEFT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[7])
				}));
				this.listView_Speaker.Items.Add(new ListViewItem(new string[]
				{
					GlobalMessages.VIRT_SPEAKER_SIDERIGHT,
					this.FormatAngleString(this.m_paramSystem.m_rpChannelAngle_08[8])
				}));
				return;
			default:
				return;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00018128 File Offset: 0x00016328
		private void listView_Speaker_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
			{
				return;
			}
			if (this.m_nCurrentAudioSystem < 0 || this.listView_Speaker.SelectedItems.Count != 1)
			{
				return;
			}
			float[] array = null;
			int num = -1;
			switch (this.m_nCurrentAudioSystem)
			{
			case 0:
				array = this.m_paramSystem.m_rpChannelAngle_00;
				num = 1;
				break;
			case 1:
				array = this.m_paramSystem.m_rpChannelAngle_01;
				num = 2;
				break;
			case 2:
				array = this.m_paramSystem.m_rpChannelAngle_02;
				num = 2;
				break;
			case 3:
				array = this.m_paramSystem.m_rpChannelAngle_03;
				num = 2;
				break;
			case 4:
				array = this.m_paramSystem.m_rpChannelAngle_04;
				num = 4;
				break;
			case 5:
				array = this.m_paramSystem.m_rpChannelAngle_05;
				num = 6;
				break;
			case 6:
				array = this.m_paramSystem.m_rpChannelAngle_06;
				num = 7;
				break;
			case 7:
				array = this.m_paramSystem.m_rpChannelAngle_07;
				num = 8;
				break;
			case 8:
				array = this.m_paramSystem.m_rpChannelAngle_08;
				num = 9;
				break;
			}
			if (array == null)
			{
				return;
			}
			int index = this.listView_Speaker.SelectedItems[0].Index;
			if (index >= num)
			{
				return;
			}
			float num2 = array[index];
			int num3 = -1;
			for (int i = 0; i < this.toolStripComboBox_SpeakerAngle.Items.Count; i++)
			{
				frmVirtualization.SpeakerAngle speakerAngle = this.toolStripComboBox_SpeakerAngle.Items[i] as frmVirtualization.SpeakerAngle;
				if (speakerAngle.AngleFloat == num2)
				{
					num3 = i;
					break;
				}
				if (speakerAngle.AngleFloat == 0f)
				{
					num3 = i;
				}
			}
			if (num3 == -1)
			{
				return;
			}
			this.contextMenuStrip_SpeakerAngle.Tag = null;
			this.toolStripComboBox_SpeakerAngle.SelectedIndex = num3;
			this.contextMenuStrip_SpeakerAngle.Tag = index.ToString();
			this.contextMenuStrip_SpeakerAngle.Show(this.listView_Speaker, e.Location);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000182F4 File Offset: 0x000164F4
		private void toolStripComboBox_SpeakerAngle_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_nCurrentAudioSystem < 0)
			{
				return;
			}
			if (this.contextMenuStrip_SpeakerAngle.Tag == null)
			{
				return;
			}
			if (this.contextMenuStrip_SpeakerAngle.Tag.GetType() != typeof(string))
			{
				return;
			}
			string text = this.contextMenuStrip_SpeakerAngle.Tag as string;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			float[] array = null;
			int num2 = -1;
			switch (this.m_nCurrentAudioSystem)
			{
			case 0:
				array = this.m_paramSystem.m_rpChannelAngle_00;
				num2 = 1;
				break;
			case 1:
				array = this.m_paramSystem.m_rpChannelAngle_01;
				num2 = 2;
				break;
			case 2:
				array = this.m_paramSystem.m_rpChannelAngle_02;
				num2 = 2;
				break;
			case 3:
				array = this.m_paramSystem.m_rpChannelAngle_03;
				num2 = 2;
				break;
			case 4:
				array = this.m_paramSystem.m_rpChannelAngle_04;
				num2 = 4;
				break;
			case 5:
				array = this.m_paramSystem.m_rpChannelAngle_05;
				num2 = 6;
				break;
			case 6:
				array = this.m_paramSystem.m_rpChannelAngle_06;
				num2 = 7;
				break;
			case 7:
				array = this.m_paramSystem.m_rpChannelAngle_07;
				num2 = 8;
				break;
			case 8:
				array = this.m_paramSystem.m_rpChannelAngle_08;
				num2 = 9;
				break;
			}
			if (array == null)
			{
				return;
			}
			if (num >= num2)
			{
				return;
			}
			if (this.toolStripComboBox_SpeakerAngle.SelectedItem == null)
			{
				return;
			}
			if (this.toolStripComboBox_SpeakerAngle.SelectedItem.GetType() != typeof(frmVirtualization.SpeakerAngle))
			{
				return;
			}
			frmVirtualization.SpeakerAngle speakerAngle = this.toolStripComboBox_SpeakerAngle.SelectedItem as frmVirtualization.SpeakerAngle;
			array[num] = speakerAngle.AngleFloat;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00018478 File Offset: 0x00016678
		private void contextMenuStrip_SpeakerAngle_Closed(object sender, ToolStripDropDownClosedEventArgs e)
		{
			this.contextMenuStrip_SpeakerAngle.Tag = null;
			this.RefreshSpeakerList();
		}

		// Token: 0x0400018A RID: 394
		private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramSystem = default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);

		// Token: 0x0400018B RID: 395
		private int m_nCurrentAudioSystem = -1;

		// Token: 0x02000018 RID: 24
		private class EnvRealizePreset
		{
			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600015A RID: 346 RVA: 0x0001849E File Offset: 0x0001669E
			public string PresetName
			{
				get
				{
					return this.m_szPresetName;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600015B RID: 347 RVA: 0x000184A6 File Offset: 0x000166A6
			// (set) Token: 0x0600015C RID: 348 RVA: 0x000184AE File Offset: 0x000166AE
			public string Text
			{
				get
				{
					return this.m_szPresetName;
				}
				set
				{
					this.m_szPresetName = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600015D RID: 349 RVA: 0x000184B7 File Offset: 0x000166B7
			public int PresetID
			{
				get
				{
					return this.m_nPresetID;
				}
			}

			// Token: 0x0600015E RID: 350 RVA: 0x000184BF File Offset: 0x000166BF
			public EnvRealizePreset(string szPresetName, int nPresetID)
			{
				this.m_szPresetName = szPresetName;
				this.m_nPresetID = nPresetID;
			}

			// Token: 0x0600015F RID: 351 RVA: 0x000184E8 File Offset: 0x000166E8
			public override bool Equals(object obj)
			{
				if (obj == null)
				{
					return false;
				}
				if (obj.GetType() != typeof(frmVirtualization.EnvRealizePreset))
				{
					return false;
				}
				frmVirtualization.EnvRealizePreset envRealizePreset = obj as frmVirtualization.EnvRealizePreset;
				return envRealizePreset.PresetName == this.m_szPresetName && envRealizePreset.PresetID == this.m_nPresetID;
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00018539 File Offset: 0x00016739
			public override int GetHashCode()
			{
				return this.m_nPresetID;
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00018541 File Offset: 0x00016741
			public override string ToString()
			{
				return this.m_szPresetName;
			}

			// Token: 0x0400018C RID: 396
			private string m_szPresetName = "";

			// Token: 0x0400018D RID: 397
			private int m_nPresetID = -1;
		}

		// Token: 0x02000019 RID: 25
		private class SpeakerAngle
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000162 RID: 354 RVA: 0x00018549 File Offset: 0x00016749
			public string AngleString
			{
				get
				{
					if (this.m_fAngle >= 0f)
					{
						return "+" + this.m_fAngle.ToString("F01");
					}
					return this.m_fAngle.ToString("F01");
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000163 RID: 355 RVA: 0x00018583 File Offset: 0x00016783
			// (set) Token: 0x06000164 RID: 356 RVA: 0x0001858B File Offset: 0x0001678B
			public float AngleFloat
			{
				get
				{
					return this.m_fAngle;
				}
				set
				{
					this.m_fAngle = value;
				}
			}

			// Token: 0x06000165 RID: 357 RVA: 0x00018594 File Offset: 0x00016794
			public SpeakerAngle(float fAngle)
			{
				this.m_fAngle = fAngle;
			}

			// Token: 0x06000166 RID: 358 RVA: 0x000185A4 File Offset: 0x000167A4
			public override bool Equals(object obj)
			{
				if (obj == null)
				{
					return false;
				}
				if (obj.GetType() != typeof(frmVirtualization.SpeakerAngle))
				{
					return false;
				}
				frmVirtualization.SpeakerAngle speakerAngle = obj as frmVirtualization.SpeakerAngle;
				return speakerAngle.AngleFloat == this.m_fAngle;
			}

			// Token: 0x06000167 RID: 359 RVA: 0x000185E2 File Offset: 0x000167E2
			public override int GetHashCode()
			{
				return (int)Math.Round((double)this.m_fAngle);
			}

			// Token: 0x06000168 RID: 360 RVA: 0x000185F1 File Offset: 0x000167F1
			public override string ToString()
			{
				return this.AngleString;
			}

			// Token: 0x0400018E RID: 398
			private float m_fAngle;
		}

        private void SingleButton_Cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void SingleButton_OK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void SingleButton_ResetConfig_Click(object sender, EventArgs e)
        {
            this.m_paramSystem.m_rpChannelAngle_00 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_01 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_02 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_03 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_04 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_05 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_06 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_07 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_08 = new float[9];
            this.m_paramSystem.m_rpChannelAngle_00[0] = 0f;
            this.m_paramSystem.m_rpChannelAngle_01[0] = -30f;
            this.m_paramSystem.m_rpChannelAngle_01[1] = 30f;
            this.m_paramSystem.m_rpChannelAngle_02[0] = -90f;
            this.m_paramSystem.m_rpChannelAngle_02[1] = 90f;
            this.m_paramSystem.m_rpChannelAngle_03[0] = -150f;
            this.m_paramSystem.m_rpChannelAngle_03[1] = 150f;
            this.m_paramSystem.m_rpChannelAngle_04[0] = -45f;
            this.m_paramSystem.m_rpChannelAngle_04[1] = 45f;
            this.m_paramSystem.m_rpChannelAngle_04[2] = -135f;
            this.m_paramSystem.m_rpChannelAngle_04[3] = 135f;
            this.m_paramSystem.m_rpChannelAngle_05[0] = -30f;
            this.m_paramSystem.m_rpChannelAngle_05[1] = 30f;
            this.m_paramSystem.m_rpChannelAngle_05[2] = 0f;
            this.m_paramSystem.m_rpChannelAngle_05[3] = 0f;
            this.m_paramSystem.m_rpChannelAngle_05[4] = -110f;
            this.m_paramSystem.m_rpChannelAngle_05[5] = 110f;
            this.m_paramSystem.m_rpChannelAngle_06[0] = -30f;
            this.m_paramSystem.m_rpChannelAngle_06[1] = 30f;
            this.m_paramSystem.m_rpChannelAngle_06[2] = 0f;
            this.m_paramSystem.m_rpChannelAngle_06[3] = 0f;
            this.m_paramSystem.m_rpChannelAngle_06[4] = 180f;
            this.m_paramSystem.m_rpChannelAngle_06[5] = -90f;
            this.m_paramSystem.m_rpChannelAngle_06[6] = 90f;
            this.m_paramSystem.m_rpChannelAngle_07[0] = -30f;
            this.m_paramSystem.m_rpChannelAngle_07[1] = 30f;
            this.m_paramSystem.m_rpChannelAngle_07[2] = 0f;
            this.m_paramSystem.m_rpChannelAngle_07[3] = 0f;
            this.m_paramSystem.m_rpChannelAngle_07[4] = -150f;
            this.m_paramSystem.m_rpChannelAngle_07[5] = 150f;
            this.m_paramSystem.m_rpChannelAngle_07[6] = -90f;
            this.m_paramSystem.m_rpChannelAngle_07[7] = 90f;
            this.m_paramSystem.m_rpChannelAngle_08[0] = -30f;
            this.m_paramSystem.m_rpChannelAngle_08[1] = 30f;
            this.m_paramSystem.m_rpChannelAngle_08[2] = 0f;
            this.m_paramSystem.m_rpChannelAngle_08[3] = 0f;
            this.m_paramSystem.m_rpChannelAngle_08[4] = -150f;
            this.m_paramSystem.m_rpChannelAngle_08[5] = 150f;
            this.m_paramSystem.m_rpChannelAngle_08[6] = 180f;
            this.m_paramSystem.m_rpChannelAngle_08[7] = -90f;
            this.m_paramSystem.m_rpChannelAngle_08[8] = 90f;
            this.RefreshSpeakerList();
        }

        private void HSlider_EnvRealizeDrySignal_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {

        }

        private void ButtonBox_AudioSystemConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = (ListBox)sender;
            if (l == null) return;
            if (l.SelectedIndex < 0 || l.SelectedIndex >8)return;
            
            this.m_nCurrentAudioSystem = l.SelectedIndex;
            this.RefreshSpeakerList();
        }
    }
}
