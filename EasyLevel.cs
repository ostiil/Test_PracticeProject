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

namespace Testing_ProjectPractice_KAS
{

    public partial class EasyLevel : Form
    {
        public static int result = 0; Home home = new Home();
        public EasyLevel()
        {
            InitializeComponent();
            Read();
        }
        private void Read()
        {
            string[] text = File.ReadAllLines(@"easyTest.txt");
            string[] element = File.ReadAllLines(@"easyTestAnswer.txt");
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
            catch(Exception ex)
            {
                MessageBox.Show("Проверьте файл с вопросами");
            }
            try
            {
                for (int i = 0; i < element.Length; i++)
                {
                    true1.Text = element[0];
                    radioButton2.Text = element[1];
                    radioButton3.Text = element[2];
                    radioButton5.Text = element[3];
                    radioButton4.Text = element[4];
                    true2.Text = element[5];
                    radioButton7.Text = element[6];
                    true3.Text = element[7];
                    radioButton9.Text = element[8];
                    radioButton10.Text = element[9];
                    radioButton11.Text = element[10];
                    true4.Text = element[11];
                    false5.Text = element[12];
                    false5_2.Text = element[13];
                    true5.Text = element[14];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте файл с ответами");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (true1.Checked)
            {
                true1.ForeColor = Color.Green;
                result += 1;
            }
            if (radioButton2.Checked)
            {
                radioButton2.ForeColor = Color.Red;
            }
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Red;
            }
            if (true2.Checked)
            {
                true2.ForeColor = Color.Green;
                result += 1;
            }
            if(radioButton4.Checked) 
            {
                radioButton4.ForeColor = Color.Red;
            }
            if (radioButton5.Checked)
            {
                radioButton5.ForeColor = Color.Red;
            }
            if (radioButton7.Checked)
            {
                radioButton7.ForeColor = Color.Red;
            }
            if (radioButton9.Checked)
            {
                radioButton9.ForeColor = Color.Red;
            }
            if (true3.Checked)
            {
                true3.ForeColor = Color.Green;
                result += 1;
            }
             if (radioButton10.Checked)
            {
                radioButton10.ForeColor = Color.Red;
            }
             if (radioButton11.Checked)
            {
                radioButton11.ForeColor = Color.Red;
            }
             if (true4.Checked)
            {
                true4.ForeColor = Color.Green;
                result += 1;
            }
             if (true5.Checked)
            {
                true5.ForeColor = Color.Green;
                result += 1;
            }
             if (false5.Checked)
            {
                false5.ForeColor = Color.Red;
            }
             if (false5_2.Checked)
            {
                false5.ForeColor = Color.Red;
            }
            label8.Text = $"Правильных ответов: {result}";
            label8.Visible = true;
            if (result >= 3)
            {
                nextButton.Enabled = true;
            }
            checkButton.Enabled = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            EasyLevelGrammar grammar = new EasyLevelGrammar();
            grammar.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = 0;
            if (true1.Checked)
            {
                true1.Checked = false;
                true1.ForeColor = Color.Black;
            }
            if (radioButton2.Checked)
            {
                radioButton2.ForeColor = Color.Black;
                true1.ForeColor = Color.Black;
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Black;
                true1.ForeColor = Color.Black;
                radioButton3.Checked = false;
            }
            if (true2.Checked)
            {
                true2.ForeColor = Color.Black;
                true2.Checked = false;
            }
            if (radioButton4.Checked)
            {
                radioButton4.ForeColor = Color.Black;
                true2.ForeColor = Color.Black;
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked)
            {
                radioButton5.ForeColor = Color.Black;
                true2.ForeColor = Color.Black;
                radioButton5.Checked = false;
            }
            if (radioButton7.Checked)
            {
                radioButton7.ForeColor = Color.Black;
                true3.ForeColor = Color.Black;
                radioButton7.Checked = false;
            }
            if (radioButton9.Checked)
            {
                radioButton9.ForeColor = Color.Black;
                true3.ForeColor = Color.Black;
                radioButton9.Checked = false;
            }
            if (true3.Checked)
            {
                true3.ForeColor = Color.Black;
                true3.Checked = false;
            }
            if (radioButton10.Checked)
            {
                true4.ForeColor = Color.Black;
                radioButton10.ForeColor = Color.Black;
                radioButton10.Checked = false;
            }
            if (radioButton11.Checked)
            {
                true4.ForeColor = Color.Black;
                radioButton11.ForeColor = Color.Black;
                radioButton11.Checked = false;
            }
            if (true4.Checked)
            {
                true4.ForeColor = Color.Black;
                true4.Checked = false;
            }
            if (true5.Checked)
            {
                true5.ForeColor = Color.Black;
                true5.Checked = false;
            }
            if (false5.Checked)
            {
                false5.ForeColor = Color.Black;
                true5.ForeColor = Color.Black;
                false5.Checked = false;
            }
            if (false5_2.Checked)
            {
                false5.ForeColor = Color.Black;
                true5.ForeColor = Color.Black;
                false5_2.Checked = false;
            }
            //label8.Text = $"Правильных ответов: {result}";
            label8.Visible = false;
            checkButton.Enabled = true;
            nextButton.Enabled = false;
        }

    }
}
