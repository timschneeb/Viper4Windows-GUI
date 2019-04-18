namespace ViPER4WindowsBin
{
	// Token: 0x0200000F RID: 15
	public partial class frmEQPreset : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000099 RID: 153 RVA: 0x00008871 File Offset: 0x00006A71
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00008890 File Offset: 0x00006A90
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmEQPreset));
			this.buttonBox_Preset = new global::ViPER4WindowsBin.UIControls.ButtonBox();
			this.singleButton_Load = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.singleButton_Cancel = new global::ViPER4WindowsBin.UIControls.SingleButton();
			base.SuspendLayout();
			this.buttonBox_Preset.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonBox_Preset.Location = new global::System.Drawing.Point(12, 12);
			this.buttonBox_Preset.Name = "buttonBox_Preset";
			this.buttonBox_Preset.Size = new global::System.Drawing.Size(175, 331);
			this.buttonBox_Preset.TabIndex = 0;
			this.singleButton_Load.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Load.ButtonText = "$LOAD_PRESET";
			this.singleButton_Load.Location = new global::System.Drawing.Point(193, 12);
			this.singleButton_Load.Name = "singleButton_Load";
			this.singleButton_Load.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_Load.TabIndex = 1;
			this.singleButton_Load.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Load_ButtonClickNotify);
			this.singleButton_Cancel.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Cancel.ButtonText = "$CANCEL";
			this.singleButton_Cancel.Location = new global::System.Drawing.Point(193, 303);
			this.singleButton_Cancel.Name = "singleButton_Cancel";
			this.singleButton_Cancel.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_Cancel.TabIndex = 2;
			this.singleButton_Cancel.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Cancel_ButtonClickNotify);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(318, 355);
			base.Controls.Add(this.singleButton_Cancel);
			base.Controls.Add(this.singleButton_Load);
			base.Controls.Add(this.buttonBox_Preset);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmEQPreset";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$EQUALIZER_PRESET";
			base.ResumeLayout(false);
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000091 RID: 145
		private global::ViPER4WindowsBin.UIControls.ButtonBox buttonBox_Preset;

		// Token: 0x04000092 RID: 146
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Load;

		// Token: 0x04000093 RID: 147
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Cancel;
	}
}
