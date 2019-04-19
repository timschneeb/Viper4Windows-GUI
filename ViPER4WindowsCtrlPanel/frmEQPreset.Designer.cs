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
            this.components = new System.ComponentModel.Container();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.singleButton_Load = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_Cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonBox_Preset = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // singleButton_Load
            // 
            this.singleButton_Load.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Load.BeforeTouchSize = new System.Drawing.Size(112, 28);
            this.singleButton_Load.IsBackStageButton = false;
            this.singleButton_Load.Location = new System.Drawing.Point(123, 197);
            this.singleButton_Load.Name = "singleButton_Load";
            this.singleButton_Load.Size = new System.Drawing.Size(112, 28);
            this.singleButton_Load.TabIndex = 8;
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
            this.singleButton_Cancel.Location = new System.Drawing.Point(5, 197);
            this.singleButton_Cancel.Name = "singleButton_Cancel";
            this.singleButton_Cancel.Size = new System.Drawing.Size(112, 28);
            this.singleButton_Cancel.TabIndex = 9;
            this.singleButton_Cancel.Text = "$CANCEL";
            this.singleButton_Cancel.ThemeName = "Office2016Colorful";
            this.singleButton_Cancel.UseVisualStyle = true;
            this.singleButton_Cancel.Click += new System.EventHandler(this.SingleButton_Cancel_Click);
            // 
            // buttonBox_Preset
            // 
            this.buttonBox_Preset.Location = new System.Drawing.Point(5, 5);
            this.buttonBox_Preset.MultiSelect = false;
            this.buttonBox_Preset.Name = "buttonBox_Preset";
            this.buttonBox_Preset.Size = new System.Drawing.Size(230, 186);
            this.buttonBox_Preset.TabIndex = 11;
            this.buttonBox_Preset.UseCompatibleStateImageBehavior = false;
            this.buttonBox_Preset.View = System.Windows.Forms.View.List;
            this.buttonBox_Preset.SelectedIndexChanged += new System.EventHandler(this.ButtonBox_Preset_SelectedIndexChanged);
            // 
            // frmEQPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 235);
            this.Controls.Add(this.buttonBox_Preset);
            this.Controls.Add(this.singleButton_Cancel);
            this.Controls.Add(this.singleButton_Load);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEQPreset";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$EQUALIZER_PRESET";
            this.ResumeLayout(false);

		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Cancel;
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Load;
        private System.Windows.Forms.ListView buttonBox_Preset;
    }
}
