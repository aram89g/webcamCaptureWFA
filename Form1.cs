using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//EMGU
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

//DiresctShow
using DirectShowLib;

namespace webcamCaptureWFA
{
    public partial class Form1 : Form
    {
        VideoCapture cap1;
        VideoCapture cap2;
        bool captureInProgress;
        int cnt = 0;
        String defaultPath = "C:\\Users\\Public\\Pictures";
        Mat mat1Frame = new Mat();
        Mat mat2Frame = new Mat();
        Mat mat1Reshaped = new Mat();
        Mat mat2Reshaped = new Mat();
        Mat saveFrame1 = new Mat();
        Mat saveFrame2 = new Mat();
        Video_Device[] WebCams;


        public Form1()
        {
            InitializeComponent();
            //-> Find systems cameras with DirectShow.Net dll
            //thanks to carles lloret
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new Video_Device[_SystemCamereas.Length];
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
                Camera_Selection_Left.Items.Add(WebCams[i].ToString());
                Camera_Selection_Right.Items.Add(WebCams[i].ToString());
            }
            if (Camera_Selection_Left.Items.Count > 0)
            {
                Camera_Selection_Left.SelectedIndex = 0; //Set the selected device the default
                Camera_Selection_Right.SelectedIndex = 1; //Set the selected device the default

            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {

            mat1Frame = cap1.QueryFrame();
            mat2Frame = cap2.QueryFrame();
            mat1Reshaped = mat1Frame;
            mat2Reshaped = mat2Frame;

            imageBox1.Image = mat1Reshaped;
            imageBox2.Image = mat2Reshaped;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = defaultPath;
        }



        private void CapturBtn_Click(object sender, EventArgs e)
        {
            captureBox1.Image = imageBox1.Image;
            captureBox2.Image = imageBox2.Image;
            saveFrame1 = mat1Frame;
            saveFrame2 = mat2Frame;
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            if (cap1 == null) cap1 = new VideoCapture(Camera_Selection_Left.SelectedIndex);
            if (cap2 == null) cap2 = new VideoCapture(Camera_Selection_Right.SelectedIndex);

            if (captureInProgress)
            {
                StartBtn.Text = "Stop!";
                Application.Idle -= ProcessFrame;
            }
            else
            {
                StartBtn.Text = "Start!";
                Application.Idle += ProcessFrame;

            }
            captureInProgress = !captureInProgress;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            String path1 = textBox1.Text + "\\camera1\\image_" + cnt + ".jpg";
            String path2 = textBox1.Text + "\\camera2\\image_" + cnt + ".jpg";
            System.IO.Directory.CreateDirectory(textBox1.Text + "\\camera1");
            System.IO.Directory.CreateDirectory(textBox1.Text + "\\camera2");

            // Convert to bitmap and save

            saveFrame1.Save(path1);
            saveFrame2.Save(path2);
            /*
            int width = Convert.ToInt32(captureBox1.Width);
            int height = Convert.ToInt32(captureBox1.Height);
            Bitmap bmp = new Bitmap(width, height);
            captureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
            bmp.Save(path1, System.Drawing.Imaging.ImageFormat.Jpeg);

            width = Convert.ToInt32(captureBox2.Width);
            height = Convert.ToInt32(captureBox2.Height);
            bmp = new Bitmap(width, height);
            captureBox2.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
            bmp.Save(path2, System.Drawing.Imaging.ImageFormat.Jpeg);
            */
            cnt++;

            label1.Text = cnt.ToString();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void RstBtn_Click(object sender, EventArgs e)
        {
            cnt = 0;
            label1.Text = cnt.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
