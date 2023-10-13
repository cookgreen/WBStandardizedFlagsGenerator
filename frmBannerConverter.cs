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

namespace WBBannerConverter
{
    public enum WBBannerConverterState
    {
        WBtoStd,
        StdToWB
    }

    public partial class frmBannerConverter : Form
    {
        private WBBannerConverterState state;

        public frmBannerConverter()
        {
            InitializeComponent();
            state = WBBannerConverterState.WBtoStd;
            Text = "WB Banner Converter - Mode: [Vertical to Horizontal]";
            cmbBannerMode.SelectedIndex = 0;
		}

        private void btnBrowseDDS_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string filter = string.Empty;
            switch(state)
            {
                case WBBannerConverterState.WBtoStd:
					filter = "WB/WFaS Banner Image File|*.png";
					break;
                case WBBannerConverterState.StdToWB:
					filter = "WB/WFaS Standard Banner Image File|*.png";
					break;
            }
            dialog.Filter = filter;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtBannerInput.Text = dialog.FileName;
            }
        }

        private void btnSaveDDS_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
			string filter = string.Empty;
			switch (state)
			{
				case WBBannerConverterState.StdToWB:
					filter = "WB/WFaS Banner Image File|*.png";
					break;
				case WBBannerConverterState.WBtoStd:
					filter = "WB/WFaS Standard Banner Image File|*.png";
					break;
			}
			dialog.Filter = filter;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtBannerOutput.Text = dialog.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBannerInput.Text) &&
               !string.IsNullOrEmpty(txtBannerOutput.Text))
            {
                //DDSImage ddsImage = DDSImage.Load(txtBannerInputDDS.Text);
                //if (ddsImage.Format != DDSImage.CompressionMode.DXT1)
                //{
                //    MessageBox.Show("Only support DX1 format!");
                //    return;
                //}
                
                switch(state)
                {
                    case WBBannerConverterState.WBtoStd:
                        if (chkStandardized.Checked)
                        {
                            WBVerticalBannerImage verticalBannerImage = new WBVerticalBannerImage(txtBannerInput.Text);
                            verticalBannerImage.ConvertToStandardHoritonzalBanner(txtBannerOutput.Text);
                        }
                        else
						{
							WBStandardVerticalBannerImage verticalBannerImage = new WBStandardVerticalBannerImage(txtBannerInput.Text);
							verticalBannerImage.ConvertToStandardHoritonzalBanner(txtBannerOutput.Text);
						}
						break;
					case WBBannerConverterState.StdToWB:
						WBStandardHorizontalBannerImage standardHorizontalBannerImage = new WBStandardHorizontalBannerImage(txtBannerInput.Text);
						standardHorizontalBannerImage.BannerMode = cmbBannerMode.SelectedIndex;
						if (chkStandardized.Checked)
                        {
                            standardHorizontalBannerImage.ConvertToStandardVerticalBanner(txtBannerOutput.Text);
                        }
                        else
						{
							standardHorizontalBannerImage.ConvertToVerticalBanner(txtBannerOutput.Text);
						}
						break;
				}

				MessageBox.Show("Finished!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
        }

		private void btnChangeMode_Click(object sender, EventArgs e)
		{
            if(state == WBBannerConverterState.WBtoStd)
            {
                state = WBBannerConverterState.StdToWB;
				Text = "WB Banner Converter - Mode: [Horizontal to Vertical]";
				btnChangeMode.ImageIndex = 0;
			}
			else if (state == WBBannerConverterState.StdToWB)
			{
				state = WBBannerConverterState.WBtoStd;
				Text = "WB Banner Converter - Mode: [Vertical to Horizontal]";
				btnChangeMode.ImageIndex = 1;
			}
		}

		private void chkStandardized_CheckedChanged(object sender, EventArgs e)
		{
            if(chkStandardized.Checked)
            {
                lbBannerMode.Enabled = false;
                cmbBannerMode.Enabled = false;
            }
            else
            {
                lbBannerMode.Enabled = true;
                cmbBannerMode.Enabled = true;
            }
		}
	}
}
