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
    public partial class EasyLevelGrammar : Form
    {
        public static string[] text = File.ReadAllLines(@"easyGrammar.txt");
        public static int result; Home home = new Home();
        public EasyLevelGrammar()
        {
            InitializeComponent();
            Read();
        }

        private void Read()
        {
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    label1.Text = text[0];
                    label2.Text = text[1];
                    label3.Text = text[2];
                    label4.Text = text[3];
                    label6.Text = text[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с вопросами");
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string value = ""; string value2 = ""; string value3 = "";
            string value4 = "";
            string[] element = File.ReadAllLines(@"easyGranswer.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    value = element[0];
                    value2 = element[1];
                    value3 = element[2];
                    value4 = element[3];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }
            try
            {
                if (textBox1.Text.ToLower().StartsWith(value))
                {
                    textBox1.BackColor = Color.Green;
                    result += 1;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
                if (textBox2.Text.ToLower() == value2)
                {
                    textBox2.BackColor = Color.Green;
                    result += 1;
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }
                if (textBox3.Text.ToLower() == value3)
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
                    result += 1;
                    textBox4.BackColor = Color.Green;
                }
                else
                {
                    textBox4.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Попробуй еще раз.");
                //AgainButton_Click(sender,e);
            }
            label7.Visible = true;
            label7.Text = $"Правильных ответов: {result}";
            if (result >= 3)
            {
                NextButton.Enabled = true;
            }
            CheckButton.Enabled = false;

        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            label7.Visible = false;
            NextButton.Enabled = false;
            CheckButton.Enabled = true;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EasyLevelAudio audio = new EasyLevelAudio();
            audio.Show();
            this.Hide();
        }
    }
}
