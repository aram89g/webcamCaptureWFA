using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//EmguCV
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
        bool captureInProgress = false;
        int cnt = 0;
        string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\calib";
        Mat mat1Frame = new Mat();
        Mat mat2Frame = new Mat();
        Mat saveFrame1 = new Mat();
        Mat saveFrame2 = new Mat();
        Video_Device[] WebCams;


        public Form1()
        {
            InitializeComponent();
            //Find systems cameras with DirectShow.Net dll
            //thanks to Carles Lloret
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
                Camera_Selection_Right.SelectedIndex = 0; //Set the selected device the default

            }
        }

        /**********************************************************
         * Frame aquissition and show in imageBox
         **********************************************************/
        private void ProcessFrame(object sender, EventArgs e)
        {
            mat1Frame = cap1.QueryFrame();
            mat2Frame = cap2.QueryFrame();

            imageBox1.Image = mat1Frame;
            imageBox2.Image = mat2Frame;
        }

        /**********************************************************
         * Initialize default values in UI
         **********************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = defaultPath;
        }

        /**********************************************************
         * Capture the frame
         **********************************************************/
        private void CapturBtn_Click(object sender, EventArgs e)
        {
            captureBox1.Image = imageBox1.Image;
            captureBox2.Image = imageBox2.Image;
            saveFrame1 = mat1Frame;
            saveFrame2 = mat2Frame;
        }

        /**********************************************************
         * Connect to cameras and start the ProcessFrame function 
         * all the time
         **********************************************************/
        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            if (cap1 != null || cap2 != null)
            {
                cap1.Dispose();
                cap2.Dispose();
            }
            cap1 = new VideoCapture(Camera_Selection_Left.SelectedIndex);
            cap2 = new VideoCapture(Camera_Selection_Right.SelectedIndex);

            if (captureInProgress)
            {
                StartBtn.Text = "Stopped!";
                Application.Idle -= ProcessFrame;
            }
            else
            {
                StartBtn.Text = "Running!";
                Application.Idle += ProcessFrame;

            }
            captureInProgress = !captureInProgress;
        }

        /**********************************************************
         * Save the captured frames to file
         **********************************************************/
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            string path1 = textBox1.Text + @"\camera1\image_" + cnt + ".jpg";
            string path2 = textBox1.Text + @"\camera2\image_" + cnt + ".jpg";
            System.IO.Directory.CreateDirectory(textBox1.Text + @"\camera1");
            System.IO.Directory.CreateDirectory(textBox1.Text + @"\camera2");

            // Save to file
            saveFrame1.Save(path1);
            saveFrame2.Save(path2);
            cnt++;

            label1.Text = cnt.ToString();
        }

        /**********************************************************
         * Browse to find folder where to save images
         **********************************************************/
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /**********************************************************
         * Resets the counter, new images will overwrite old ones
         **********************************************************/
        private void RstBtn_Click(object sender, EventArgs e)
        {
            cnt = 0;
            label1.Text = cnt.ToString();
        }    
    }
}
