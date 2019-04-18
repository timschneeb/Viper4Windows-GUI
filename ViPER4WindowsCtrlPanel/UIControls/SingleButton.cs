using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x0200001B RID: 27
	public class SingleButton : UserControl
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00018A66 File Offset: 0x00016C66
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00018A88 File Offset: 0x00016C88
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.DoubleBuffered = true;
			base.Name = "SingleButton";
			base.Size = new Size(112, 40);
			base.KeyUp += this.SingleButton_KeyUp;
			base.MouseDown += this.SingleButton_MouseDown;
			base.MouseUp += this.SingleButton_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000172 RID: 370 RVA: 0x00018B18 File Offset: 0x00016D18
		// (remove) Token: 0x06000173 RID: 371 RVA: 0x00018B50 File Offset: 0x00016D50
		private event SingleButton.ButtonClickEventDelegate ButtonClick;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000174 RID: 372 RVA: 0x00018B85 File Offset: 0x00016D85
		// (remove) Token: 0x06000175 RID: 373 RVA: 0x00018B8E File Offset: 0x00016D8E
		public event SingleButton.ButtonClickEventDelegate ButtonClickNotify
		{
			add
			{
				this.ButtonClick += value;
			}
			remove
			{
				this.ButtonClick -= value;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00018B98 File Offset: 0x00016D98
		public SingleButton()
		{
			this.InitializeComponent();
			this.m_bMouseDown = false;
			this.m_szButtonText = "";
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.Selectable, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.FromKnownColor(KnownColor.Control);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00018C27 File Offset: 0x00016E27
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00018C2F File Offset: 0x00016E2F
		public string ButtonText
		{
			get
			{
				return this.m_szButtonText;
			}
			set
			{
				this.m_szButtonText = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00018C40 File Offset: 0x00016E40
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this.BackColor);
			graphics.DrawRectangle(new Pen(Color.Gray, 2f), base.ClientRectangle);
			Brush brush = Brushes.Black;
			if (this.m_bMouseDown)
			{
				brush = Brushes.SteelBlue;
			}
			Font font = this.Font;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			stringFormat.FormatFlags = StringFormatFlags.NoWrap;
			RectangleF layoutRectangle = default(RectangleF);
			layoutRectangle.X = 3f;
			layoutRectangle.Y = 5f;
			layoutRectangle.Width = (float)base.Width - 6f;
			layoutRectangle.Height = (float)base.Height - 6f;
			graphics.DrawString(this.m_szButtonText, font, brush, layoutRectangle, stringFormat);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00018D2A File Offset: 0x00016F2A
		private void SingleButton_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.m_bMouseDown = true;
				base.Invalidate();
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00018D46 File Offset: 0x00016F46
		private void SingleButton_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.m_bMouseDown = false;
				base.Invalidate();
				if (this.ButtonClick != null)
				{
					this.ButtonClick(this);
				}
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00018D76 File Offset: 0x00016F76
		private void SingleButton_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Return || e.KeyCode == Keys.Space) && this.ButtonClick != null)
			{
				this.ButtonClick(this);
			}
		}

		// Token: 0x04000196 RID: 406
		private IContainer components;

		// Token: 0x04000197 RID: 407
		private bool m_bMouseDown;

		// Token: 0x04000198 RID: 408
		private string m_szButtonText = "";

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x0600017E RID: 382
		public delegate void ButtonClickEventDelegate(SingleButton objSender);
	}
}
