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
        bool battleOn;
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
                if (BattleProperties.SkillList[i].CheckIfAvailable(c))
                {
                    r.CreateCells(skillList, i, BattleProperties.SkillList[i].Description, BattleProperties.SkillList[i].Name, BattleProperties.SkillList[i].CostString, BattleProperties.SkillList[i].AffinityImage, true);
                }
                else
                {
                    r.CreateCells(skillList, i, BattleProperties.SkillList[i].Description, BattleProperties.SkillList[i].Name, BattleProperties.SkillList[i].CostString, BattleProperties.SkillList[i].AffinityImage, false);
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
            battleOn = true;
            SetCharacters();
            Boss_AI.SetTestPropabilities(BattleProperties.Troops[0].Skills.Count);
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
                if(BattleProperties.Party[i].CheckEffect(Effect.KNOCKDOWN))
                {
                    characterStatuses[i].MenImDead();
                }
            }
        }

        void LeaveBattle()
        {
            battleOn = true;
            BattleProperties.ResetBattleProperties();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = false;
                pictureBox.BorderStyle = BorderStyle.None;
            }
            characterStatuses.Clear();
            skillList.Rows.Clear();
            skillList.Visible = true;
            txtSkillDesc.Visible = true;
            listTargets.Visible = false;
            btnCancelCast.Visible = false;
            TurnQueue.Clear();
            lblWinLose.Text = "";
            battleLog.Clear();
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
        public void SortCharacterList(List<KeyValuePair<PictureBox,Character>> temp)
        {
            for (int i = 0; i < temp.Count-1; i++)
            {
                for (int j = i+1; j < temp.Count; j++)
                {
                    if (temp[i].Value < temp[j].Value)
                    {
                        (temp[i], temp[j]) = (temp[j], temp[i]);
                    }
                }
            }
        }
        public void FillTurnsPanel()
        {
            flowTurnsPanel.Controls.Clear();
            foreach(bool b in BattleProperties.Turns)
            {
                if(b)
                {
                    flowTurnsPanel.Controls.Add(CreateTurnImage(turnTrue));
                }
                else
                {
                    flowTurnsPanel.Controls.Add(CreateTurnImage(turnFalse));
                }
            }
        }
        public void StartSide()
        {
            List<KeyValuePair<PictureBox, Character>> temp = new List<KeyValuePair<PictureBox, Character>>();
            if(BattleProperties.IsPlayerTurn)
            {
                for (int i = 0; i < BattleProperties.Party.Count; i++)
                {
                    if(!BattleProperties.Party[i].CheckEffect(Effect.KNOCKDOWN))
                    {
                        BattleProperties.Turns.Add(true);
                        temp.Add(new KeyValuePair<PictureBox, Character>(pictureBoxes[i], BattleProperties.Party[i]));
                    }
                }
            }
            else
            {
                for (int i = 0; i < BattleProperties.Troops.Count; i++)
                {
                    BattleProperties.Turns.Add(true);
                    temp.Add(new KeyValuePair<PictureBox, Character>(enemySprite, BattleProperties.Troops[i]));
                }
                if (BattleProperties.Turns.Count == 1)
                {
                    BattleProperties.Turns.Add(true);
                }
            }
            FillTurnsPanel();
            SortCharacterList(temp);
            foreach(KeyValuePair<PictureBox,Character> k in temp)
            {
                TurnQueue.Enqueue(k);
            }
            Current = TurnQueue.Dequeue();
            StartTurn();
        }
        public void EndSide()
        {
            battleLog.Write("================================================", Color.Black);
            BattleProperties.IsPlayerTurn = !BattleProperties.IsPlayerTurn;
            TurnQueue.Clear();
            StartSide();
        }
        public void StartTurn()
        {
            if (!battleOn)
            {
                return;
            } 
            TurnQueue.Enqueue(Current);
            foreach(PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
            enemySprite.BorderStyle = BorderStyle.None;
            Current.Key.BorderStyle = BorderStyle.FixedSingle;
            if (BattleProperties.IsPlayerTurn)
            {
                PopulizeSkills(Current.Value);
                skillList.Visible = true;
                txtSkillDesc.Visible = true;
            }
            else
            {
                int skillIndex = Boss_AI.ChooseSkill();
                selectedSkill = BattleProperties.SkillList[BattleProperties.Troops[0].Skills[skillIndex]];
                AI_Actions();
            }
        }
        public void CheckLose()
        {
            foreach(Character c in BattleProperties.Party)
            {
                if(!c.CheckEffect(Effect.KNOCKDOWN))
                {
                    return;
                }
            }
            lblWinLose.Text = "DEFEAT";
            battleOn = false;

        }
        public void CheckWin()
        {
            for (int i = 0; i < BattleProperties.Troops.Count; i++)
            {
                if (BattleProperties.Troops[i].CheckEffect(Effect.KNOCKDOWN))
                {
                    BattleProperties.Troops.RemoveAt(i);
                    enemySprite.Visible = false;        //not eleganto
                }
            }
            foreach (Character c in BattleProperties.Troops)
            {
                if (c.CheckEffect(Effect.KNOCKDOWN))
                {
                    BattleProperties.Troops.Remove(c);
                    enemySprite.Visible = false;        //not eleganto
                }
            }
            if (BattleProperties.Troops.Count<1)
            {
                lblWinLose.Text = "VICTORY";
                battleOn = false;
            }
        }
        public void EndTurn()
        {
            UpdateInfo();
            CheckLose();
            CheckWin();
            if(BattleProperties.Turns.Count > 0)
            {
                Current = TurnQueue.Dequeue();
                StartTurn();
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
                if(!(bool)skillList.SelectedRows[0].Cells[5].Value)
                {
                    txtSkillDesc.Text += "\tNOT AVAILABLE";
                }
            }
        }

        private void skillList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if((bool)skillList.Rows[e.RowIndex].Cells[5].Value)
            {
                skillList.Visible = false;
                txtSkillDesc.Visible = false;
                listTargets.Visible = true;
                btnCancelCast.Visible = true;
                selectedSkill = BattleProperties.SkillList[(int)skillList.Rows[e.RowIndex].Cells[0].Value];
                FillTargets();
            }
        }
        public AffinityRelation CheckAffinityRelations(List<AffinityRelation> list)
        {
            AffinityRelation af = AffinityRelation.NEUTRAL;
            if(list.Contains(AffinityRelation.WEAK))
            {
                af = AffinityRelation.WEAK;
            }
            if (list.Contains(AffinityRelation.NULL))
            {
                af = AffinityRelation.NULL;
            }
            if (list.Contains(AffinityRelation.REPEL)||list.Contains(AffinityRelation.ABSORB))
            {
                af = AffinityRelation.REPEL;
            }
            return af;
        }
        private void listTargets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listTargets.SelectedItems.Count<1)
            {
                return;
            }
            if(selectedSkill.DmgType==Affinity.NONE)
            {
                BattleProperties.CalculateTurns(AffinityRelation.NEUTRAL);
                FillTurnsPanel();
                EndTurn();
                return;
            }
            listTargets.Visible = false;
            btnCancelCast.Visible = false;
            List<AffinityRelation> list = new List<AffinityRelation>();
            battleLog.Write($"{Current.Value} uses {selectedSkill.Name}", Color.Blue);
            if (listTargets.SelectedItems[0].GetType()==typeof(Character))
            {
                SkillActivation((Character)listTargets.SelectedItems[0], ref list);
            }
            else
            {
                if((string)listTargets.SelectedItems[0]=="All Enemies")
                {
                    foreach(Character c in BattleProperties.Troops)
                    {
                        SkillActivation(c, ref list);
                    }
                }
                else
                {
                    foreach (Character c in BattleProperties.Party)
                    {
                        SkillActivation(c, ref list);
                    }
                }
            }
            BattleProperties.CalculateTurns(CheckAffinityRelations(list));
            FillTurnsPanel();
            EndTurn();
        }
        public void SkillActivation(Character target, ref List<AffinityRelation> list, int damage=0, bool repeled=false)
        {
            if(!repeled)
            {
                if (selectedSkill.CostType == CostType.HP)
                {
                    if (BattleProperties.Party.Contains(Current.Value))
                        Current.Value.SubHP((int)Math.Ceiling(selectedSkill.CostValue / 100.0 * Current.Value.Health));
                }
                else if (selectedSkill.CostType == CostType.MP)
                {
                    Current.Value.SubMana(selectedSkill.CostValue);
                }
            }
            if(damage==0)
            {
                damage = selectedSkill.CalculateDamage(Current.Value, target);
            }
            switch(target.CheckAffinityRelation(selectedSkill.DmgType))
            {
                case AffinityRelation.WEAK:
                    damage = Convert.ToInt32(damage * 1.2);
                    target.SubHP(damage);
                    list.Add(AffinityRelation.WEAK);
                    battleLog.Write($"{Current.Value} deals {damage} damage to {target}. It's super effective.", Color.Red);
                    break;
                case AffinityRelation.STRONG:
                    damage = Convert.ToInt32(damage * 0.8);
                    target.SubHP(damage);
                    list.Add(AffinityRelation.STRONG);
                    battleLog.Write($"{Current.Value} deals {damage} damage to {target}. It's not very effective.", Color.Gray);
                    break;
                case AffinityRelation.NULL:
                    list.Add(AffinityRelation.NULL);
                    battleLog.Write($"{target} nullified damage.", Color.Black);
                    break;
                case AffinityRelation.REPEL:
                    if(!repeled)
                    {
                        list.Add(AffinityRelation.REPEL);
                        battleLog.Write($"{target} repels {damage} damage to {Current.Value}.", Color.Black);
                        SkillActivation(Current.Value, ref list, damage, true);
                    }
                    else
                    {
                        battleLog.Write($"{target} blocked repeled damage.", Color.Black);
                    }
                    break;
                case AffinityRelation.ABSORB:
                    target.AddHP(damage);
                    list.Add(AffinityRelation.ABSORB);
                    battleLog.Write($"{target} absorbed {damage} damage.", Color.Green);
                    break;
                case AffinityRelation.NEUTRAL:
                    battleLog.Write($"{Current.Value} deals {damage} damage to {target}.", Color.Black);
                    target.SubHP(damage);
                    break;
            }
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
        public void AI_Actions()
        {
            if (selectedSkill.DmgType == Affinity.NONE)
            {
                BattleProperties.CalculateTurns(AffinityRelation.NEUTRAL);
                FillTurnsPanel();
                EndTurn();
                return;
            }
            List<AffinityRelation> list = new List<AffinityRelation>();
            battleLog.Write($"{Current.Value} uses {selectedSkill.Name}", Color.Blue);
            switch (selectedSkill.Choice)
            {
                case TargetChoice.SELF:
                    Boss_AI.targets.Add(Current.Value);
                    break;
                case TargetChoice.ONE_PARTY:
                    Boss_AI.targets.Add(BattleProperties.Troops[Boss_AI.ChooseAlly()]);
                    break;
                case TargetChoice.ALL_PARTY:
                    foreach (Character c in BattleProperties.Troops)
                    {
                        Boss_AI.targets.Add(c);
                    }
                    break;
                case TargetChoice.ONE_ENEMY:
                    Boss_AI.targets.Add(BattleProperties.Party[Boss_AI.ChooseEnemy()]);
                    break;
                case TargetChoice.ALL_ENEMY:
                    foreach(Character c in BattleProperties.Party)
                    {
                        Boss_AI.targets.Add(c);
                    }
                    break;
            }
            foreach (Character c in Boss_AI.targets)
            {
                SkillActivation(c, ref list);
            }
            Boss_AI.targets.Clear();
            BattleProperties.CalculateTurns(CheckAffinityRelations(list));
            FillTurnsPanel();
            EndTurn();
        }
    }
}
