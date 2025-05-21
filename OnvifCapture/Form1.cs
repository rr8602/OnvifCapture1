using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Flann;

using RtspClientSharp;
using RtspClientSharp.RawFrames;
using RtspClientSharp.RawFrames.Video;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using VidGrab;

namespace OnvifCapture
{
    public partial class Form1 : Form
    {
        private readonly string URL = "rtsp://192.168.10.33:554/cam0_0";
        private double speedRatio = 1;
        private int durationMs = 300;
        private double relativeMove = 0.01;

        public Form1()
        {
            InitializeComponent();
        }

        public static class PTZTypes
        {
            public static string Pan = "Pan";
            public static string Tilt = "Tilt";
            public static string Zoom = "Zoom";
        }asdf

        private void btn_connect1_Click(object sender, EventArgs e)
        {
            string ipAddress1 = txt_ipAddress1.Text;
            string port1 = txt_port1.Text;
            string id1 = txt_id1.Text;
            string password1 = txt_password1.Text;

            videoGrabber2.Stop();

            videoGrabber2.SetAuthentication(TAuthenticationType.at_IPCamera, id1, password1);
            videoGrabber2.IPCameraURL = $"rtsp://{ipAddress1}:{port1}/cam0_0";
            videoGrabber2.VideoSource = TVideoSource.vs_IPCamera;

            videoGrabber2.StartPreview();
        }

        private void SetupVG(VideoGrabber vg, string URL)
        {
            vg.VideoSource = TVideoSource.vs_IPCamera;
            vg.IPCameraURL = URL;
            //vg.IPCameraURL = vg.IPCameraURL + ">buffer=0"; // no buffering
            //vg.IPCameraURL = vg.IPCameraURL + ">lowdelay=1"; // low latency
            //vg.RecordingMethod = TRecordingMethod.rm_MP4;
            //vg.FrameGrabber = TFrameGrabber.fg_Disabled; // saves CPU, but disables the overlays and frame capture capabilities
            //vg.Display_AspectRatio = TAspectRatio.ar_Box;
            vg.SetAuthentication(TAuthenticationType.at_IPCamera, "root", "root");
        }

        private void DoPTZRelative(double pan, double tilt, double zoom)
        {
            videoGrabber2.ONVIFPTZSetPosition(pan, tilt, zoom, speedRatio, true);
        }

        private void StartContinuousPTZMove(string PTZType, bool OppositeDirection)
        {
            videoGrabber2.ONVIFPTZStartMove(PTZType, OppositeDirection, speedRatio, durationMs);
        }

        private void pan_trackerBar_Scroll(object sender, EventArgs e)
        {
            pan_numeric.Value = pan_trackerBar.Value / 10.0M;
        }

        private void pan_numeric_ValueChanged(object sender, EventArgs e)
        {
            pan_trackerBar.Value = (int)(pan_numeric.Value * 10);
        }

        private void tilt_trackerBar_Scroll(object sender, EventArgs e)
        {
            tilt_numeric.Value = tilt_trackerBar.Value / 10.0M;
        }

        private void tilt_numeric_ValueChanged(object sender, EventArgs e)
        {
            tilt_trackerBar.Value = (int)(tilt_numeric.Value * 10);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, relativeMove, 0);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, -relativeMove, 0);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            DoPTZRelative(relativeMove, 0, 0);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            DoPTZRelative(-relativeMove, 0, 0);
        }

        private void btn_zoom_out_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, 0, -relativeMove);
        }

        private void btn_zoom_in_Click(object sender, EventArgs e)
        {
            DoPTZRelative(0, 0, relativeMove);
        }

        private void btn_up_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinuousPTZMove(PTZTypes.Tilt, false);
        }

        private void btn_down_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinuousPTZMove(PTZTypes.Tilt, true);
        }

        private void btn_left_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinuousPTZMove(PTZTypes.Pan, false);
        }

        private void btn_right_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinuousPTZMove(PTZTypes.Pan, true);
        }

        private void btn_zoom_out_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinuousPTZMove(PTZTypes.Zoom, false);
        }

        private void btn_zoom_in_MouseDown(object sender, MouseEventArgs e)
        {
            StartContinuousPTZMove(PTZTypes.Zoom, true);
        }

        private void speed_trackerBar_Scroll(object sender, EventArgs e)
        {
            speedRatio = Convert.ToDouble(speed_trackerBar.Value) / 100;
        }

        private void txt_duration_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txt_duration.Text, out int duration);
        }

        private void txt_relative_move_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txt_relative_move.Text, out double relativeMove);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupVG(videoGrabber2, URL);
        }
    }
}