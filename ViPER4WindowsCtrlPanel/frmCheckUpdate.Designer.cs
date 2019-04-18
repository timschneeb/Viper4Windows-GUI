namespace ViPER4WindowsBin
{
	// Token: 0x02000033 RID: 51
	public partial class frmCheckUpdate : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000259 RID: 601 RVA: 0x0001EE32 File Offset: 0x0001D032
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001EE54 File Offset: 0x0001D054
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ViPER4WindowsBin.frmCheckUpdate));
			this.label_CodeName = new global::System.Windows.Forms.Label();
			this.label_DriverVersion = new global::System.Windows.Forms.Label();
			this.label_ControlPanelVersion = new global::System.Windows.Forms.Label();
			this.groupBox_VersionFromInternet = new global::System.Windows.Forms.GroupBox();
			this.label_CodeName_Net = new global::System.Windows.Forms.Label();
			this.label_DriverVerion_Net = new global::System.Windows.Forms.Label();
			this.label_ControlPanelVersion_Net = new global::System.Windows.Forms.Label();
			this.singleButton_Check = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.singleButton_Copy = new global::ViPER4WindowsBin.UIControls.SingleButton();
			this.groupBox_VersionFromInternet.SuspendLayout();
			base.SuspendLayout();
			this.label_CodeName.AutoSize = true;
			this.label_CodeName.Location = new global::System.Drawing.Point(12, 63);
			this.label_CodeName.Name = "label_CodeName";
			this.label_CodeName.Size = new global::System.Drawing.Size(65, 12);
			this.label_CodeName.TabIndex = 5;
			this.label_CodeName.Text = "$CODE_NAME";
			this.label_DriverVersion.AutoSize = true;
			this.label_DriverVersion.Location = new global::System.Drawing.Point(12, 41);
			this.label_DriverVersion.Name = "label_DriverVersion";
			this.label_DriverVersion.Size = new global::System.Drawing.Size(95, 12);
			this.label_DriverVersion.TabIndex = 4;
			this.label_DriverVersion.Text = "$DRIVER_VERSION";
			this.label_ControlPanelVersion.AutoSize = true;
			this.label_ControlPanelVersion.Location = new global::System.Drawing.Point(12, 19);
			this.label_ControlPanelVersion.Name = "label_ControlPanelVersion";
			this.label_ControlPanelVersion.Size = new global::System.Drawing.Size(131, 12);
			this.label_ControlPanelVersion.TabIndex = 3;
			this.label_ControlPanelVersion.Text = "$CONTROLPANEL_VERSION";
			this.groupBox_VersionFromInternet.Controls.Add(this.label_CodeName_Net);
			this.groupBox_VersionFromInternet.Controls.Add(this.label_DriverVerion_Net);
			this.groupBox_VersionFromInternet.Controls.Add(this.label_ControlPanelVersion_Net);
			this.groupBox_VersionFromInternet.Location = new global::System.Drawing.Point(14, 97);
			this.groupBox_VersionFromInternet.Name = "groupBox_VersionFromInternet";
			this.groupBox_VersionFromInternet.Size = new global::System.Drawing.Size(332, 96);
			this.groupBox_VersionFromInternet.TabIndex = 6;
			this.groupBox_VersionFromInternet.TabStop = false;
			this.groupBox_VersionFromInternet.Text = "$VERSION_FROM_INTERNET";
			this.label_CodeName_Net.AutoSize = true;
			this.label_CodeName_Net.Location = new global::System.Drawing.Point(17, 70);
			this.label_CodeName_Net.Name = "label_CodeName_Net";
			this.label_CodeName_Net.Size = new global::System.Drawing.Size(65, 12);
			this.label_CodeName_Net.TabIndex = 8;
			this.label_CodeName_Net.Text = "$CODE_NAME";
			this.label_DriverVerion_Net.AutoSize = true;
			this.label_DriverVerion_Net.Location = new global::System.Drawing.Point(17, 48);
			this.label_DriverVerion_Net.Name = "label_DriverVerion_Net";
			this.label_DriverVerion_Net.Size = new global::System.Drawing.Size(95, 12);
			this.label_DriverVerion_Net.TabIndex = 7;
			this.label_DriverVerion_Net.Text = "$DRIVER_VERSION";
			this.label_ControlPanelVersion_Net.AutoSize = true;
			this.label_ControlPanelVersion_Net.Location = new global::System.Drawing.Point(17, 26);
			this.label_ControlPanelVersion_Net.Name = "label_ControlPanelVersion_Net";
			this.label_ControlPanelVersion_Net.Size = new global::System.Drawing.Size(131, 12);
			this.label_ControlPanelVersion_Net.TabIndex = 6;
			this.label_ControlPanelVersion_Net.Text = "$CONTROLPANEL_VERSION";
			this.singleButton_Check.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Check.ButtonText = "$CHECK";
			this.singleButton_Check.Location = new global::System.Drawing.Point(239, 19);
			this.singleButton_Check.Name = "singleButton_Check";
			this.singleButton_Check.Size = new global::System.Drawing.Size(112, 40);
			this.singleButton_Check.TabIndex = 7;
			this.singleButton_Check.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Check_ButtonClickNotify);
			this.singleButton_Copy.BackColor = global::System.Drawing.SystemColors.Control;
			this.singleButton_Copy.ButtonText = "$COPY_DOWNLOAD_LINK";
			this.singleButton_Copy.Location = new global::System.Drawing.Point(14, 199);
			this.singleButton_Copy.Name = "singleButton_Copy";
			this.singleButton_Copy.Size = new global::System.Drawing.Size(166, 40);
			this.singleButton_Copy.TabIndex = 8;
			this.singleButton_Copy.ButtonClickNotify += new global::ViPER4WindowsBin.UIControls.SingleButton.ButtonClickEventDelegate(this.singleButton_Copy_ButtonClickNotify);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(363, 250);
			base.Controls.Add(this.singleButton_Copy);
			base.Controls.Add(this.singleButton_Check);
			base.Controls.Add(this.groupBox_VersionFromInternet);
			base.Controls.Add(this.label_CodeName);
			base.Controls.Add(this.label_DriverVersion);
			base.Controls.Add(this.label_ControlPanelVersion);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "frmCheckUpdate";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "$CHECK_UPDATE";
			this.groupBox_VersionFromInternet.ResumeLayout(false);
			this.groupBox_VersionFromInternet.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002B9 RID: 697
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.Label label_CodeName;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Forms.Label label_DriverVersion;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.Label label_ControlPanelVersion;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.GroupBox groupBox_VersionFromInternet;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.Label label_CodeName_Net;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.Label label_DriverVerion_Net;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.Label label_ControlPanelVersion_Net;

		// Token: 0x040002C1 RID: 705
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Check;

		// Token: 0x040002C2 RID: 706
		private global::ViPER4WindowsBin.UIControls.SingleButton singleButton_Copy;
	}
}
