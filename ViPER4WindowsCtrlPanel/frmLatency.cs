using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;

namespace ViPER4WindowsBin
{
	// Token: 0x02000008 RID: 8
	public partial class frmLatency : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000337D File Offset: 0x0000157D
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003385 File Offset: 0x00001585
		public int ShortFilterLen
		{
			get
			{
				return this.m_iShortLen;
			}
			set
			{
				this.m_iShortLen = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003394 File Offset: 0x00001594
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000339C File Offset: 0x0000159C
		public int MiddleFilterLen
		{
			get
			{
				return this.m_iMiddleLen;
			}
			set
			{
				this.m_iMiddleLen = value;
				this.UpdateUI();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000033AB File Offset: 0x000015AB
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000033B3 File Offset: 0x000015B3
		public int LongFilterLen
		{
			get
			{
				return this.m_iLongLen;
			}
			set
			{
				this.m_iLongLen = value;
				this.UpdateUI();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000033C4 File Offset: 0x000015C4
		public frmLatency()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.LATENCY_SETTING;
			this.label_CurrentLatency.Text = GlobalMessages.CURRENT_LATENCY + " : " + (this.GetLatency() * 1000f).ToString("F04") + " ms";
			this.label_DesiredLatency.Text = GlobalMessages.DESIRED_LATENCY;
			this.label_LowLatencyNote.Text = GlobalMessages.LOW_LATENCY_NOTE;
			this.singleButton_OK.Text = GlobalMessages.OK;
			this.singleButton_Cancel.Text = GlobalMessages.CANCEL;
            this.buttonBox_Latency.Items.Add((this.GetLatency(16384) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(8192) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(4096) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(2048) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(1024) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(512) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(256) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(128) * 1000f).ToString("F04") + " ms");
            this.buttonBox_Latency.Items.Add((this.GetLatency(64) * 1000f).ToString("F04") + " ms");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003694 File Offset: 0x00001894
		private float GetLatency()
		{
			return (float)this.m_iShortLen / 44100f;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000036B0 File Offset: 0x000018B0
		private float GetLatency(int nLength)
		{
			return (float)nLength / 44100f;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000036C8 File Offset: 0x000018C8
		private void UpdateUI()
		{
			this.label_CurrentLatency.Text = GlobalMessages.CURRENT_LATENCY + " : " + (this.GetLatency() * 1000f).ToString("F04") + " ms";
		}


		// Token: 0x04000013 RID: 19
		private int m_iShortLen = 4096;

		// Token: 0x04000014 RID: 20
		private int m_iMiddleLen;

		// Token: 0x04000015 RID: 21
		private int m_iLongLen;

        private void SingleButton_OK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }

        private void SingleButton_Cancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView l = (ListView)sender;
            if (l == null)return;
            if (l.SelectedIndices[0] < 0 || l.SelectedIndices[0] > 8) return;

            switch (l.SelectedIndices[0].ToString())
            {
                case "8":
                    this.m_iShortLen = 64;
                    this.m_iMiddleLen = 2048;
                    this.m_iLongLen = 16384;
                    return;
                case "7":
                    this.m_iShortLen = 128;
                    this.m_iMiddleLen = 2048;
                    this.m_iLongLen = 8192;
                    return;
                case "6":
                    this.m_iShortLen = 256;
                    this.m_iMiddleLen = 8192;
                    this.m_iLongLen = 0;
                    return;
                case "5":
                    this.m_iShortLen = 512;
                    this.m_iMiddleLen = 4096;
                    this.m_iLongLen = 0;
                    return;
                case "4":
                    this.m_iShortLen = 1024;
                    this.m_iMiddleLen = 2048;
                    this.m_iLongLen = 0;
                    return;
                case "3":
                    this.m_iShortLen = 2048;
                    this.m_iMiddleLen = 0;
                    this.m_iLongLen = 0;
                    return;
                case "2":
                    this.m_iShortLen = 4096;
                    this.m_iMiddleLen = 0;
                    this.m_iLongLen = 0;
                    return;
                case "1":
                    this.m_iShortLen = 8192;
                    this.m_iMiddleLen = 0;
                    this.m_iLongLen = 0;
                    return;
                case "0":
                    this.m_iShortLen = 16384;
                    this.m_iMiddleLen = 0;
                    this.m_iLongLen = 0;
                    break;

                    return;
            }
            }
    }
}
