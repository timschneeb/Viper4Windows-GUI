using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x0200000A RID: 10
	public partial class frmCompressorLite : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00006CB0 File Offset: 0x00004EB0
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00006CBF File Offset: 0x00004EBF
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00006CC7 File Offset: 0x00004EC7
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006CD6 File Offset: 0x00004ED6
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00006CDE File Offset: 0x00004EDE
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00006CED File Offset: 0x00004EED
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00006CF5 File Offset: 0x00004EF5
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00006D0C File Offset: 0x00004F0C
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006D1B File Offset: 0x00004F1B
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00006D23 File Offset: 0x00004F23
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00006D32 File Offset: 0x00004F32
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00006D3A File Offset: 0x00004F3A
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00006D49 File Offset: 0x00004F49
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00006D51 File Offset: 0x00004F51
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00006D60 File Offset: 0x00004F60
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00006D68 File Offset: 0x00004F68
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00006D77 File Offset: 0x00004F77
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00006D7F File Offset: 0x00004F7F
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00006D8E File Offset: 0x00004F8E
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00006D96 File Offset: 0x00004F96
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

		// Token: 0x06000064 RID: 100 RVA: 0x00006DA8 File Offset: 0x00004FA8
		public frmCompressorLite()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.COMPRESSOR;
			this.singleButton_OK.ButtonText = GlobalMessages.OK;
			this.singleButton_Cancel.ButtonText = GlobalMessages.CANCEL;
			this.label_Compressor_Enable.Text = GlobalMessages.ENABLE;
			this.groupBox_Threshold.Text = GlobalMessages.COMPRESSOR_THRESHOLD;
			this.groupBox_Knee.Text = GlobalMessages.COMPRESSOR_KNEEWIDTH;
			this.label_AutoKnee.Text = GlobalMessages.COMPRESSOR_AUTOKNEE;
			this.groupBox_Ratio.Text = GlobalMessages.COMPRESSOR_RATIO;
			this.groupBox_Attack.Text = GlobalMessages.COMPRESSOR_ATTACK;
			this.label_AutoAttack.Text = GlobalMessages.COMPRESSOR_AUTOATTACK;
			this.groupBox_Release.Text = GlobalMessages.COMPRESSOR_RELEASE;
			this.label_AutoRelease.Text = GlobalMessages.COMPRESSOR_AUTORELEASE;
			this.groupBox_MakeUpGain.Text = GlobalMessages.COMPRESSOR_MAKEUPGAIN;
			this.label_AutoGain.Text = GlobalMessages.COMPRESSOR_AUTOGAIN;
			this.UpdateUI();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006EF4 File Offset: 0x000050F4
		private void UpdateUI()
		{
			this.onOffSwitch_Compressor.SwitchedOn = this.m_bCompressorEnabled;
			this.onOffSwitch_AutoKnee.SwitchedOn = this.m_bAutoKnee;
			this.onOffSwitch_AutoAttack.SwitchedOn = this.m_bAutoAttack;
			this.onOffSwitch_AutoRelease.SwitchedOn = this.m_bAutoRelease;
			this.onOffSwitch_AutoGain.SwitchedOn = this.m_bAutoGain;
			this.hSlider_Threshold.Position = (uint)(this.m_rThreshold * 100f);
			this.hSlider_Knee.Position = (uint)(this.m_rKneewidth * 100f);
			this.hSlider_Ratio.Position = (uint)(this.m_rRatio * 100f);
			this.hSlider_Attack.Position = (uint)(this.m_rAttack * 100f);
			this.hSlider_Release.Position = (uint)(this.m_rRelease * 100f);
			this.hSlider_Gain.Position = (uint)(this.m_rMakeupGain * 100f);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006FE6 File Offset: 0x000051E6
		private void onOffSwitch_Compressor_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bCompressorEnabled = bSwitchedOn;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006FEF File Offset: 0x000051EF
		private void onOffSwitch_AutoKnee_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoKnee = bSwitchedOn;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006FF8 File Offset: 0x000051F8
		private void onOffSwitch_AutoAttack_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoAttack = bSwitchedOn;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007001 File Offset: 0x00005201
		private void onOffSwitch_AutoRelease_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoRelease = bSwitchedOn;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000700A File Offset: 0x0000520A
		private void onOffSwitch_AutoGain_SwitchChangeNotify(bool bSwitchedOn, OnOffSwitch objSender)
		{
			this.m_bAutoGain = bSwitchedOn;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007014 File Offset: 0x00005214
		private void hSlider_Threshold_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rThreshold = fPercent;
			this.label_Threshold.Text = (20.0 * Math.Log10(Math.Pow(10.0, (double)(fPercent * -60f) / 20.0))).ToString("F02") + "dB";
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000707C File Offset: 0x0000527C
		private void hSlider_Knee_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rKneewidth = fPercent;
			this.label_Knee.Text = (20.0 * Math.Log10(Math.Pow(10.0, (double)(fPercent * 60f) / 20.0))).ToString("F02") + "dB";
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000070E4 File Offset: 0x000052E4
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

		// Token: 0x0600006E RID: 110 RVA: 0x0000714C File Offset: 0x0000534C
		private void hSlider_Attack_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rAttack = fPercent;
			this.label_Attack.Text = ((double)Parameters.PARAM2LOG(fPercent, 0.0001f, 0.2f) * 1000.0).ToString("F02") + "ms";
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000071A0 File Offset: 0x000053A0
		private void hSlider_Release_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rRelease = fPercent;
			this.label_Release.Text = ((double)Parameters.PARAM2LOG(fPercent, 0.005f, 2f) * 1000.0).ToString("F02") + "ms";
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000071F4 File Offset: 0x000053F4
		private void hSlider_Gain_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rMakeupGain = fPercent;
			this.label_Gain.Text = (20.0 * Math.Log10(Math.Pow(10.0, (double)(fPercent * 60f) / 20.0))).ToString("F02") + "dB";
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007259 File Offset: 0x00005459
		private void singleButton_OK_ButtonClickNotify(SingleButton objSender)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007262 File Offset: 0x00005462
		private void singleButton_Cancel_ButtonClickNotify(SingleButton objSender)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0400006A RID: 106
		private bool m_bCompressorEnabled;

		// Token: 0x0400006B RID: 107
		private float m_rThreshold;

		// Token: 0x0400006C RID: 108
		private float m_rKneewidth;

		// Token: 0x0400006D RID: 109
		private bool m_bAutoKnee = true;

		// Token: 0x0400006E RID: 110
		private float m_rRatio;

		// Token: 0x0400006F RID: 111
		private float m_rAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);

		// Token: 0x04000070 RID: 112
		private bool m_bAutoAttack = true;

		// Token: 0x04000071 RID: 113
		private float m_rRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);

		// Token: 0x04000072 RID: 114
		private bool m_bAutoRelease = true;

		// Token: 0x04000073 RID: 115
		private float m_rMakeupGain;

		// Token: 0x04000074 RID: 116
		private bool m_bAutoGain = true;
	}
}
