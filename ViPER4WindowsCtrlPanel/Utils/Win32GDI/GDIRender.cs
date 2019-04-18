using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ViPER4WindowsBin.Utils.Win32GDI
{
	// Token: 0x02000037 RID: 55
	internal class GDIRender
	{
		// Token: 0x06000261 RID: 609
		[DllImport("gdi32.dll")]
		private static extern IntPtr CreateCompatibleDC(IntPtr __pHDC);

		// Token: 0x06000262 RID: 610
		[DllImport("gdi32.dll")]
		private static extern IntPtr SelectObject(IntPtr __pHDC, IntPtr __pObject);

		// Token: 0x06000263 RID: 611
		[DllImport("gdi32.dll")]
		private static extern int BitBlt(IntPtr __pHdcDest, int __nXDest, int __nYDest, int __nWidth, int __nHeight, IntPtr __pHdcSrc, int __nXSrc, int __nYSrc, int __dwRop);

		// Token: 0x06000264 RID: 612
		[DllImport("gdi32.dll")]
		private static extern bool DeleteObject(IntPtr __pObject);

		// Token: 0x06000265 RID: 613 RVA: 0x0001F434 File Offset: 0x0001D634
		public GDIRender()
		{
			this.backgroundGraphic = null;
			this.backgroundRenderGraphic = null;
			this.backgroundMemoryGraphic = null;
			this.backgroundDrawGraphic = null;
			this.backgroundMemoryBitmap = null;
			this.graphicsBuffer = null;
			this.DrawQuality = DRAW_QUALITY.QUALITY_SUPER_HIGH;
			this.RenderLock = new GDIMutex(false);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001F484 File Offset: 0x0001D684
		~GDIRender()
		{
			this.Dispose();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		public void Dispose()
		{
			if (this.backgroundGraphic != null)
			{
				this.backgroundGraphic.Dispose();
			}
			this.backgroundGraphic = null;
			if (this.graphicsBuffer != null)
			{
				this.graphicsBuffer.Dispose();
			}
			this.graphicsBuffer = null;
			if (this.backgroundRenderGraphic != null)
			{
				this.backgroundRenderGraphic.Dispose();
			}
			this.backgroundRenderGraphic = null;
			if (this.backgroundMemoryBitmap != null)
			{
				GDIRender.DeleteObject(this.memoryBitmapHdc);
				this.backgroundMemoryBitmap.Dispose();
			}
			this.backgroundMemoryBitmap = null;
			if (this.backgroundMemoryGraphic != null)
			{
				GDIRender.DeleteObject(this.memoryGraphicHdc);
				this.backgroundMemoryGraphic.Dispose();
			}
			this.backgroundMemoryGraphic = null;
			if (this.backgroundDrawGraphic != null)
			{
				this.backgroundDrawGraphic.Dispose();
			}
			this.backgroundDrawGraphic = null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001F574 File Offset: 0x0001D774
		public int ResetDraw(Panel GraphOle, Color BackColor)
		{
			if (GraphOle == null || GraphOle.GetType() != typeof(Panel))
			{
				return -1;
			}
			if (GraphOle.ClientRectangle.Width < 1 || GraphOle.ClientRectangle.Height < 1)
			{
				return -1;
			}
			this.RenderLock.WaitLock();
			this.backgroundGraph = GraphOle;
			lock (this.backgroundGraph)
			{
				if (this.backgroundGraphic != null)
				{
					this.backgroundGraphic.Dispose();
				}
				if (this.graphicsBuffer != null)
				{
					this.graphicsBuffer.Dispose();
				}
				if (this.backgroundRenderGraphic != null)
				{
					this.backgroundRenderGraphic.Dispose();
				}
				if (this.backgroundMemoryBitmap != null)
				{
					GDIRender.DeleteObject(this.memoryBitmapHdc);
					this.backgroundMemoryBitmap.Dispose();
				}
				if (this.backgroundMemoryGraphic != null)
				{
					GDIRender.DeleteObject(this.memoryGraphicHdc);
					this.backgroundMemoryGraphic.Dispose();
				}
				if (this.backgroundDrawGraphic != null)
				{
					this.backgroundDrawGraphic.Dispose();
				}
				this.backgroundGraphic = this.backgroundGraph.CreateGraphics();
				BufferedGraphicsContext bufferedGraphicsContext = BufferedGraphicsManager.Current;
				this.graphicsBuffer = bufferedGraphicsContext.Allocate(this.backgroundGraphic, this.backgroundGraph.ClientRectangle);
				this.backgroundRenderGraphic = this.graphicsBuffer.Graphics;
				this.backgroundRenderGraphic.Clear(BackColor);
				this.backgroundRenderGraphic.SetClip(this.backgroundGraph.ClientRectangle);
				this.backgroundMemoryBitmap = new Bitmap(this.backgroundGraph.ClientRectangle.Width, this.backgroundGraph.ClientRectangle.Height, this.backgroundRenderGraphic);
				this.backgroundMemoryGraphic = Graphics.FromImage(this.backgroundMemoryBitmap);
				this.backgroundMemoryGraphic.Clear(BackColor);
				this.memoryGraphicHdc = GDIRender.CreateCompatibleDC(this.backgroundMemoryGraphic.GetHdc());
				this.memoryBitmapHdc = this.backgroundMemoryBitmap.GetHbitmap();
				GDIRender.SelectObject(this.memoryGraphicHdc, this.memoryBitmapHdc);
				this.backgroundDrawGraphic = Graphics.FromHdc(this.memoryGraphicHdc);
				switch (this.DrawQuality)
				{
				case DRAW_QUALITY.QUALITY_SUPER_HIGH:
					this.backgroundDrawGraphic.SmoothingMode = SmoothingMode.HighQuality;
					this.backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
					this.backgroundDrawGraphic.InterpolationMode = InterpolationMode.HighQualityBilinear;
					this.backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
					break;
				case DRAW_QUALITY.QUALITY_HIGH:
					this.backgroundDrawGraphic.SmoothingMode = SmoothingMode.AntiAlias;
					this.backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
					this.backgroundDrawGraphic.InterpolationMode = InterpolationMode.Bilinear;
					this.backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.Half;
					break;
				case DRAW_QUALITY.QUALITY_MIDDLE:
					this.backgroundDrawGraphic.SmoothingMode = SmoothingMode.HighSpeed;
					this.backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.AntiAlias;
					this.backgroundDrawGraphic.InterpolationMode = InterpolationMode.NearestNeighbor;
					this.backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.HighSpeed;
					break;
				case DRAW_QUALITY.QUALITY_LOW:
					this.backgroundDrawGraphic.SmoothingMode = SmoothingMode.None;
					this.backgroundDrawGraphic.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
					this.backgroundDrawGraphic.InterpolationMode = InterpolationMode.Low;
					this.backgroundDrawGraphic.PixelOffsetMode = PixelOffsetMode.None;
					break;
				}
			}
			this.RenderLock.Unlock();
			return 0;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001F88C File Offset: 0x0001DA8C
		public void SetDrawQuality(DRAW_QUALITY NewQuality)
		{
			this.DrawQuality = NewQuality;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001F895 File Offset: 0x0001DA95
		public void BeginRender()
		{
			this.RenderLock.WaitLock();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001F8A2 File Offset: 0x0001DAA2
		public void EndRender()
		{
			this.RenderLock.Unlock();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001F8AF File Offset: 0x0001DAAF
		public Graphics GetGraphicHandle()
		{
			return this.backgroundDrawGraphic;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001F8B7 File Offset: 0x0001DAB7
		public IntPtr BeginUnmanaged()
		{
			return this.backgroundDrawGraphic.GetHdc();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001F8C4 File Offset: 0x0001DAC4
		public void EndUnmanaged()
		{
			this.backgroundDrawGraphic.ReleaseHdc();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		public void BltToFront()
		{
			this.RenderLock.WaitLock();
			try
			{
				IntPtr hdc = this.backgroundDrawGraphic.GetHdc();
				IntPtr hdc2 = this.backgroundRenderGraphic.GetHdc();
				GDIRender.BitBlt(hdc2, 0, 0, this.backgroundGraph.ClientRectangle.Width, this.backgroundGraph.ClientRectangle.Height, hdc, 0, 0, 13369376);
				this.backgroundDrawGraphic.ReleaseHdc();
				this.backgroundRenderGraphic.ReleaseHdc();
				this.graphicsBuffer.Render(this.backgroundGraphic);
			}
			finally
			{
				this.RenderLock.Unlock();
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0001F980 File Offset: 0x0001DB80
		public void BltToFront(int srcX, int srcY, int dstX, int dstY, int Width, int Height)
		{
			this.RenderLock.WaitLock();
			try
			{
				IntPtr hdc = this.backgroundDrawGraphic.GetHdc();
				IntPtr hdc2 = this.backgroundRenderGraphic.GetHdc();
				GDIRender.BitBlt(hdc2, dstX, dstY, Width, Height, hdc, srcX, srcY, 13369376);
				this.backgroundDrawGraphic.ReleaseHdc();
				this.backgroundRenderGraphic.ReleaseHdc();
				this.graphicsBuffer.Render(this.backgroundGraphic);
			}
			finally
			{
				this.RenderLock.Unlock();
			}
		}

		// Token: 0x040002CA RID: 714
		private const int SRCCOPY = 13369376;

		// Token: 0x040002CB RID: 715
		private Panel backgroundGraph;

		// Token: 0x040002CC RID: 716
		private Graphics backgroundGraphic;

		// Token: 0x040002CD RID: 717
		private Graphics backgroundRenderGraphic;

		// Token: 0x040002CE RID: 718
		private Graphics backgroundMemoryGraphic;

		// Token: 0x040002CF RID: 719
		private Graphics backgroundDrawGraphic;

		// Token: 0x040002D0 RID: 720
		private Bitmap backgroundMemoryBitmap;

		// Token: 0x040002D1 RID: 721
		private BufferedGraphics graphicsBuffer;

		// Token: 0x040002D2 RID: 722
		private IntPtr memoryGraphicHdc;

		// Token: 0x040002D3 RID: 723
		private IntPtr memoryBitmapHdc;

		// Token: 0x040002D4 RID: 724
		private GDIMutex RenderLock;

		// Token: 0x040002D5 RID: 725
		private DRAW_QUALITY DrawQuality;
	}
}
