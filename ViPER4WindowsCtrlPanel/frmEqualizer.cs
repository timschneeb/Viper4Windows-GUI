using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x02000009 RID: 9
	public partial class frmEqualizer : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000041 RID: 65 RVA: 0x00005188 File Offset: 0x00003388
		public void SetRealtimeParameters(RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramBaseSystem, RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode, RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode, RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle, RuntimeUtils.ConfigProxy cpConfigProxy)
		{
			this.m_paramBaseSystem = paramBaseSystem;
			this.m_paramMusicMode = paramMusicMode;
			this.m_paramMovieMode = paramMovieMode;
			this.m_paramFreestyle = paramFreestyle;
			this.m_cpConfigProxy = cpConfigProxy;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000051B0 File Offset: 0x000033B0
		public frmEqualizer()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.EQUALIZER;
			this.label_Equalizer_Enable.Text = GlobalMessages.ENABLE;
			this.checkBox_RealtimeAdjust.Text = GlobalMessages.EQUALIZER_REALTIME_ADJUST;
			this.singleButton_Preset.Text = GlobalMessages.PRESET;
			this.singleButton_OK.Text = GlobalMessages.OK;
            this.m_ctlEQBandList.Add(this.vSlider1);
            this.m_ctlEQBandList.Add(this.vSlider2);
            this.m_ctlEQBandList.Add(this.vSlider3);
            this.m_ctlEQBandList.Add(this.vSlider4);
            this.m_ctlEQBandList.Add(this.vSlider5);
            this.m_ctlEQBandList.Add(this.vSlider6);
            this.m_ctlEQBandList.Add(this.vSlider7);
            this.m_ctlEQBandList.Add(this.vSlider8);
            this.m_ctlEQBandList.Add(this.vSlider9);
            this.m_ctlEQBandList.Add(this.vSlider10);
            this.m_ctlEQBandList.Add(this.vSlider11);
            this.m_ctlEQBandList.Add(this.vSlider12);
            this.m_ctlEQBandList.Add(this.vSlider13);
            this.m_ctlEQBandList.Add(this.vSlider14);
            this.m_ctlEQBandList.Add(this.vSlider15);
            this.m_ctlEQBandList.Add(this.vSlider16);
            this.m_ctlEQBandList.Add(this.vSlider17);
            this.m_ctlEQBandList.Add(this.vSlider18);
            for (int i = 0; i < this.m_ctlEQBandList.Count; i++)
            {
                this.m_ctlEQBandList[i].Tag = i.ToString();
            }
            for (int j = 0; j < this.m_faEQBands.Length; j++)
			{
				this.m_faEQBands[j] = 1f;
			}
			this.m_bEQEnabled = false;
			this.UpdateUI();

			
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005424 File Offset: 0x00003624
		private void UpdateUI()
		{
			if (this.m_bEQEnabled)
			{
				this.onOffSwitch_Equalizer.Checked = true;
			}
			else
			{
				this.onOffSwitch_Equalizer.Checked = false;
			}
			for (int i = 0; i < this.m_faEQBands.Length; i++)
			{
				float num = this.m_faEQBands[i];
				if (num <= 1f)
				{
					num *= 0.5f;
				}
				else
				{
					num -= 1f;
					num /= 4f;
					num *= 0.5f;
					num += 0.5f;
				}
				uint num2 = (uint)(num * 100f);
				if (num2 > 100u)
				{
					num2 = 100u;
				}
                if((int)num2*5 > 500) this.m_ctlEQBandList[i].Value = 500;
                else this.m_ctlEQBandList[i].Value = (int)num2*5;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000054C4 File Offset: 0x000036C4
		private void EQBandChanged(float fPercent, TrackBar objSender)
		{
            //0-5
			if (objSender == null)
			{
				return;
			}
			if (objSender.Tag == null)
			{
				return;
			}
			string text = objSender.Tag as string;
			if (text == null)
			{
				return;
			}
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			if (num < 0 || num >= this.m_faEQBands.Length)
			{
				return;
			}
			float num2;
			if (fPercent < 0.5f)
			{
				num2 = fPercent / 0.5f;
			}
			else
			{
				num2 = (fPercent - 0.5f) / 0.5f;
				num2 = num2 * 4f + 1f;
			}
            this.label1.Text = num2.ToString();
			this.m_faEQBands[num] = num2;
			if (this.checkBox_RealtimeAdjust.Checked)
			{
				if (this.m_paramBaseSystem.m_nEffectMode == 0u)
				{
					this.m_paramMusicMode.m_rpEqualizerBands[num] = num2;
					this.m_cpConfigProxy.UpdateParameter(this.m_paramMusicMode);
					this.m_cpConfigProxy.SyncConfig();
				}
				if (this.m_paramBaseSystem.m_nEffectMode == 1u)
				{
					this.m_paramMovieMode.m_rpEqualizerBands[num] = num2;
					this.m_cpConfigProxy.UpdateParameter(this.m_paramMovieMode);
					this.m_cpConfigProxy.SyncConfig();
				}
				if (this.m_paramBaseSystem.m_nEffectMode == 2u)
				{
					this.m_paramFreestyle.m_rpEqualizerBands[num] = num2;
					this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
					this.m_cpConfigProxy.SyncConfig();
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005600 File Offset: 0x00003800
		private void EQSwitchChange(bool bSwitchedOn, MetroSuite.MetroSwitch objSender)
		{
			this.m_bEQEnabled = bSwitchedOn;
			if (this.checkBox_RealtimeAdjust.Checked)
			{
				if (this.m_paramBaseSystem.m_nEffectMode == 0u)
				{
					if (this.m_bEQEnabled)
					{
						this.m_paramMusicMode.m_bEqualizerEnabled = 1;
					}
					else
					{
						this.m_paramMusicMode.m_bEqualizerEnabled = 0;
					}
					this.m_cpConfigProxy.UpdateParameter(this.m_paramMusicMode);
					this.m_cpConfigProxy.SyncConfig();
				}
				if (this.m_paramBaseSystem.m_nEffectMode == 1u)
				{
					if (this.m_bEQEnabled)
					{
						this.m_paramMovieMode.m_bEqualizerEnabled = 1;
					}
					else
					{
						this.m_paramMovieMode.m_bEqualizerEnabled = 0;
					}
					this.m_cpConfigProxy.UpdateParameter(this.m_paramMovieMode);
					this.m_cpConfigProxy.SyncConfig();
				}
				if (this.m_paramBaseSystem.m_nEffectMode == 2u)
				{
					if (this.m_bEQEnabled)
					{
						this.m_paramFreestyle.m_bEqualizerEnabled = 1;
					}
					else
					{
						this.m_paramFreestyle.m_bEqualizerEnabled = 0;
					}
					this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
					this.m_cpConfigProxy.SyncConfig();
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005707 File Offset: 0x00003907
		public void SetParameters(float[] faEQBands, bool bEQEnabled)
		{
			if (faEQBands == null)
			{
				return;
			}
			if (faEQBands.Length != this.m_faEQBands.Length)
			{
				return;
			}
			Array.Copy(faEQBands, this.m_faEQBands, this.m_faEQBands.Length);
			this.m_bEQEnabled = bEQEnabled;
			this.UpdateUI();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000573C File Offset: 0x0000393C
		public float[] GetParameter()
		{
			return this.m_faEQBands;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005744 File Offset: 0x00003944
		public bool GetEQEnabled()
		{
			return this.m_bEQEnabled;
		}


		// Token: 0x0600004B RID: 75 RVA: 0x0000589C File Offset: 0x00003A9C
		private void checkBox_RealtimeAdjust_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox_RealtimeAdjust.Checked)
			{
				if (this.m_paramBaseSystem.m_nEffectMode == 0u)
				{
					if (this.m_bEQEnabled)
					{
						this.m_paramMusicMode.m_bEqualizerEnabled = 1;
					}
					else
					{
						this.m_paramMusicMode.m_bEqualizerEnabled = 0;
					}
					Array.Copy(this.m_faEQBands, this.m_paramMusicMode.m_rpEqualizerBands, this.m_faEQBands.Length);
					this.m_cpConfigProxy.UpdateParameter(this.m_paramMusicMode);
					this.m_cpConfigProxy.SyncConfig();
				}
				if (this.m_paramBaseSystem.m_nEffectMode == 1u)
				{
					if (this.m_bEQEnabled)
					{
						this.m_paramMovieMode.m_bEqualizerEnabled = 1;
					}
					else
					{
						this.m_paramMovieMode.m_bEqualizerEnabled = 0;
					}
					Array.Copy(this.m_faEQBands, this.m_paramMovieMode.m_rpEqualizerBands, this.m_faEQBands.Length);
					this.m_cpConfigProxy.UpdateParameter(this.m_paramMovieMode);
					this.m_cpConfigProxy.SyncConfig();
				}
				if (this.m_paramBaseSystem.m_nEffectMode == 2u)
				{
					if (this.m_bEQEnabled)
					{
						this.m_paramFreestyle.m_bEqualizerEnabled = 1;
					}
					else
					{
						this.m_paramFreestyle.m_bEqualizerEnabled = 0;
					}
					Array.Copy(this.m_faEQBands, this.m_paramFreestyle.m_rpEqualizerBands, this.m_faEQBands.Length);
					this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
					this.m_cpConfigProxy.SyncConfig();
				}
			}
		}

		// Token: 0x04000043 RID: 67
		private bool m_bEQEnabled;

		// Token: 0x04000044 RID: 68
		private float[] m_faEQBands = new float[18];

		// Token: 0x04000045 RID: 69
		private List<TrackBar> m_ctlEQBandList = new List<TrackBar>();

		// Token: 0x04000046 RID: 70
		private RuntimeUtils.ConfigProxy._ParamOfBaseSystem m_paramBaseSystem;

		// Token: 0x04000047 RID: 71
		private RuntimeUtils.ConfigProxy._ParamOfMusicMode m_paramMusicMode;

		// Token: 0x04000048 RID: 72
		private RuntimeUtils.ConfigProxy._ParamOfMovieMode m_paramMovieMode;

		// Token: 0x04000049 RID: 73
		private RuntimeUtils.ConfigProxy._ParamOfFreestyle m_paramFreestyle;

		// Token: 0x0400004A RID: 74
		private RuntimeUtils.ConfigProxy m_cpConfigProxy;


        private void VSlider1_Scroll(object sender, EventArgs e)
        {
            TrackBar myTB;
            myTB = (TrackBar)sender;
            EQBandChanged(myTB.Value/5f,myTB);
        }

        private void SingleButton_Preset_Click(object sender, EventArgs e)
        {
            frmEQPreset frmEQPreset = new frmEQPreset();
            frmEQPreset.SetPreset(this.m_faEQBands);
            if (frmEQPreset.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            float[] preset = frmEQPreset.GetPreset();
            if (preset == null)
            {
                return;
            }
            if (preset.Length != this.m_faEQBands.Length)
            {
                return;
            }
            Array.Copy(preset, this.m_faEQBands, this.m_faEQBands.Length);
            if (this.checkBox_RealtimeAdjust.Checked)
            {
                if (this.m_paramBaseSystem.m_nEffectMode == 0u)
                {
                    Array.Copy(this.m_faEQBands, this.m_paramMusicMode.m_rpEqualizerBands, this.m_faEQBands.Length);
                    this.m_cpConfigProxy.UpdateParameter(this.m_paramMusicMode);
                    this.m_cpConfigProxy.SyncConfig();
                }
                if (this.m_paramBaseSystem.m_nEffectMode == 1u)
                {
                    Array.Copy(this.m_faEQBands, this.m_paramMovieMode.m_rpEqualizerBands, this.m_faEQBands.Length);
                    this.m_cpConfigProxy.UpdateParameter(this.m_paramMovieMode);
                    this.m_cpConfigProxy.SyncConfig();
                }
                if (this.m_paramBaseSystem.m_nEffectMode == 2u)
                {
                    Array.Copy(this.m_faEQBands, this.m_paramFreestyle.m_rpEqualizerBands, this.m_faEQBands.Length);
                    this.m_cpConfigProxy.UpdateParameter(this.m_paramFreestyle);
                    this.m_cpConfigProxy.SyncConfig();
                }
            }
            this.UpdateUI();

        }

        private void SingleButton_OK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void OnOffSwitch_Equalizer_CheckedChanged(object sender, bool isChecked)
        {
            EQSwitchChange(isChecked, (MetroSuite.MetroSwitch)sender);
        }

        private void Label_Equalizer_Enable_Click(object sender, EventArgs e)
        {

        }
    }
}
