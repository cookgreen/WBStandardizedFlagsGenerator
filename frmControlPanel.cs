using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBBannerConverter
{
	public partial class frmControlPanel : Form
	{
		public frmControlPanel()
		{
			InitializeComponent();
		}

		private void btnStartConverter_Click(object sender, EventArgs e)
		{
			Hide();
			frmBannerConverter bannerConverterWin = new frmBannerConverter();
			bannerConverterWin.ShowDialog();
			Show();
		}

		private void btnStartGenerator_Click(object sender, EventArgs e)
		{
			Hide();
			frmBannerGenerator bannerGeneratorWin = new frmBannerGenerator();
			bannerGeneratorWin.ShowDialog();
			Show();
		}
	}
}
