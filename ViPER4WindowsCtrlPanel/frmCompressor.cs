using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x02000032 RID: 50
	public partial class frmCompressor : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0001E088 File Offset: 0x0001C288
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0001E090 File Offset: 0x0001C290
		public bool CompressorEnabled
		{
			get
			{
				return this.m_bCompressorEnabled;
			}
			set
			{
				this.m_bCompressorEnabled = value;
				this.UpdateUI();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0001E09F File Offset: 0x0001C29F
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0001E0A7 File Offset: 0x0001C2A7
		public float Threshold
		{
			get
			{
				return this.m_rThreshold;
			}
			set
			{
				this.m_rThreshold = value;
				this.UpdateUI();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0001E0B6 File Offset: 0x0001C2B6
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0001E0BE File Offset: 0x0001C2BE
		public float KneeWidth
		{
			get
			{
				return this.m_rKneewidth;
			}
			set
			{
				this.m_rKneewidth = value;
				this.UpdateUI();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0001E0CD File Offset: 0x0001C2CD
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0001E0D5 File Offset: 0x0001C2D5
		public bool AutoKnee
		{
			get
			{
				return this.m_bAutoKnee;
			}
			set
			{
				this.m_bAutoKnee = value;
				this.UpdateUI();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0001E0EC File Offset: 0x0001C2EC
		public float Ratio
		{
			get
			{
				return this.m_rRatio;
			}
			set
			{
				this.m_rRatio = value;
				this.UpdateUI();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0001E0FB File Offset: 0x0001C2FB
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0001E103 File Offset: 0x0001C303
		public float AttackTime
		{
			get
			{
				return this.m_rAttack;
			}
			set
			{
				this.m_rAttack = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0001E112 File Offset: 0x0001C312
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0001E11A File Offset: 0x0001C31A
		public bool AutoAttack
		{
			get
			{
				return this.m_bAutoAttack;
			}
			set
			{
				this.m_bAutoAttack = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0001E129 File Offset: 0x0001C329
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0001E131 File Offset: 0x0001C331
		public float ReleaseTime
		{
			get
			{
				return this.m_rRelease;
			}
			set
			{
				this.m_rRelease = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0001E140 File Offset: 0x0001C340
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0001E148 File Offset: 0x0001C348
		public bool AutoRelease
		{
			get
			{
				return this.m_bAutoRelease;
			}
			set
			{
				this.m_bAutoRelease = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0001E157 File Offset: 0x0001C357
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0001E15F File Offset: 0x0001C35F
		public float MakeupGain
		{
			get
			{
				return this.m_rMakeupGain;
			}
			set
			{
				this.m_rMakeupGain = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0001E16E File Offset: 0x0001C36E
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0001E176 File Offset: 0x0001C376
		public bool AutoGain
		{
			get
			{
				return this.m_bAutoGain;
			}
			set
			{
				this.m_bAutoGain = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0001E185 File Offset: 0x0001C385
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0001E18D File Offset: 0x0001C38D
		public bool NoClip
		{
			get
			{
				return this.m_bNoClip;
			}
			set
			{
				this.m_bNoClip = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0001E19C File Offset: 0x0001C39C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		public float KneeMult
		{
			get
			{
				return this.m_rKneeMult;
			}
			set
			{
				this.m_rKneeMult = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0001E1B3 File Offset: 0x0001C3B3
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0001E1BB File Offset: 0x0001C3BB
		public float CrestTime
		{
			get
			{
				return this.m_rCrestTime;
			}
			set
			{
				this.m_rCrestTime = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0001E1CA File Offset: 0x0001C3CA
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0001E1D2 File Offset: 0x0001C3D2
		public float AdaptTime
		{
			get
			{
				return this.m_rAdaptTime;
			}
			set
			{
				this.m_rAdaptTime = value;
				this.UpdateUI();
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001E1E4 File Offset: 0x0001C3E4
		public frmCompressor()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.COMPRESSOR;
			this.singleButton_OK.Text = GlobalMessages.OK;
			this.singleButton_Cancel.Text = GlobalMessages.CANCEL;
			this.label_Compressor_Enable.Text = GlobalMessages.ENABLE;
			this.label_NoClip.Text = GlobalMessages.COMPRESSOR_NOCLIP;
			this.groupBox_Threshold.Text = GlobalMessages.COMPRESSOR_THRESHOLD;
			this.groupBox_Knee.Text = GlobalMessages.COMPRESSOR_KNEEWIDTH;
			this.label_AutoKnee.Text = GlobalMessages.COMPRESSOR_AUTOKNEE;
			this.groupBox_Ratio.Text = GlobalMessages.COMPRESSOR_RATIO;
			this.groupBox_Attack.Text = GlobalMessages.COMPRESSOR_ATTACK;
			this.label_AutoAttack.Text = GlobalMessages.COMPRESSOR_AUTOATTACK;
			this.groupBox_Release.Text = GlobalMessages.COMPRESSOR_RELEASE;
			this.label_AutoRelease.Text = GlobalMessages.COMPRESSOR_AUTORELEASE;
			this.groupBox_Misc.Text = GlobalMessages.COMPRESSOR_MISC;
			this.label_KneeMult.Text = GlobalMessages.COMPRESSOR_KNEEMULT;
			this.label_Crest.Text = GlobalMessages.COMPRESSOR_CRESTTIME;
			this.label_Adapt.Text = GlobalMessages.COMPRESSOR_ADAPTTIME;
			this.groupBox_MakeUpGain.Text = GlobalMessages.COMPRESSOR_MAKEUPGAIN;
			this.label_AutoGain.Text = GlobalMessages.COMPRESSOR_AUTOGAIN;
			this.UpdateUI();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001E3D4 File Offset: 0x0001C5D4
		private void UpdateUI()
		{
            this.onOffSwitch_Compressor.Checked = this.m_bCompressorEnabled;
			this.onOffSwitch_NoClip.Checked = this.m_bNoClip;
			this.onOffSwitch_AutoKnee.Checked = this.m_bAutoKnee;
			this.onOffSwitch_AutoAttack.Checked = this.m_bAutoAttack;
			this.onOffSwitch_AutoRelease.Checked = this.m_bAutoRelease;
			this.onOffSwitch_AutoGain.Checked = this.m_bAutoGain;
			this.hSlider_Threshold.Value = (int)(this.m_rThreshold*100);
			this.hSlider_Knee.Value = (int)(this.m_rKneewidth*100 );
			this.hSlider_Ratio.Value = (int)(this.m_rRatio*100 );
			this.hSlider_Attack.Value = (int)(this.m_rAttack *100);
			this.hSlider_Release.Value = (int)(this.m_rRelease*100 );
			this.hSlider_KneeMult.Value = (int)(this.m_rKneeMult *100);
			this.hSlider_Crest.Value = (int)(this.m_rCrestTime*100 );
			this.hSlider_Adapt.Value = (int)(this.m_rAdaptTime*100 );
			this.hSlider_Gain.Value = (int)(this.m_rMakeupGain *100);

		}


		// Token: 0x040002A8 RID: 680
		private bool m_bCompressorEnabled;

		// Token: 0x040002A9 RID: 681
		private float m_rThreshold;

		// Token: 0x040002AA RID: 682
		private float m_rKneewidth;

		// Token: 0x040002AB RID: 683
		private bool m_bAutoKnee = true;

		// Token: 0x040002AC RID: 684
		private float m_rRatio;

		// Token: 0x040002AD RID: 685
		private float m_rAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);

		// Token: 0x040002AE RID: 686
		private bool m_bAutoAttack = true;

		// Token: 0x040002AF RID: 687
		private float m_rRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);

		// Token: 0x040002B0 RID: 688
		private bool m_bAutoRelease = true;

		// Token: 0x040002B1 RID: 689
		private float m_rMakeupGain;

		// Token: 0x040002B2 RID: 690
		private bool m_bAutoGain = true;

		// Token: 0x040002B3 RID: 691
		private bool m_bNoClip = true;

		// Token: 0x040002B4 RID: 692
		private float m_rKneeMult = Parameters.LIN2PARAM(2f, 0f, 4f);

		// Token: 0x040002B5 RID: 693
		private float m_rCrestTime = Parameters.LOG2PARAM(0.2f, 0.005f, 2f);

		// Token: 0x040002B6 RID: 694
		private float m_rAdaptTime = Parameters.LOG2PARAM(2.5f, 1f, 4f);

        private void OnOffSwitch_NoClip_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bNoClip = isChecked;
        }

        private void OnOffSwitch_Compressor_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bCompressorEnabled = isChecked;
        }

        private void OnOffSwitch_AutoKnee_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bAutoKnee = isChecked;

        }

        private void OnOffSwitch_AutoGain_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bAutoAttack = isChecked;
        }

        private void OnOffSwitch_AutoRelease_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bAutoRelease = isChecked;
        }

        private void OnOffSwitch_AutoAttack_CheckedChanged(object sender, bool isChecked)
        {
            this.m_bAutoGain = isChecked;
        }

        private void SingleButton_OK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void SingleButton_Cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void HSlider_Threshold_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            
            this.m_rThreshold = e.SliderValue/100f;
            this.label_Threshold.Text = ((20.0 * Math.Log10(Math.Pow(10.0, (double)(e.SliderValue * -60f) / 20.0))) / 100).ToString("F02") + "dB";
        }

        private void HSlider_Knee_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            this.m_rKneewidth = e.SliderValue/100f;
            this.label_Knee.Text = ((20.0 * Math.Log10(Math.Pow(10.0, (double)(e.SliderValue * 60f) / 20.0)))/100).ToString("F02") + "dB";
        }

        private void HSlider_Ratio_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            float fPercent = e.SliderValue;
            this.m_rRatio = fPercent/100f;
            if (fPercent > 99.99f)
            {
                this.label_Ratio.Text = "oo:1";
                return;
            }
            this.label_Ratio.Text = (100.0 / (100.0 - (double)fPercent)).ToString("F02") + ":1";
        }

        private void HSlider_Attack_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            //200
            this.m_rAttack = e.SliderValue/1000f;
            this.label_Attack.Text = ((double)Parameters.PARAM2LOG(e.SliderValue/1000f, 0.0001f, 0.2f) * 1000.0).ToString("F02") + "ms";

        }

        private void HSlider_Release_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            //2000
            this.m_rRelease = e.SliderValue/1000f;
            this.label_Release.Text = ((double)Parameters.PARAM2LOG(e.SliderValue/1000f, 0.005f, 2f) * 1000.0).ToString("F02") + "ms";
        }

        private void HSlider_Crest_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            //2000
            this.m_rCrestTime = e.SliderValue/1000f;
            this.label_CrestValue.Text = (((double)Parameters.PARAM2LOG(e.SliderValue/1000f, 0.005f, 2f) * 1000.0)).ToString("F02") + "ms";
        }

        private void HSlider_KneeMult_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            //4
            this.m_rKneeMult = e.SliderValue/100f;
            this.label_KneeMultValue.Text = (Parameters.PARAM2LIN(e.SliderValue/100f, 0f, 4f)).ToString("F02") + "x";
        }

        private void HSlider_Adapt_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
            //4000
            this.m_rAdaptTime = e.SliderValue/1000f;
            this.label_AdaptValue.Text = (((double)Parameters.PARAM2LOG(e.SliderValue/1000f, 1f, 4f) * 100.0)).ToString("F02") + "ms";
        }

        private void HSlider_Gain_Scroll(object sender, MetroSuite.MetroTrackbar.TrackbarEventArgs e)
        {
           this.m_rMakeupGain = e.SliderValue/100f;
            this.label_Gain.Text = ((20.0 * Math.Log10(Math.Pow(10.0, (double)(e.SliderValue * 60f) / 20.0)))/100).ToString("F02") + "dB";

        }

        private void GroupBox_MakeUpGain_Enter(object sender, EventArgs e)
        {

        }

        private void Label_CrestValue_Click(object sender, EventArgs e)
        {

        }

        private void Label_KneeMult_Click(object sender, EventArgs e)
        {

        }
    }  
}
