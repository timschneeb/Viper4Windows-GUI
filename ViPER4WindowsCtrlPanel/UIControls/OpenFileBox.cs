using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x02000003 RID: 3
	public class OpenFileBox : UserControl
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000023F4 File Offset: 0x000005F4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002414 File Offset: 0x00000614
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.DoubleBuffered = true;
			base.Name = "OpenFileBox";
			base.Size = new Size(147, 36);
			base.Click += this.OpenFileBox_Click;
			base.ResumeLayout(false);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000006 RID: 6 RVA: 0x00002480 File Offset: 0x00000680
		// (remove) Token: 0x06000007 RID: 7 RVA: 0x000024B8 File Offset: 0x000006B8
		private event OpenFileBox.FileChangeEventDelegate FileChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000008 RID: 8 RVA: 0x000024ED File Offset: 0x000006ED
		// (remove) Token: 0x06000009 RID: 9 RVA: 0x000024F6 File Offset: 0x000006F6
		public event OpenFileBox.FileChangeEventDelegate FileChangeNotify
		{
			add
			{
				this.FileChanged += value;
			}
			remove
			{
				this.FileChanged -= value;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002500 File Offset: 0x00000700
		public OpenFileBox()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.FromKnownColor(KnownColor.Control);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002584 File Offset: 0x00000784
		public string FilePathName
		{
			get
			{
				return this.m_szFilePathName;
			}
			set
			{
				this.m_szFilePathName = value;
				if (this.FileChanged != null)
				{
					this.FileChanged(this.m_szFilePathName, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000002 RID: 2
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000025AD File Offset: 0x000007AD
		public string DialogTitle
		{
			set
			{
				this.m_ofdDialog.Title = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000025BB File Offset: 0x000007BB
		public string OpenDirectory
		{
			set
			{
				this.m_ofdDialog.InitialDirectory = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000025C9 File Offset: 0x000007C9
		public string FileFilter
		{
			set
			{
				this.m_ofdDialog.Filter = value;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000025D8 File Offset: 0x000007D8
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this.BackColor);
			graphics.DrawRectangle(new Pen(Color.Gray, 1f), 0f, 0f, (float)base.Width, (float)base.Height);
			graphics.FillRectangle(Brushes.SteelBlue, (float)base.Width - 27f, 2f, 25f, (float)base.Height - 4f);
			float num = (float)base.Width - 14.5f;
			float num2 = (float)base.Height / 2f;
			PointF pointF = new PointF(num - 4f, num2 - 4f);
			PointF pointF2 = new PointF(num + 4f, num2 - 4f);
			PointF pointF3 = new PointF(num, num2 + 4f);
			graphics.FillPolygon(Brushes.Black, new PointF[]
			{
				pointF,
				pointF2,
				pointF3
			});
			string s;
			if (this.m_szFilePathName.Length <= 0)
			{
				s = "";
			}
			else
			{
				int num3 = this.m_szFilePathName.LastIndexOf("\\");
				if (num3 > 0)
				{
					string text = this.m_szFilePathName.Substring(num3 + 1, this.m_szFilePathName.Length - num3 - 1);
					if (text.Length > 0)
					{
						s = text;
					}
					else
					{
						s = "";
					}
				}
				else
				{
					s = "";
				}
			}
			Font font = this.Font;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			RectangleF layoutRectangle = default(RectangleF);
			layoutRectangle.X = 2f;
			layoutRectangle.Y = 2f;
			layoutRectangle.Width = (float)base.Width - 35f;
			layoutRectangle.Height = (float)base.Height - 4f;
			graphics.DrawString(s, font, Brushes.Black, layoutRectangle, stringFormat);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002804 File Offset: 0x00000A04
		private void OpenFileBox_Click(object sender, EventArgs e)
		{
			if (this.m_ofdDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			this.m_szFilePathName = this.m_ofdDialog.FileName;
			if (this.FileChanged != null)
			{
				this.FileChanged(this.m_szFilePathName, this);
			}
			base.Invalidate();
		}

		// Token: 0x04000002 RID: 2
		private IContainer components;

		// Token: 0x04000003 RID: 3
		private OpenFileDialog m_ofdDialog = new OpenFileDialog();

		// Token: 0x04000004 RID: 4
		private string m_szFilePathName = "";

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000013 RID: 19
		public delegate void FileChangeEventDelegate(string szFilePathName, OpenFileBox objSender);
	}
}
