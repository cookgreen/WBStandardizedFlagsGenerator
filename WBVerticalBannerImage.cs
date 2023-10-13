using DDS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBBannerConverter
{
	/// <summary>
	/// banners_a.dds, banners_d.dds, banners_e.dds, banners_f.dds and banners_g.dds are same pattern
	/// but banners_b.dds and banners_c.dds are very messed pattern which are very different from the banners_a.dds, so we need to handle them directly
	/// or you need to adjust your banners file manually to suit the banners_b.dds and banners_c.dds
	/// </summary>
    public class WBVerticalBannerImage
	{
		private int[] BANNER_MODE_B_X_STRIDE_ARR = new int[] { 2, 4, 1, 3, 1, 2, };
		private int BANNER_MOD_B_Y_STRIDE = 4;
		private int[] BANNER_MODE_C_STRIDE_ARR = new int[] { 3, 4, };

		protected Bitmap image;
		protected Bitmap verticalBannerImage;
		protected List<Bitmap> veriticalBannerImages;

		protected const int SINGLE_VERTICAL_BANNER_WIDTH = 140;
		protected const int SINGLE_VERTICAL_BANNER_HEIGHT = 341;

		private const int SINGLE_VERTICAL_BANNER_B_WIDTH = 135;
		private const int SINGLE_VERTICAL_BANNER_B_HEIGHT = 348;

		private const int SINGLE_VERTICAL_BANNER_C_WIDTH = 134;
		private const int SINGLE_VERTICAL_BANNER_C_HEIGHT = 349;

		public int BannerMode { get; set; }

		private DDSImage ddsImage;

        public WBVerticalBannerImage(string bannerImageFileName)
        {
            image = new Bitmap(bannerImageFileName);
            veriticalBannerImages = new List<Bitmap>();
            splitImageIntoSingleBanner();
        }

        public WBVerticalBannerImage(DDSImage ddsImage)
        {
			this.ddsImage = ddsImage;
            image = new Bitmap(ddsImage.Images[0]);
            veriticalBannerImages = new List<Bitmap>();
            splitImageIntoSingleBanner();
        }

        protected virtual void splitImageIntoSingleBanner()
        {
            int index = 0;

            Rectangle drawRect = new Rectangle(0, 0, SINGLE_VERTICAL_BANNER_WIDTH, SINGLE_VERTICAL_BANNER_HEIGHT);

            for (int i = 0; i < 3; i++) //Warband banner_*.dds has 21 banners in one dds image
            {
                for (int j = 0; j < 7; j++)
                {
                    var rect = new Rectangle(j * SINGLE_VERTICAL_BANNER_WIDTH, i * SINGLE_VERTICAL_BANNER_HEIGHT, SINGLE_VERTICAL_BANNER_WIDTH, SINGLE_VERTICAL_BANNER_HEIGHT);

                    Bitmap newImage = new Bitmap(SINGLE_VERTICAL_BANNER_WIDTH, SINGLE_VERTICAL_BANNER_HEIGHT, image.PixelFormat);
                    using (var g = Graphics.FromImage(newImage))
                    {
                        g.DrawImage(image, drawRect, rect, GraphicsUnit.Pixel);
                    }

                    index++;

                    veriticalBannerImages.Add(newImage);
                }
            }
        }

        public void ConvertToStandardHoritonzalBanner(string outputFilePath)
        {
            WBStandardHorizontalBannerImage standardizedBannerImage = 
				new WBStandardHorizontalBannerImage(veriticalBannerImages, ddsImage);
            standardizedBannerImage.Save(outputFilePath);
		}

		#region Std To WB

		public WBVerticalBannerImage(List<Bitmap> standardHorizontalBannerImages, DDSImage ddsImage)
		{
			this.ddsImage = ddsImage;
			veriticalBannerImages = new List<Bitmap>();
			rescaleToVerticalBannerImages(standardHorizontalBannerImages);
		}

		private void rescaleToVerticalBannerImages(List<Bitmap> standardHorizontalBannerImages)
		{
			for (int i = 0; i < standardHorizontalBannerImages.Count; i++)
			{
				Bitmap standardizedSingleBannerImage = null;
				using (Bitmap bitmap = new Bitmap(
					SINGLE_VERTICAL_BANNER_WIDTH,
					SINGLE_VERTICAL_BANNER_HEIGHT,
					standardHorizontalBannerImages[i].PixelFormat))
				{
					using (var g = Graphics.FromImage(bitmap))
					{
						g.DrawImage(standardHorizontalBannerImages[i], new Rectangle(0, 0, SINGLE_VERTICAL_BANNER_WIDTH, SINGLE_VERTICAL_BANNER_HEIGHT));
					}
					standardizedSingleBannerImage = new Bitmap(bitmap);
				}
				veriticalBannerImages.Add(standardizedSingleBannerImage);
			}
		}

		protected virtual Bitmap generateVerticalBannerImage()
        {
            string bannerTemplateFile = Environment.CurrentDirectory + "//Template//wb_banners_template.png";
            Bitmap wbBannerImage = new Bitmap(Image.FromFile(bannerTemplateFile));

			int col = 0;
			int row = 0;
            int x = 0;
            int y = 0;
            using (var g = Graphics.FromImage(wbBannerImage))
            {
                Rectangle rect = new Rectangle(x, y,
                    SINGLE_VERTICAL_BANNER_WIDTH,
                    SINGLE_VERTICAL_BANNER_HEIGHT);
                for (int i = 0; i < veriticalBannerImages.Count; i++)
				{
					if (i == 0)
					{
						g.DrawImage(veriticalBannerImages[i], rect);
					}
					else
					{
						int ret = i % 7;

						if (ret != 0)
						{
							x = col * SINGLE_VERTICAL_BANNER_WIDTH;
							y = row * SINGLE_VERTICAL_BANNER_HEIGHT;
						}
						else
						{
							row++;
							col = 0;

							x = 0;
							y = row * SINGLE_VERTICAL_BANNER_HEIGHT;
						}

						rect.X = x;
						rect.Y = y;

						g.DrawImage(veriticalBannerImages[i], rect);
					}

					col++;
				}
            }

            return wbBannerImage;
        }

		public void SaveToDDS(string outputFilePath)
		{
			verticalBannerImage = generateVerticalBannerImage();
			DDSImage.Save(verticalBannerImage, outputFilePath, ddsImage.Format);
		}

		public void Save(string outputFilePath)
		{
			verticalBannerImage = generateVerticalBannerImage();
			verticalBannerImage.Save(outputFilePath);
			image.Dispose();
		}

		#endregion
	}
}
