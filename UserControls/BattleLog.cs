using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RPG_Project.UserControls
{
    public partial class BattleLog : UserControl
    {
        public BattleLog()
        {
            InitializeComponent();
        }
        public void Write(string messeage, Color color)
        {
            Log.SelectionStart = Log.TextLength;
            Log.SelectionLength = 0;

            Log.SelectionColor = color;
            Log.AppendText(messeage+"\n");
            Log.SelectionColor = Log.ForeColor;
        }
        public void Clear()
        {
            Log.Text = "";
        }
    }
}
