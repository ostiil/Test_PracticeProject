using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace Testing_ProjectPractice_KAS
{
    public partial class MiddleLevelAudio : Form
    {
        public static int result = 0; Home home = new Home();
        public MiddleLevelAudio()
        {
            InitializeComponent();
            Read();
        }
        private void Read()
        {
            string[] text = File.ReadAllLines(@"MiddleAudio.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    label2.Text = text[0];
                    label4.Text = text[1];
                    label5.Text = text[2];
                    label6.Text = text[3];
                    label7.Text = text[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с вопросами");
            }

        }
        SoundPlayer soundPlayer = new SoundPlayer("middlelevel.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            soundPlayer.Dispose();
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string value = ""; string value2 = ""; string value3 = ""; string value4 = ""; string value5 = "";
            string[] element = File.ReadAllLines(@"MiddleAudioAnswer.txt");
            try
            {
                for (int i = 0; i < element.Length; i++)
                {
                    value = element[0];
                    value2 = element[1];
                    value3 = element[2];
                    value4 = element[3];
                    value5 = element[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");;
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
            if (textBox3.Text.ToLower().StartsWith(value3))
            {
                textBox3.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text.ToLower().StartsWith(value4))
            {
                textBox4.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            if (textBox5.Text.ToLower().StartsWith(value5))
            {
                textBox5.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
            label8.Text = $"Правильных ответов: {result}";
            label8.Visible = true;
            if (result >= 3)
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
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;

            result = 0;
            NextButton.Enabled = false;
            label8.Visible = false;
            CheckButton.Enabled = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinishMiddle finish = new FinishMiddle();
            finish.Show();
            Hide();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

    }
}
