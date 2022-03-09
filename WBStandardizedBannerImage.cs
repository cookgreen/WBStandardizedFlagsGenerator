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
        private Image standardizedBannerImage;

        private const int single_standard_image_width = 132;
        private const int single_standard_image_height = 220;

        private List<Bitmap> standardizedSingleBannerImages;

        public WBStandardizedBannerImage(List<Bitmap> unStandardizedbannerImages)
        {
            standardizedSingleBannerImages = new List<Bitmap>();
            generateStandardizedBannerImages(unStandardizedbannerImages);
        }

        private void generateStandardizedBannerImages(List<Bitmap> unStandardizedbannerImages)
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

        public void Save(string outputFilePath)
        {
            standardizedBannerImage = Image.FromFile(Environment.CurrentDirectory + "//Template//std_template.png");

            int col = 0;
            int row = 0;
            int x = 0;
            int y = 0;
            using (var g = Graphics.FromImage(standardizedBannerImage))
            {
                for (int i = 0; i < standardizedSingleBannerImages.Count; i++)
                {
                    if (i == 0)
                    {
                        g.DrawImage(standardizedSingleBannerImages[i], new Rectangle(x, y, single_standard_image_width, single_standard_image_height));
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

                        g.DrawImage(standardizedSingleBannerImages[i], new Rectangle(x, y, single_standard_image_width, single_standard_image_height));
                    }

                    col++;
                }
            }

            standardizedBannerImage.Save(outputFilePath);
        }
    }
}
