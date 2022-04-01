using DDS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBStandardizedBannerGenerator
{
    public class WBBannerImage
    {
        private DDSImage ddsImage;
        private Bitmap image;
        private const int single_banner_width = 140;
        private const int single_banner_height = 341;

        private List<Bitmap> bannerBitmaps;

        public WBBannerImage(string bannerImageFileName)
        {
            image = new Bitmap(bannerImageFileName);
            bannerBitmaps = new List<Bitmap>();
            splitImageIntoSingleBanner();
        }

        public WBBannerImage(DDSImage ddsImage)
        {
            this.ddsImage = ddsImage;
            image = new Bitmap(ddsImage.Images[0]);
            bannerBitmaps = new List<Bitmap>();
            splitImageIntoSingleBanner();
        }

        private void splitImageIntoSingleBanner()
        {
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    var rect = new Rectangle(j * single_banner_width, i * single_banner_height, single_banner_width, single_banner_height);

                    Bitmap newImage = new Bitmap(single_banner_width, single_banner_height, image.PixelFormat);
                    using (var g = Graphics.FromImage(newImage))
                    {
                        g.DrawImage(image, 
                            new Rectangle(0, 0, single_banner_width, single_banner_height), 
                            rect, GraphicsUnit.Pixel);
                    }

                    index++;
                    //newImage.Save("C:\\Users\\every\\Desktop\\" + index + ".png");

                    bannerBitmaps.Add(newImage);
                }
            }
        }

        public void ConvertToStandardBanner(string outputFilePath)
        {
            WBStandardizedBannerImage standardizedBannerImage = new WBStandardizedBannerImage(bannerBitmaps, ddsImage);
            standardizedBannerImage.Save(outputFilePath);
        }
    }
}
