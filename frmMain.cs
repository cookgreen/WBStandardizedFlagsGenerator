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
    public enum WBBannerConverterState
    {
        WBtoStd,
        StdToWB
    }

    public partial class frmMain : Form
    {
        private WBBannerConverterState state;

        public frmMain()
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
						WBVerticalBannerImage verticalBannerImage = new WBVerticalBannerImage(txtBannerInput.Text);
						verticalBannerImage.ConvertToStandardHoritonzalBanner(txtBannerOutput.Text);
						break;
					case WBBannerConverterState.StdToWB:
						WBStandardHorizontalBannerImage standardHorizontalBannerImage = new WBStandardHorizontalBannerImage(txtBannerInput.Text);
                        standardHorizontalBannerImage.BannerMode = cmbBannerMode.SelectedIndex;
						standardHorizontalBannerImage.ConvertToVerticalBanner(txtBannerOutput.Text);
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
                lbBannerMode.Visible = true;
                cmbBannerMode.Visible = true;
			}
			else if (state == WBBannerConverterState.StdToWB)
			{
				state = WBBannerConverterState.WBtoStd;
				Text = "WB Banner Converter - Mode: [Vertical to Horizontal]";
				btnChangeMode.ImageIndex = 1;
				lbBannerMode.Visible = false;
				cmbBannerMode.Visible = false;
			}
		}
	}
}
