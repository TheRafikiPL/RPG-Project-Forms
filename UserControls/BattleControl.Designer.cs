namespace RPG_Project
{
    partial class BattleControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.leaveButton = new System.Windows.Forms.Button();
            this.battlePanel = new System.Windows.Forms.Panel();
            this.flowTurnsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.enemyHPBar = new System.Windows.Forms.ProgressBar();
            this.enemySprite = new System.Windows.Forms.PictureBox();
            this.partySprite4 = new System.Windows.Forms.PictureBox();
            this.partySprite3 = new System.Windows.Forms.PictureBox();
            this.partySprite2 = new System.Windows.Forms.PictureBox();
            this.partySprite1 = new System.Windows.Forms.PictureBox();
            this.battleUIPanel = new System.Windows.Forms.Panel();
            this.battleLog = new RPG_Project.UserControls.BattleLog();
            this.btnCancelCast = new System.Windows.Forms.Button();
            this.listTargets = new System.Windows.Forms.ListBox();
            this.txtSkillDesc = new System.Windows.Forms.TextBox();
            this.characterStatus4 = new RPG_Project.UserControls.CharacterStatus();
            this.characterStatus3 = new RPG_Project.UserControls.CharacterStatus();
            this.characterStatus2 = new RPG_Project.UserControls.CharacterStatus();
            this.characterStatus1 = new RPG_Project.UserControls.CharacterStatus();
            this.skillList = new System.Windows.Forms.DataGridView();
            this.skillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillAffinity = new System.Windows.Forms.DataGridViewImageColumn();
            this.battlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemySprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite1)).BeginInit();
            this.battleUIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillList)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveButton
            // 
            this.leaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaveButton.Location = new System.Drawing.Point(537, 3);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(205, 52);
            this.leaveButton.TabIndex = 0;
            this.leaveButton.Text = "Leave Battle";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // battlePanel
            // 
            this.battlePanel.Controls.Add(this.flowTurnsPanel);
            this.battlePanel.Controls.Add(this.lblEnemyHP);
            this.battlePanel.Controls.Add(this.enemyHPBar);
            this.battlePanel.Controls.Add(this.enemySprite);
            this.battlePanel.Controls.Add(this.partySprite4);
            this.battlePanel.Controls.Add(this.partySprite3);
            this.battlePanel.Controls.Add(this.partySprite2);
            this.battlePanel.Controls.Add(this.partySprite1);
            this.battlePanel.Controls.Add(this.leaveButton);
            this.battlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.battlePanel.Location = new System.Drawing.Point(0, 0);
            this.battlePanel.Name = "battlePanel";
            this.battlePanel.Size = new System.Drawing.Size(1280, 522);
            this.battlePanel.TabIndex = 1;
            // 
            // flowTurnsPanel
            // 
            this.flowTurnsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowTurnsPanel.Location = new System.Drawing.Point(776, 3);
            this.flowTurnsPanel.Name = "flowTurnsPanel";
            this.flowTurnsPanel.Size = new System.Drawing.Size(501, 52);
            this.flowTurnsPanel.TabIndex = 8;
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Location = new System.Drawing.Point(1172, 344);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(48, 13);
            this.lblEnemyHP.TabIndex = 7;
            this.lblEnemyHP.Text = "100/100";
            // 
            // enemyHPBar
            // 
            this.enemyHPBar.Location = new System.Drawing.Point(1134, 331);
            this.enemyHPBar.Name = "enemyHPBar";
            this.enemyHPBar.Size = new System.Drawing.Size(128, 10);
            this.enemyHPBar.Step = 1;
            this.enemyHPBar.TabIndex = 6;
            // 
            // enemySprite
            // 
            this.enemySprite.Location = new System.Drawing.Point(1134, 197);
            this.enemySprite.Name = "enemySprite";
            this.enemySprite.Size = new System.Drawing.Size(128, 128);
            this.enemySprite.TabIndex = 5;
            this.enemySprite.TabStop = false;
            this.enemySprite.Visible = false;
            // 
            // partySprite4
            // 
            this.partySprite4.Location = new System.Drawing.Point(23, 392);
            this.partySprite4.Name = "partySprite4";
            this.partySprite4.Size = new System.Drawing.Size(128, 128);
            this.partySprite4.TabIndex = 4;
            this.partySprite4.TabStop = false;
            this.partySprite4.Visible = false;
            // 
            // partySprite3
            // 
            this.partySprite3.Location = new System.Drawing.Point(23, 262);
            this.partySprite3.Name = "partySprite3";
            this.partySprite3.Size = new System.Drawing.Size(128, 128);
            this.partySprite3.TabIndex = 3;
            this.partySprite3.TabStop = false;
            this.partySprite3.Visible = false;
            // 
            // partySprite2
            // 
            this.partySprite2.Location = new System.Drawing.Point(23, 132);
            this.partySprite2.Name = "partySprite2";
            this.partySprite2.Size = new System.Drawing.Size(128, 128);
            this.partySprite2.TabIndex = 2;
            this.partySprite2.TabStop = false;
            this.partySprite2.Visible = false;
            // 
            // partySprite1
            // 
            this.partySprite1.Location = new System.Drawing.Point(23, 2);
            this.partySprite1.Name = "partySprite1";
            this.partySprite1.Size = new System.Drawing.Size(128, 128);
            this.partySprite1.TabIndex = 1;
            this.partySprite1.TabStop = false;
            this.partySprite1.Visible = false;
            // 
            // battleUIPanel
            // 
            this.battleUIPanel.Controls.Add(this.battleLog);
            this.battleUIPanel.Controls.Add(this.btnCancelCast);
            this.battleUIPanel.Controls.Add(this.txtSkillDesc);
            this.battleUIPanel.Controls.Add(this.characterStatus4);
            this.battleUIPanel.Controls.Add(this.characterStatus3);
            this.battleUIPanel.Controls.Add(this.characterStatus2);
            this.battleUIPanel.Controls.Add(this.characterStatus1);
            this.battleUIPanel.Controls.Add(this.skillList);
            this.battleUIPanel.Controls.Add(this.listTargets);
            this.battleUIPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.battleUIPanel.Location = new System.Drawing.Point(0, 522);
            this.battleUIPanel.Name = "battleUIPanel";
            this.battleUIPanel.Size = new System.Drawing.Size(1280, 198);
            this.battleUIPanel.TabIndex = 2;
            // 
            // battleLog
            // 
            this.battleLog.Location = new System.Drawing.Point(424, 3);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(346, 187);
            this.battleLog.TabIndex = 8;
            // 
            // btnCancelCast
            // 
            this.btnCancelCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelCast.Location = new System.Drawing.Point(262, 73);
            this.btnCancelCast.Name = "btnCancelCast";
            this.btnCancelCast.Size = new System.Drawing.Size(104, 39);
            this.btnCancelCast.TabIndex = 7;
            this.btnCancelCast.Text = "Cancel";
            this.btnCancelCast.UseVisualStyleBackColor = true;
            this.btnCancelCast.Visible = false;
            this.btnCancelCast.Click += new System.EventHandler(this.btnCancelCast_Click);
            // 
            // listTargets
            // 
            this.listTargets.FormattingEnabled = true;
            this.listTargets.Location = new System.Drawing.Point(3, 0);
            this.listTargets.Name = "listTargets";
            this.listTargets.Size = new System.Drawing.Size(209, 199);
            this.listTargets.TabIndex = 6;
            this.listTargets.Visible = false;
            this.listTargets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listTargets_MouseDoubleClick);
            // 
            // txtSkillDesc
            // 
            this.txtSkillDesc.Location = new System.Drawing.Point(215, 3);
            this.txtSkillDesc.Multiline = true;
            this.txtSkillDesc.Name = "txtSkillDesc";
            this.txtSkillDesc.ReadOnly = true;
            this.txtSkillDesc.Size = new System.Drawing.Size(203, 187);
            this.txtSkillDesc.TabIndex = 5;
            this.txtSkillDesc.Visible = false;
            // 
            // characterStatus4
            // 
            this.characterStatus4.Location = new System.Drawing.Point(776, 147);
            this.characterStatus4.Name = "characterStatus4";
            this.characterStatus4.Size = new System.Drawing.Size(501, 47);
            this.characterStatus4.TabIndex = 4;
            this.characterStatus4.Visible = false;
            // 
            // characterStatus3
            // 
            this.characterStatus3.Location = new System.Drawing.Point(776, 98);
            this.characterStatus3.Name = "characterStatus3";
            this.characterStatus3.Size = new System.Drawing.Size(501, 47);
            this.characterStatus3.TabIndex = 3;
            this.characterStatus3.Visible = false;
            // 
            // characterStatus2
            // 
            this.characterStatus2.Location = new System.Drawing.Point(776, 51);
            this.characterStatus2.Name = "characterStatus2";
            this.characterStatus2.Size = new System.Drawing.Size(501, 47);
            this.characterStatus2.TabIndex = 2;
            this.characterStatus2.Visible = false;
            // 
            // characterStatus1
            // 
            this.characterStatus1.Location = new System.Drawing.Point(776, 2);
            this.characterStatus1.Name = "characterStatus1";
            this.characterStatus1.Size = new System.Drawing.Size(501, 47);
            this.characterStatus1.TabIndex = 1;
            this.characterStatus1.Visible = false;
            // 
            // skillList
            // 
            this.skillList.AllowUserToAddRows = false;
            this.skillList.AllowUserToDeleteRows = false;
            this.skillList.AllowUserToResizeColumns = false;
            this.skillList.AllowUserToResizeRows = false;
            this.skillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.skillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillId,
            this.skillDescription,
            this.skillName,
            this.skillCost,
            this.skillAffinity});
            this.skillList.Location = new System.Drawing.Point(0, 0);
            this.skillList.Name = "skillList";
            this.skillList.RowHeadersVisible = false;
            this.skillList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.skillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skillList.Size = new System.Drawing.Size(209, 198);
            this.skillList.TabIndex = 0;
            this.skillList.Visible = false;
            this.skillList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.skillList_CellMouseDoubleClick);
            this.skillList.SelectionChanged += new System.EventHandler(this.skillList_SelectionChanged);
            // 
            // skillId
            // 
            this.skillId.HeaderText = "Id";
            this.skillId.Name = "skillId";
            this.skillId.ReadOnly = true;
            this.skillId.Visible = false;
            this.skillId.Width = 22;
            // 
            // skillDescription
            // 
            this.skillDescription.HeaderText = "Description";
            this.skillDescription.Name = "skillDescription";
            this.skillDescription.ReadOnly = true;
            this.skillDescription.Visible = false;
            this.skillDescription.Width = 66;
            // 
            // skillName
            // 
            this.skillName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skillName.HeaderText = "Name";
            this.skillName.Name = "skillName";
            this.skillName.ReadOnly = true;
            // 
            // skillCost
            // 
            this.skillCost.HeaderText = "Cost";
            this.skillCost.Name = "skillCost";
            this.skillCost.ReadOnly = true;
            this.skillCost.Width = 53;
            // 
            // skillAffinity
            // 
            this.skillAffinity.HeaderText = "Affinity";
            this.skillAffinity.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.skillAffinity.Name = "skillAffinity";
            this.skillAffinity.ReadOnly = true;
            this.skillAffinity.Width = 44;
            // 
            // BattleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.battleUIPanel);
            this.Controls.Add(this.battlePanel);
            this.Name = "BattleControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.VisibleChanged += new System.EventHandler(this.BattleControl_VisibleChanged);
            this.battlePanel.ResumeLayout(false);
            this.battlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemySprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySprite1)).EndInit();
            this.battleUIPanel.ResumeLayout(false);
            this.battleUIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Panel battlePanel;
        private System.Windows.Forms.Panel battleUIPanel;
        private System.Windows.Forms.PictureBox partySprite1;
        private System.Windows.Forms.PictureBox partySprite4;
        private System.Windows.Forms.PictureBox partySprite3;
        private System.Windows.Forms.PictureBox partySprite2;
        private System.Windows.Forms.PictureBox enemySprite;
        private System.Windows.Forms.DataGridView skillList;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillCost;
        private System.Windows.Forms.DataGridViewImageColumn skillAffinity;
        private UserControls.CharacterStatus characterStatus4;
        private UserControls.CharacterStatus characterStatus3;
        private UserControls.CharacterStatus characterStatus2;
        private UserControls.CharacterStatus characterStatus1;
        private System.Windows.Forms.TextBox txtSkillDesc;
        private System.Windows.Forms.ProgressBar enemyHPBar;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.ListBox listTargets;
        private System.Windows.Forms.Button btnCancelCast;
        private System.Windows.Forms.FlowLayoutPanel flowTurnsPanel;
        private UserControls.BattleLog battleLog;
    }
}
