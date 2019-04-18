using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
	// Token: 0x0200001A RID: 26
	public partial class frmChannelPan : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000185F9 File Offset: 0x000167F9
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00018601 File Offset: 0x00016801
		public float ChannelPan
		{
			get
			{
				return this.m_rChannelPan;
			}
			set
			{
				this.m_rChannelPan = value;
                this.hSlider_Pan.Value = Convert.ToInt32(this.m_rChannelPan * 0.5f + 0.5f);
                    
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00018628 File Offset: 0x00016828
		public frmChannelPan()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.CHANNEL_PAN;
			this.label_Left.Text = GlobalMessages.LEFT;
			this.label_Right.Text = GlobalMessages.RIGHT;
			this.singleButton_Center.Text = GlobalMessages.BALANCE;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001867C File Offset: 0x0001687C
		private void hSlider_Pan_PositionChangeNotify(float fPercent, HSlider objSender)
		{
			this.m_rChannelPan = (fPercent - 0.5f) * 2f;
			this.label_Value.Text = this.m_rChannelPan.ToString("F01");
		}

		// Token: 0x0400018F RID: 399
		private float m_rChannelPan;

        private void SingleButton_Center_Click(object sender, EventArgs e)
        {
			this.m_rChannelPan = 0f;
			this.hSlider_Pan.Value = 50;
        }
    }
}
