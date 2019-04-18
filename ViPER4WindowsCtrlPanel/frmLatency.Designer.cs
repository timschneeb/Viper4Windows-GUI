namespace ViPER4WindowsBin
{
	// Token: 0x02000008 RID: 8
	public partial class frmLatency : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000030 RID: 48 RVA: 0x00002F56 File Offset: 0x00001156
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002F78 File Offset: 0x00001178
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmLatency));
			this.label_CurrentLatency = new global::System.Windows.Forms.Label();
			this.label_DesiredLatency = new global::System.Windows.Forms.Label();
			this.buttonBox_Latency = new global::ViPER4WindowsBin.UIControls.ButtonBox();
			this.label_LowLatencyNote = new global::System.Windows.Forms.Label();
			this.singleButton_OK = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.singleButton_Cancel = new global::ViPER4WindowsBin.UIControls.SingleButton();
			base.SuspendLayout();
			this.label_CurrentLatency.AutoSize = true;
			this.label_CurrentLatency.Location = new global::System.Drawing.Point(12, 9);
			this.label_CurrentLatency.Name = "label_CurrentLatency";
			this.label_CurrentLatency.Size = new global::System.Drawing.Size(137, 12);
			this.label_CurrentLatency.TabIndex = 0;
			this.label_CurrentLatency.Text = "$CURRENT_LATENCY : 0ms";
			this.label_DesiredLatency.AutoSize = true;
			this.label_DesiredLatency.Location = new global::System.Drawing.Point(12, 41);
			this.label_DesiredLatency.Name = "label_DesiredLatency";
			this.label_DesiredLatency.Size = new global::System.Drawing.Size(101, 12);
			this.label_DesiredLatency.TabIndex = 1;
			this.label_DesiredLatency.Text = "$DESIRED_LATENCY";
			this.buttonBox_Latency.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonBox_Latency.Location = new global::System.Drawing.Point(12, 74);
			this.buttonBox_Latency.Name = "buttonBox_Latency";
			this.buttonBox_Latency.Size = new global::System.Drawing.Size(137, 190);
			this.buttonBox_Latency.TabIndex = 2;
			this.buttonBox_Latency.ItemSelectedNotify += new global::ViPER4WindowsBin.UIControls.ButtonBox.ItemSelectDelegate(this.buttonBox_Latency_ItemSelectedNotify);
			this.label_LowLatencyNote.AutoSize = true;
			this.label_LowLatencyNote.ForeColor = global::System.Drawing.Color.Red;
			this.label_LowLatencyNote.Location = new global::System.Drawing.Point(12, 59);
			this.label_LowLatencyNote.Name = "label_LowLatencyNote";
			this.label_LowLatencyNote.Size = new global::System.Drawing.Size(107, 12);
			this.label_LowLatencyNote.TabIndex = 3;
			this.label_LowLatencyNote.Text = "$LOW_LATENCY_NOTE";
			this.singleButton_OK.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_OK.ButtonText = "$OK";
			this.singleButton_OK.Location = new global::System.Drawing.Point(155, 182);
			this.singleButton_OK.Name = "singleButton_OK";
			this.singleButton_OK.Size = new global::System.Drawing.Size(88, 38);
			this.singleButton_OK.TabIndex = 4;
			this.singleButton_OK.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_OK_ButtonClickNotify);
			this.singleButton_Cancel.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Cancel.ButtonText = "$CANCEL";
			this.singleButton_Cancel.Location = new global::System.Drawing.Point(155, 226);
			this.singleButton_Cancel.Name = "singleButton_Cancel";
			this.singleButton_Cancel.Size = new global::System.Drawing.Size(88, 38);
			this.singleButton_Cancel.TabIndex = 5;
			this.singleButton_Cancel.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Cancel_ButtonClickNotify);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(254, 279);
			base.Controls.Add(this.singleButton_Cancel);
			base.Controls.Add(this.singleButton_OK);
			base.Controls.Add(this.label_LowLatencyNote);
			base.Controls.Add(this.buttonBox_Latency);
			base.Controls.Add(this.label_DesiredLatency);
			base.Controls.Add(this.label_CurrentLatency);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmLatency";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$LATENCY_SETTING";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label_CurrentLatency;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label_DesiredLatency;

		// Token: 0x0400000F RID: 15
		private global::ViPER4WindowsBin.UIControls.ButtonBox buttonBox_Latency;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label_LowLatencyNote;

		// Token: 0x04000011 RID: 17
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_OK;

		// Token: 0x04000012 RID: 18
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Cancel;
	}
}
