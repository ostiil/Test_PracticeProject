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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            EasyLevel ea = new EasyLevel();
            ea.Show();
            Hide();
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            MiddleLevelTest middle = new MiddleLevelTest();
            middle.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            HardLevelTest hardLevel = new HardLevelTest();
            hardLevel.Show();
            Hide();
        }
    }
}
