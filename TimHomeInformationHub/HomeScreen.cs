using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimHomeInformationHub
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            this.creditCardBtn.Image = Properties.Resources.dollar;
            this.headerLabel.BackColor = Color.Transparent;
            this.BackgroundImage = Properties.Resources.knights;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosed += Exit_FormClosed;
        }

        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
