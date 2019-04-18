using System;
using System.Runtime.InteropServices;

namespace ViPER4WindowsBin
{
	// Token: 0x02000007 RID: 7
	internal class RegHelper
	{
		// Token: 0x06000026 RID: 38
		[DllImport("Utils.dll", CharSet = CharSet.Unicode)]
		private static extern int QueryRegistryStringValue(string pszBrunch, string pszKey, IntPtr pszValueBuffer, int nBufferSize);

		// Token: 0x06000027 RID: 39
		[DllImport("Utils.dll", CharSet = CharSet.Unicode)]
		private static extern int QueryRegistryDWORDValue(string pszBrunch, string pszKey, IntPtr puiValue);

		// Token: 0x06000028 RID: 40
		[DllImport("Utils.dll", CharSet = CharSet.Unicode)]
		private static extern int WriteRegistryDWORDValue(string pszBrunch, string pszKey, uint uiValue);

		// Token: 0x06000029 RID: 41 RVA: 0x00002B88 File Offset: 0x00000D88
		public static bool CheckConfigRegister()
		{
			int num = 260;
			char[] array = new char[num * 2];
			char[] array2 = new char[num * 2];
			IntPtr intPtr = Marshal.AllocHGlobal(num * 2);
			int num2 = RegHelper.QueryRegistryStringValue("SOFTWARE\\ViPER4Windows", "ConfigPath", intPtr, num);
			Marshal.Copy(intPtr, array, 0, num * 2);
			int num3 = RegHelper.QueryRegistryStringValue("SOFTWARE\\ViPER4Windows", "ConfigFile", intPtr, num);
			Marshal.Copy(intPtr, array2, 0, num * 2);
			Marshal.FreeHGlobal(intPtr);
			if (num2 == 0 || num3 == 0)
			{
				return false;
			}
			string text = new string(array);
			string text2 = new string(array2);
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				return false;
			}
			char[] array3 = text.ToCharArray();
			int num4 = -1;
			for (int i = 0; i < array3.Length; i++)
			{
				if (array3[i] == '\0')
				{
					num4 = i;
					break;
				}
			}
			if (num4 == -1)
			{
				return false;
			}
			char[] array4 = new char[num4];
			Array.Copy(array3, array4, num4);
			text = new string(array4);
			array3 = text2.ToCharArray();
			num4 = -1;
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j] == '\0')
				{
					num4 = j;
					break;
				}
			}
			if (num4 == -1)
			{
				return false;
			}
			array4 = new char[num4];
			Array.Copy(array3, array4, num4);
			text2 = new string(array4);
			return !string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public static string GetConfigPath()
		{
			int num = 260;
			char[] array = new char[num * 2];
			IntPtr intPtr = Marshal.AllocHGlobal(num * 2);
			int num2 = RegHelper.QueryRegistryStringValue("SOFTWARE\\ViPER4Windows", "ConfigPath", intPtr, num);
			Marshal.Copy(intPtr, array, 0, num * 2);
			Marshal.FreeHGlobal(intPtr);
			if (num2 == 0)
			{
				return "";
			}
			string text = new string(array);
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			char[] array2 = text.ToCharArray();
			int num3 = -1;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == '\0')
				{
					num3 = i;
					break;
				}
			}
			if (num3 == -1)
			{
				return "";
			}
			char[] array3 = new char[num3];
			Array.Copy(array2, array3, num3);
			text = new string(array3);
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public static string GetConfigFile()
		{
			int num = 260;
			char[] array = new char[num * 2];
			IntPtr intPtr = Marshal.AllocHGlobal(num * 2);
			int num2 = RegHelper.QueryRegistryStringValue("SOFTWARE\\ViPER4Windows", "ConfigFile", intPtr, num);
			Marshal.Copy(intPtr, array, 0, num * 2);
			Marshal.FreeHGlobal(intPtr);
			if (num2 == 0)
			{
				return "";
			}
			string text = new string(array);
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			char[] array2 = text.ToCharArray();
			int num3 = -1;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == '\0')
				{
					num3 = i;
					break;
				}
			}
			if (num3 == -1)
			{
				return "";
			}
			char[] array3 = new char[num3];
			Array.Copy(array2, array3, num3);
			text = new string(array3);
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002EA0 File Offset: 0x000010A0
		public static string GetConfig()
		{
			return RegHelper.GetConfigPath() + "\\" + RegHelper.GetConfigFile();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002EB8 File Offset: 0x000010B8
		public static uint QueryDWORD(string szKeyName, uint uiDefault)
		{
			byte[] array = new byte[Marshal.SizeOf(typeof(uint))];
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(uint)));
			int num = RegHelper.QueryRegistryDWORDValue("SOFTWARE\\ViPER4Windows", szKeyName, intPtr);
			Marshal.Copy(intPtr, array, 0, Marshal.SizeOf(typeof(uint)));
			Marshal.FreeHGlobal(intPtr);
			uint result = BitConverter.ToUInt32(array, 0);
			if (num == 0)
			{
				result = uiDefault;
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002F2C File Offset: 0x0000112C
		public static bool WriteDWORD(string szKeyName, uint uiValue)
		{
			return RegHelper.WriteRegistryDWORDValue("SOFTWARE\\ViPER4Windows", szKeyName, uiValue) != 0;
		}

		// Token: 0x04000009 RID: 9
		private const string m_szAppRegisterPath = "SOFTWARE\\ViPER4Windows";

		// Token: 0x0400000A RID: 10
		private const string m_szKeyConfigPath = "ConfigPath";

		// Token: 0x0400000B RID: 11
		private const string m_szKeyConfigFile = "ConfigFile";
	}
}
