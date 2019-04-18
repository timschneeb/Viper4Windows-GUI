using System;
using System.IO;
using System.Text;

namespace ViPER4WindowsBin
{
	// Token: 0x02000016 RID: 22
	public class TrayMenuPreset
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00015E36 File Offset: 0x00014036
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00015E3E File Offset: 0x0001403E
		public string PresetName
		{
			get
			{
				return this.m_szPresetName;
			}
			set
			{
				this.m_szPresetName = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00015E47 File Offset: 0x00014047
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00015E4F File Offset: 0x0001404F
		public int PresetMode
		{
			get
			{
				return this.m_nPresetMode;
			}
			set
			{
				this.m_nPresetMode = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00015E58 File Offset: 0x00014058
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00015E60 File Offset: 0x00014060
		public string PresetFile
		{
			get
			{
				return this.m_szPresetFile;
			}
			set
			{
				this.m_szPresetFile = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00015E6C File Offset: 0x0001406C
		public string PresetFileShort
		{
			get
			{
				if (string.IsNullOrEmpty(this.m_szPresetFile))
				{
					return "";
				}
				int num = this.m_szPresetFile.LastIndexOf("\\");
				if (num <= 0)
				{
					return "";
				}
				return this.m_szPresetFile.Substring(num + 1, this.m_szPresetFile.Length - num - 1);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00015EC4 File Offset: 0x000140C4
		public TrayMenuPreset(string szName, int nMode, string szFile)
		{
			this.m_szPresetName = szName;
			this.m_nPresetMode = nMode;
			this.m_szPresetFile = szFile;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00015EF7 File Offset: 0x000140F7
		public bool Valid()
		{
			return this.m_nPresetMode == 0 || this.m_nPresetMode == 1 || this.m_nPresetMode == 2;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00015F16 File Offset: 0x00014116
		public bool PresetLoadable()
		{
			return !string.IsNullOrEmpty(this.m_szPresetFile) && File.Exists(this.m_szPresetFile);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00015F38 File Offset: 0x00014138
		public TrayMenuPreset Clone()
		{
			return new TrayMenuPreset(this.m_szPresetName, this.m_nPresetMode, this.m_szPresetFile);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00015F60 File Offset: 0x00014160
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(TrayMenuPreset))
			{
				return false;
			}
			TrayMenuPreset trayMenuPreset = obj as TrayMenuPreset;
			return trayMenuPreset.PresetName == this.m_szPresetName && trayMenuPreset.PresetMode == this.m_nPresetMode && trayMenuPreset.PresetFile == this.m_szPresetFile;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00015FC4 File Offset: 0x000141C4
		public override int GetHashCode()
		{
			if (!this.Valid())
			{
				return 0;
			}
			int num = 0;
			byte[] bytes = Encoding.Default.GetBytes(this.m_szPresetFile);
			byte[] bytes2 = Encoding.Default.GetBytes(this.m_szPresetName);
			if (bytes != null)
			{
				for (int i = 0; i < bytes.Length; i++)
				{
					num += (int)bytes[i];
				}
				num <<= this.m_nPresetMode;
			}
			if (bytes2 != null)
			{
				for (int j = 0; j < bytes2.Length; j++)
				{
					num += (int)bytes2[j];
				}
				num >>= this.m_nPresetMode;
			}
			num += this.m_nPresetMode;
			return num * (this.m_nPresetMode + 1);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001605F File Offset: 0x0001425F
		public override string ToString()
		{
			return this.m_szPresetName;
		}

		// Token: 0x04000170 RID: 368
		private string m_szPresetName = "";

		// Token: 0x04000171 RID: 369
		private int m_nPresetMode;

		// Token: 0x04000172 RID: 370
		private string m_szPresetFile = "";
	}
}
