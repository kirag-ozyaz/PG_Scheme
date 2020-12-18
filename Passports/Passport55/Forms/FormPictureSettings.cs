using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FormLbr.Classes;

namespace Passport.Forms
{
	public partial class FormPictureSettings : Form
	{
		public FormPictureSettings(Image image, EISSettings config)
		{
			this.InitializeComponent();
			this.eissettings_0 = config;
			this.tbrImage.Value = config.FrmPassportSettings.CompressValue;
			this.pbImage.Image = image;
		}

		private void tbrImage_ValueChanged(object sender, EventArgs e)
		{
			this.pbImage.Image = ImageCompress.GetCompressImage(this.pbImage.Image, (long)this.tbrImage.Value);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.eissettings_0.FrmPassportSettings.CompressValue = this.tbrImage.Value;
			this.appConfig_0.SaveAppConfig(this.eissettings_0);
			base.Close();
		}

		private AppConfig appConfig_0 = new AppConfig();

		private EISSettings eissettings_0;
	}
}
