﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
	// Token: 0x0200000F RID: 15
	public partial class frmEQPreset : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000093 RID: 147 RVA: 0x000083D8 File Offset: 0x000065D8
		public frmEQPreset()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.EQUALIZER_PRESET;
			this.singleButton_Load.ButtonText = GlobalMessages.LOAD_PRESET;
			this.singleButton_Cancel.ButtonText = GlobalMessages.CANCEL;
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_FLAT, "0"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_SUPERBASS, "1"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_SOFTBASS, "2"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_ROCK, "3"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_RANDB, "4"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_CLASSIC, "5"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_POP, "6"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_JAZZ, "7"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_BLUES, "8"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_ELECTRONIC, "9"));
			this.buttonBox_Preset.AddItem(new ButtonBox.Item(GlobalMessages.EQUALIZER_PRESET_VOCAL, "10"));
			this.buttonBox_Preset.ItemSelectedNotify += this.PresetSelected;
			for (int i = 0; i < this.m_faEQPreset.Length; i++)
			{
				this.m_faEQPreset[i] = 1f;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008688 File Offset: 0x00006888
		private void PresetSelected(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender)
		{
			if (itCurrItem.Tag == null)
			{
				return;
			}
			if (!(itCurrItem.Tag is string))
			{
				return;
			}
			string text = itCurrItem.Tag as string;
			if (text == "")
			{
				return;
			}
			int num = -1;
			if (!int.TryParse(text, out num))
			{
				return;
			}
			if (num < 0 || num >= 11)
			{
				return;
			}
			switch (num)
			{
			case 0:
				Array.Copy(this.m_faEQPreset_Flat, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 1:
				Array.Copy(this.m_faEQPreset_SuperBass, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 2:
				Array.Copy(this.m_faEQPreset_SoftBass, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 3:
				Array.Copy(this.m_faEQPreset_Rock, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 4:
				Array.Copy(this.m_faEQPreset_RandB, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 5:
				Array.Copy(this.m_faEQPreset_Classic, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 6:
				Array.Copy(this.m_faEQPreset_Pop, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 7:
				Array.Copy(this.m_faEQPreset_Jazz, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 8:
				Array.Copy(this.m_faEQPreset_Blues, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 9:
				Array.Copy(this.m_faEQPreset_Electronic, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			case 10:
				Array.Copy(this.m_faEQPreset_Vocal, this.m_faEQPreset, this.m_faEQPreset.Length);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000882F File Offset: 0x00006A2F
		public void SetPreset(float[] faPreset)
		{
			if (faPreset == null)
			{
				return;
			}
			if (faPreset.Length != this.m_faEQPreset.Length)
			{
				return;
			}
			Array.Copy(faPreset, this.m_faEQPreset, this.m_faEQPreset.Length);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008857 File Offset: 0x00006A57
		public float[] GetPreset()
		{
			return this.m_faEQPreset;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000885F File Offset: 0x00006A5F
		private void singleButton_Load_ButtonClickNotify(SingleButton objSender)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008868 File Offset: 0x00006A68
		private void singleButton_Cancel_ButtonClickNotify(SingleButton objSender)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x04000084 RID: 132
		private readonly float[] m_faEQPreset_Flat = new float[]
		{
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f
		};

		// Token: 0x04000085 RID: 133
		private readonly float[] m_faEQPreset_SuperBass = new float[]
		{
			3.5f,
			2.5f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f
		};

		// Token: 0x04000086 RID: 134
		private readonly float[] m_faEQPreset_SoftBass = new float[]
		{
			3.5f,
			1f,
			0.5f,
			0.5f,
			0.7f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1f,
			1.1f,
			1.1f,
			1.2f,
			1.2f,
			1.3f,
			1.4f,
			1f
		};

		// Token: 0x04000087 RID: 135
		private readonly float[] m_faEQPreset_Rock = new float[]
		{
			2f,
			3f,
			2f,
			0.7f,
			0.7f,
			0.8f,
			1f,
			1f,
			1f,
			1f,
			0.8f,
			0.8f,
			1.3f,
			2f,
			2f,
			1.5f,
			1f,
			1f
		};

		// Token: 0x04000088 RID: 136
		private readonly float[] m_faEQPreset_RandB = new float[]
		{
			1f,
			1.5f,
			2f,
			2.2f,
			0.8f,
			0.8f,
			1f,
			1.4f,
			0.8f,
			1f,
			1.2f,
			1.4f,
			1.6f,
			2f,
			0.8f,
			1f,
			1.4f,
			1.4f
		};

		// Token: 0x04000089 RID: 137
		private readonly float[] m_faEQPreset_Classic = new float[]
		{
			1f,
			1.2f,
			1.8f,
			2.2f,
			2.5f,
			3f,
			2f,
			0.8f,
			0.7f,
			0.7f,
			0.7f,
			0.7f,
			0.8f,
			1f,
			1.5f,
			1.8f,
			2f,
			2f
		};

		// Token: 0x0400008A RID: 138
		private readonly float[] m_faEQPreset_Pop = new float[]
		{
			2f,
			1.8f,
			1.7f,
			1.6f,
			1.5f,
			1.4f,
			1.2f,
			0.8f,
			0.7f,
			0.6f,
			0.7f,
			0.8f,
			1f,
			1.2f,
			1.4f,
			1.6f,
			1.8f,
			1.8f
		};

		// Token: 0x0400008B RID: 139
		private readonly float[] m_faEQPreset_Jazz = new float[]
		{
			1f,
			1f,
			1f,
			1f,
			1.5f,
			1.8f,
			2f,
			2f,
			2f,
			1.6f,
			1f,
			0.8f,
			0.6f,
			0.9f,
			1.2f,
			1.2f,
			1.3f,
			1.3f
		};

		// Token: 0x0400008C RID: 140
		private readonly float[] m_faEQPreset_Blues = new float[]
		{
			0.7f,
			0.8f,
			0.9f,
			1f,
			1.2f,
			1.5f,
			1.2f,
			1f,
			1f,
			1f,
			0.8f,
			0.8f,
			0.8f,
			0.7f,
			0.7f,
			0.7f,
			0.65f,
			0.5f
		};

		// Token: 0x0400008D RID: 141
		private readonly float[] m_faEQPreset_Electronic = new float[]
		{
			1.8f,
			1f,
			0.8f,
			0.6f,
			0.4f,
			0.4f,
			0.6f,
			0.8f,
			1f,
			1f,
			0.8f,
			0.8f,
			1.2f,
			1.4f,
			1.6f,
			1.6f,
			1.6f,
			1.6f
		};

		// Token: 0x0400008E RID: 142
		private readonly float[] m_faEQPreset_Vocal = new float[]
		{
			0.8f,
			0.8f,
			0.8f,
			0.8f,
			0.8f,
			0.8f,
			1f,
			1.2f,
			1.6f,
			2f,
			2f,
			1.6f,
			1.4f,
			1.2f,
			1f,
			0.8f,
			0.6f,
			0.6f
		};

		// Token: 0x0400008F RID: 143
		private float[] m_faEQPreset = new float[18];
	}
}
