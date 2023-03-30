using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project
{
    public static class NavigationControl
    {
        static public Dictionary<string, UserControl> Views = new Dictionary<string, UserControl>();
        static public Panel MainPanel;

        public static void FillList()
        {
            Views.Add("MainMenu", new MainControl());
            Views["MainMenu"].Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Views["MainMenu"]);

            Views.Add("CharacterSelection", new CharacterControl());
            Views["CharacterSelection"].Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Views["CharacterSelection"]);

            Views.Add("Battle", new BattleControl());
            Views["Battle"].Dock = DockStyle.Fill;
            Views["Battle"].Visible = false;
            MainPanel.Controls.Add(Views["Battle"]);
        }

        public static void Display(string nameOfView)
        {
            if(Views.ContainsKey(nameOfView))
            {
                Views[nameOfView].BringToFront();
            }
        }
    }
}