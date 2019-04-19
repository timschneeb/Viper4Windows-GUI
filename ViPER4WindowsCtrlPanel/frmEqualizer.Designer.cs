namespace ViPER4WindowsBin
{
	// Token: 0x02000009 RID: 9
	public partial class frmEqualizer : global::Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x0600003F RID: 63 RVA: 0x00003926 File Offset: 0x00001B26
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003948 File Offset: 0x00001B48
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label_Equalizer_Enable = new System.Windows.Forms.Label();
            this.vSlider1 = new System.Windows.Forms.TrackBar();
            this.vSlider2 = new System.Windows.Forms.TrackBar();
            this.vSlider3 = new System.Windows.Forms.TrackBar();
            this.vSlider4 = new System.Windows.Forms.TrackBar();
            this.vSlider5 = new System.Windows.Forms.TrackBar();
            this.vSlider6 = new System.Windows.Forms.TrackBar();
            this.vSlider7 = new System.Windows.Forms.TrackBar();
            this.vSlider8 = new System.Windows.Forms.TrackBar();
            this.vSlider9 = new System.Windows.Forms.TrackBar();
            this.vSlider10 = new System.Windows.Forms.TrackBar();
            this.vSlider11 = new System.Windows.Forms.TrackBar();
            this.vSlider12 = new System.Windows.Forms.TrackBar();
            this.vSlider13 = new System.Windows.Forms.TrackBar();
            this.vSlider14 = new System.Windows.Forms.TrackBar();
            this.vSlider15 = new System.Windows.Forms.TrackBar();
            this.vSlider16 = new System.Windows.Forms.TrackBar();
            this.vSlider17 = new System.Windows.Forms.TrackBar();
            this.vSlider18 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_dB_Max = new System.Windows.Forms.Label();
            this.label_dB_Min = new System.Windows.Forms.Label();
            this.label_dB_Zero = new System.Windows.Forms.Label();
            this.checkBox_RealtimeAdjust = new System.Windows.Forms.CheckBox();
            this.singleButton_OK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.singleButton_Preset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.skinManager1 = new Syncfusion.Windows.Forms.SkinManager(this.components);
            this.onOffSwitch_Equalizer = new MetroSuite.MetroSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider18)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Equalizer_Enable
            // 
            this.label_Equalizer_Enable.AutoSize = true;
            this.label_Equalizer_Enable.Location = new System.Drawing.Point(51, 278);
            this.label_Equalizer_Enable.Name = "label_Equalizer_Enable";
            this.label_Equalizer_Enable.Size = new System.Drawing.Size(55, 13);
            this.label_Equalizer_Enable.TabIndex = 0;
            this.label_Equalizer_Enable.Text = "$ENABLE";
            this.label_Equalizer_Enable.Click += new System.EventHandler(this.Label_Equalizer_Enable_Click);
            // 
            // vSlider1
            // 
            this.vSlider1.Location = new System.Drawing.Point(42, 19);
            this.vSlider1.Maximum = 500;
            this.vSlider1.Name = "vSlider1";
            this.vSlider1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider1.Size = new System.Drawing.Size(45, 221);
            this.vSlider1.TabIndex = 2;
            this.vSlider1.TickFrequency = 50;
            this.vSlider1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider1.Value = 250;
            this.vSlider1.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider2
            // 
            this.vSlider2.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider2.Location = new System.Drawing.Point(84, 19);
            this.vSlider2.Maximum = 500;
            this.vSlider2.Name = "vSlider2";
            this.vSlider2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider2.Size = new System.Drawing.Size(45, 221);
            this.vSlider2.TabIndex = 3;
            this.vSlider2.TickFrequency = 50;
            this.vSlider2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider2.Value = 250;
            this.vSlider2.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider3
            // 
            this.vSlider3.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider3.Location = new System.Drawing.Point(125, 19);
            this.vSlider3.Maximum = 500;
            this.vSlider3.Name = "vSlider3";
            this.vSlider3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider3.Size = new System.Drawing.Size(45, 221);
            this.vSlider3.TabIndex = 4;
            this.vSlider3.TickFrequency = 50;
            this.vSlider3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider3.Value = 250;
            this.vSlider3.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider4
            // 
            this.vSlider4.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider4.Location = new System.Drawing.Point(166, 19);
            this.vSlider4.Maximum = 500;
            this.vSlider4.Name = "vSlider4";
            this.vSlider4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider4.Size = new System.Drawing.Size(45, 221);
            this.vSlider4.TabIndex = 5;
            this.vSlider4.TickFrequency = 50;
            this.vSlider4.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider4.Value = 250;
            this.vSlider4.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider5
            // 
            this.vSlider5.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider5.Location = new System.Drawing.Point(204, 19);
            this.vSlider5.Maximum = 500;
            this.vSlider5.Name = "vSlider5";
            this.vSlider5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider5.Size = new System.Drawing.Size(45, 221);
            this.vSlider5.TabIndex = 6;
            this.vSlider5.TickFrequency = 50;
            this.vSlider5.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider5.Value = 250;
            this.vSlider5.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider6
            // 
            this.vSlider6.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider6.Location = new System.Drawing.Point(246, 19);
            this.vSlider6.Maximum = 500;
            this.vSlider6.Name = "vSlider6";
            this.vSlider6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider6.Size = new System.Drawing.Size(45, 221);
            this.vSlider6.TabIndex = 7;
            this.vSlider6.TickFrequency = 50;
            this.vSlider6.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider6.Value = 250;
            this.vSlider6.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider7
            // 
            this.vSlider7.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider7.Location = new System.Drawing.Point(288, 19);
            this.vSlider7.Maximum = 500;
            this.vSlider7.Name = "vSlider7";
            this.vSlider7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider7.Size = new System.Drawing.Size(45, 221);
            this.vSlider7.TabIndex = 8;
            this.vSlider7.TickFrequency = 50;
            this.vSlider7.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider7.Value = 250;
            this.vSlider7.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider8
            // 
            this.vSlider8.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider8.Location = new System.Drawing.Point(327, 19);
            this.vSlider8.Maximum = 500;
            this.vSlider8.Name = "vSlider8";
            this.vSlider8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider8.Size = new System.Drawing.Size(45, 221);
            this.vSlider8.TabIndex = 9;
            this.vSlider8.TickFrequency = 50;
            this.vSlider8.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider8.Value = 250;
            this.vSlider8.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider9
            // 
            this.vSlider9.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider9.Location = new System.Drawing.Point(366, 19);
            this.vSlider9.Maximum = 500;
            this.vSlider9.Name = "vSlider9";
            this.vSlider9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider9.Size = new System.Drawing.Size(45, 221);
            this.vSlider9.TabIndex = 10;
            this.vSlider9.TickFrequency = 50;
            this.vSlider9.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider9.Value = 250;
            this.vSlider9.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider10
            // 
            this.vSlider10.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider10.Location = new System.Drawing.Point(408, 19);
            this.vSlider10.Maximum = 500;
            this.vSlider10.Name = "vSlider10";
            this.vSlider10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider10.Size = new System.Drawing.Size(45, 221);
            this.vSlider10.TabIndex = 11;
            this.vSlider10.TickFrequency = 50;
            this.vSlider10.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider10.Value = 250;
            this.vSlider10.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider11
            // 
            this.vSlider11.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider11.Location = new System.Drawing.Point(450, 19);
            this.vSlider11.Maximum = 500;
            this.vSlider11.Name = "vSlider11";
            this.vSlider11.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider11.Size = new System.Drawing.Size(45, 221);
            this.vSlider11.TabIndex = 12;
            this.vSlider11.TickFrequency = 50;
            this.vSlider11.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider11.Value = 250;
            this.vSlider11.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider12
            // 
            this.vSlider12.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider12.Location = new System.Drawing.Point(492, 19);
            this.vSlider12.Maximum = 500;
            this.vSlider12.Name = "vSlider12";
            this.vSlider12.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider12.Size = new System.Drawing.Size(45, 221);
            this.vSlider12.TabIndex = 13;
            this.vSlider12.TickFrequency = 50;
            this.vSlider12.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider12.Value = 250;
            this.vSlider12.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider13
            // 
            this.vSlider13.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider13.Location = new System.Drawing.Point(535, 20);
            this.vSlider13.Maximum = 500;
            this.vSlider13.Name = "vSlider13";
            this.vSlider13.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider13.Size = new System.Drawing.Size(45, 221);
            this.vSlider13.TabIndex = 14;
            this.vSlider13.TickFrequency = 50;
            this.vSlider13.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider13.Value = 250;
            this.vSlider13.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider14
            // 
            this.vSlider14.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider14.Location = new System.Drawing.Point(577, 20);
            this.vSlider14.Maximum = 500;
            this.vSlider14.Name = "vSlider14";
            this.vSlider14.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider14.Size = new System.Drawing.Size(45, 221);
            this.vSlider14.TabIndex = 15;
            this.vSlider14.TickFrequency = 50;
            this.vSlider14.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider14.Value = 250;
            this.vSlider14.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider15
            // 
            this.vSlider15.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider15.Location = new System.Drawing.Point(620, 20);
            this.vSlider15.Maximum = 500;
            this.vSlider15.Name = "vSlider15";
            this.vSlider15.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider15.Size = new System.Drawing.Size(45, 221);
            this.vSlider15.TabIndex = 16;
            this.vSlider15.TickFrequency = 50;
            this.vSlider15.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider15.Value = 250;
            this.vSlider15.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider16
            // 
            this.vSlider16.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider16.Location = new System.Drawing.Point(664, 20);
            this.vSlider16.Maximum = 500;
            this.vSlider16.Name = "vSlider16";
            this.vSlider16.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider16.Size = new System.Drawing.Size(45, 221);
            this.vSlider16.TabIndex = 17;
            this.vSlider16.TickFrequency = 50;
            this.vSlider16.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider16.Value = 250;
            this.vSlider16.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider17
            // 
            this.vSlider17.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider17.Location = new System.Drawing.Point(709, 20);
            this.vSlider17.Maximum = 500;
            this.vSlider17.Name = "vSlider17";
            this.vSlider17.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider17.Size = new System.Drawing.Size(45, 221);
            this.vSlider17.TabIndex = 18;
            this.vSlider17.TickFrequency = 50;
            this.vSlider17.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider17.Value = 250;
            this.vSlider17.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // vSlider18
            // 
            this.vSlider18.Cursor = System.Windows.Forms.Cursors.Default;
            this.vSlider18.Location = new System.Drawing.Point(755, 20);
            this.vSlider18.Maximum = 500;
            this.vSlider18.Name = "vSlider18";
            this.vSlider18.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vSlider18.Size = new System.Drawing.Size(45, 221);
            this.vSlider18.TabIndex = 19;
            this.vSlider18.TickFrequency = 50;
            this.vSlider18.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vSlider18.Value = 250;
            this.vSlider18.Scroll += new System.EventHandler(this.VSlider1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "65";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "93";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "131";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "185";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "262";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "370";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "523";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "740";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "1.0k";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "1.5k";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "2.1k";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "3.0k";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "4.2k";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(587, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "6.0k";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(630, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "8.4k";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(669, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "11.8k";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(715, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "16.7k";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(766, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "20k";
            // 
            // label_dB_Max
            // 
            this.label_dB_Max.AutoSize = true;
            this.label_dB_Max.Location = new System.Drawing.Point(4, 29);
            this.label_dB_Max.Name = "label_dB_Max";
            this.label_dB_Max.Size = new System.Drawing.Size(32, 13);
            this.label_dB_Max.TabIndex = 41;
            this.label_dB_Max.Text = "12dB";
            // 
            // label_dB_Min
            // 
            this.label_dB_Min.AutoSize = true;
            this.label_dB_Min.Location = new System.Drawing.Point(1, 213);
            this.label_dB_Min.Name = "label_dB_Min";
            this.label_dB_Min.Size = new System.Drawing.Size(35, 13);
            this.label_dB_Min.TabIndex = 42;
            this.label_dB_Min.Text = "-12dB";
            // 
            // label_dB_Zero
            // 
            this.label_dB_Zero.AutoSize = true;
            this.label_dB_Zero.Location = new System.Drawing.Point(1, 123);
            this.label_dB_Zero.Name = "label_dB_Zero";
            this.label_dB_Zero.Size = new System.Drawing.Size(26, 13);
            this.label_dB_Zero.TabIndex = 43;
            this.label_dB_Zero.Text = "0dB";
            // 
            // checkBox_RealtimeAdjust
            // 
            this.checkBox_RealtimeAdjust.AutoSize = true;
            this.checkBox_RealtimeAdjust.Location = new System.Drawing.Point(357, 279);
            this.checkBox_RealtimeAdjust.Name = "checkBox_RealtimeAdjust";
            this.checkBox_RealtimeAdjust.Size = new System.Drawing.Size(201, 17);
            this.checkBox_RealtimeAdjust.TabIndex = 44;
            this.checkBox_RealtimeAdjust.Text = "$EQUALIZER_REALTIME_ADJUST";
            this.checkBox_RealtimeAdjust.UseVisualStyleBackColor = true;
            this.checkBox_RealtimeAdjust.CheckedChanged += new System.EventHandler(this.checkBox_RealtimeAdjust_CheckedChanged);
            // 
            // singleButton_OK
            // 
            this.singleButton_OK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_OK.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_OK.BeforeTouchSize = new System.Drawing.Size(119, 30);
            this.singleButton_OK.IsBackStageButton = false;
            this.singleButton_OK.Location = new System.Drawing.Point(672, 273);
            this.singleButton_OK.Name = "singleButton_OK";
            this.singleButton_OK.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_OK.Size = new System.Drawing.Size(119, 30);
            this.singleButton_OK.TabIndex = 40;
            this.singleButton_OK.Text = "$OK";
            this.singleButton_OK.ThemeName = "Office2016Colorful";
            this.singleButton_OK.UseVisualStyle = true;
            this.singleButton_OK.Click += new System.EventHandler(this.SingleButton_OK_Click);
            // 
            // singleButton_Preset
            // 
            this.singleButton_Preset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Colorful;
            this.singleButton_Preset.BackColor = System.Drawing.SystemColors.Control;
            this.singleButton_Preset.BeforeTouchSize = new System.Drawing.Size(102, 30);
            this.singleButton_Preset.IsBackStageButton = false;
            this.singleButton_Preset.Location = new System.Drawing.Point(564, 273);
            this.singleButton_Preset.Name = "singleButton_Preset";
            this.singleButton_Preset.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.singleButton_Preset.Size = new System.Drawing.Size(102, 30);
            this.singleButton_Preset.TabIndex = 38;
            this.singleButton_Preset.Text = "$PRESET";
            this.singleButton_Preset.ThemeName = "Office2016Colorful";
            this.singleButton_Preset.UseVisualStyle = true;
            this.singleButton_Preset.Click += new System.EventHandler(this.SingleButton_Preset_Click);
            // 
            // skinManager1
            // 
            this.skinManager1.Controls = this;
            this.skinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016Colorful;
            // 
            // onOffSwitch_Equalizer
            // 
            this.onOffSwitch_Equalizer.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitch_Equalizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onOffSwitch_Equalizer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.onOffSwitch_Equalizer.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.onOffSwitch_Equalizer.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.onOffSwitch_Equalizer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.onOffSwitch_Equalizer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.onOffSwitch_Equalizer.Location = new System.Drawing.Point(7, 275);
            this.onOffSwitch_Equalizer.Name = "onOffSwitch_Equalizer";
            this.onOffSwitch_Equalizer.Size = new System.Drawing.Size(37, 23);
            this.onOffSwitch_Equalizer.SwitchColor = System.Drawing.Color.White;
            this.onOffSwitch_Equalizer.TabIndex = 45;
            this.onOffSwitch_Equalizer.Text = "metroSwitch1";
            this.onOffSwitch_Equalizer.CheckedChanged += new MetroSuite.MetroSwitch.CheckedChangedEventHandler(this.OnOffSwitch_Equalizer_CheckedChanged);
            // 
            // frmEqualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 313);
            this.Controls.Add(this.onOffSwitch_Equalizer);
            this.Controls.Add(this.checkBox_RealtimeAdjust);
            this.Controls.Add(this.label_dB_Zero);
            this.Controls.Add(this.label_dB_Min);
            this.Controls.Add(this.label_dB_Max);
            this.Controls.Add(this.singleButton_OK);
            this.Controls.Add(this.singleButton_Preset);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vSlider18);
            this.Controls.Add(this.vSlider17);
            this.Controls.Add(this.vSlider16);
            this.Controls.Add(this.vSlider15);
            this.Controls.Add(this.vSlider14);
            this.Controls.Add(this.vSlider13);
            this.Controls.Add(this.vSlider12);
            this.Controls.Add(this.vSlider11);
            this.Controls.Add(this.vSlider10);
            this.Controls.Add(this.vSlider9);
            this.Controls.Add(this.vSlider8);
            this.Controls.Add(this.vSlider7);
            this.Controls.Add(this.vSlider6);
            this.Controls.Add(this.vSlider5);
            this.Controls.Add(this.vSlider4);
            this.Controls.Add(this.vSlider3);
            this.Controls.Add(this.vSlider2);
            this.Controls.Add(this.vSlider1);
            this.Controls.Add(this.label_Equalizer_Enable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEqualizer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$EQUALIZER";
            ((System.ComponentModel.ISupportInitialize)(this.vSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSlider18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000016 RID: 22
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label_Equalizer_Enable;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.TrackBar vSlider1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.TrackBar vSlider2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.TrackBar vSlider3;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.TrackBar vSlider4;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.TrackBar vSlider5;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.TrackBar vSlider6;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.TrackBar vSlider7;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.TrackBar vSlider8;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.TrackBar vSlider9;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TrackBar vSlider10;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.TrackBar vSlider11;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.TrackBar vSlider12;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TrackBar vSlider13;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.TrackBar vSlider14;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.TrackBar vSlider15;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.TrackBar vSlider16;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TrackBar vSlider17;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.TrackBar vSlider18;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400003D RID: 61
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_Preset;

		// Token: 0x0400003E RID: 62
		private global::Syncfusion.Windows.Forms.ButtonAdv singleButton_OK;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label_dB_Max;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label_dB_Min;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label_dB_Zero;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.CheckBox checkBox_RealtimeAdjust;
        private Syncfusion.Windows.Forms.SkinManager skinManager1;
        private MetroSuite.MetroSwitch onOffSwitch_Equalizer;
    }
}
