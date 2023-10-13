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
    public class WBStandardHorizontalBannerImage
	{
		private Bitmap image;
		private Bitmap standardizedBannerImage;
		private List<Bitmap> standardizedSingleBannerImages;

		private const int SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH = 132;
		private const int SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT = 220;

        private DDSImage ddsImage;

		public int BannerMode { get; set; }

		public WBStandardHorizontalBannerImage(string bannerImageFileName)
		{
			image = new Bitmap(Image.FromFile(bannerImageFileName));
			standardizedSingleBannerImages = new List<Bitmap>();
			splitImageIntoSingleBanner();
		}

		public WBStandardHorizontalBannerImage(DDSImage ddsImage)
		{
			this.ddsImage = ddsImage;
			image = new Bitmap(ddsImage.Images[0]);
			standardizedSingleBannerImages = new List<Bitmap>();
			splitImageIntoSingleBanner();
		}

		public void ConvertToVerticalBanner(string outputPath)
		{
			WBVerticalBannerImage wbVerticalBanner = new WBVerticalBannerImage(standardizedSingleBannerImages, ddsImage);
			wbVerticalBanner.BannerMode = BannerMode;
            wbVerticalBanner.Save(outputPath);
		}

		public void ConvertToStandardVerticalBanner(string outputPath)
		{
			WBStandardVerticalBannerImage wbVerticalBanner = new WBStandardVerticalBannerImage(standardizedSingleBannerImages, ddsImage);
			wbVerticalBanner.BannerMode = BannerMode;
			wbVerticalBanner.Save(outputPath);
		}

		private void splitImageIntoSingleBanner()
		{
			int index = 0;

			int x, y = 0;

			Rectangle drawRect = new Rectangle(0, 0, SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH, SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT);

			for (int i = 0; i < 3; i++) //Warband banner_*.dds has 21 banners in one dds image
			{
				for (int j = 0; j < 7; j++)
				{
					if (i == 0)
					{
						if (j == 0)
						{
							x = j * SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH;
							y = i * SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT;
						}
						else
						{
							x = j * (SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH + 2);
							y = i * SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT;
						}
					}
					else
					{
						if (j == 0)
						{
							x = j * SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH;
							y = i * (SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT + 2);
						}
						else
						{
							x = j * (SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH + 2);
							y = i * (SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT + 2);
						}
					}

					var rect = new Rectangle(
                        x, y, 
                        SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH, 
                        SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT);

					Bitmap newImage = new Bitmap(
                        SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH, 
                        SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT, 
                        image.PixelFormat);
					using (var g = Graphics.FromImage(newImage))
					{
						g.DrawImage(image, drawRect, rect, GraphicsUnit.Pixel);
					}

					index++;

					standardizedSingleBannerImages.Add(newImage);
				}
			}
		}


		#region WB to Std

		public WBStandardHorizontalBannerImage(List<Bitmap> unStandardizedbannerImages, DDSImage ddsImage)
		{
			this.ddsImage = ddsImage;
			standardizedSingleBannerImages = new List<Bitmap>();
			rescaleToStandardHorizontalBannerImages(unStandardizedbannerImages);
		}

		private void rescaleToStandardHorizontalBannerImages(List<Bitmap> unStandardizedbannerImages)
		{
			for (int i = 0; i < unStandardizedbannerImages.Count; i++)
			{
				Bitmap standardizedSingleBannerImage = null;
				using (Bitmap bitmap = new Bitmap(
					SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH,
					SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT,
					unStandardizedbannerImages[i].PixelFormat))
				{
					using (var g = Graphics.FromImage(bitmap))
					{
						g.DrawImage(unStandardizedbannerImages[i], new Rectangle(0, 0, SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH, SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT));
					}
					standardizedSingleBannerImage = new Bitmap(bitmap);
				}
				standardizedSingleBannerImages.Add(standardizedSingleBannerImage);
			}
		}

		private Bitmap generateStandardizedBitmap()
		{
			Bitmap standardizedBannerImage = new Bitmap(Image.FromFile(Environment.CurrentDirectory + "//Template//std_horizontal_flags_template.png"));

			int col = 0;
			int row = 0;
			int x = 0;
			int y = 0;
			using (var g = Graphics.FromImage(standardizedBannerImage))
			{
				Rectangle rect = new Rectangle(x, y,
					SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH,
					SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT);

				for (int i = 0; i < standardizedSingleBannerImages.Count; i++) //Standard Banner std_banner_*.dds also has 21 banners but each banner's size is different
				{
					if (i == 0)
					{
						g.DrawImage(standardizedSingleBannerImages[i], rect);
					}
					else
					{
						int ret = i % 7;

						if (ret == 0)
						{
							row++;
							col = 0;

							x = 0;
							y = row * (SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT + 2);
						}
						else
						{
							x = col * (SINGLE_STANDARD_HORIZONTAL_BANNER_WIDTH + 2);

							if (row == 0)
							{
								y = row * SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT;
							}
							else
							{
								y = row * (SINGLE_STANDARD_HORIZONTAL_BANNER_HEIGHT + 2);
							}
						}

						rect.X = x;
						rect.Y = y;

						g.DrawImage(standardizedSingleBannerImages[i], rect);
					}

					col++;
				}
			}

			return standardizedBannerImage;
		}

		public void SaveToDDS(string outputFilePath)
		{
			standardizedBannerImage = generateStandardizedBitmap();
			DDSImage.Save(standardizedBannerImage, outputFilePath, ddsImage.Format);
		}

		public void Save(string outputFilePath)
		{
			standardizedBannerImage = generateStandardizedBitmap();
			standardizedBannerImage.Save(outputFilePath);
			image.Dispose();
		}

		#endregion
	}
}
