using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x0200000C RID: 12
	public class ButtonBox : UserControl
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000077CC File Offset: 0x000059CC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000077EC File Offset: 0x000059EC
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.DoubleBuffered = true;
			base.Name = "ButtonBox";
			base.Size = new Size(131, 45);
			base.MouseUp += this.ButtonBox_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000078 RID: 120 RVA: 0x00007858 File Offset: 0x00005A58
		// (remove) Token: 0x06000079 RID: 121 RVA: 0x00007890 File Offset: 0x00005A90
		private event ButtonBox.ItemSelectDelegate ItemSelected;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600007A RID: 122 RVA: 0x000078C5 File Offset: 0x00005AC5
		// (remove) Token: 0x0600007B RID: 123 RVA: 0x000078CE File Offset: 0x00005ACE
		public event ButtonBox.ItemSelectDelegate ItemSelectedNotify
		{
			add
			{
				this.ItemSelected += value;
			}
			remove
			{
				this.ItemSelected -= value;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000078D8 File Offset: 0x00005AD8
		public ButtonBox()
		{
			this.InitializeComponent();
			this.m_nCurrentSelected = -1;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.Selectable, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.FromKnownColor(KnownColor.Control);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000796E File Offset: 0x00005B6E
		public void AddItem(ButtonBox.Item itButtonBoxItem)
		{
			if (itButtonBoxItem == null)
			{
				return;
			}
			this.m_dictMutex.WaitOne();
			this.m_dictItems.Add(this.m_dictItems.Count, itButtonBoxItem.Clone());
			this.m_dictMutex.ReleaseMutex();
			base.Invalidate();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000079B0 File Offset: 0x00005BB0
		public void AddItem(List<ButtonBox.Item> lstItem)
		{
			if (lstItem == null)
			{
				return;
			}
			this.m_dictMutex.WaitOne();
			foreach (ButtonBox.Item item in lstItem)
			{
				if (item != null)
				{
					this.m_dictItems.Add(this.m_dictItems.Count, item.Clone());
				}
			}
			this.m_dictMutex.ReleaseMutex();
			base.Invalidate();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007A38 File Offset: 0x00005C38
		public void AddItem(ButtonBox.Item[] aryItem)
		{
			if (aryItem == null)
			{
				return;
			}
			this.m_dictMutex.WaitOne();
			foreach (ButtonBox.Item item in aryItem)
			{
				if (item != null)
				{
					this.m_dictItems.Add(this.m_dictItems.Count, item.Clone());
				}
			}
			this.m_dictMutex.ReleaseMutex();
			base.Invalidate();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007A9C File Offset: 0x00005C9C
		public void ClearItem()
		{
			ButtonBox.Item itPrevItem = null;
			this.m_dictMutex.WaitOne();
			if (this.m_dictItems.ContainsKey(this.m_nCurrentSelected))
			{
				itPrevItem = this.m_dictItems[this.m_nCurrentSelected].Clone();
			}
			this.m_dictItems.Clear();
			this.m_dictMutex.ReleaseMutex();
			this.m_nCurrentSelected = -1;
			base.Invalidate();
			if (this.ItemSelected != null)
			{
				this.ItemSelected(itPrevItem, null, this);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00007B1C File Offset: 0x00005D1C
		public ButtonBox.Item GetItem(int nIndex)
		{
			ButtonBox.Item result = null;
			this.m_dictMutex.WaitOne();
			if (this.m_dictItems.ContainsKey(nIndex))
			{
				result = this.m_dictItems[nIndex].Clone();
			}
			this.m_dictMutex.ReleaseMutex();
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00007B64 File Offset: 0x00005D64
		public void SelectItem(int nIndex)
		{
			ButtonBox.Item itPrevItem = null;
			ButtonBox.Item itCurrItem = null;
			this.m_dictMutex.WaitOne();
			if (this.m_dictItems.ContainsKey(this.m_nCurrentSelected))
			{
				itPrevItem = this.m_dictItems[this.m_nCurrentSelected].Clone();
			}
			if (this.m_dictItems.ContainsKey(nIndex))
			{
				itCurrItem = this.m_dictItems[nIndex].Clone();
				this.m_nCurrentSelected = nIndex;
			}
			else
			{
				this.m_nCurrentSelected = -1;
			}
			this.m_dictMutex.ReleaseMutex();
			base.Invalidate();
			if (this.ItemSelected != null)
			{
				this.ItemSelected(itPrevItem, itCurrItem, this);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007C02 File Offset: 0x00005E02
		public void UpdateControl()
		{
			base.Invalidate();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007C0C File Offset: 0x00005E0C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this.BackColor);
			if (this.m_dictItems.Count <= 0)
			{
				graphics.DrawRectangle(new Pen(Color.Gray, 4f), base.ClientRectangle);
				return;
			}
			this.m_dictMutex.WaitOne();
			int num = base.Height / this.m_dictItems.Count;
			for (int i = 0; i < this.m_dictItems.Count; i++)
			{
				if (this.m_nCurrentSelected != i)
				{
					graphics.DrawRectangle(new Pen(Color.Gray, 2f), 0f, (float)(num * i) + 1f, (float)base.Width, (float)num);
					Font font = this.Font;
					StringFormat stringFormat = new StringFormat();
					stringFormat.Alignment = StringAlignment.Near;
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Trimming = StringTrimming.EllipsisCharacter;
					stringFormat.FormatFlags = StringFormatFlags.NoWrap;
					RectangleF layoutRectangle = default(RectangleF);
					layoutRectangle.X = 20f;
					layoutRectangle.Y = (float)(num * i) + 5f;
					layoutRectangle.Width = (float)base.Width - 25f;
					layoutRectangle.Height = (float)num - 4f;
					graphics.DrawString(this.m_dictItems[i].Title, font, Brushes.Black, layoutRectangle, stringFormat);
				}
			}
			if (this.m_dictItems.ContainsKey(this.m_nCurrentSelected))
			{
				int nCurrentSelected = this.m_nCurrentSelected;
				graphics.DrawRectangle(new Pen(Color.SteelBlue, 2f), 0f, (float)(num * nCurrentSelected) + 1f, (float)base.Width, (float)num);
				PointF pt = new PointF(6f, (float)(num * nCurrentSelected) + (float)num / 2f - 6f);
				PointF pt2 = new PointF(6f, (float)(num * nCurrentSelected) + (float)num / 2f + 6f);
				PointF pt3 = new PointF(15f, (float)(num * nCurrentSelected) + (float)num / 2f);
				graphics.DrawLine(new Pen(Color.Black, 2f), pt, pt3);
				graphics.DrawLine(new Pen(Color.Black, 2f), pt2, pt3);
				Font font2 = this.Font;
				StringFormat stringFormat2 = new StringFormat();
				stringFormat2.Alignment = StringAlignment.Near;
				stringFormat2.LineAlignment = StringAlignment.Center;
				stringFormat2.Trimming = StringTrimming.EllipsisCharacter;
				stringFormat2.FormatFlags = StringFormatFlags.NoWrap;
				RectangleF layoutRectangle2 = default(RectangleF);
				layoutRectangle2.X = 20f;
				layoutRectangle2.Y = (float)(num * nCurrentSelected) + 5f;
				layoutRectangle2.Width = (float)base.Width - 25f;
				layoutRectangle2.Height = (float)num - 4f;
				graphics.DrawString(this.m_dictItems[nCurrentSelected].Title, font2, Brushes.Black, layoutRectangle2, stringFormat2);
			}
			this.m_dictMutex.ReleaseMutex();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007EFC File Offset: 0x000060FC
		private void ButtonBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.m_dictItems.Count <= 0)
			{
				return;
			}
			ButtonBox.Item itPrevItem = null;
			this.m_dictMutex.WaitOne();
			float num = (float)base.Height / (float)this.m_dictItems.Count;
			if (this.m_dictItems.ContainsKey(this.m_nCurrentSelected))
			{
				itPrevItem = this.m_dictItems[this.m_nCurrentSelected].Clone();
			}
			this.m_dictMutex.ReleaseMutex();
			int num2 = (int)Math.Truncate((double)((float)e.Y / num));
			if (num2 < 0)
			{
				return;
			}
			if (num2 >= this.m_dictItems.Count)
			{
				return;
			}
			this.m_dictMutex.WaitOne();
			if (this.m_dictItems.ContainsKey(num2))
			{
				ButtonBox.Item itCurrItem = this.m_dictItems[num2].Clone();
				this.m_nCurrentSelected = num2;
				base.Invalidate();
				this.m_dictMutex.ReleaseMutex();
				if (this.ItemSelected != null)
				{
					this.ItemSelected(itPrevItem, itCurrItem, this);
				}
				return;
			}
			this.m_dictMutex.ReleaseMutex();
		}

		// Token: 0x0400007D RID: 125
		private IContainer components;

		// Token: 0x0400007E RID: 126
		private Dictionary<int, ButtonBox.Item> m_dictItems = new Dictionary<int, ButtonBox.Item>();

		// Token: 0x0400007F RID: 127
		private Mutex m_dictMutex = new Mutex();

		// Token: 0x04000080 RID: 128
		private int m_nCurrentSelected = -1;

		// Token: 0x0200000D RID: 13
		public class Item
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00008005 File Offset: 0x00006205
			// (set) Token: 0x06000087 RID: 135 RVA: 0x0000800D File Offset: 0x0000620D
			public object Tag
			{
				get
				{
					return this.m_objUserData;
				}
				set
				{
					this.m_objUserData = value;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00008016 File Offset: 0x00006216
			// (set) Token: 0x06000089 RID: 137 RVA: 0x0000801E File Offset: 0x0000621E
			public string Title
			{
				get
				{
					return this.m_szTitle;
				}
				set
				{
					this.m_szTitle = value;
				}
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00008027 File Offset: 0x00006227
			public Item()
			{
			}

			// Token: 0x0600008B RID: 139 RVA: 0x0000803A File Offset: 0x0000623A
			public Item(string szText)
			{
				this.m_szTitle = szText;
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00008054 File Offset: 0x00006254
			public Item(string szText, object objTag)
			{
				this.m_szTitle = szText;
				this.m_objUserData = objTag;
			}

			// Token: 0x0600008D RID: 141 RVA: 0x00008075 File Offset: 0x00006275
			public bool IsEqual(ButtonBox.Item itItem)
			{
				return itItem.Tag == this.m_objUserData && itItem.Title == this.m_szTitle;
			}

			// Token: 0x0600008E RID: 142 RVA: 0x0000809C File Offset: 0x0000629C
			public ButtonBox.Item Clone()
			{
				return new ButtonBox.Item(this.m_szTitle, this.m_objUserData);
			}

			// Token: 0x04000082 RID: 130
			private object m_objUserData;

			// Token: 0x04000083 RID: 131
			private string m_szTitle = "";
		}

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000090 RID: 144
		public delegate void ItemSelectDelegate(ButtonBox.Item itPrevItem, ButtonBox.Item itCurrItem, ButtonBox objSender);
	}
}
