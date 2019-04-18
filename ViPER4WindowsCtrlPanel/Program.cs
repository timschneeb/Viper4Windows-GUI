using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x02000014 RID: 20
	internal static class Program
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00008FB4 File Offset: 0x000071B4
		[STAThread]
		private static void Main(string[] szArgs)
		{
			Process process = Program.RunningInstance();
			if (process != null)
			{
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string text = "";
			string text2 = "";
			string text3 = AppDomain.CurrentDomain.BaseDirectory;
			if (!text3.EndsWith("\\"))
			{
				text3 += "\\";
			}
			string text4 = text3 + "Language\\";
			ConfigFile configFile = new ConfigFile(text3 + "Config.ini");
			string text5 = configFile.ReadConfig("$LANGUAGE_NAME");
			if (text5 == "")
			{
				text5 = "English";
			}
			FolderExplorer folderExplorer = new FolderExplorer();
			string[] array = folderExplorer.ListFiles(text4);
			string text6 = "";
			foreach (string text7 in array)
			{
				ConfigFile configFile2 = new ConfigFile(text7);
				string text8 = configFile2.ReadConfig("$LANGUAGE_NAME");
				if (text8.Trim() == text5)
				{
					text6 = text7;
					break;
				}
			}
			if (text6 != "")
			{
				text = text4;
				text2 = text6;
			}
			else if (text5 == "English")
			{
				MessageBox.Show("Can not load default language (English), use built-in language.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				text5 = "English";
				foreach (string text9 in array)
				{
					ConfigFile configFile3 = new ConfigFile(text9);
					string text10 = configFile3.ReadConfig("$LANGUAGE_NAME");
					if (text10.Trim() == text5)
					{
						text6 = text9;
						break;
					}
				}
				if (text6 != "")
				{
					text = text4;
					text2 = text6;
				}
				else
				{
					MessageBox.Show("Can not load default language (English), use built-in language.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			if (text != "" && text2 != "")
			{
				GlobalMessages.LoadMessages(text2);
			}
			if (!RegHelper.CheckConfigRegister())
			{
				MessageBox.Show(GlobalMessages.DRIVER_NOT_CONFIG, GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			frmMain.SetLanguage(text, text2);
			frmMain mainForm = new frmMain(szArgs);
			Application.Run(mainForm);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000091B4 File Offset: 0x000073B4
		private static Process RunningInstance()
		{
			Process currentProcess = Process.GetCurrentProcess();
			Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
			foreach (Process process in processesByName)
			{
				if (process.Id != currentProcess.Id && Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == currentProcess.MainModule.FileName)
				{
					return process;
				}
			}
			return null;
		}
	}
}
