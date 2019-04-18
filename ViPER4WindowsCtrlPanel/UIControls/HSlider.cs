using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x0200001D RID: 29
	public class HSlider : UserControl
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000181 RID: 385 RVA: 0x00018DA0 File Offset: 0x00016FA0
		// (remove) Token: 0x06000182 RID: 386 RVA: 0x00018DD8 File Offset: 0x00016FD8
		private event HSlider.PositionChangeEventDelegate PositionChanged;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000183 RID: 387 RVA: 0x00018E0D File Offset: 0x0001700D
		// (remove) Token: 0x06000184 RID: 388 RVA: 0x00018E16 File Offset: 0x00017016
		public event HSlider.PositionChangeEventDelegate PositionChangeNotify
		{
			add
			{
				this.PositionChanged += value;
			}
			remove
			{
				this.PositionChanged -= value;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00018E20 File Offset: 0x00017020
		public HSlider()
		{
			this.InitializeComponent();
			this.m_nPosition = 0u;
			this.m_nMoveDelta = 1u;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.Selectable, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.FromKnownColor(KnownColor.Control);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00018EA7 File Offset: 0x000170A7
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00018EB0 File Offset: 0x000170B0
		public uint Position
		{
			get
			{
				return this.m_nPosition;
			}
			set
			{
				if (value < 0u)
				{
					value = 0u;
				}
				if (value > 100u)
				{
					value = 100u;
				}
				this.m_nPosition = value;
				if (this.PositionChanged != null)
				{
					this.PositionChanged(this.Position / 100f, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00018EFC File Offset: 0x000170FC
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00018F0C File Offset: 0x0001710C
		public float PositionFloat
		{
			get
			{
				return this.m_nPosition / 100f;
			}
			set
			{
				uint num = (uint)(value * 100f);
				if (num < 0u)
				{
					num = 0u;
				}
				if (num > 100u)
				{
					num = 100u;
				}
				this.m_nPosition = num;
				if (this.PositionChanged != null)
				{
					this.PositionChanged(this.Position / 100f, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00018F5F File Offset: 0x0001715F
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00018F67 File Offset: 0x00017167
		public uint MoveDelta
		{
			get
			{
				return this.m_nMoveDelta;
			}
			set
			{
				this.m_nMoveDelta = value;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00018F70 File Offset: 0x00017170
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.BackColor);
			graphics.DrawLine(new Pen(Color.Gray, 2f), (float)base.Height / 2f, (float)base.Height / 2f, (float)base.Width - (float)base.Height / 2f, (float)base.Height / 2f);
			float num = this.m_nPosition / 100f * (float)(base.Width - base.Height) + (float)base.Height / 2f;
			graphics.FillEllipse(Brushes.SteelBlue, num - (float)base.Height / 4f, (float)base.Height / 4f, (float)base.Height / 2f, (float)base.Height / 2f);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00019060 File Offset: 0x00017260
		private void HSlider_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.m_bMouseDown = true;
				float num = (float)e.X;
				if (num < (float)base.Height / 2f)
				{
					num = (float)base.Height / 2f;
				}
				if (num > (float)base.Width - (float)base.Height / 2f)
				{
					num = (float)base.Width - (float)base.Height / 2f;
				}
				float num2 = (num - (float)base.Height / 2f) / (float)(base.Width - base.Height);
				this.m_nPosition = (uint)Math.Round((double)(num2 * 100f));
				if (this.PositionChanged != null)
				{
					this.PositionChanged(this.Position / 100f, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00019134 File Offset: 0x00017334
		private void HSlider_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.PositionChanged != null)
				{
					this.PositionChanged(this.Position / 100f, this);
				}
				this.m_bMouseDown = false;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001916C File Offset: 0x0001736C
		private void HSlider_MouseMove(object sender, MouseEventArgs e)
		{
			if (!this.m_bMouseDown)
			{
				return;
			}
			float num = (float)e.X;
			if (num < (float)base.Height / 2f)
			{
				num = (float)base.Height / 2f;
			}
			if (num > (float)base.Width - (float)base.Height / 2f)
			{
				num = (float)base.Width - (float)base.Height / 2f;
			}
			float num2 = (num - (float)base.Height / 2f) / (float)(base.Width - base.Height);
			this.m_nPosition = (uint)Math.Round((double)(num2 * 100f));
			if (this.PositionChanged != null)
			{
				this.PositionChanged(this.Position / 100f, this);
			}
			base.Invalidate();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00019232 File Offset: 0x00017432
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00019254 File Offset: 0x00017454
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.DoubleBuffered = true;
			base.Name = "HSlider";
			base.Size = new Size(204, 47);
			base.MouseDown += this.HSlider_MouseDown;
			base.MouseMove += this.HSlider_MouseMove;
			base.MouseUp += this.HSlider_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x0400019A RID: 410
		private const uint m_nRangeMin = 0u;

		// Token: 0x0400019B RID: 411
		private const uint m_nRangeMax = 100u;

		// Token: 0x0400019C RID: 412
		private bool m_bMouseDown;

		// Token: 0x0400019D RID: 413
		private uint m_nPosition;

		// Token: 0x0400019E RID: 414
		private uint m_nMoveDelta = 1u;

		// Token: 0x040001A0 RID: 416
		private IContainer components;

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000193 RID: 403
		public delegate void PositionChangeEventDelegate(float fPercent, HSlider objSender);
	}
}
