using DDS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WBBannerConverter
{
	public class WBStandardVerticalBannerImage : WBVerticalBannerImage
	{
		private const int SINGLE_STANDARD_VERTICAL_BANNER_WIDTH = 132;
		private const int SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT = 330;

		public WBStandardVerticalBannerImage(string bannerImageFileName) : base(bannerImageFileName)
		{
		}

		public WBStandardVerticalBannerImage(List<Bitmap> standardHorizontalBannerImages, DDSImage ddsImage) : base(standardHorizontalBannerImages, ddsImage)
		{
		}

		protected override void splitImageIntoSingleBanner()
		{
			int index = 0;

			int x, y = 0;

			Rectangle drawRect = new Rectangle(0, 0, 
				SINGLE_STANDARD_VERTICAL_BANNER_WIDTH,
				SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT);

			for (int i = 0; i < 3; i++) //Warband banner_*.dds has 21 banners in one dds image
			{
				for (int j = 0; j < 7; j++)
				{
					if (i == 0)
					{
						if (j == 0)
						{
							x = j * SINGLE_STANDARD_VERTICAL_BANNER_WIDTH;
							y = i * SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT + 10;
						}
						else
						{
							x = j * (SINGLE_STANDARD_VERTICAL_BANNER_WIDTH + 2);
							y = i * (SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT + 10);
						}
					}
					else
					{
						if (j == 0)
						{
							x = j * SINGLE_STANDARD_VERTICAL_BANNER_WIDTH;
							y = i * (SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT + 10);
						}
						else
						{
							x = j * (SINGLE_STANDARD_VERTICAL_BANNER_WIDTH + 2);
							y = i * (SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT + 10);
						}
					}

					var rect = new Rectangle(
						x, y,
						SINGLE_STANDARD_VERTICAL_BANNER_WIDTH,
						SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT);

					Bitmap newImage = new Bitmap(
						SINGLE_STANDARD_VERTICAL_BANNER_WIDTH,
						SINGLE_STANDARD_VERTICAL_BANNER_HEIGHT,
						image.PixelFormat);
					using (var g = Graphics.FromImage(newImage))
					{
						g.DrawImage(image, drawRect, rect, GraphicsUnit.Pixel);
					}

					index++;

					veriticalBannerImages.Add(newImage);
				}
			}
		}

		protected override Bitmap generateVerticalBannerImage()
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
	}
}
