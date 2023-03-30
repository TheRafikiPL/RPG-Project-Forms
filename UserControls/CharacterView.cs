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

namespace RPG_Project.UserControls
{
    public partial class CharacterView : UserControl
    {
        public CharacterView()
        {
            InitializeComponent();
            for (int i = 2; i < BattleProperties.SkillList.Count; i++)
            {
                skillDataGrid.Rows.Add(false, BattleProperties.SkillList[i].Name, BattleProperties.SkillList[i].CostString, BattleProperties.SkillList[i].AffinityImage);
            }
            SetComboBoxes();
        }
        public Character CreateCharacterFromViewInfo()
        {
            Character c = new Character(nameTextBox.Text, (int)hpValue.Value, (int)mpValue.Value, (int)strValue.Value, (int)mgValue.Value, (int)dexValue.Value, (int)agiValue.Value, (int)lucValue.Value);
            for(int i=0; i<skillDataGrid.Rows.Count; i++)
            {
                if((bool)skillDataGrid.Rows[i].Cells[0].Value == true)
                {
                    c.AddSkillByIndex(i);
                }
            }
            string[] affinities = new string[7];
            affinities[0] = affinityCombo1.Text;
            affinities[1] = affinityCombo2.Text;
            affinities[2] = affinityCombo3.Text;
            affinities[3] = affinityCombo4.Text;
            affinities[4] = affinityCombo5.Text;
            affinities[5] = affinityCombo6.Text;
            affinities[6] = affinityCombo7.Text;
            for (int i = 0; i < affinities.Length; i++)
            {
                AffinityRelation aff = AffinityRelation.NEUTRAL;
                switch (affinities[i])
                {
                    case "Wk":
                        aff = AffinityRelation.WEAK;
                        break;
                    case "Str":
                        aff = AffinityRelation.STRONG;
                        break;
                    case "Nu":
                        aff = AffinityRelation.NULL;
                        break;
                    case "Rep":
                        aff = AffinityRelation.REPEL;
                        break;
                    case "Abs":
                        aff = AffinityRelation.ABSORB;
                        break;
                }
                c.ChangeAffinityRelation(i,aff);
            }
            c.SetImage(characterArt.Image);
            return c;
        }
        void SetComboBoxes()
        {
            affinityCombo1.SelectedIndex = 0;
            affinityCombo2.SelectedIndex = 0;
            affinityCombo3.SelectedIndex = 0;
            affinityCombo4.SelectedIndex = 0;
            affinityCombo5.SelectedIndex = 0;
            affinityCombo6.SelectedIndex = 0;
            affinityCombo7.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.WriteLine(nameTextBox.Text);
                    sw.WriteLine(hpValue.Value.ToString());
                    sw.WriteLine(mpValue.Value.ToString());
                    sw.WriteLine(strValue.Value.ToString());
                    sw.WriteLine(mgValue.Value.ToString());
                    sw.WriteLine(dexValue.Value.ToString());
                    sw.WriteLine(agiValue.Value.ToString());
                    sw.WriteLine(lucValue.Value.ToString());
                    sw.WriteLine(affinityCombo1.SelectedIndex);
                    sw.WriteLine(affinityCombo2.SelectedIndex);
                    sw.WriteLine(affinityCombo3.SelectedIndex);
                    sw.WriteLine(affinityCombo4.SelectedIndex);
                    sw.WriteLine(affinityCombo5.SelectedIndex);
                    sw.WriteLine(affinityCombo6.SelectedIndex);
                    sw.WriteLine(affinityCombo7.SelectedIndex);
                    for (int i = 0; i < skillDataGrid.Rows.Count; i++)
                    {
                        if ((bool)skillDataGrid.Rows[i].Cells[0].Value == true)
                        {
                            sw.WriteLine(i);
                        }
                    }
                    sw.Close();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ERROR");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if(loadFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = loadFileDialog.FileName;
                    StreamReader sr = new StreamReader(filePath);
                    nameTextBox.Text = sr.ReadLine();
                    hpValue.Value = Convert.ToInt32(sr.ReadLine());
                    mpValue.Value = Convert.ToInt32(sr.ReadLine());
                    strValue.Value = Convert.ToInt32(sr.ReadLine());
                    mgValue.Value = Convert.ToInt32(sr.ReadLine());
                    dexValue.Value = Convert.ToInt32(sr.ReadLine());
                    agiValue.Value = Convert.ToInt32(sr.ReadLine());
                    lucValue.Value = Convert.ToInt32(sr.ReadLine());
                    affinityCombo1.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    affinityCombo2.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    affinityCombo3.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    affinityCombo4.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    affinityCombo5.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    affinityCombo6.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    affinityCombo7.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                    while(!sr.EndOfStream)
                    {
                        skillDataGrid.Rows[Convert.ToInt32(sr.ReadLine())].Cells[0].Value = true;
                    }
                    sr.Close();
                }
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message,"ERROR");
            }
        }
    }
}
