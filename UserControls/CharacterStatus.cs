using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project.UserControls
{
    public partial class CharacterStatus : UserControl
    {
        public CharacterStatus()
        {
            InitializeComponent();
        }
        public void UpdateInfo(Character c)
        {
            lblName.Text = c.Name;
            lblHP.Text = $"{c.CurrentHealth}/{c.Health} HP";
            lblMP.Text = $"{c.CurrentMana}/{c.Mana} MP";
            barHP.Maximum = c.Health;
            barHP.Value = c.CurrentHealth;
            barMP.Maximum = c.Mana;
            barMP.Value = c.CurrentMana;
        }
    }
}
