using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x02000025 RID: 37
	public class IRShape : UserControl
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x0001BA4D File Offset: 0x00019C4D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001BA6C File Offset: 0x00019C6C
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.DoubleBuffered = true;
			base.Name = "IRShape";
			base.Size = new Size(190, 63);
			base.ResumeLayout(false);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		public IRShape()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0001BB3C File Offset: 0x00019D3C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0001BB44 File Offset: 0x00019D44
		public Color ShapeBackColor
		{
			get
			{
				return this.m_clBackColor;
			}
			set
			{
				this.m_clBackColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0001BB53 File Offset: 0x00019D53
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0001BB5B File Offset: 0x00019D5B
		public Color ShapeForeColor
		{
			get
			{
				return this.m_clForeColor;
			}
			set
			{
				this.m_clForeColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001BB6C File Offset: 0x00019D6C
		public void SetImpulseResponse(float[] fIRSamples, int nChannels)
		{
			this.ZeroArray();
			if (fIRSamples == null || nChannels <= 0)
			{
				base.Invalidate();
				return;
			}
			int num = fIRSamples.Length / nChannels;
			if (num <= 0)
			{
				base.Invalidate();
				return;
			}
			float[] array = new float[num];
			int i = 0;
			int num2 = 0;
			while (i < num * nChannels)
			{
				double num3 = 0.0;
				for (int j = 0; j < nChannels; j++)
				{
					num3 += (double)fIRSamples[i + j];
				}
				num3 /= (double)nChannels;
				array[num2] = (float)num3;
				i += nChannels;
				num2++;
			}
			this.ScaleArray(array);
			base.Invalidate();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001BBFC File Offset: 0x00019DFC
		private void ZeroArray()
		{
			for (int i = 0; i < this.m_fIRSamples.Length; i++)
			{
				this.m_fIRSamples[i] = 0f;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0001BC2C File Offset: 0x00019E2C
		private void ScaleArray(float[] fArray)
		{
			int num = fArray.Length / (this.m_fIRSamples.Length + 1);
			float num2 = 0f;
			int num3 = 0;
			int num4 = 0;
			while (num3 < fArray.Length && num4 < this.m_fIRSamples.Length)
			{
				this.m_fIRSamples[num4] = fArray[num3];
				if (Math.Abs(this.m_fIRSamples[num4]) > num2)
				{
					num2 = Math.Abs(this.m_fIRSamples[num4]);
				}
				num3 += num;
				num4++;
			}
			if (num2 <= 1E-06f)
			{
				return;
			}
			float num5 = 1f / (num2 + 1E-06f);
			for (int i = 0; i < this.m_fIRSamples.Length; i++)
			{
				this.m_fIRSamples[i] *= num5;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.m_clBackColor);
			graphics.DrawRectangle(new Pen(Color.Gray, 1f), base.ClientRectangle);
			double num = ((double)base.Width - 2.0) / (double)(this.m_fIRSamples.Length + 1);
			PointF pt = new PointF(2f, (float)base.Height / 2f);
			for (int i = 0; i < this.m_fIRSamples.Length; i++)
			{
				float num2 = (float)((double)i * num) + 2f;
				if (num2 > (float)base.Width - 1f)
				{
					return;
				}
				float num3 = (float)base.Height / 2f + this.m_fIRSamples[i] * ((float)(base.Height - 2) / 2f);
				if (num3 < 2f)
				{
					num3 = 2f;
				}
				if (num3 > (float)base.Height - 2f)
				{
					num3 = (float)base.Height - 2f;
				}
				num3 = (float)base.Height - num3;
				graphics.DrawLine(new Pen(this.m_clForeColor, 1f), pt, new PointF(num2, num3));
				pt.X = num2;
				pt.Y = num3;
			}
		}

		// Token: 0x040001CD RID: 461
		private IContainer components;

		// Token: 0x040001CE RID: 462
		private Color m_clBackColor = Color.White;

		// Token: 0x040001CF RID: 463
		private Color m_clForeColor = Color.Black;

		// Token: 0x040001D0 RID: 464
		private float[] m_fIRSamples = new float[256];
	}
}
