namespace ViPER4WindowsBin
{
	// Token: 0x0200001A RID: 26
	public partial class frmChannelPan : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x0600016E RID: 366 RVA: 0x000186C6 File Offset: 0x000168C6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000186E8 File Offset: 0x000168E8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label_Left = new System.Windows.Forms.Label();
            this.label_Right = new System.Windows.Forms.Label();
            this.label_Value = new System.Windows.Forms.Label();
            this.hSlider_Pan = new MetroSuite.MetroTrackbar();
            this.singleButton_Center = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.SuspendLayout();
            // 
            // label_Left
            // 
            this.label_Left.AutoSize = true;
            this.label_Left.Location = new System.Drawing.Point(5, 10);
            this.label_Left.Name = "label_Left";
            this.label_Left.Size = new System.Drawing.Size(39, 13);
            this.label_Left.TabIndex = 0;
            this.label_Left.Text = "$LEFT";
            // 
            // label_Right
            // 
            this.label_Right.AutoSize = true;
            this.label_Right.Location = new System.Drawing.Point(343, 10);
            this.label_Right.Name = "label_Right";
            this.label_Right.Size = new System.Drawing.Size(47, 13);
            this.label_Right.TabIndex = 1;
            this.label_Right.Text = "$RIGHT";
            // 
            // label_Value
            // 
            this.label_Value.Location = new System.Drawing.Point(140, 10);
            this.label_Value.Name = "label_Value";
            this.label_Value.Size = new System.Drawing.Size(114, 18);
            this.label_Value.TabIndex = 4;
            this.label_Value.Text = "0.0";
            this.label_Value.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hSlider_Pan
            // 
            this.hSlider_Pan.BackColor = System.Drawing.Color.Transparent;
            this.hSlider_Pan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hSlider_Pan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.hSlider_Pan.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.hSlider_Pan.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Pan.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.hSlider_Pan.Location = new System.Drawing.Point(8, 31);
            this.hSlider_Pan.Name = "hSlider_Pan";
            this.hSlider_Pan.RegionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.hSlider_Pan.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.hSlider_Pan.SecondValue = 0;
            this.hSlider_Pan.Size = new System.Drawing.Size(376, 23);
            this.hSlider_Pan.SliderColor = System.Drawing.Color.White;
            this.hSlider_Pan.TabIndex = 5;
            this.hSlider_Pan.Scroll += new MetroSuite.MetroTrackbar.ScrollEventHandler(this.HSlider_Pan_Scroll);
            // 
            // singleButton_Center
            // 
            this.singleButton_Center.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Center.BeforeTouchSize = new System.Drawing.Size(93, 36);
            this.singleButton_Center.IsBackStageButton = false;
            this.singleButton_Center.Location = new System.Drawing.Point(149, 66);
            this.singleButton_Center.Name = "singleButton_Center";
            this.singleButton_Center.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Center.Size = new System.Drawing.Size(93, 36);
            this.singleButton_Center.TabIndex = 6;
            this.singleButton_Center.Text = "$BALANCE";
            this.singleButton_Center.ThemeName = "Office2016Colorful";
            this.singleButton_Center.UseVisualStyle = true;
            this.singleButton_Center.Click += new System.EventHandler(this.SingleButton_Center_Click);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // frmChannelPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 118);
            this.Controls.Add(this.singleButton_Center);
            this.Controls.Add(this.hSlider_Pan);
            this.Controls.Add(this.label_Value);
            this.Controls.Add(this.label_Right);
            this.Controls.Add(this.label_Left);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChannelPan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$CHANNEL_PAN";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000190 RID: 400
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.Label label_Left;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.Label label_Right;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.Label label_Value;
        private MetroSuite.MetroTrackbar hSlider_Pan;
        private Syncfusion.Windows.Forms.ButtonAdv singleButton_Center;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
    }
}
