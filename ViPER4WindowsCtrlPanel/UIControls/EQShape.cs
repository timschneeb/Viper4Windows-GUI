using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x02000023 RID: 35
	public class EQShape : UserControl
	{
		// Token: 0x060001DD RID: 477 RVA: 0x0001B687 File Offset: 0x00019887
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001B6A8 File Offset: 0x000198A8
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.DoubleBuffered = true;
			base.Name = "EQShapre";
			base.Size = new Size(274, 129);
			base.ResumeLayout(false);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0001B708 File Offset: 0x00019908
		public EQShape()
		{
			this.InitializeComponent();
			for (int i = 0; i < this.m_fEQBands.Length; i++)
			{
				this.m_fEQBands[i] = 1f;
			}
			this.ZeroArray();
			float[] array = RuntimeUtils.EqualizerUtils.EstimateEqualizerResponse(this.m_fEQBands);
			if (array != null)
			{
				this.ScaleArray(array);
			}
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0001B7C5 File Offset: 0x000199C5
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0001B7CD File Offset: 0x000199CD
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001B7DC File Offset: 0x000199DC
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0001B7E4 File Offset: 0x000199E4
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

		// Token: 0x060001E4 RID: 484 RVA: 0x0001B7F4 File Offset: 0x000199F4
		public void SetEqualizerBands(float[] rEQBands)
		{
			if (rEQBands == null)
			{
				return;
			}
			if (rEQBands.Length != 18)
			{
				return;
			}
			Array.Copy(rEQBands, this.m_fEQBands, this.m_fEQBands.Length);
			this.ZeroArray();
			float[] array = RuntimeUtils.EqualizerUtils.EstimateEqualizerResponse(this.m_fEQBands);
			if (array != null)
			{
				this.ScaleArray(array);
			}
			base.Invalidate();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001B844 File Offset: 0x00019A44
		private void ZeroArray()
		{
			for (int i = 0; i < this.m_fEQResponse.Length; i++)
			{
				this.m_fEQResponse[i] = 0f;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001B874 File Offset: 0x00019A74
		private void ScaleArray(float[] fArray)
		{
			int num = fArray.Length / (this.m_fEQResponse.Length + 1);
			int i = 0;
			int num2 = 0;
			while (i < fArray.Length)
			{
				if (num2 >= this.m_fEQResponse.Length)
				{
					return;
				}
				this.m_fEQResponse[num2] = fArray[i];
				i += num;
				num2++;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001B8BC File Offset: 0x00019ABC
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.m_clBackColor);
			graphics.DrawRectangle(new Pen(Color.Gray, 1f), base.ClientRectangle);
			double num = ((double)base.Width - 2.0) / (double)(this.m_fEQResponse.Length + 1);
			float num2 = this.m_fEQResponse[0] * (float)(base.Height - 2) + 1f;
			if (num2 < 2f)
			{
				num2 = 2f;
			}
			if (num2 > (float)base.Height - 2f)
			{
				num2 = (float)base.Height - 2f;
			}
			num2 = (float)base.Height - num2;
			PointF pt = new PointF(2f, num2);
			for (int i = 1; i < this.m_fEQResponse.Length; i++)
			{
				float num3 = (float)((double)i * num) + 2f;
				if (num3 > (float)base.Width - 1f)
				{
					return;
				}
				float num4 = this.m_fEQResponse[i] * (float)(base.Height - 2) + 1f;
				if (num4 < 2f)
				{
					num4 = 2f;
				}
				if (num4 > (float)base.Height - 2f)
				{
					num4 = (float)base.Height - 2f;
				}
				num4 = (float)base.Height - num4;
				graphics.DrawLine(new Pen(this.m_clForeColor, 1f), pt, new PointF(num3, num4));
				pt.X = num3;
				pt.Y = num4;
			}
		}

		// Token: 0x040001C5 RID: 453
		private IContainer components;

		// Token: 0x040001C6 RID: 454
		private Color m_clBackColor = Color.White;

		// Token: 0x040001C7 RID: 455
		private Color m_clForeColor = Color.Black;

		// Token: 0x040001C8 RID: 456
		private float[] m_fEQBands = new float[18];

		// Token: 0x040001C9 RID: 457
		private float[] m_fEQResponse = new float[256];
	}
}
