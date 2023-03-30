using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            NavigationControl.Display("CharacterSelection");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
