using System;
using System.IO;
using System.Text;

namespace ViPER4WindowsBin.Utils
{
	// Token: 0x02000002 RID: 2
	internal class ConfigFile
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public ConfigFile(string szConfigPath)
		{
			this.m_szConfigPathName = szConfigPath;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000026C
		public string ReadConfig(string szKey)
		{
			if (this.m_szConfigPathName == null)
			{
				return "";
			}
			if (this.m_szConfigPathName == "")
			{
				return "";
			}
			int num = this.m_szConfigPathName.LastIndexOf("\\");
			if (num <= 0)
			{
				return "";
			}
			string path = this.m_szConfigPathName.Substring(0, num) + "\\";
			if (!Directory.Exists(path))
			{
				return "";
			}
			if (!File.Exists(this.m_szConfigPathName))
			{
				return "";
			}
			string result;
			try
			{
				StreamReader streamReader = new StreamReader(this.m_szConfigPathName);
				while (!streamReader.EndOfStream)
				{
					string text = streamReader.ReadLine();
					if (text != null && !text.StartsWith("#"))
					{
						string[] array = text.Split(new char[]
						{
							'='
						});
						if (array.Length == 2 && array[0].Trim().ToUpper() == szKey.Trim().ToUpper())
						{
							streamReader.Close();
							return array[1].Trim();
						}
					}
				}
				streamReader.Close();
				result = "";
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021A0 File Offset: 0x000003A0
		public void SetConfig(string szKey, string szValue)
		{
			if (szKey == null)
			{
				return;
			}
			if (szKey == "")
			{
				return;
			}
			if (this.m_szConfigPathName == null)
			{
				return;
			}
			if (this.m_szConfigPathName == "")
			{
				return;
			}
			int num = this.m_szConfigPathName.LastIndexOf("\\");
			if (num > 0)
			{
				string path = this.m_szConfigPathName.Substring(0, num) + "\\";
				if (!Directory.Exists(path))
				{
					try
					{
						Directory.CreateDirectory(path);
					}
					catch
					{
						return;
					}
				}
			}
			if (!File.Exists(this.m_szConfigPathName))
			{
				try
				{
					StreamWriter streamWriter = new StreamWriter(this.m_szConfigPathName, false, Encoding.Unicode);
					streamWriter.WriteLine(szKey.Trim().ToUpper() + "=" + szValue.Trim());
					streamWriter.Flush();
					streamWriter.Close();
					return;
				}
				catch
				{
				}
			}
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				StreamReader streamReader = new StreamReader(this.m_szConfigPathName);
				bool flag = false;
				while (!streamReader.EndOfStream)
				{
					string text = streamReader.ReadLine();
					if (text != null)
					{
						if (text.StartsWith("#"))
						{
							stringBuilder.AppendLine(text);
						}
						else
						{
							string[] array = text.Split(new char[]
							{
								'='
							});
							if (array.Length == 2)
							{
								if (array[0].Trim().ToUpper() == szKey.Trim().ToUpper())
								{
									stringBuilder.AppendLine(szKey.Trim().ToUpper() + "=" + szValue.Trim());
									flag = true;
								}
								else
								{
									stringBuilder.AppendLine(text.Trim());
								}
							}
							else
							{
								stringBuilder.AppendLine(text);
							}
						}
					}
				}
				streamReader.Close();
				if (!flag)
				{
					stringBuilder.AppendLine(szKey.Trim().ToUpper() + "=" + szValue.Trim());
				}
				StreamWriter streamWriter2 = new StreamWriter(this.m_szConfigPathName, false, Encoding.Unicode);
				streamWriter2.Write(stringBuilder.ToString());
				streamWriter2.Flush();
				streamWriter2.Close();
			}
			catch
			{
			}
		}

		// Token: 0x04000001 RID: 1
		private string m_szConfigPathName = "";
	}
}
