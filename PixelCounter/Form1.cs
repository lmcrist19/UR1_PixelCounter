using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelCounter
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int _threshold = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            thresholdTrackBar.Value = _threshold;
        }
        private void DisplayWebcam()
        {
            while(_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();
                int newHeight = (frame.Size.Height * rawView.Size.Width) / frame.Size.Width;
                Size newSize = new Size(rawView.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);
                rawView.Image = frame.Bitmap;

                Mat grayFrame = new Mat();
                Mat binaryFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(grayFrame, binaryFrame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                thresholdView.Image = binaryFrame.Bitmap;

                int slice1WhitePixels = 0;
                int slice2WhitePixels = 0;
                int slice3WhitePixels = 0;
                int slice4WhitePixels = 0;
                int slice5WhitePixels = 0;

                Image<Gray, byte> img = binaryFrame.ToImage<Gray, byte>();
                
                for (int slice1x = 0; slice1x< binaryFrame.Width / 5; slice1x++)
                {
                    for(int slice1y = 0; slice1y < binaryFrame.Height; slice1y++)
                    {
                        if (img.Data[slice1y, slice1x, 0] == 255) slice1WhitePixels++; //slice 1 white pixel counter
                    }
                }
                for (int slice2x = binaryFrame.Width / 5; slice2x < (2 * binaryFrame.Width) / 5; slice2x++)
                {
                    for (int slice2y = 0; slice2y < binaryFrame.Height; slice2y++)
                    {
                        if (img.Data[slice2y, slice2x, 0] == 255) slice2WhitePixels++; //slice 2 white pixel counter
                    }
                }
                for (int slice3x = (2 * binaryFrame.Width) / 5; slice3x < (3 * binaryFrame.Width) / 5; slice3x++)
                {
                    for (int slice3y = 0; slice3y < binaryFrame.Height; slice3y++)
                    {
                        if (img.Data[slice3y, slice3x, 0] == 255) slice3WhitePixels++; //slice 3 white pixel counter
                    }
                }
                for (int slice4x = (3 * binaryFrame.Width) / 5; slice4x < (4 * binaryFrame.Width) / 5; slice4x++)
                {
                    for (int slice4y = 0; slice4y < binaryFrame.Height; slice4y++)
                    {
                        if (img.Data[slice4y, slice4x, 0] == 255) slice4WhitePixels++; //slice 4 white pixel counter
                    }
                }
                for (int slice5x = (4 * binaryFrame.Width) / 5; slice5x <  binaryFrame.Width; slice5x++)
                {
                    for (int slice5y = 0; slice5y < binaryFrame.Height; slice5y++)
                    {
                        if (img.Data[slice5y, slice5x, 0] == 255) slice5WhitePixels++; //slice 5 white pixel counter
                    }
                }
                Invoke(new Action(() =>
                {
                    slice1Label.Text = $"Slice 1: {slice1WhitePixels} white pixels";
                    slice2Label.Text = $"Slice 2: {slice2WhitePixels} white pixels";
                    slice3Label.Text = $"Slice 3: {slice3WhitePixels} white pixels";
                    slice4Label.Text = $"Slice 4: {slice4WhitePixels} white pixels";
                    slice5Label.Text = $"Slice 5: {slice5WhitePixels} white pixels";
                }));
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }
        private void thresholdTrackBar_Scroll_1(object sender, EventArgs e)
        {
           _threshold = thresholdTrackBar.Value;
        }
    }
}
