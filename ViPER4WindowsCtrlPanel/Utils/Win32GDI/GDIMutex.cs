using System;
using System.Threading;

namespace ViPER4WindowsBin.Utils.Win32GDI
{
	// Token: 0x02000036 RID: 54
	internal class GDIMutex
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0001F3F7 File Offset: 0x0001D5F7
		public GDIMutex(bool Locking)
		{
			if (Locking)
			{
				this.MutexLock.WaitOne();
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001F419 File Offset: 0x0001D619
		public void WaitLock()
		{
			this.MutexLock.WaitOne();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001F427 File Offset: 0x0001D627
		public void Unlock()
		{
			this.MutexLock.ReleaseMutex();
		}

		// Token: 0x040002C9 RID: 713
		private Mutex MutexLock = new Mutex();
	}
}
