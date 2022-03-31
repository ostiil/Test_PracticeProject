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
    public partial class EasyLevelAudio : Form
    {
        public static int result = 0; Home home = new Home();
        public EasyLevelAudio()
        {
            InitializeComponent();
            Read();
        }
        private void Read()
        {
            string[] text = File.ReadAllLines(@"easyAudio.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    label2.Text = text[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Провеьте файл с вопросами");
            }
            string[] element = File.ReadAllLines(@"easyAudioAnswer.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    radioButton1.Text = element[0];
                    radioButton2.Text = element[1];
                    radioButton3.Text = element[2];
                    radioButton4.Text = element[3];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer("easylevel.wav");
            soundPlayer.Play();
        }
        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                result += 1;
                radioButton2.ForeColor= Color.Green;
            }
            if (radioButton1.Checked) radioButton1.ForeColor = Color.Red;
            if (radioButton3.Checked) radioButton3.ForeColor = Color.Red;
            if (radioButton4.Checked) radioButton4.ForeColor = Color.Red;
            if (result == 1)
            {
                NextButton.Enabled = true;
            }
            CheckButton.Enabled = false;
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton2.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Black;
            result = 0;
            CheckButton.Enabled = true;
            NextButton.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Finish finish = new Finish();
            finish.Show();
            Hide();
        }
    }
}
