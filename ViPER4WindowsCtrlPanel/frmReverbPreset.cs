using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
	// Token: 0x0200001F RID: 31
	public partial class frmReverbPreset : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000192E4 File Offset: 0x000174E4
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000192EC File Offset: 0x000174EC
		public float ReverbSize
		{
			get
			{
				return this.m_rReverbSize;
			}
			set
			{
				this.m_rReverbSize = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000192F5 File Offset: 0x000174F5
		// (set) Token: 0x06000199 RID: 409 RVA: 0x000192FD File Offset: 0x000174FD
		public float ReverbPredelay
		{
			get
			{
				return this.m_rReverbPredelay;
			}
			set
			{
				this.m_rReverbPredelay = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00019306 File Offset: 0x00017506
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001930E File Offset: 0x0001750E
		public float ReverbDamping
		{
			get
			{
				return this.m_rReverbDamping;
			}
			set
			{
				this.m_rReverbDamping = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00019317 File Offset: 0x00017517
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0001931F File Offset: 0x0001751F
		public float ReverbDensity
		{
			get
			{
				return this.m_rReverbDensity;
			}
			set
			{
				this.m_rReverbDensity = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00019328 File Offset: 0x00017528
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00019330 File Offset: 0x00017530
		public float ReverbBandwidth
		{
			get
			{
				return this.m_rReverbBandwidth;
			}
			set
			{
				this.m_rReverbBandwidth = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00019339 File Offset: 0x00017539
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00019341 File Offset: 0x00017541
		public float ReverbDecay
		{
			get
			{
				return this.m_rReverbDecay;
			}
			set
			{
				this.m_rReverbDecay = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001934A File Offset: 0x0001754A
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00019352 File Offset: 0x00017552
		public float ReverbEarlyMix
		{
			get
			{
				return this.m_rReverbEarlyMix;
			}
			set
			{
				this.m_rReverbEarlyMix = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001935B File Offset: 0x0001755B
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00019363 File Offset: 0x00017563
		public float ReverbMix
		{
			get
			{
				return this.m_rReverbMix;
			}
			set
			{
				this.m_rReverbMix = value;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001936C File Offset: 0x0001756C
		public frmReverbPreset()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.REVERB_PRESET;
			this.singleButton_Load.Text = GlobalMessages.LOAD_PRESET;
			this.singleButton_Cancel.Text = GlobalMessages.CANCEL;
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_LIVINGROOM);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_BATHROOM);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_BATHROOM_BATHING);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_BEDROOM);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_THEATER);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_AUDITORIUM);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_UNDERGROUND_PLAZA);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_UNDERGROUND_PARKING);
            this.buttonBox_Preset.Items.Add(GlobalMessages.REVERB_PRESET_SCENE_SHOW);



		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000194BC File Offset: 0x000176BC
		private void Apply01Preset()
		{
			this.m_rReverbDamping = 0.3f;
			this.m_rReverbDensity = 0.3f;
			this.m_rReverbBandwidth = 0.96f;
			this.m_rReverbPredelay = 0.2f;
			this.m_rReverbSize = 0.15f;
			this.m_rReverbDecay = 0.41f;
			this.m_rReverbMix = 0.36f;
			this.m_rReverbEarlyMix = 0.51f;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00019524 File Offset: 0x00017724
		private void Apply02Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.8f;
			this.m_rReverbBandwidth = 1f;
			this.m_rReverbPredelay = 0f;
			this.m_rReverbSize = 0.05f;
			this.m_rReverbDecay = 0.26f;
			this.m_rReverbMix = 0.51f;
			this.m_rReverbEarlyMix = 0.59f;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001958C File Offset: 0x0001778C
		private void Apply03Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.8f;
			this.m_rReverbBandwidth = 0.11f;
			this.m_rReverbPredelay = 0f;
			this.m_rReverbSize = 0.05f;
			this.m_rReverbDecay = 0.26f;
			this.m_rReverbMix = 0.51f;
			this.m_rReverbEarlyMix = 0.59f;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000195F4 File Offset: 0x000177F4
		private void Apply04Preset()
		{
			this.m_rReverbDamping = 0.3f;
			this.m_rReverbDensity = 0.3f;
			this.m_rReverbBandwidth = 0.8f;
			this.m_rReverbPredelay = 0.14f;
			this.m_rReverbSize = 0.08f;
			this.m_rReverbDecay = 0.41f;
			this.m_rReverbMix = 0.29f;
			this.m_rReverbEarlyMix = 0.41f;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001965C File Offset: 0x0001785C
		private void Apply05Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.3f;
			this.m_rReverbBandwidth = 0.25f;
			this.m_rReverbPredelay = 0f;
			this.m_rReverbSize = 0.51f;
			this.m_rReverbDecay = 0.06f;
			this.m_rReverbMix = 0.39f;
			this.m_rReverbEarlyMix = 0.5f;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000196C4 File Offset: 0x000178C4
		private void Apply06Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.16f;
			this.m_rReverbBandwidth = 1f;
			this.m_rReverbPredelay = 0.37f;
			this.m_rReverbSize = 0.6f;
			this.m_rReverbDecay = 0.26f;
			this.m_rReverbMix = 0.51f;
			this.m_rReverbEarlyMix = 0.59f;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001972C File Offset: 0x0001792C
		private void Apply07Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.3f;
			this.m_rReverbBandwidth = 0f;
			this.m_rReverbPredelay = 0f;
			this.m_rReverbSize = 1f;
			this.m_rReverbDecay = 0f;
			this.m_rReverbMix = 0.39f;
			this.m_rReverbEarlyMix = 0.5f;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00019794 File Offset: 0x00017994
		private void Apply08Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.16f;
			this.m_rReverbBandwidth = 0.91f;
			this.m_rReverbPredelay = 0.18f;
			this.m_rReverbSize = 1f;
			this.m_rReverbDecay = 0f;
			this.m_rReverbMix = 0.59f;
			this.m_rReverbEarlyMix = 0.33f;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000197FC File Offset: 0x000179FC
		private void Apply09Preset()
		{
			this.m_rReverbDamping = 0.65f;
			this.m_rReverbDensity = 0.33f;
			this.m_rReverbBandwidth = 0.15f;
			this.m_rReverbPredelay = 0f;
			this.m_rReverbSize = 0.81f;
			this.m_rReverbDecay = 0f;
			this.m_rReverbMix = 0.4f;
			this.m_rReverbEarlyMix = 0.25f;
		}

		// Token: 0x040001A1 RID: 417
		private float m_rReverbSize;

		// Token: 0x040001A2 RID: 418
		private float m_rReverbPredelay;

		// Token: 0x040001A3 RID: 419
		private float m_rReverbDamping;

		// Token: 0x040001A4 RID: 420
		private float m_rReverbDensity;

		// Token: 0x040001A5 RID: 421
		private float m_rReverbBandwidth = 1f;

		// Token: 0x040001A6 RID: 422
		private float m_rReverbDecay;

		// Token: 0x040001A7 RID: 423
		private float m_rReverbEarlyMix;

		// Token: 0x040001A8 RID: 424
		private float m_rReverbMix;

        private void SingleButton_Cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void SingleButton_Load_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void ButtonBox_Preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buttonBox_Preset.SelectedItems.Count != 1) return;
            int idx = buttonBox_Preset.SelectedItems[0].Index;
            if (idx < 0 || idx > 10)
            {
                return;
            }
            switch (idx)
            {
                case 0:
                    this.Apply01Preset();
                    return;
                case 1:
                    this.Apply02Preset();
                    return;
                case 2:
                    this.Apply03Preset();
                    return;
                case 3:
                    this.Apply04Preset();
                    return;
                case 4:
                    this.Apply05Preset();
                    return;
                case 5:
                    this.Apply06Preset();
                    return;
                case 6:
                    this.Apply07Preset();
                    return;
                case 7:
                    this.Apply08Preset();
                    return;
                case 8:
                    this.Apply09Preset();
                    return;
                default:
                    return;
            }

        }
    }
}
