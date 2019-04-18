using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ViPER4WindowsBin.UIControls;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x02000033 RID: 51
	public partial class frmCheckUpdate : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000256 RID: 598 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
		public frmCheckUpdate()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.CHECK_UPDATE;
			this.label_ControlPanelVersion.Text = string.Concat(new string[]
			{
				GlobalMessages.CONTROL_PANEL_VERSION,
				" : ",
				1u.ToString(),
				".",
				0u.ToString(),
				".",
				5u.ToString()
			});
			this.label_DriverVersion.Text = GlobalMessages.DRIVER_VERSION + " : " + RuntimeUtils.EffectDriver.GetVersion();
			this.label_CodeName.Text = GlobalMessages.CODE_NAME + " : " + RuntimeUtils.EffectDriver.GetCodeName();
			this.groupBox_VersionFromInternet.Text = GlobalMessages.VERSION_FROM_INTERNET;
			this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
			this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
			this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
			this.singleButton_Check.ButtonText = GlobalMessages.CHECK;
			this.singleButton_Copy.ButtonText = GlobalMessages.COPY_DOWNLOAD_LINK;
			this.singleButton_Copy.Enabled = false;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001E9F4 File Offset: 0x0001CBF4
		private void singleButton_Check_ButtonClickNotify(SingleButton objSender)
		{
			string text = AppDomain.CurrentDomain.BaseDirectory;
			if (!text.EndsWith("\\"))
			{
				text += "\\version.txt";
			}
			else
			{
				text += "version.txt";
			}
			try
			{
				this.singleButton_Check.Enabled = false;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://vipersaudio.com/swupdate/viper4windows/version.bin");
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				Stream stream = new FileStream(text, FileMode.Create);
				byte[] array = new byte[1024];
				for (int i = responseStream.Read(array, 0, array.Length); i > 0; i = responseStream.Read(array, 0, array.Length))
				{
					stream.Write(array, 0, i);
				}
				stream.Flush();
				stream.Close();
				responseStream.Close();
				httpWebResponse.Close();
				httpWebRequest.Abort();
				StreamReader streamReader = new StreamReader(text, Encoding.Unicode);
				string text2 = streamReader.ReadLine();
				string text3 = streamReader.ReadLine();
				string text4 = streamReader.ReadLine();
				string text5 = streamReader.ReadLine();
				streamReader.Close();
				File.Delete(text);
				if (text2 == null || text3 == null || text4 == null || text5 == null)
				{
					this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
					this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
					this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
					this.singleButton_Check.Enabled = true;
					this.singleButton_Copy.Enabled = false;
				}
				else
				{
					string[] array2 = text2.Split(new char[]
					{
						'.'
					});
					if (array2.Length != 3)
					{
						this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
						this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
						this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
						this.singleButton_Check.Enabled = true;
						this.singleButton_Copy.Enabled = false;
					}
					else
					{
						array2 = text3.Split(new char[]
						{
							'.'
						});
						if (array2.Length != 3)
						{
							this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
							this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
							this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
							this.singleButton_Check.Enabled = true;
							this.singleButton_Copy.Enabled = false;
						}
						else if (text4 == "" || text5.Length < 32)
						{
							this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
							this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
							this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
							this.singleButton_Check.Enabled = true;
							this.singleButton_Copy.Enabled = false;
						}
						else
						{
							this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : " + text2;
							this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : " + text3;
							this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : " + text4;
							this.m_szDownloadLink = text5;
							this.singleButton_Check.Enabled = true;
							this.singleButton_Copy.Enabled = true;
						}
					}
				}
			}
			catch
			{
				File.Delete(text);
				this.label_ControlPanelVersion_Net.Text = GlobalMessages.CONTROL_PANEL_VERSION + " : N/A";
				this.label_DriverVerion_Net.Text = GlobalMessages.DRIVER_VERSION + " : N/A";
				this.label_CodeName_Net.Text = GlobalMessages.CODE_NAME + " : N/A";
				this.singleButton_Check.Enabled = true;
				this.singleButton_Copy.Enabled = false;
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001EE20 File Offset: 0x0001D020
		private void singleButton_Copy_ButtonClickNotify(SingleButton objSender)
		{
			Clipboard.Clear();
			Clipboard.SetText(this.m_szDownloadLink);
		}

		// Token: 0x040002B7 RID: 695
		private const string m_szCheckUpdateLink = "http://vipersaudio.com/swupdate/viper4windows/version.bin";

		// Token: 0x040002B8 RID: 696
		private string m_szDownloadLink = "";
	}
}
