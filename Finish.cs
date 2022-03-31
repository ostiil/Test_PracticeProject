using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_ProjectPractice_KAS
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }
        private void Finish_Load(object sender, EventArgs e)
        {
            int finishResult = EasyLevel.result + EasyLevelGrammar.result + EasyLevelAudio.result;
            label1.Text = $"По итогам тестирования количество ваших правильных ответов составило {finishResult}";
            if (finishResult < 3)
            {
                label2.Text = "Вы не прошли тестирование. Ваша оценка: 2";
                label2.ForeColor = Color.Red;
            }
            if (finishResult < 5)
            {
                label2.Text = "Вы прошли тестирование. Ваша оценка: 3";
                label2.ForeColor = Color.Green;
            }
            if (finishResult <= 7)
            {
                label2.Text = "Вы прошли тестирование. Ваша оценка: 4";
                label2.ForeColor = Color.Green;
            }
            if (finishResult >= 8)
            {
                label2.Text = "Вы прошли тестирование. Ваша оценка: 5";
                label2.ForeColor = Color.Green;
            }
            EasyLevel.result = 0;
            EasyLevelAudio.result = 0;
            EasyLevelGrammar.result = 0;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }
    }
}
