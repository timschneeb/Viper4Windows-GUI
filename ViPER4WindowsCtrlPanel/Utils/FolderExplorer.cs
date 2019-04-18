using System;
using System.Collections.Generic;
using System.IO;

namespace ViPER4WindowsBin.Utils
{
	// Token: 0x02000010 RID: 16
	internal class FolderExplorer
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00008AF0 File Offset: 0x00006CF0
		private void InternalListFiles(string szFolder, List<string> lsResult)
		{
			try
			{
				lsResult.AddRange(Directory.GetFiles(szFolder));
				foreach (string szFolder2 in Directory.GetDirectories(szFolder))
				{
					this.InternalListFiles(szFolder2, lsResult);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008B40 File Offset: 0x00006D40
		public string[] ListFiles(string szFolder)
		{
			if (szFolder == null)
			{
				return new string[0];
			}
			if (!Directory.Exists(szFolder))
			{
				return new string[0];
			}
			List<string> list = new List<string>();
			this.InternalListFiles(szFolder, list);
			return list.ToArray();
		}
	}
}
