using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FaceDetect
{
    public class Knowledge
    {
        static public Bitmap ToGray(Bitmap img1)
        {
            Bitmap grayimg = img1;
            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixelColor = img1.GetPixel(i, j);
                    //计算灰度值
                    int grey = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    Color newColor = Color.FromArgb(grey, grey, grey);
                    grayimg.SetPixel(i, j, newColor);
                }
            }
            return grayimg;
        }
        //计算出二值化的图
        static public Bitmap Thresholding(Bitmap img1)
        {
            int[] histogram = new int[256];
            Bitmap grayimg = img1;
            int minGrayValue = 255, maxGrayValue = 0;
            //求取直方图
            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixelColor = img1.GetPixel(i, j);
                    histogram[pixelColor.R]++;
                    if (pixelColor.R > maxGrayValue) maxGrayValue = pixelColor.R;
                    if (pixelColor.R < minGrayValue) minGrayValue = pixelColor.R;
                }
            }
            //迭代计算阀值
            int threshold = -1;
            int newThreshold = (minGrayValue + maxGrayValue) / 2;
            for (int iterationTimes = 0; threshold != newThreshold && iterationTimes < 100; iterationTimes++)
            {
                threshold = newThreshold;
                int lP1 = 0;
                int lP2 = 0;
                int lS1 = 0;
                int lS2 = 0;
                //求两个区域的灰度的平均值
                for (int i = minGrayValue; i < threshold; i++)
                {
                    lP1 += histogram[i] * i;
                    lS1 += histogram[i];
                }
                int mean1GrayValue = (lP1 / lS1);
                for (int i = threshold + 1; i < maxGrayValue; i++)
                {
                    lP2 += histogram[i] * i;
                    lS2 += histogram[i];
                }
                int mean2GrayValue = (lP2 / lS2);
                newThreshold = (mean1GrayValue + mean2GrayValue) / 2;
            }
            //计算二值化
            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixelColor = img1.GetPixel(i, j);
                    if (pixelColor.R > threshold) grayimg.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    else grayimg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                }
            }
            return grayimg;
        }
        /// <summary>
        /// 将二值化的图片进行检测人脸
        /// </summary>
        /// <param name="bit"></param>
        /// <returns></returns>
        static public Bitmap FaceDetection(Bitmap bit)
        {
            Bitmap ouputimg;
            decimal width = bit.Width;
            decimal height = bit.Height;
            decimal r = Math.Floor(width / 10);//分成10行
            decimal c = Math.Floor(height / 10);//分成10列
            int x1 = 1; int x2 = (int)r;//对应初始化
            decimal s = r * c;//块的面积
            for (int i = 1; i <= 10; i++)
            {
                int y1 = 1; int y2 = (int)c;//对应行初始化
                for (int j = 1; j <= 10; j++)
                {
                    if ((y2 <= c || y2 >= 9 * c) || (x1 == 1 || x2 == r * 10))
                    {//如果在四周区域        
                        ouputimg = LocalRegion(bit, x1, x2, y1, y2);
                        List<int[,]> loc = find(ouputimg);
                        int p = loc.Count;//
                        decimal pr = p / s * 100;//黑色像素所占的比例数
                        if (pr <= 100)
                        {
                            for (int kk = x1 - 1; kk < x2; kk++)
                                for (int ll = y1 - 1; ll < y2; ll++)
                                {
                                    kk = kk >= (int)width ? ((int)width - 1) : kk;
                                    ll = ll >= (int)height ? ((int)height - 1) : ll;
                                    bit.SetPixel(kk, ll, Color.Black);
                                }
                        }
                    }
                    y1 += (int)c;//列跳跃
                    y2 += (int)c;
                }
                x1 += (int)c;
                x2 += (int)c;//行跳跃
            }
            return bit;
        }
        static private List<int[,]> find(Bitmap region)
        {
            List<int[,]> loc = new List<int[,]>();
            int m = region.Width;
            int n = region.Height;
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    Color color = region.GetPixel(x, y);
                    int gray = (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
                    if (gray == 0)
                    {
                        int[,] pixelloc = new int[x, y];
                        loc.Add(pixelloc);
                    }
                }
            }
            return loc;
        }
        /// <summary>
        /// 在原图中提取出特定位置的局部图片
        /// </summary>
        /// <param name="inputImg"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static Bitmap LocalRegion(Bitmap inputImg, int x1, int x2, int y1, int y2)
        {
            int width = x2 - x1;
            int height = y2 - y1;
            Bitmap outputImg = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    Color c = inputImg.GetPixel(i, j);
                    outputImg.SetPixel(i, j, c);
                }
            return outputImg;
        }
    }
}
