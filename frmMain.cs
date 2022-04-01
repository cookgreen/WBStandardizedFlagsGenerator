using DDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBStandardizedBannerGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowseDDS_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "WB/WFaS Banner DDS File|*.dds";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtWBBannerDDS.Text = dialog.FileName;
            }
        }

        private void btnSaveDDS_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "WB/WFaS Standard Banner DDS File|*.dds";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtStandardBannerDDS.Text = dialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtWBBannerDDS.Text) &&
               !string.IsNullOrEmpty(txtStandardBannerDDS.Text))
            {
                DDSImage ddsImage = DDSImage.Load(txtWBBannerDDS.Text);
                if (ddsImage.Format != DDSImage.CompressionMode.DXT1)
                {
                    MessageBox.Show("Only support DX1 format!");
                    return;
                }

                WBBannerImage bannerImage = new WBBannerImage(ddsImage);
                bannerImage.ConvertToStandardBanner(txtStandardBannerDDS.Text);
                MessageBox.Show("Finished!");
            }
        }
    }
}
