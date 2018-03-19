using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using Accord;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using AForge;
using AForge.Video;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace FaceDetect
{
    public class FileAssistance
    {
        private static string pathname = string.Empty;//静态的文件路径

        #region 文件操作
        /// <summary>
        /// 文件转换为BYTE
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static byte[] GetFilebyte(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream stream = new FileStream(filename, FileMode.Open);
                byte[] bts = new byte[stream.Length];
                stream.Read(bts, 0, bts.Length);
                stream.Close();
                stream.Dispose();
                return bts;
            }
            return null;
        }
        /// <summary>
        /// 将路径名转为图片
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static System.Drawing.Image FilenameToImage(string filename)
        {
            byte[] bts = GetFilebyte(filename);
            if (bts == null)
                return null;
            return System.Drawing.Image.FromStream(new MemoryStream(bts));
        }
        /// <summary>
        /// 打开文件路径
        /// </summary>
        /// <returns></returns>
        public static string OpenFile()
        {
            OpenFileDialog openfile = new OpenFileDialog();//初始化
            openfile.Filter =
                " JPEG File Interchange Format (*.jpg) | *.jpg; *.jpeg | " +
                "Windows Bitmap(*.bmp)|*.bmp|" +
                "Graphics Interchange Format (*.gif)|(*.gif)|" +
                "Portable Network Graphics (*.png)|*.png|" +
                "Tag Image File Format (*.tif)|*.tif;*.tiff";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pathname = openfile.FileName;//图片文件的路径
            }
            return pathname;
        }
        public static void SaveImg(PictureBox pb)
        {
            System.Drawing.Imaging.ImageFormat imageformat = null;
            SaveFileDialog save = new SaveFileDialog();
            bool isSave = true;
            save.Title="图片保存";
            save.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif|png|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string filename = save.FileName.ToString();
                if(filename!=""&& filename != null)
                {
                    string fileExtName = filename.Substring(filename.LastIndexOf(".")+1).ToString();
                    
                    if(fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imageformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imageformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imageformat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            case "png":
                                imageformat = System.Drawing.Imaging.ImageFormat.Png;
                                break;
                            default:
                                MessageBox.Show("不好意思,图片格式不支持");
                                isSave = false;
                                break;
                        }
                    }
                    if(imageformat == null)
                    {
                        imageformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                        
                    }
                }
                if (isSave)
                {
                    try
                    {
                        pb.Image.Save(filename, imageformat);
                    }
                    catch
                    {
                        MessageBox.Show("保存错误");
                    }
                }
            }        
        }
        #endregion
    }
}
