namespace ViPER4WindowsBin
{
	// Token: 0x0200000B RID: 11
	public partial class frmAbout : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000073 RID: 115 RVA: 0x0000726B File Offset: 0x0000546B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000728C File Offset: 0x0000548C
		private void InitializeComponent()
		{
            this.label_ControlPanelVersion = new System.Windows.Forms.Label();
            this.label_DriverVersion = new System.Windows.Forms.Label();
            this.label_CodeName = new System.Windows.Forms.Label();
            this.label_LanVersion = new System.Windows.Forms.Label();
            this.label_LanTranslator = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.label_SupportForum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ControlPanelVersion
            // 
            this.label_ControlPanelVersion.AutoSize = true;
            this.label_ControlPanelVersion.Location = new System.Drawing.Point(12, 20);
            this.label_ControlPanelVersion.Name = "label_ControlPanelVersion";
            this.label_ControlPanelVersion.Size = new System.Drawing.Size(154, 13);
            this.label_ControlPanelVersion.TabIndex = 0;
            this.label_ControlPanelVersion.Text = "$CONTROLPANEL_VERSION";
            // 
            // label_DriverVersion
            // 
            this.label_DriverVersion.AutoSize = true;
            this.label_DriverVersion.Location = new System.Drawing.Point(12, 43);
            this.label_DriverVersion.Name = "label_DriverVersion";
            this.label_DriverVersion.Size = new System.Drawing.Size(108, 13);
            this.label_DriverVersion.TabIndex = 1;
            this.label_DriverVersion.Text = "$DRIVER_VERSION";
            // 
            // label_CodeName
            // 
            this.label_CodeName.AutoSize = true;
            this.label_CodeName.Location = new System.Drawing.Point(12, 67);
            this.label_CodeName.Name = "label_CodeName";
            this.label_CodeName.Size = new System.Drawing.Size(80, 13);
            this.label_CodeName.TabIndex = 2;
            this.label_CodeName.Text = "$CODE_NAME";
            // 
            // label_LanVersion
            // 
            this.label_LanVersion.AutoSize = true;
            this.label_LanVersion.Location = new System.Drawing.Point(12, 91);
            this.label_LanVersion.Name = "label_LanVersion";
            this.label_LanVersion.Size = new System.Drawing.Size(126, 13);
            this.label_LanVersion.TabIndex = 3;
            this.label_LanVersion.Text = "$LANGUAGE_VERSION";
            // 
            // label_LanTranslator
            // 
            this.label_LanTranslator.AutoSize = true;
            this.label_LanTranslator.Location = new System.Drawing.Point(12, 115);
            this.label_LanTranslator.Name = "label_LanTranslator";
            this.label_LanTranslator.Size = new System.Drawing.Size(151, 13);
            this.label_LanTranslator.TabIndex = 4;
            this.label_LanTranslator.Text = "$LANGUAGE_TRANSLATOR";
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Location = new System.Drawing.Point(12, 152);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(76, 13);
            this.label_Copyright.TabIndex = 5;
            this.label_Copyright.Text = "$COPYRIGHT";
            // 
            // label_SupportForum
            // 
            this.label_SupportForum.AutoSize = true;
            this.label_SupportForum.Location = new System.Drawing.Point(12, 176);
            this.label_SupportForum.Name = "label_SupportForum";
            this.label_SupportForum.Size = new System.Drawing.Size(110, 13);
            this.label_SupportForum.TabIndex = 6;
            this.label_SupportForum.Text = "$SUPPORT_FORUM";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 206);
            this.Controls.Add(this.label_SupportForum);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.label_LanTranslator);
            this.Controls.Add(this.label_LanVersion);
            this.Controls.Add(this.label_CodeName);
            this.Controls.Add(this.label_DriverVersion);
            this.Controls.Add(this.label_ControlPanelVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$ABOUT";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000075 RID: 117
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label label_ControlPanelVersion;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label label_DriverVersion;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label_CodeName;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label label_LanVersion;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label label_LanTranslator;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Label label_Copyright;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label label_SupportForum;
	}
}
