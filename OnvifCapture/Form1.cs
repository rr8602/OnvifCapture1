using LibVLCSharp.Shared;

using Onvif.Core.Client.Camera;
using Onvif.Core.Client.Camera.Requests;
using Onvif.Core.Client.Common;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace OnvifCapture
{
    public partial class Form1 : Form
    {
        //private readonly string URL = "rtsp://192.168.10.33:554/cam0_0";

        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;

        private Onvif.Core.Client.Camera.Camera camera;

        public Form1()
        {
            InitializeComponent();

            string vlcPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libvlc", "win-x64");

            Core.Initialize(vlcPath);

            _libVLC = new LibVLC();
        }

        private void btn_connect1_Click(object sender, EventArgs e)
        {
            try
            {
                string rtspUrl = "rtsp://192.168.10.33:554/cam0_0";

                // 이전 MediaPlayer가 있으면 해제
                _mediaPlayer?.Stop();
                _mediaPlayer?.Dispose();

                // 새로운 MediaPlayer 생성
                _mediaPlayer = new MediaPlayer(_libVLC);

                // VideoView에 바인딩
                videoView1.MediaPlayer = _mediaPlayer;

                // RTSP Media 생성 및 재생
                var media = new Media(_libVLC, rtspUrl, FromType.FromLocation);
                _mediaPlayer.Play(media);

                var account = new Account("192.168.10.33", "root", "root");
                camera = Onvif.Core.Client.Camera.Camera.Create(account, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"RTSP 연결 오류: {ex.Message}");
            }
        }

        private async void btn_up_Click(object sender, EventArgs e)
        {
            var vector1 = new PTZVector { PanTilt = new Vector2D { x = 0.5f } };
            var speed1 = new PTZSpeed { PanTilt = new Vector2D { x = 1f, y = 1f } };

            await camera.MoveAsync(MoveType.Absolute, vector1, speed1, null);
        }

        private async void btn_zoom_in_Click(object sender, EventArgs e)
        {
            var vector2 = new PTZVector { Zoom = new Vector1D { x = 1f } };
            var speed2 = new PTZSpeed { Zoom = new Vector1D { x = 1f } };
            await camera.MoveAsync(MoveType.Absolute, vector2, speed2, null);
        }
    }
}