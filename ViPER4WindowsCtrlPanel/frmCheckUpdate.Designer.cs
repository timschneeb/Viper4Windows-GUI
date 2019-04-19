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
            this.components = new System.ComponentModel.Container();
            this.label_CodeName = new System.Windows.Forms.Label();
            this.label_DriverVersion = new System.Windows.Forms.Label();
            this.label_ControlPanelVersion = new System.Windows.Forms.Label();
            this.groupBox_VersionFromInternet = new System.Windows.Forms.GroupBox();
            this.label_CodeName_Net = new System.Windows.Forms.Label();
            this.label_DriverVerion_Net = new System.Windows.Forms.Label();
            this.label_ControlPanelVersion_Net = new System.Windows.Forms.Label();
            this.singleButton_Check = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.singleButton_Copy = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox_VersionFromInternet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CodeName
            // 
            this.label_CodeName.AutoSize = true;
            this.label_CodeName.Location = new System.Drawing.Point(12, 68);
            this.label_CodeName.Name = "label_CodeName";
            this.label_CodeName.Size = new System.Drawing.Size(80, 13);
            this.label_CodeName.TabIndex = 5;
            this.label_CodeName.Text = "$CODE_NAME";
            // 
            // label_DriverVersion
            // 
            this.label_DriverVersion.AutoSize = true;
            this.label_DriverVersion.Location = new System.Drawing.Point(12, 44);
            this.label_DriverVersion.Name = "label_DriverVersion";
            this.label_DriverVersion.Size = new System.Drawing.Size(108, 13);
            this.label_DriverVersion.TabIndex = 4;
            this.label_DriverVersion.Text = "$DRIVER_VERSION";
            // 
            // label_ControlPanelVersion
            // 
            this.label_ControlPanelVersion.AutoSize = true;
            this.label_ControlPanelVersion.Location = new System.Drawing.Point(12, 21);
            this.label_ControlPanelVersion.Name = "label_ControlPanelVersion";
            this.label_ControlPanelVersion.Size = new System.Drawing.Size(154, 13);
            this.label_ControlPanelVersion.TabIndex = 3;
            this.label_ControlPanelVersion.Text = "$CONTROLPANEL_VERSION";
            // 
            // groupBox_VersionFromInternet
            // 
            this.groupBox_VersionFromInternet.Controls.Add(this.label_CodeName_Net);
            this.groupBox_VersionFromInternet.Controls.Add(this.label_DriverVerion_Net);
            this.groupBox_VersionFromInternet.Controls.Add(this.label_ControlPanelVersion_Net);
            this.groupBox_VersionFromInternet.Location = new System.Drawing.Point(14, 105);
            this.groupBox_VersionFromInternet.Name = "groupBox_VersionFromInternet";
            this.groupBox_VersionFromInternet.Size = new System.Drawing.Size(332, 104);
            this.groupBox_VersionFromInternet.TabIndex = 6;
            this.groupBox_VersionFromInternet.TabStop = false;
            this.groupBox_VersionFromInternet.Text = "$VERSION_FROM_INTERNET";
            // 
            // label_CodeName_Net
            // 
            this.label_CodeName_Net.AutoSize = true;
            this.label_CodeName_Net.Location = new System.Drawing.Point(17, 76);
            this.label_CodeName_Net.Name = "label_CodeName_Net";
            this.label_CodeName_Net.Size = new System.Drawing.Size(80, 13);
            this.label_CodeName_Net.TabIndex = 8;
            this.label_CodeName_Net.Text = "$CODE_NAME";
            // 
            // label_DriverVerion_Net
            // 
            this.label_DriverVerion_Net.AutoSize = true;
            this.label_DriverVerion_Net.Location = new System.Drawing.Point(17, 52);
            this.label_DriverVerion_Net.Name = "label_DriverVerion_Net";
            this.label_DriverVerion_Net.Size = new System.Drawing.Size(108, 13);
            this.label_DriverVerion_Net.TabIndex = 7;
            this.label_DriverVerion_Net.Text = "$DRIVER_VERSION";
            // 
            // label_ControlPanelVersion_Net
            // 
            this.label_ControlPanelVersion_Net.AutoSize = true;
            this.label_ControlPanelVersion_Net.Location = new System.Drawing.Point(17, 28);
            this.label_ControlPanelVersion_Net.Name = "label_ControlPanelVersion_Net";
            this.label_ControlPanelVersion_Net.Size = new System.Drawing.Size(154, 13);
            this.label_ControlPanelVersion_Net.TabIndex = 6;
            this.label_ControlPanelVersion_Net.Text = "$CONTROLPANEL_VERSION";
            // 
            // singleButton_Check
            // 
            this.singleButton_Check.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Check.BeforeTouchSize = new System.Drawing.Size(160, 34);
            this.singleButton_Check.IsBackStageButton = false;
            this.singleButton_Check.Location = new System.Drawing.Point(186, 216);
            this.singleButton_Check.Name = "singleButton_Check";
            this.singleButton_Check.Size = new System.Drawing.Size(160, 34);
            this.singleButton_Check.TabIndex = 9;
            this.singleButton_Check.Text = "$CHECK";
            this.singleButton_Check.ThemeName = "Office2016Colorful";
            this.singleButton_Check.UseVisualStyle = true;
            this.singleButton_Check.Click += new System.EventHandler(this.SingleButton_Check_Click);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // singleButton_Copy
            // 
            this.singleButton_Copy.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Copy.BeforeTouchSize = new System.Drawing.Size(160, 34);
            this.singleButton_Copy.IsBackStageButton = false;
            this.singleButton_Copy.Location = new System.Drawing.Point(15, 216);
            this.singleButton_Copy.Name = "singleButton_Copy";
            this.singleButton_Copy.Size = new System.Drawing.Size(160, 34);
            this.singleButton_Copy.TabIndex = 10;
            this.singleButton_Copy.Text = "$COPY";
            this.singleButton_Copy.ThemeName = "Office2016Colorful";
            this.singleButton_Copy.UseVisualStyle = true;
            this.singleButton_Copy.Click += new System.EventHandler(this.SingleButton_Copy_Click);
            // 
            // frmCheckUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 265);
            this.Controls.Add(this.singleButton_Copy);
            this.Controls.Add(this.singleButton_Check);
            this.Controls.Add(this.groupBox_VersionFromInternet);
            this.Controls.Add(this.label_CodeName);
            this.Controls.Add(this.label_DriverVersion);
            this.Controls.Add(this.label_ControlPanelVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCheckUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$CHECK_UPDATE";
            this.groupBox_VersionFromInternet.ResumeLayout(false);
            this.groupBox_VersionFromInternet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Check;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Copy;
    }
}
