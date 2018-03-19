using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FaceDetect
{
    public static   class GridOn
    {
        public static  int iw = 20;//每个单元格的宽度
        public static int ih = 10;
        public static Graphics GridPaint(bool bvis,Bitmap objBitmap)
        {
            Color color = new Color();
            int width = objBitmap.Width;
            int height = objBitmap.Height;
            iw = width / 10;
            ih = height / 10;
            Graphics objGraphic = Graphics.FromImage(objBitmap);
            for (int i=0;i<=width - iw; i+=iw)
            {
                if (bvis == true)
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.White;
                }
                //每次距离一个iw像素画一条小线段
                objGraphic.DrawLine(new Pen (new SolidBrush(color),2),i+iw,0,i+iw,height);
            }
            for (int i = 0; i <= height - ih; i+=ih)
            {
                if (bvis == true)
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.White;
                }
                objGraphic.DrawLine(new Pen(new SolidBrush(color),2), 0, i + ih,width,i+ih);
            }
            return objGraphic;
        }
    }
}
