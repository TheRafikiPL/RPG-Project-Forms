using RPG_Project.UserControls;
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
    public partial class CharacterControl : UserControl
    {
        List<CharacterView> characterViews = new List<CharacterView>();
        public CharacterControl()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            NavigationControl.Display("MainMenu");
            ResetControl();
            BattleProperties.ResetBattleProperties();
        }
        void ResetControl()
        {
            partySizeAcceptButton.Visible = true;
            partySizeLabel.Visible = true;
            partySizeNumeric.Visible = true;
            characterCombo.Visible = false;
            chooseCharacterLabel.Visible = false;
            battleStartButton.Visible = false;
            foreach(CharacterView c in characterViews)
            {
                c.Visible = false;
            }
            characterViews.Clear();
            characterCombo.Items.Clear();
        }

        private void partySizeAcceptButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < partySizeNumeric.Value; i++)
            {
                characterCombo.Items.Add($"{i+1}. Party Member");
            }
            characterCombo.Items.Add("Enemy");
            characterViews.Add(partyCharacter1);
            if(partySizeNumeric.Value > 1)
            {
                characterViews.Add(partyCharacter2);
            }
            if(partySizeNumeric.Value > 2)
            {
                characterViews.Add(partyCharacter3);
            }
            if (partySizeNumeric.Value > 3)
            {
                characterViews.Add(partyCharacter4);
            }
            characterViews.Add(enemyCharacter);
            characterCombo.SelectedIndex = 0;
            partySizeAcceptButton.Visible = false;
            partySizeLabel.Visible = false;
            partySizeNumeric.Visible = false;
            characterCombo.Visible = true;
            chooseCharacterLabel.Visible = true;
            battleStartButton.Visible = true;
        }

        private void characterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(CharacterView c in characterViews)
            {
                c.Visible = false;
            }
            characterViews[characterCombo.SelectedIndex].Visible = true;
        }
        void CreatePartyFromControllers()
        {
            for (int i = 0; i < characterViews.Count-1; i++)
            {
                BattleProperties.Party.Add(characterViews[i].CreateCharacterFromViewInfo());
            }
            BattleProperties.Troops.Add(characterViews[characterViews.Count-1].CreateCharacterFromViewInfo());
        }

        private void battleStartButton_Click(object sender, EventArgs e)
        {
            CreatePartyFromControllers();
            NavigationControl.Views["Battle"].Visible = true;
            NavigationControl.Display("Battle");
        }
    }
}
