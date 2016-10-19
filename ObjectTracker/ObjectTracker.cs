using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV.GPU;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace ObjectTracker
{
    public partial class ObjectTracking : Form
    {
        Capture capwebcam = null;
        bool blnCapturingInProcess = false;
        Image<Bgr, Byte> imgOriginal;
        Image<Gray, Byte> imgProcessed;

        public ObjectTracking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capwebcam = new Capture();
            }
            catch (NullReferenceException except)
            {
                txtXYRadius.Text = except.Message;
                return;
            }

            Application.Idle += processFrameAndUpdateGUI;
            blnCapturingInProcess = true;

        }
        private void Frorm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(capwebcam != null){
                capwebcam.Dispose();
            }
        }
        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {
            imgOriginal = capwebcam.QueryFrame();
            if (imgOriginal == null) return;

            imgProcessed = imgOriginal.InRange(new Bgr(80, 150, 150), new Bgr(170, 255, 255));

            imgProcessed = imgProcessed.SmoothGaussian(9);

            CircleF[] circles = imgProcessed.HoughCircles(new Gray(100), 
                                                           new Gray(50), 
                                                                      2, 
                                                imgProcessed.Height / 4, 
                                                                     10, 
                                                                400)[0];

            foreach(CircleF circle in circles)
            {
                if (txtXYRadius.Text != "") txtXYRadius.AppendText(Environment.NewLine);
                txtXYRadius.AppendText("ball positon = x" + circle.Center.X.ToString().PadLeft(4) +
                                                     ",y" + circle.Center.Y.ToString().PadLeft(4) +
                                         "radius=" + circle.Radius.ToString("###.000").PadLeft(7));
                txtXYRadius.ScrollToCaret();

                CvInvoke.cvCircle(imgOriginal,
                    new Point((int)circle.Center.X, (int)circle.Center.Y),
                    3,
                    new MCvScalar(0, 255, 0),
                    -1,
                    LINE_TYPE.CV_AA,
                    0);
                imgOriginal.Draw(circle,
                    new Bgr(Color.Red),
                    3);
            }
            captureImageBox.Image = imgOriginal;
            processedImageBox.Image = imgProcessed;
        }

        private void btnPauseOrResume_Click(object sender, EventArgs e)
        {
            if (blnCapturingInProcess == true)
            {
                Application.Idle -= processFrameAndUpdateGUI;
                blnCapturingInProcess = false;
                btnPauseOrResume.Text = "resume";

            }
            else
            {
                Application.Idle += processFrameAndUpdateGUI;
                blnCapturingInProcess = true;
                btnPauseOrResume.Text = "pause";
            }
        }
    }
}
