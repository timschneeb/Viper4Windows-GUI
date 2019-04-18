using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ViPER4WindowsBin.UIControls
{
	// Token: 0x02000005 RID: 5
	public class OnOffSwitch : UserControl
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002851 File Offset: 0x00000A51
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002870 File Offset: 0x00000A70
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			base.Name = "OnOffSwitch";
			base.Size = new Size(107, 28);
			base.KeyUp += this.OnOffSwitch_KeyUp;
			base.MouseUp += this.OnOffSwitch_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000018 RID: 24 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (remove) Token: 0x06000019 RID: 25 RVA: 0x00002930 File Offset: 0x00000B30
		private event OnOffSwitch.SwitchChangeEventDelegate SwitchChanged;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600001A RID: 26 RVA: 0x00002965 File Offset: 0x00000B65
		// (remove) Token: 0x0600001B RID: 27 RVA: 0x0000296E File Offset: 0x00000B6E
		public event OnOffSwitch.SwitchChangeEventDelegate SwitchChangeNotify
		{
			add
			{
				this.SwitchChanged += value;
			}
			remove
			{
				this.SwitchChanged -= value;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002978 File Offset: 0x00000B78
		public OnOffSwitch()
		{
			this.InitializeComponent();
			this.m_bSwitchStatus = false;
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.StandardClick, true);
			base.SetStyle(ControlStyles.Selectable, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.Transparent;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000029F0 File Offset: 0x00000BF0
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000029F8 File Offset: 0x00000BF8
		public bool SwitchedOn
		{
			get
			{
				return this.m_bSwitchStatus;
			}
			set
			{
				this.m_bSwitchStatus = value;
				if (this.SwitchChanged != null)
				{
					this.SwitchChanged(this.m_bSwitchStatus, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002A24 File Offset: 0x00000C24
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(Color.White);
			graphics.DrawRectangle(new Pen(Color.Gray, 1f), 0, 0, base.Width, base.Height);
			if (this.m_bSwitchStatus)
			{
				graphics.FillRectangle(Brushes.SteelBlue, (float)base.Width / 2f + 6f, 2f, (float)base.Width / 2f - 8f, (float)base.Height - 4f);
				return;
			}
			graphics.FillRectangle(Brushes.Gray, 2f, 2f, (float)base.Width / 2f - 8f, (float)base.Height - 4f);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002AF8 File Offset: 0x00000CF8
		private void OnOffSwitch_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Return)
			{
				this.m_bSwitchStatus = !this.m_bSwitchStatus;
				if (this.SwitchChanged != null)
				{
					this.SwitchChanged(this.m_bSwitchStatus, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002B48 File Offset: 0x00000D48
		private void OnOffSwitch_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.m_bSwitchStatus = !this.m_bSwitchStatus;
				if (this.SwitchChanged != null)
				{
					this.SwitchChanged(this.m_bSwitchStatus, this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x04000006 RID: 6
		private IContainer components;

		// Token: 0x04000007 RID: 7
		private bool m_bSwitchStatus;

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000023 RID: 35
		public delegate void SwitchChangeEventDelegate(bool bSwitchedOn, OnOffSwitch objSender);
	}
}
