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

namespace OnvifCapture
{
    public partial class Form1 : Form
    {
        //private readonly string URL = "rtsp://192.168.10.33:554/cam0_0";

        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private Camera camera;

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

                var account = new Account(txt_ipAddress1.Text, txt_id1.Text, txt_password1.Text);
                camera = Camera.Create(account, ex => MessageBox.Show($"Can not create camera : {ex}"));

                // 카메라 연결 확인
                if (camera != null)
                {
                    MessageBox.Show("카메라 연결 성공");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"RTSP 연결 오류: {ex.Message}");
            }
        }

        private async void btn_up_Click(object sender, EventArgs e)
        {
            var vector1 = new PTZVector { PanTilt = new Vector2D { x = 2.0f } };
            var speed1 = new PTZSpeed { PanTilt = new Vector2D { x = 2f, y = 2f } };

            await camera.MoveAsync(MoveType.Continuous, vector1, speed1, null);
        }

        private async void btn_zoom_in_Click(object sender, EventArgs e)
        {
            var vector2 = new PTZVector { Zoom = new Vector1D { x = 1f } };
            var speed2 = new PTZSpeed { Zoom = new Vector1D { x = 1f } };
            await camera.MoveAsync(MoveType.Relative, vector2, speed2, null);
        }
    }
}