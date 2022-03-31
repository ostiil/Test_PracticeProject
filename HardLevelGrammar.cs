using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_ProjectPractice_KAS
{
    public partial class HardLevelGrammar : Form
    {
        public static int result = 0; Home home = new Home();
        public HardLevelGrammar()
        {
            InitializeComponent();
            Read();
        }
        private void Read()
        {
            string[] text = File.ReadAllLines(@"HardGrammar.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    label1.Text = text[0];
                    label2.Text = text[1];
                    label3.Text = text[2];
                    label4.Text = text[3];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string value = ""; string value2 = ""; string value3 = ""; string value4 = "";
            string[] element = File.ReadAllLines(@"HardGrammarAnswer.txt");
            try
            {
                for (int i = 0; i < element.Length; i++)
                {
                    value = element[0];
                    value2 = element[1];
                    value3 = element[2];
                    value4 = element[3];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }
            if (textBox1.Text.ToLower() == value)
            {
                textBox1.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text.ToLower().EndsWith(value2))
            {
                result += 1;
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text.ToLower().EndsWith(value3))
            {
                textBox3.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text.ToLower().EndsWith(value4))
            {
                textBox4.BackColor = Color.Green;
                result += 1;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            label5.Text = $"Правилных ответов: {result}";
            label5.Visible = true;
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
            result = 0;
            NextButton.Enabled = false;
            label5.Visible = false;
            CheckButton.Enabled = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            HardLevelAudio hardLevelAudio = new HardLevelAudio();
            hardLevelAudio.Show();
            Hide();
        }
    }
}
