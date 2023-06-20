namespace HohoAgent
{
    partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.imageListViseme = new System.Windows.Forms.ImageList(this.components);
      this.button2 = new System.Windows.Forms.Button();
      this.imageListViseme2 = new System.Windows.Forms.ImageList(this.components);
      this.memTrainTimer = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(664, 468);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 34);
      this.button1.TabIndex = 0;
      this.button1.Text = "Speak";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Location = new System.Drawing.Point(298, 20);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(478, 434);
      this.textBox1.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(15, 20);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(266, 213);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(18, 248);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(264, 26);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // imageListViseme
      // 
      this.imageListViseme.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListViseme.ImageStream")));
      this.imageListViseme.TransparentColor = System.Drawing.Color.Transparent;
      this.imageListViseme.Images.SetKeyName(0, "1.jpg");
      this.imageListViseme.Images.SetKeyName(1, "2.jpg");
      this.imageListViseme.Images.SetKeyName(2, "3.jpg");
      this.imageListViseme.Images.SetKeyName(3, "4.jpg");
      this.imageListViseme.Images.SetKeyName(4, "5.jpg");
      this.imageListViseme.Images.SetKeyName(5, "6.jpg");
      this.imageListViseme.Images.SetKeyName(6, "7.jpg");
      this.imageListViseme.Images.SetKeyName(7, "8.jpg");
      this.imageListViseme.Images.SetKeyName(8, "9.jpg");
      this.imageListViseme.Images.SetKeyName(9, "10.jpg");
      this.imageListViseme.Images.SetKeyName(10, "11.jpg");
      this.imageListViseme.Images.SetKeyName(11, "12.jpg");
      this.imageListViseme.Images.SetKeyName(12, "13.jpg");
      this.imageListViseme.Images.SetKeyName(13, "14.jpg");
      this.imageListViseme.Images.SetKeyName(14, "15.jpg");
      this.imageListViseme.Images.SetKeyName(15, "16.jpg");
      this.imageListViseme.Images.SetKeyName(16, "17.jpg");
      this.imageListViseme.Images.SetKeyName(17, "18.jpg");
      this.imageListViseme.Images.SetKeyName(18, "19.jpg");
      this.imageListViseme.Images.SetKeyName(19, "20.jpg");
      this.imageListViseme.Images.SetKeyName(20, "21.jpg");
      this.imageListViseme.Images.SetKeyName(21, "22.jpg");
      this.imageListViseme.Images.SetKeyName(22, "image.jpg");
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.Location = new System.Drawing.Point(538, 468);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(112, 34);
      this.button2.TabIndex = 4;
      this.button2.Text = "Stop";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // imageListViseme2
      // 
      this.imageListViseme2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListViseme2.ImageStream")));
      this.imageListViseme2.TransparentColor = System.Drawing.Color.Transparent;
      this.imageListViseme2.Images.SetKeyName(0, "mouth2.jpg");
      this.imageListViseme2.Images.SetKeyName(1, "mouth3.jpg");
      this.imageListViseme2.Images.SetKeyName(2, "mouth4.jpg");
      this.imageListViseme2.Images.SetKeyName(3, "mouth5.jpg");
      this.imageListViseme2.Images.SetKeyName(4, "mouth6.jpg");
      this.imageListViseme2.Images.SetKeyName(5, "mouth7.jpg");
      this.imageListViseme2.Images.SetKeyName(6, "mouth8.jpg");
      this.imageListViseme2.Images.SetKeyName(7, "mouth9.jpg");
      this.imageListViseme2.Images.SetKeyName(8, "mouth10.jpg");
      this.imageListViseme2.Images.SetKeyName(9, "mouth11.jpg");
      this.imageListViseme2.Images.SetKeyName(10, "mouth12.jpg");
      this.imageListViseme2.Images.SetKeyName(11, "mouth13.jpg");
      this.imageListViseme2.Images.SetKeyName(12, "silence.jpg");
      // 
      // memTrainTimer
      // 
      this.memTrainTimer.Interval = 5000;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(795, 514);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageListViseme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageListViseme2;
        private System.Windows.Forms.Timer memTrainTimer;
    }
}