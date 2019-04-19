namespace ViPER4WindowsBin
{
	// Token: 0x0200001F RID: 31
	public partial class frmReverbPreset : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x060001B3 RID: 435 RVA: 0x00019936 File Offset: 0x00017B36
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00019958 File Offset: 0x00017B58
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.singleButton_Load = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.buttonBox_Preset = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // singleButton_Load
            // 
            this.singleButton_Load.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Load.BeforeTouchSize = new System.Drawing.Size(112, 28);
            this.singleButton_Load.IsBackStageButton = false;
            this.singleButton_Load.Location = new System.Drawing.Point(123, 260);
            this.singleButton_Load.Name = "singleButton_Load";
            this.singleButton_Load.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Load.Size = new System.Drawing.Size(112, 28);
            this.singleButton_Load.TabIndex = 6;
            this.singleButton_Load.Text = "$LOAD_PRESET";
            this.singleButton_Load.ThemeName = "Office2016Colorful";
            this.singleButton_Load.UseVisualStyle = true;
            this.singleButton_Load.Click += new System.EventHandler(this.SingleButton_Load_Click);
            // 
            // singleButton_Cancel
            // 
            this.singleButton_Cancel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Cancel.BeforeTouchSize = new System.Drawing.Size(112, 28);
            this.singleButton_Cancel.IsBackStageButton = false;
            this.singleButton_Cancel.Location = new System.Drawing.Point(5, 260);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Cancel.Size = new System.Drawing.Size(112, 28);
            this.singleButton_Cancel.TabIndex = 7;
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
            // buttonBox_Preset
            // 
            this.buttonBox_Preset.Location = new System.Drawing.Point(5, 5);
            this.buttonBox_Preset.MultiSelect = false;
            this.buttonBox_Preset.Name = "buttonBox_Preset";
            this.buttonBox_Preset.Size = new System.Drawing.Size(230, 249);
            this.buttonBox_Preset.TabIndex = 12;
            this.buttonBox_Preset.UseCompatibleStateImageBehavior = false;
            this.buttonBox_Preset.View = System.Windows.Forms.View.List;
            this.buttonBox_Preset.SelectedIndexChanged += new System.EventHandler(this.ButtonBox_Preset_SelectedIndexChanged);
            // 
            // frmReverbPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 299);
            this.Controls.Add(this.buttonBox_Preset);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.singleButton_Load);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReverbPreset";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$REVERB_PRESET";
            this.ResumeLayout(false);

		}

		// Token: 0x040001A9 RID: 425
		private global::System.ComponentModel.IContainer components;
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Load;
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Cancel;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private System.Windows.Forms.ListView buttonBox_Preset;
    }
}
