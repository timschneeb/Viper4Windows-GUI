using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x02000021 RID: 33
	public class VSlider : UserControl
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001CA RID: 458 RVA: 0x0001B194 File Offset: 0x00019394
		// (remove) Token: 0x060001CB RID: 459 RVA: 0x0001B1CC File Offset: 0x000193CC
		private event VSlider.PositionChangeEventDelegate PositionChanged;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060001CC RID: 460 RVA: 0x0001B201 File Offset: 0x00019401
		// (remove) Token: 0x060001CD RID: 461 RVA: 0x0001B20A File Offset: 0x0001940A
		public event VSlider.PositionChangeEventDelegate PositionChangeNotify
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

		// Token: 0x060001CE RID: 462 RVA: 0x0001B214 File Offset: 0x00019414
		public VSlider()
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

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0001B29B File Offset: 0x0001949B
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0001B2A8 File Offset: 0x000194A8
		public uint Position
		{
			get
			{
				return 100u - this.m_nPosition;
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
				this.m_nPosition = 100u - value;
				if (this.PositionChanged != null)
				{
					this.PositionChanged(this.Position / 100f, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001B2F7 File Offset: 0x000194F7
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0001B2FF File Offset: 0x000194FF
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

		// Token: 0x060001D3 RID: 467 RVA: 0x0001B308 File Offset: 0x00019508
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.BackColor);
			graphics.DrawLine(new Pen(Color.Gray, 2f), (float)base.Width / 2f, (float)base.Width / 2f, (float)base.Width / 2f, (float)base.Height - (float)base.Width / 2f);
			float num = this.m_nPosition / 100f * (float)(base.Height - base.Width) + (float)base.Width / 2f;
			graphics.FillEllipse(Brushes.SteelBlue, (float)base.Width / 4f, num - (float)base.Width / 4f, (float)base.Width / 2f, (float)base.Width / 2f);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001B3F8 File Offset: 0x000195F8
		private void VSlider_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.m_bMouseDown = true;
				float num = (float)e.Y;
				if (num < (float)base.Width / 2f)
				{
					num = (float)base.Width / 2f;
				}
				if (num > (float)base.Height - (float)base.Width / 2f)
				{
					num = (float)base.Height - (float)base.Width / 2f;
				}
				float num2 = (num - (float)base.Width / 2f) / (float)(base.Height - base.Width);
				this.m_nPosition = (uint)Math.Round((double)(num2 * 100f));
				if (this.PositionChanged != null)
				{
					this.PositionChanged(this.Position / 100f, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001B4CC File Offset: 0x000196CC
		private void VSlider_MouseUp(object sender, MouseEventArgs e)
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

		// Token: 0x060001D6 RID: 470 RVA: 0x0001B504 File Offset: 0x00019704
		private void VSlider_MouseMove(object sender, MouseEventArgs e)
		{
			if (!this.m_bMouseDown)
			{
				return;
			}
			float num = (float)e.Y;
			if (num < (float)base.Width / 2f)
			{
				num = (float)base.Width / 2f;
			}
			if (num > (float)base.Height - (float)base.Width / 2f)
			{
				num = (float)base.Height - (float)base.Width / 2f;
			}
			float num2 = (num - (float)base.Width / 2f) / (float)(base.Height - base.Width);
			this.m_nPosition = (uint)Math.Round((double)(num2 * 100f));
			if (this.PositionChanged != null)
			{
				this.PositionChanged(this.Position / 100f, this);
			}
			base.Invalidate();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001B5CA File Offset: 0x000197CA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001B5EC File Offset: 0x000197EC
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			this.DoubleBuffered = true;
			base.Name = "VSlider";
			base.Size = new Size(47, 204);
			base.MouseDown += this.VSlider_MouseDown;
			base.MouseMove += this.VSlider_MouseMove;
			base.MouseUp += this.VSlider_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x040001BE RID: 446
		private const uint m_nRangeMin = 0u;

		// Token: 0x040001BF RID: 447
		private const uint m_nRangeMax = 100u;

		// Token: 0x040001C0 RID: 448
		private bool m_bMouseDown;

		// Token: 0x040001C1 RID: 449
		private uint m_nPosition;

		// Token: 0x040001C2 RID: 450
		private uint m_nMoveDelta = 1u;

		// Token: 0x040001C4 RID: 452
		private IContainer components;

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060001DA RID: 474
		public delegate void PositionChangeEventDelegate(float fPercent, VSlider objSender);
	}
}
