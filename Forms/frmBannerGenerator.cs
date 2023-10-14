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
	public partial class frmBannerGenerator : Form
	{
		public frmBannerGenerator()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			if(listBannerImages.Items.Count == 0)
			{
				MessageBox.Show("You must add some images to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SaveFileDialog dialog = new SaveFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				List<Bitmap> images = new List<Bitmap>();
				for (int i = 0; i < listBannerImages.Items.Count; i++)
				{
					images.Add(new Bitmap(Image.FromFile(listBannerImages.Items[i].ToString())));
				}

				if (rbGenerateStandardHorizontalBanner.Checked)
				{
					WBStandardHorizontalBannerImage standardHorizontalBannerImage = new WBStandardHorizontalBannerImage(images, null);
					standardHorizontalBannerImage.Save(dialog.FileName);
				}
				else if (rbGenerateWBDefaultBanner.Checked)
				{
					WBStandardVerticalBannerImage standardVerticalBannerImage = new WBStandardVerticalBannerImage(images, null);
					standardVerticalBannerImage.Save(dialog.FileName);
				}
				else if (rbGenerateStandardVerticalBanner.Checked)
				{
					WBVerticalBannerImage verticalBannerImage = new WBVerticalBannerImage(images, null);
					verticalBannerImage.Save(dialog.FileName);
				}
				MessageBox.Show("Generate finished!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image File|*.png";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				listBannerImages.Items.Add(dialog.FileName);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			listBannerImages.Items.RemoveAt(listBannerImages.SelectedIndex);
		}

		private void listBannerImages_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBannerImages.SelectedIndex > -1)
			{
				btnDelete.Enabled = true;
			}
			else
			{
				btnDelete.Enabled = false;
			}
		}
	}
}
