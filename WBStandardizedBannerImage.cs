using DDS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBStandardizedBannerGenerator
{
    public class WBStandardizedBannerImage
    {
        private Bitmap standardizedBannerImage;

        private const int single_standard_image_width = 132;
        private const int single_standard_image_height = 220;

        private List<Bitmap> standardizedSingleBannerImages;

        private DDSImage ddsImage;

        public WBStandardizedBannerImage(List<Bitmap> unStandardizedbannerImages, DDSImage ddsImage)
        {
            this.ddsImage = ddsImage;
            standardizedSingleBannerImages = new List<Bitmap>();
            rescaleStandardizedBannerImages(unStandardizedbannerImages);
        }

        private void rescaleStandardizedBannerImages(List<Bitmap> unStandardizedbannerImages)
        {
            for (int i = 0; i < unStandardizedbannerImages.Count; i++)
            {
                Bitmap standardizedSingleBannerImage = null;
                using (Bitmap bitmap = new Bitmap(single_standard_image_width, single_standard_image_height, unStandardizedbannerImages[i].PixelFormat))
                {
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        g.DrawImage(unStandardizedbannerImages[i], new Rectangle(0, 0, single_standard_image_width, single_standard_image_height));
                    }
                    standardizedSingleBannerImage = new Bitmap(bitmap);
                }
                standardizedSingleBannerImages.Add(standardizedSingleBannerImage);
            }
        }

        private Bitmap generateStandardizedBitmap()
        {
            Bitmap standardizedBannerImage = new Bitmap(Image.FromFile(Environment.CurrentDirectory + "//Template//std_template.png"));

            int col = 0;
            int row = 0;
            int x = 0;
            int y = 0;
            using (var g = Graphics.FromImage(standardizedBannerImage))
            {
                Rectangle rect = new Rectangle(x, y,
                    single_standard_image_width,
                    single_standard_image_height);

                for (int i = 0; i < standardizedSingleBannerImages.Count; i++) //Standard Banner std_banner_*.dds also has 21 banners but each banner's size is different
                {
                    if (i == 0)
                    {
                        g.DrawImage(standardizedSingleBannerImages[i], rect);
                    }
                    else
                    {
                        int ret = i % 7;

                        if (ret != 0)
                        {
                            x = col * (single_standard_image_width + 2);

                            if (row == 0)
                            {
                                y = row * single_standard_image_height;
                            }
                            else
                            {
                                y = row * (single_standard_image_height + 2);
                            }
                        }
                        else
                        {
                            row++;
                            col = 0;

                            x = 0;
                            y = row * (single_standard_image_height + 2);
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
        }
    }
}
