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
    public partial class MiddleLevelTest : Form
    {
        public static int result = 0; Home home = new Home();
        public MiddleLevelTest()
        {
            InitializeComponent();
            Read();
        }
        private void Read()
        {
            string[] text = File.ReadAllLines(@"MiddleTest.txt");
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    label2.Text = text[0];
                    label3.Text = text[1];
                    label4.Text = text[2];
                    label5.Text = text[3];
                    label6.Text = text[4];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с вопросами");
            }
            string[] element = File.ReadAllLines(@"MiddleTestAnswer.txt");
            try
            {
                for (int i = 0; i < element.Length; i++)
                {
                    radioButton1.Text = element[0];
                    radioButton2.Text = element[1];
                    radioButton3.Text = element[2];
                    radioButton4.Text = element[3];
                    radioButton5.Text = element[4];
                    radioButton6.Text = element[5];
                    radioButton7.Text = element[6];
                    radioButton8.Text = element[7];
                    radioButton9.Text = element[8];
                    radioButton10.Text = element[9];
                    radioButton11.Text = element[10];
                    radioButton12.Text = element[11];
                    radioButton13.Text = element[12];
                    radioButton14.Text = element[13];
                    radioButton15.Text = element[14];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.ForeColor = Color.Red;
            }
            if (radioButton2.Checked)
            {
                radioButton2.ForeColor = Color.Green;
                result += 1;
            }
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Red;
            }
            if (radioButton4.Checked)
            {
                radioButton4.ForeColor = Color.Red;
            }
            if (radioButton5.Checked)
            {
                radioButton5.ForeColor = Color.Green;
                result += 1;
            }
            if (radioButton6.Checked)
            {
                radioButton6.ForeColor = Color.Red;
            }
            if (radioButton7.Checked)
            {
                radioButton7.ForeColor = Color.Red;
            }
            if (radioButton8.Checked)
            {
                radioButton8.ForeColor = Color.Red;
            }
            if (radioButton9.Checked)
            {
                radioButton9.ForeColor = Color.Green;
                result += 1;
            }
            if (radioButton10.Checked)
            {
                radioButton10.ForeColor = Color.Red;
            }
            if (radioButton11.Checked)
            {
                radioButton11.ForeColor = Color.Green;
                result += 1;
            }
            if (radioButton12.Checked)
            {
                radioButton12.ForeColor = Color.Red;
            }
            if (radioButton13.Checked)
            {
                radioButton13.ForeColor = Color.Red;
            }
            if (radioButton14.Checked)
            {
                radioButton14.ForeColor = Color.Red;
            }
            if (radioButton15.Checked)
            {
                radioButton15.ForeColor = Color.Green;
                result += 1;
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
            result = 0;
            NextButton.Enabled = false;
            CheckButton.Enabled = true;
            label8.Visible = false;
            radioButton1.Checked = false;
            radioButton1.ForeColor = Color.Black;
            radioButton2.Checked = false;
            radioButton2.ForeColor = Color.Black;
            radioButton3.Checked = false;
            radioButton3.ForeColor = Color.Black;
            radioButton4.Checked = false;
            radioButton4.ForeColor = Color.Black;
            radioButton5.Checked = false;
            radioButton5.ForeColor = Color.Black;
            radioButton6.Checked = false;
            radioButton6.ForeColor = Color.Black;
            radioButton7.Checked = false;
            radioButton7.ForeColor = Color.Black;
            radioButton8.Checked = false;
            radioButton8.ForeColor = Color.Black;
            radioButton9.Checked = false;
            radioButton9.ForeColor = Color.Black;
            radioButton10.Checked = false;
            radioButton10.ForeColor = Color.Black;
            radioButton11.Checked = false;
            radioButton11.ForeColor = Color.Black;
            radioButton12.Checked = false;
            radioButton12.ForeColor = Color.Black;
            radioButton13.Checked = false;
            radioButton13.ForeColor = Color.Black;
            radioButton14.Checked = false;
            radioButton14.ForeColor = Color.Black;
            radioButton15.Checked = false;
            radioButton15.ForeColor = Color.Black;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MiddleLevelGrammar grammar = new MiddleLevelGrammar();
            grammar.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
