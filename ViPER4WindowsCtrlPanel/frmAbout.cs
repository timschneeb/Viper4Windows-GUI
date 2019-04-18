using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x0200000B RID: 11
	public partial class frmAbout : Syncfusion.WinForms.Controls.SfForm
    {
		// Token: 0x06000075 RID: 117 RVA: 0x000076B0 File Offset: 0x000058B0
		public frmAbout()
		{
			this.InitializeComponent();
			this.Text = GlobalMessages.ABOUT;
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
			this.label_LanVersion.Text = GlobalMessages.LANGUAGE_VERSION + " : " + GlobalMessages.LANGUAGE_VERSION_STR;
			this.label_LanTranslator.Text = GlobalMessages.LANGUAGE_TRANSLATOR + " : " + GlobalMessages.LANGUAGE_TRANSLATOR_STR;
			this.label_Copyright.Text = GlobalMessages.COPYRIGHT;
			this.label_SupportForum.Text = GlobalMessages.SUPPORT_FORUM;
		}

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
