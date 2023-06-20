using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using System.Diagnostics;

namespace HohoAgent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (string name in VoiceWrapper.Instance.VoiceNames)
                comboBox1.Items.Add(name);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            VoiceWrapper.Instance.Viseme += new _ISpeechVoiceEvents_VisemeEventHandler(onViseme);

            pictureBox1.Image = imageListViseme.Images[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoiceWrapper.Instance.SetVoiceByIdx(comboBox1.SelectedIndex);
        }

        private void onViseme(int StreamNumber, object StreamPosition, int Duration, SpeechVisemeType NextVisemeId, 
            SpeechVisemeFeature Feature, SpeechVisemeType CurrentVisemeId)
        {
            Trace.WriteLine(string.Format("{0} viseme id {1}", DateTime.Now, CurrentVisemeId));

            int viseme_id = int.Parse(CurrentVisemeId.ToString().Replace("SVP_", ""));

            if (viseme_id >= imageListViseme.Images.Count)
                return;

            pictureBox1.Image = imageListViseme.Images[viseme_id];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Speak(textBox1.Text);

        }

        private void Speak(string p)
        {
            try
            {
                VoiceWrapper.Instance.Speak(p, SpeechVoiceSpeakFlags.SVSFlagsAsync);
            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("Speak error {0}", error.Message),
                    "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoiceWrapper.Instance.SpeakAsyncCancelAll();
        }
        // 启动记忆训练
   


    }
}
