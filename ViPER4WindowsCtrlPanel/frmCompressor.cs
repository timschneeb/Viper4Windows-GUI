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
			this.singleButton_OK.ButtonText = GlobalMessages.OK;
			this.singleButton_Cancel.ButtonText = GlobalMessages.CANCEL;
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
			this.onOffSwitch_Compressor.SwitchedOn = this.m_bCompressorEnabled;
			this.onOffSwitch_NoClip.SwitchedOn = this.m_bNoClip;
			this.onOffSwitch_AutoKnee.SwitchedOn = this.m_bAutoKnee;
			this.onOffSwitch_AutoAttack.SwitchedOn = this.m_bAutoAttack;
			this.onOffSwitch_AutoRelease.SwitchedOn = this.m_bAutoRelease;
			this.onOffSwitch_AutoGain.SwitchedOn = this.m_bAutoGain;
			this.hSlider_Threshold.Position = (uint)(this.m_rThreshold * 100f);
			this.hSlider_Knee.Position = (uint)(this.m_rKneewidth * 100f);
			this.hSlider_Ratio.Position = (uint)(this.m_rRatio * 100f);
			this.hSlider_Attack.Position = (uint)(this.m_rAttack * 100f);
			this.hSlider_Release.Position = (uint)(this.m_rRelease * 100f);
			this.hSlider_KneeMult.Position = (uint)(this.m_rKneeMult * 100f);
			this.hSlider_Crest.Position = (uint)(this.m_rCrestTime * 100f);
			this.hSlider_Adapt.Position = (uint)(this.m_rAdaptTime * 100f);
			this.hSlider_Gain.Position = (uint)(this.m_rMakeupGain * 100f);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001E51F File Offset: 0x0001C71F
		private void onOffSwitch_Compressor_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bCompressorEnabled = bSwitchedOn;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001E528 File Offset: 0x0001C728
		private void onOffSwitch_NoClip_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bNoClip = bSwitchedOn;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001E531 File Offset: 0x0001C731
		private void onOffSwitch_AutoKnee_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoKnee = bSwitchedOn;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001E53A File Offset: 0x0001C73A
		private void onOffSwitch_AutoAttack_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoAttack = bSwitchedOn;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001E543 File Offset: 0x0001C743
		private void onOffSwitch_AutoRelease_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoRelease = bSwitchedOn;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001E54C File Offset: 0x0001C74C
		private void onOffSwitch_AutoGain_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoGain = bSwitchedOn;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001E558 File Offset: 0x0001C758
		private void hSlider_Threshold_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rThreshold = fPercent;
			this.label_Threshold.Text = (20.0 * Math.Log10(Math.Pow(10.0, (double)(fPercent * -60f) / 20.0))).ToString("F02") + "dB";
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001E5C0 File Offset: 0x0001C7C0
		private void hSlider_Knee_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rKneewidth = fPercent;
			this.label_Knee.Text = (20.0 * Math.Log10(Math.Pow(10.0, (double)(fPercent * 60f) / 20.0))).ToString("F02") + "dB";
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001E628 File Offset: 0x0001C828
		private void hSlider_Ratio_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rRatio = fPercent;
			if (fPercent > 0.99f)
			{
				this.label_Ratio.Text = "oo:1";
				return;
			}
			this.label_Ratio.Text = (1.0 / (1.0 - (double)fPercent)).ToString("F02") + ":1";
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001E690 File Offset: 0x0001C890
		private void hSlider_Attack_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rAttack = fPercent;
			this.label_Attack.Text = ((double)Parameters.PARAM2LOG(fPercent, 0.0001f, 0.2f) * 1000.0).ToString("F02") + "ms";
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		private void hSlider_Release_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rRelease = fPercent;
			this.label_Release.Text = ((double)Parameters.PARAM2LOG(fPercent, 0.005f, 2f) * 1000.0).ToString("F02") + "ms";
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001E738 File Offset: 0x0001C938
		private void hSlider_KneeMult_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rKneeMult = fPercent;
			this.label_KneeMultValue.Text = Parameters.PARAM2LIN(fPercent, 0f, 4f).ToString("F02") + "x";
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001E780 File Offset: 0x0001C980
		private void hSlider_Crest_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rCrestTime = fPercent;
			this.label_CrestValue.Text = ((double)Parameters.PARAM2LOG(fPercent, 0.005f, 2f) * 1000.0).ToString("F02") + "ms";
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		private void hSlider_Adapt_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rAdaptTime = fPercent;
			this.label_AdaptValue.Text = ((double)Parameters.PARAM2LOG(fPercent, 1f, 4f) * 1000.0).ToString("F02") + "ms";
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001E828 File Offset: 0x0001CA28
		private void hSlider_Gain_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rMakeupGain = fPercent;
			this.label_Gain.Text = (20.0 * Math.Log10(Math.Pow(10.0, (double)(fPercent * 60f) / 20.0))).ToString("F02") + "dB";
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001E88D File Offset: 0x0001CA8D
		private void singleButton_OK_ButtonClickNotify(SingleButton objSender)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001E896 File Offset: 0x0001CA96
		private void singleButton_Cancel_ButtonClickNotify(SingleButton objSender)
		{
			base.DialogResult = DialogResult.Cancel;
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
	}
}
