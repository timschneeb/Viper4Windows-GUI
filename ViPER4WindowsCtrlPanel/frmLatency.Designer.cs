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
            this.components = new System.ComponentModel.Container();
            this.label_CurrentLatency = new System.Windows.Forms.Label();
            this.label_DesiredLatency = new System.Windows.Forms.Label();
            this.label_LowLatencyNote = new System.Windows.Forms.Label();
            this.singleButton_OK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.buttonBox_Latency = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label_CurrentLatency
            // 
            this.label_CurrentLatency.AutoSize = true;
            this.label_CurrentLatency.Location = new System.Drawing.Point(12, 10);
            this.label_CurrentLatency.Name = "label_CurrentLatency";
            this.label_CurrentLatency.Size = new System.Drawing.Size(149, 13);
            this.label_CurrentLatency.TabIndex = 0;
            this.label_CurrentLatency.Text = "$CURRENT_LATENCY : 0ms";
            // 
            // label_DesiredLatency
            // 
            this.label_DesiredLatency.AutoSize = true;
            this.label_DesiredLatency.Location = new System.Drawing.Point(12, 44);
            this.label_DesiredLatency.Name = "label_DesiredLatency";
            this.label_DesiredLatency.Size = new System.Drawing.Size(116, 13);
            this.label_DesiredLatency.TabIndex = 1;
            this.label_DesiredLatency.Text = "$DESIRED_LATENCY";
            // 
            // label_LowLatencyNote
            // 
            this.label_LowLatencyNote.AutoSize = true;
            this.label_LowLatencyNote.ForeColor = System.Drawing.Color.Red;
            this.label_LowLatencyNote.Location = new System.Drawing.Point(12, 64);
            this.label_LowLatencyNote.Name = "label_LowLatencyNote";
            this.label_LowLatencyNote.Size = new System.Drawing.Size(129, 13);
            this.label_LowLatencyNote.TabIndex = 3;
            this.label_LowLatencyNote.Text = "$LOW_LATENCY_NOTE";
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_OK.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_OK.BeforeTouchSize = new System.Drawing.Size(81, 28);
            this.singleButton_OK.IsBackStageButton = false;
            this.singleButton_OK.Location = new System.Drawing.Point(172, 267);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_OK.Size = new System.Drawing.Size(81, 28);
            this.singleButton_OK.TabIndex = 4;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "Office2016Colorful";
            this.singleButton_OK.UseVisualStyle = true;
            this.singleButton_OK.Click += new System.EventHandler(this.SingleButton_OK_Click);
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Cancel.BeforeTouchSize = new System.Drawing.Size(84, 28);
            this.singleButton_Cancel.IsBackStageButton = false;
            this.singleButton_Cancel.Location = new System.Drawing.Point(82, 267);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Cancel.Size = new System.Drawing.Size(84, 28);
            this.singleButton_Cancel.TabIndex = 5;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "Office2016Colorful";
            this.singleButton_Cancel.UseVisualStyle = true;
            this.singleButton_Cancel.Click += new System.EventHandler(this.SingleButton_Cancel_Click);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // buttonBox_Latency
            // 
            this.buttonBox_Latency.Location = new System.Drawing.Point(15, 85);
            this.buttonBox_Latency.MultiSelect = false;
            this.buttonBox_Latency.Name = "buttonBox_Latency";
            this.buttonBox_Latency.Size = new System.Drawing.Size(238, 176);
            this.buttonBox_Latency.TabIndex = 6;
            this.buttonBox_Latency.UseCompatibleStateImageBehavior = false;
            this.buttonBox_Latency.View = System.Windows.Forms.View.List;
            this.buttonBox_Latency.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // frmLatency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 306);
            this.Controls.Add(this.buttonBox_Latency);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.label_LowLatencyNote);
            this.Controls.Add(this.label_DesiredLatency);
            this.Controls.Add(this.label_CurrentLatency);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLatency";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$LATENCY_SETTING";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label_CurrentLatency;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label_DesiredLatency;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label_LowLatencyNote;

		// Token: 0x04000011 RID: 17
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_OK;

		// Token: 0x04000012 RID: 18
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_Cancel;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private System.Windows.Forms.ListView buttonBox_Latency;
    }
}
