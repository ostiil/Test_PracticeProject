using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_ProjectPractice_KAS
{
    public partial class HardLevelAudio : Form
    {
        public HardLevelAudio()
        {
            InitializeComponent();
            Read();
        }
        SoundPlayer soundPlayer = new SoundPlayer("hardaudio.wav");
        public static int result = 0; Home home = new Home();
        private void PlayButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            soundPlayer.Dispose();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }
        private void Read()
        {
            string[] text = File.ReadAllLines(@"HardAudio.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    label2.Text = text[0];
                    label4.Text = text[1];
                    label5.Text = text[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с вопросами");
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string value = ""; string value2 = ""; 
            string[] element = File.ReadAllLines(@"HardAudioAnswer.txt");
            try
            {
                for (int i = 0; i < element.Length; i++)
                {
                    value = element[0];
                    value2 = element[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }
            if (textBox1.Text.ToLower().StartsWith(value))
            {
                textBox1.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text.ToLower().StartsWith(value2))
            {
                result += 1;
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            label6.Text = $"Правильных ответов: {result}";
            label6.Visible = true;
            if (result >= 1)
            {
                NextButton.Enabled = true;
            }
            CheckButton.Enabled = false;
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;

            result = 0;
            NextButton.Enabled = false;
            label6.Visible = false;
            CheckButton.Enabled = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinishHard finishHard = new FinishHard();
            finishHard.Show();
            Hide();
        }
    }
}
