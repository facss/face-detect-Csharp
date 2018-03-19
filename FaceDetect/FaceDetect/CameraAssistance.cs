using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using AForge.Video.DirectShow;

namespace FaceDetect
{
    public class CameraAssistance
    {
        private static VideoCaptureDevice _videoSource;//摄像头的静态资源
        /// <summary>
        /// 初始化并遍历所有的摄像头设备
        /// </summary>
        /// <returns>设备的名字</returns>
        public static List<string> Enumerate()
        {
            List<string> _cameraList = new List<string>();//初始化空的摄像头ID链表
            try
            {
                FilterInfoCollection _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);//获取所有已插USB摄像头驱动信息
                if (_filterInfoCollection == null && _filterInfoCollection.Count == 0)
                {
                    throw new ApplicationException();
                }
                // 枚举所有视频输入设备
                foreach (FilterInfo device in _filterInfoCollection)
                {
                    _cameraList.Add(device.Name);//向集合中添加USB摄像头硬件Id
                }
                _cameraList.Remove(""); //移出空项
            }
            catch (ApplicationException)
            {
                _cameraList.Add("No local capture devices");
            }
            return _cameraList;
        }
        /// <summary>
        /// 链接摄像头
        /// </summary>
        /// <param name="videoDevices"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static VideoCaptureDevice CameraConn(FilterInfoCollection videoDevices, int index)
        {
            try
            {
                _videoSource = new VideoCaptureDevice(videoDevices[index].MonikerString);

                _videoSource.DesiredFrameSize = new Size(320, 240);
                _videoSource.DesiredFrameRate = 1;
                return _videoSource;
            }
            catch
            {
                return null;
            }
        }
    }

}
