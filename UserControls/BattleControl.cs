using RPG_Project.Properties;
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
    public partial class BattleControl : UserControl
    {
        Image turnTrue;
        Image turnFalse;
        Queue<KeyValuePair<PictureBox, Character>> TurnQueue;
        KeyValuePair<PictureBox, Character> Current;
        PictureBox[] pictureBoxes;
        public List<CharacterStatus> characterStatuses = new List<CharacterStatus>();
        Skill selectedSkill;
        public BattleControl()
        {
            turnTrue = Resources.turnTruePlaceholder;
            turnFalse = Resources.error_none;
            InitializeComponent();
            TurnQueue = new Queue<KeyValuePair<PictureBox, Character>>();
            pictureBoxes = new PictureBox[] {partySprite1, partySprite2, partySprite3, partySprite4 };
        }
        public PictureBox CreateTurnImage(Image im)
        {
            PictureBox p = new PictureBox();
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.Image = im;
            return p;
        }

        public void PopulizeSkills(Character c)
        {
            skillList.Rows.Clear();
            foreach (int i in c.Skills)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(skillList, i, BattleProperties.SkillList[i].Description, BattleProperties.SkillList[i].Name, BattleProperties.SkillList[i].CostString, BattleProperties.SkillList[i].AffinityImage);
                switch (BattleProperties.SkillList[i].CostType)
                {
                    case CostType.HP:
                        if(c.CurrentHealth < BattleProperties.SkillList[i].CostValue)
                        {
                            r.ReadOnly = true;
                        }
                        break;
                    case CostType.MP:
                        if (c.CurrentMana < BattleProperties.SkillList[i].CostValue)
                        {
                            r.ReadOnly = true;
                        }
                        break;
                }
                skillList.Rows.Add(r);
            }
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            NavigationControl.Views["Battle"].Visible = false;
            NavigationControl.Display("CharacterSelection");
        }

        public void FirstSetting()
        {
            SetCharacters();
            for (int i = 0; i < characterStatuses.Count; i++)
            {
                characterStatuses[i].UpdateInfo(BattleProperties.Party[i]);
            }
            enemyHPBar.Maximum = BattleProperties.Troops[0].Health;
            enemyHPBar.Value = BattleProperties.Troops[0].CurrentHealth;
            lblEnemyHP.Text = $"{BattleProperties.Troops[0].CurrentHealth.ToString()}/{BattleProperties.Troops[0].Health.ToString()}";
        }
        public void UpdateInfo()
        {
            enemyHPBar.Value = BattleProperties.Troops[0].CurrentHealth;
            lblEnemyHP.Text = $"{BattleProperties.Troops[0].CurrentHealth.ToString()}/{BattleProperties.Troops[0].Health.ToString()}";
            for (int i = 0; i < characterStatuses.Count; i++)
            {
                characterStatuses[i].UpdateInfo(BattleProperties.Party[i]);
            }
        }

        void LeaveBattle()
        {
            BattleProperties.ResetBattleProperties();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = false;
            }
            characterStatuses.Clear();
            skillList.Rows.Clear();
            skillList.Visible = true;
            txtSkillDesc.Visible = true;
            listTargets.Visible = false;
            btnCancelCast.Visible = false;
            TurnQueue.Clear();
            flowTurnsPanel.Controls.Clear();
        }

        void SetCharacters()
        {
            CharacterStatus[] ch = { characterStatus1, characterStatus2, characterStatus3, characterStatus4 };
            int range = 262 - (65 * BattleProperties.Party.Count);
            for (int i = 0; i < BattleProperties.Party.Count; i++)
            {
                pictureBoxes[i].Location = new Point(pictureBoxes[i].Location.X, range);
                pictureBoxes[i].Visible = true;
                pictureBoxes[i].Image = BattleProperties.Party[i].GetImage();
                characterStatuses.Add(ch[i]);
                range += 128;
            }
            enemySprite.Visible = true;
            enemySprite.Image = BattleProperties.Troops[0].GetImage();
            SetCharacterStatuses();
        }

        void SetCharacterStatuses()
        {
            int range = 98 - (24*characterStatuses.Count);
            for (int i = 0; i < characterStatuses.Count; i++)
            {
                characterStatuses[i].Location = new Point(characterStatuses[i].Location.X, range);
                characterStatuses[i].Visible = true;
                range += 47;
            }
        }

        public void StartSide()
        {
            if(BattleProperties.IsPlayerTurn)
            {
                for (int i = 0; i < BattleProperties.Party.Count; i++)
                {
                    BattleProperties.Turns.Add(true);
                    flowTurnsPanel.Controls.Add(CreateTurnImage(turnTrue));
                    TurnQueue.Enqueue(new KeyValuePair<PictureBox, Character>(pictureBoxes[i], BattleProperties.Party[i]));
                }
            }
            else
            {
                for (int i = 0; i < BattleProperties.Troops.Count; i++)
                {
                    BattleProperties.Turns.Add(true);
                    flowTurnsPanel.Controls.Add(CreateTurnImage(turnTrue));
                    TurnQueue.Enqueue(new KeyValuePair<PictureBox, Character>(enemySprite, BattleProperties.Troops[i]));

                }
                if (BattleProperties.Turns.Count == 1)
                {
                    BattleProperties.Turns.Add(true);
                    flowTurnsPanel.Controls.Add(CreateTurnImage(turnTrue));
                }
            }
            
            Current = TurnQueue.Dequeue();
            StartTurn(Current);
        }
        public void EndSide()
        {
            BattleProperties.IsPlayerTurn = !BattleProperties.IsPlayerTurn;
            TurnQueue.Clear();
            StartSide();
        }
        public void StartTurn(KeyValuePair<PictureBox, Character> characterInfo)
        {
            TurnQueue.Enqueue(characterInfo);
            if(BattleProperties.IsPlayerTurn)
            {
                characterInfo.Key.BorderStyle = BorderStyle.FixedSingle;
                PopulizeSkills(characterInfo.Value);
                skillList.Visible = true;
                txtSkillDesc.Visible = true;
            }
        }
        public void EndTurn()
        {
            Current.Key.BorderStyle = BorderStyle.None;
            if(BattleProperties.Turns.Count > 0)
            {
                StartTurn(TurnQueue.Dequeue());
            }
            else
            {
                EndSide();
            }
        }
        private void BattleControl_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible == true)
            {
                FirstSetting();
                StartSide();
            }
            else
            {
                LeaveBattle();
            }
        }

        private void skillList_SelectionChanged(object sender, EventArgs e)
        {
            if(skillList.SelectedRows.Count > 0)
            {
                txtSkillDesc.Text = skillList.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void skillList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            skillList.Visible = false;
            txtSkillDesc.Visible = false;
            listTargets.Visible = true;
            btnCancelCast.Visible = true;
            selectedSkill = BattleProperties.SkillList[(int)skillList.Rows[e.RowIndex].Cells[0].Value];
            FillTargets();
        }

        private void listTargets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        public void FillTargets()
        {
            listTargets.Items.Clear();
            switch(selectedSkill.Choice)
            {
                case TargetChoice.SELF:
                    listTargets.Items.Add(Current.Value);
                    break;
                case TargetChoice.ONE_PARTY:
                    foreach(Character c in BattleProperties.Party)
                    {
                        if(!c.CheckEffect(Effect.KNOCKDOWN))
                        {
                            listTargets.Items.Add(c);
                        }
                    }
                    break;
                case TargetChoice.ALL_PARTY:
                    listTargets.Items.Add("All Allies");
                    break;
                case TargetChoice.ONE_ENEMY:
                    foreach (Character c in BattleProperties.Troops)
                    {
                        listTargets.Items.Add(c);
                    }
                    break;
                case TargetChoice.ALL_ENEMY:
                    listTargets.Items.Add("All Enemies");
                    break;
            }
        }
        private void btnCancelCast_Click(object sender, EventArgs e)
        {
            skillList.Visible = true;
            txtSkillDesc.Visible = true;
            listTargets.Visible = false;
            btnCancelCast.Visible = false;
        }
    }
}
