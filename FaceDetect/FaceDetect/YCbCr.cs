using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace FaceDetect
{
    public class YCbCr
    {
        /// <summary>
        /// 对原图进行基准白矫正1,效率比较低
        /// </summary>
        /// <param name="bitimg"></param>
        /// <returns></returns>
        static public Bitmap NormalizedWhite(Bitmap bitimg)
        {
            Bitmap myimg = bitimg;
            int m = bitimg.Width;
            int n = bitimg.Height;
            double[,] H = new double[m, n];
            double maxH = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    byte red = bitimg.GetPixel(i, j).R;
                    byte green = bitimg.GetPixel(i, j).G;
                    byte blue = bitimg.GetPixel(i, j).B;
                    System.Drawing.Color color = System.Drawing.Color.FromArgb(red, green, blue);
                    double hue = color.GetHue();
                    //double hue = 0.299*(double)red + 0.587*(double)green + 0.114*(double)blue;
                    //double Cb = 0.564*((double)blue - hue);
                    //double Cr = 0.713 * ((double)red - hue);

                    if (maxH < hue)//找到最大的亮度数值
                    {
                        maxH = hue;
                    }
                    H[i, j] = hue;
                    float saturation = color.GetSaturation();
                    float lightness = color.GetBrightness();
                }
            }
            double[] sortedH = new double[(int)maxH + 1];//用来存档排序后的亮度值
            double sumI = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sortedH[(int)H[i, j]]++;
                    sumI += H[i, j];//求出图像的所有亮度和
                }
            }
            double meanI = sumI / (m * n);//求出图像的平均亮度值
            int count = (int)(sortedH.Count() * 0.05);//数据的总数n

            float sumR = 0;
            float sumG = 0;
            float sumB = 0;
            int countRGB = 0;
            for (int i = sortedH.Count(); i > sortedH.Count() - count; i--)
            {
                for (int ii = 0; ii < m; ii++)//遍历所有的图片像素
                    for (int iii = 0; iii < n; iii++)
                    {
                        if (H[ii, iii] == i)//找到一样的像素
                        {
                            sumR += bitimg.GetPixel(ii, iii).R;
                            sumG += bitimg.GetPixel(ii, iii).G;
                            sumB += bitimg.GetPixel(ii, iii).B;
                            countRGB++;
                        }
                    }
            }
            double meanR = sumR / countRGB;//基准白的R均值
            double meanG = sumG / countRGB;//基准白的G均值
            double meanB = sumB / countRGB;//基准白的B均值
            double aR = meanR / meanG;//调整系数
            double aG = meanG / meanI;
            double aB = meanB / meanI;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    int colorR = (int)(bitimg.GetPixel(i, j).R * aR);
                    int colorG = (int)(bitimg.GetPixel(i, j).G * aG);
                    int colorB = (int)(bitimg.GetPixel(i, j).B * aB);
                    int cR;
                    int cG;
                    int cB;
                    if (double.IsNaN(aR * aG * aB))
                    {
                        cR = double.IsNaN(aR) ? bitimg.GetPixel(i, j).R : colorR;
                        cG = double.IsNaN(aG) ? bitimg.GetPixel(i, j).G : colorG;
                        cB = double.IsNaN(aG) ? bitimg.GetPixel(i, j).B : colorB;
                    }
                    else
                    {
                        cR = colorR > 255 ? 255 : colorR;
                        cG = colorG > 255 ? 255 : colorG;
                        cB = colorB > 255 ? 255 : colorB;
                    }
                    Color cnew = Color.FromArgb(cR, cG, cB);
                    myimg.SetPixel(i, j, cnew);
                }
            //进行排序
            return myimg;
        }
        //定义肤色检测函数
        static public Bitmap SkinDetect1(Bitmap a)
        {
            Rectangle rect = new Rectangle(0, 0, a.Width, a.Height);
            System.Drawing.Imaging.BitmapData bmpData = a.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            int stride = bmpData.Stride;
            unsafe
            {
                byte* pIn = (byte*)bmpData.Scan0.ToPointer();
                byte* P;
                int R, G, B;
                double r, g, Fupr, Flor, Wrg;
                for (int y = 0; y < a.Height; y++)
                {
                    for (int x = 0; x < a.Width; x++)
                    {
                        P = pIn;
                        B = P[0];
                        G = P[1];
                        R = P[2];
                        if (R + G + B == 0)
                        {
                            r = 0;
                            g = 0;
                        }
                        else
                        {
                            r = (R / (R + G + B));
                            g = (G / (R + G + B));
                        }
                        Fupr = (1.0743 * r + 0.1452 - 1.3767 * r * r);
                        Flor = (0.5601 * r + 0.1766 - 0.776 * r * r);
                        Wrg = (r - 0.33) * (r - 0.33) + (g - 0.33) * (g - 0.33);
                        if ((R - G >= 45) && ((R > G) && (G > B)) && (Fupr > g) && (Wrg >= 0.0004))
                        {
                            P[0] = (byte)B;
                            P[1] = (byte)G;
                            P[2] = (byte)R;
                        }
                        else
                        {
                            P[0] = 0;
                            P[1] = 0;
                            P[2] = 0;
                        }
                        pIn += 3;

                    }
                    pIn += stride - a.Width * 3;
                }
            }
            a.UnlockBits(bmpData);
            return a;
        }
        public static void RGB2HSB(int red, int green, int blue, out double hue, out double sat, out double bri)
        {
            double r = ((double)red / 255.0);
            double g = ((double)green / 255.0);
            double b = ((double)blue / 255.0);

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            hue = 0.0;
            if (max == r && g >= b)
            {
                if (max - min == 0) hue = 0.0;
                else hue = 60 * (g - b) / (max - min);
            }
            else if (max == r && g < b)
            {
                hue = 60 * (g - b) / (max - min) + 360;
            }
            else if (max == g)
            {
                hue = 60 * (b - r) / (max - min) + 120;
            }
            else if (max == b)
            {
                hue = 60 * (r - g) / (max - min) + 240;
            }

            sat = (max == 0) ? 0.0 : (1.0 - ((double)min / (double)max));
            bri = max;
        }
        public static void HSB2RGB(double hue, double sat, double bri, out int red, out int green, out int blue)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            if (sat == 0)
            {
                r = g = b = bri;
            }
            else
            {
                // the color wheel consists of 6 sectors. Figure out which sector you're in.
                double sectorPos = hue / 60.0;
                int sectorNumber = (int)(Math.Floor(sectorPos));
                // get the fractional part of the sector
                double fractionalSector = sectorPos - sectorNumber;

                // calculate values for the three axes of the color. 
                double p = bri * (1.0 - sat);
                double q = bri * (1.0 - (sat * fractionalSector));
                double t = bri * (1.0 - (sat * (1 - fractionalSector)));

                // assign the fractional colors to r, g, and b based on the sector the angle is in.
                switch (sectorNumber)
                {
                    case 0:
                        r = bri;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = bri;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = bri;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = bri;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = bri;
                        break;
                    case 5:
                        r = bri;
                        g = p;
                        b = q;
                        break;
                }
            }
            red = Convert.ToInt32(r * 255);
            green = Convert.ToInt32(g * 255);
            blue = Convert.ToInt32(b * 255); ;
        }
        // 对原图进行基准白矫正，效率相比较高
        public static Bitmap Lightingconpensate(Bitmap box1)
        {
            int xres, yres, i, j, k, l, m, n, calnum, total, num, averagegray;
            xres = box1.Width;
            yres = box1.Height;
            total = box1.Width * box1.Height;//面积
            calnum = 0;
            averagegray = 0;
            num = 0;
            const int thresholdnum = 100;
            int[] histogram = new int[256];//图片的灰度表，记录在图片中出现的所有灰度
            const float threshlidco = 0.05f;
            for (i = 0; i < 256; i++) histogram[i] = 0;
            if (box1.Width * box1.Height * threshlidco < thresholdnum) return default( Bitmap) ;
            int colorr, colorg, colorb, gray;
            float color;

            Rectangle rt = new Rectangle(0, 0, box1.Width, box1.Height);//设定以矩形，也就是图片边框
            BitmapData dt = box1.LockBits(rt, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//内存锁定，以实现unsafe代码
            unsafe
            {
                byte* ptr = (byte*)(dt.Scan0);
                for (i = 0; i < box1.Height; i++)
                {
                    for (j = 0; j < box1.Width; j++)
                    {
                        colorb = ptr[0];//顺序不是rgb，是bgr，这是跟win32的图片显示有关！注意！！！！
                        colorg = ptr[1];
                        colorr = ptr[2];
                        gray = (int)(0.299 * colorr + 0.587 * colorg + 0.114 * colorb);//这个是通过RGB得到灰度
                        histogram[gray]++;

                        ptr += 3;
                    }
                    ptr += dt.Stride - box1.Width * 3;
                }

                for (k = 0; k < 256; k++)
                {
                    if ((float)calnum / total < threshlidco)
                    {
                        calnum += histogram[255 - k];
                        num = k;
                    }
                    else break;
                }
                calnum = 0;


                for (l = 255; l >= 255 - num; l--)
                {
                    averagegray += histogram[l] * l;
                    calnum += histogram[l];
                }
                averagegray /= calnum;
                float co = (float)(255.0 / (float)averagegray);

                //一下代码实现亮度调节，上面代码是求出亮度补偿系数，然后下边代码将每个像素都乘上补偿系数，就可以实现调节
                byte* ptr2 = (byte*)(dt.Scan0);
                for (m = 0; m < box1.Height; m++)
                {
                    for (n = 0; n < box1.Width; n++)
                    {

                        color = ptr2[0];
                        color *= co;
                        if (color > 255) color = 255;
                        ptr2[0] = (byte)color;

                        color = ptr2[1];
                        color *= co;
                        if (color > 255) color = 255;
                        ptr2[1] = (byte)color;

                        color = ptr2[2];
                        color *= co;
                        if (color > 255) color = 255;
                        ptr2[2] = (byte)color;

                        ptr2 += 3;
                    }
                    ptr2 += dt.Stride - box1.Width * 3;
                }
            }
            box1.UnlockBits(dt);
           return  box1;
        }
               
    }
}
