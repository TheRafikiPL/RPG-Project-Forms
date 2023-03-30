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
    public partial class NavigationForm : Form
    {
        
        public NavigationForm()
        {
            BattleProperties.FillSkillList();
            InitializeComponent();
            NavigationControl.MainPanel = panel;
            NavigationControl.FillList();
            NavigationControl.Display("MainMenu");
            
        }
    }
}
