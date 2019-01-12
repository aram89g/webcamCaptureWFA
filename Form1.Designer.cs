namespace webcamCaptureWFA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.captureBox2 = new Emgu.CV.UI.ImageBox();
            this.captureBox1 = new Emgu.CV.UI.ImageBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CapturBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RstBtn = new System.Windows.Forms.Button();
            this.Camera_Selection_Left = new System.Windows.Forms.ComboBox();
            this.Camera_Selection_Right = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            resources.ApplyResources(this.imageBox1, "imageBox1");
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            resources.ApplyResources(this.imageBox2, "imageBox2");
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.TabStop = false;
            // 
            // captureBox2
            // 
            resources.ApplyResources(this.captureBox2, "captureBox2");
            this.captureBox2.Name = "captureBox2";
            this.captureBox2.TabStop = false;
            // 
            // captureBox1
            // 
            resources.ApplyResources(this.captureBox1, "captureBox1");
            this.captureBox1.Name = "captureBox1";
            this.captureBox1.TabStop = false;
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CapturBtn
            // 
            resources.ApplyResources(this.CapturBtn, "CapturBtn");
            this.CapturBtn.Name = "CapturBtn";
            this.CapturBtn.UseVisualStyleBackColor = true;
            this.CapturBtn.Click += new System.EventHandler(this.CapturBtn_Click);
            // 
            // StartBtn
            // 
            resources.ApplyResources(this.StartBtn, "StartBtn");
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // BrowseBtn
            // 
            resources.ApplyResources(this.BrowseBtn, "BrowseBtn");
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // RstBtn
            // 
            resources.ApplyResources(this.RstBtn, "RstBtn");
            this.RstBtn.Name = "RstBtn";
            this.RstBtn.UseVisualStyleBackColor = true;
            this.RstBtn.Click += new System.EventHandler(this.RstBtn_Click);
            // 
            // Camera_Selection_Left
            // 
            this.Camera_Selection_Left.FormattingEnabled = true;
            resources.ApplyResources(this.Camera_Selection_Left, "Camera_Selection_Left");
            this.Camera_Selection_Left.Name = "Camera_Selection_Left";
            // 
            // Camera_Selection_Right
            // 
            this.Camera_Selection_Right.FormattingEnabled = true;
            resources.ApplyResources(this.Camera_Selection_Right, "Camera_Selection_Right");
            this.Camera_Selection_Right.Name = "Camera_Selection_Right";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Camera_Selection_Right);
            this.Controls.Add(this.Camera_Selection_Left);
            this.Controls.Add(this.RstBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CapturBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.captureBox1);
            this.Controls.Add(this.captureBox2);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox captureBox2;
        private Emgu.CV.UI.ImageBox captureBox1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CapturBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RstBtn;
        private System.Windows.Forms.ComboBox Camera_Selection_Left;
        private System.Windows.Forms.ComboBox Camera_Selection_Right;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

