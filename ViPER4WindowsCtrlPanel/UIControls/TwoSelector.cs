using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x02000011 RID: 17
	public class TwoSelector : UserControl
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600009E RID: 158 RVA: 0x00008B84 File Offset: 0x00006D84
		// (remove) Token: 0x0600009F RID: 159 RVA: 0x00008BBC File Offset: 0x00006DBC
		private event TwoSelector.SelectorChangeEventDelegate SelectorChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000A0 RID: 160 RVA: 0x00008BF1 File Offset: 0x00006DF1
		// (remove) Token: 0x060000A1 RID: 161 RVA: 0x00008BFA File Offset: 0x00006DFA
		public event TwoSelector.SelectorChangeEventDelegate SelectorChangeNotify
		{
			add
			{
				this.SelectorChanged += value;
			}
			remove
			{
				this.SelectorChanged -= value;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008C04 File Offset: 0x00006E04
		public TwoSelector()
		{
			this.InitializeComponent();
			this.m_objLeftObj = null;
			this.m_objRightObj = null;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.Selectable, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.Transparent;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00008C83 File Offset: 0x00006E83
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00008C8B File Offset: 0x00006E8B
		public object LeftObject
		{
			get
			{
				return this.m_objLeftObj;
			}
			set
			{
				this.m_objLeftObj = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00008C94 File Offset: 0x00006E94
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00008C9C File Offset: 0x00006E9C
		public object RightObject
		{
			get
			{
				return this.m_objRightObj;
			}
			set
			{
				this.m_objRightObj = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00008CA5 File Offset: 0x00006EA5
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00008CBC File Offset: 0x00006EBC
		public object CurrentObject
		{
			get
			{
				if (this.m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
				{
					return this.m_objLeftObj;
				}
				return this.m_objRightObj;
			}
			set
			{
				if (this.m_objLeftObj == this.m_objRightObj)
				{
					return;
				}
				if (value == this.m_objLeftObj)
				{
					this.m_spCurrentPosition = TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
					if (this.SelectorChanged != null)
					{
						this.SelectorChanged(this.m_spCurrentPosition, this.m_objLeftObj, this);
					}
					base.Invalidate();
					return;
				}
				if (value == this.m_objRightObj)
				{
					this.m_spCurrentPosition = TwoSelector.SelectorPosition.SELECTOR_ON_RIGHT;
					if (this.SelectorChanged != null)
					{
						this.SelectorChanged(this.m_spCurrentPosition, this.m_objRightObj, this);
					}
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00008D45 File Offset: 0x00006F45
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00008D50 File Offset: 0x00006F50
		public TwoSelector.SelectorPosition Selector
		{
			get
			{
				return this.m_spCurrentPosition;
			}
			set
			{
				this.m_spCurrentPosition = value;
				if (this.SelectorChanged != null)
				{
					if (this.m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
					{
						this.SelectorChanged(this.m_spCurrentPosition, this.m_objLeftObj, this);
					}
					else
					{
						this.SelectorChanged(this.m_spCurrentPosition, this.m_objRightObj, this);
					}
				}
				base.Invalidate();
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008DAC File Offset: 0x00006FAC
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(Color.White);
			graphics.DrawRectangle(new Pen(Color.Gray, 1f), 0, 0, base.Width, base.Height);
			if (this.m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
			{
				RectangleF rect = default(RectangleF);
				rect.X = 2f;
				rect.Y = 2f;
				rect.Width = (float)base.ClientRectangle.Height - 4f;
				rect.Height = (float)base.ClientRectangle.Height - 4f;
				graphics.FillEllipse(Brushes.SteelBlue, rect);
				return;
			}
			RectangleF rect2 = default(RectangleF);
			rect2.X = (float)base.ClientRectangle.Width - 2f - ((float)base.ClientRectangle.Height - 4f);
			rect2.Y = 2f;
			rect2.Width = (float)base.ClientRectangle.Height - 4f;
			rect2.Height = (float)base.ClientRectangle.Height - 4f;
			graphics.FillEllipse(Brushes.SteelBlue, rect2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00008EF8 File Offset: 0x000070F8
		private void TwoSelector_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
			{
				return;
			}
			if (this.m_spCurrentPosition == TwoSelector.SelectorPosition.SELECTOR_ON_LEFT)
			{
				this.Selector = TwoSelector.SelectorPosition.SELECTOR_ON_RIGHT;
				return;
			}
			this.Selector = TwoSelector.SelectorPosition.SELECTOR_ON_LEFT;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00008F1F File Offset: 0x0000711F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008F40 File Offset: 0x00007140
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			base.Name = "TwoSelector";
			base.Size = new Size(107, 28);
			base.MouseUp += this.TwoSelector_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x04000094 RID: 148
		private object m_objLeftObj;

		// Token: 0x04000095 RID: 149
		private object m_objRightObj;

		// Token: 0x04000096 RID: 150
		private TwoSelector.SelectorPosition m_spCurrentPosition;

		// Token: 0x04000098 RID: 152
		private IContainer components;

		// Token: 0x02000012 RID: 18
		public enum SelectorPosition
		{
			// Token: 0x0400009A RID: 154
			SELECTOR_ON_LEFT,
			// Token: 0x0400009B RID: 155
			SELECTOR_ON_RIGHT
		}

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000B0 RID: 176
		public delegate void SelectorChangeEventDelegate(TwoSelector.SelectorPosition spCurrentPosition, object objSelected, TwoSelector objSender);
	}
}
