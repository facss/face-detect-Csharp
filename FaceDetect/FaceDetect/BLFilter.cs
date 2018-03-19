using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FaceDetect
{
    public class BLFilter
    {
        public BLFilter()
        {

        }
        public static void filter(Bitmap curBitmap)
        {
            if (curBitmap != null)
            {
                double distantR = 0.06;
                //Bitmap newImage = new Bitmap(curBitmap.Width + 18, curBitmap.Height + 18);
                Matrix padImage = new Matrix(curBitmap.Height + 18, curBitmap.Width + 18);
                Matrix meshGrid = new Matrix(19, 19);
                Matrix weights = new Matrix(19, 19);

                Matrix gMatrix = new Matrix(curBitmap.Height, curBitmap.Width);
                Matrix imageBlock = new Matrix(19, 19);
                Rectangle rect = new Rectangle(0, 0, curBitmap.Width, curBitmap.Height);
                //Rectangle newRect=new Rectangle(0,0,newImage.Width,newImage.Height);
                System.Drawing.Imaging.BitmapData bmpData = curBitmap.LockBits(rect,
                    System.Drawing.Imaging.ImageLockMode.ReadWrite, curBitmap.PixelFormat);
                //System.Drawing.Imaging.BitmapData newData = newImage.LockBits(newRect,
                //    System.Drawing.Imaging.ImageLockMode.ReadWrite, newImage.PixelFormat);

                unsafe
                {
                    byte* ptr = (byte*)(bmpData.Scan0);

                    for (int i = 0; i < bmpData.Height; i++)
                    {
                        for (int j = 0; j < bmpData.Width; j++)
                        {
                            gMatrix[i, j] = (0.229 * ptr[2] + 0.587 * ptr[1] + 0.114 * ptr[0]) / 241;
                            ptr += 3;
                        }
                        ptr += bmpData.Stride - bmpData.Width * 3;
                    }

                    padImage = gMatrix.PadMatrix(9, 9);

                    ptr = (byte*)(bmpData.Scan0);

                    //for (int i = 0; i < padImage.Row; i++)
                    //{
                    //    for (int j = 0; j < padImage.Col; j++)
                    //    {
                    //        ptr[0] = ptr[1] = ptr[2] = (byte)padImage[i, j];
                    //        ptr += 3;
                    //    }
                    //    ptr += newData.Stride - newData.Width * 3;
                    //}
                    for (int i = 9; i < bmpData.Height + 9; i++)
                    {
                        for (int j = 9; j < bmpData.Width + 9; j++)
                        {
                            for (int k = 0; k < imageBlock.Row; k++)
                            {
                                for (int l = 0; l < imageBlock.Col; l++)
                                {
                                    imageBlock[k, l] = padImage[i - 9 + k, j - 9 + l];
                                    meshGrid[k, l] = Math.Exp(-(imageBlock[k, l] - padImage[i, j]) *
                                        (imageBlock[k, l] - imageBlock[9, 9]) / (distantR * distantR));
                                }
                            }
                            weights = imageBlock * meshGrid;
                            gMatrix[i - 9, j - 9] = (weights.SumOfMatrix()) / (meshGrid.SumOfMatrix());
                            ptr[0] = ptr[1] = ptr[2] = (byte)(gMatrix[i - 9, j - 9] * 255);
                            ptr += 3;
                        }
                        ptr += bmpData.Stride - bmpData.Width * 3;
                    }
                    curBitmap.UnlockBits(bmpData);
                    //newImage.UnlockBits(newData);
                    //curBitmap = newImage;

                }
            }
        }
    }
}
