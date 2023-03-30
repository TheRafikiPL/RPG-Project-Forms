namespace RPG_Project
{
    partial class CharacterControl
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
            this.backButton = new System.Windows.Forms.Button();
            this.characterCombo = new System.Windows.Forms.ComboBox();
            this.partySizeLabel = new System.Windows.Forms.Label();
            this.partySizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.partySizeAcceptButton = new System.Windows.Forms.Button();
            this.chooseCharacterLabel = new System.Windows.Forms.Label();
            this.partyCharacter1 = new RPG_Project.UserControls.CharacterView();
            this.partyCharacter2 = new RPG_Project.UserControls.CharacterView();
            this.partyCharacter3 = new RPG_Project.UserControls.CharacterView();
            this.partyCharacter4 = new RPG_Project.UserControls.CharacterView();
            this.enemyCharacter = new RPG_Project.UserControls.CharacterView();
            this.battleStartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partySizeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 93);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // characterCombo
            // 
            this.characterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterCombo.FormattingEnabled = true;
            this.characterCombo.Location = new System.Drawing.Point(594, 3);
            this.characterCombo.Name = "characterCombo";
            this.characterCombo.Size = new System.Drawing.Size(489, 50);
            this.characterCombo.TabIndex = 1;
            this.characterCombo.Visible = false;
            this.characterCombo.SelectedIndexChanged += new System.EventHandler(this.characterCombo_SelectedIndexChanged);
            // 
            // partySizeLabel
            // 
            this.partySizeLabel.AutoSize = true;
            this.partySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partySizeLabel.Location = new System.Drawing.Point(268, 205);
            this.partySizeLabel.Name = "partySizeLabel";
            this.partySizeLabel.Size = new System.Drawing.Size(670, 55);
            this.partySizeLabel.TabIndex = 2;
            this.partySizeLabel.Text = "Number of characters in party:";
            // 
            // partySizeNumeric
            // 
            this.partySizeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partySizeNumeric.Location = new System.Drawing.Point(944, 203);
            this.partySizeNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.partySizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partySizeNumeric.Name = "partySizeNumeric";
            this.partySizeNumeric.Size = new System.Drawing.Size(63, 62);
            this.partySizeNumeric.TabIndex = 3;
            this.partySizeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // partySizeAcceptButton
            // 
            this.partySizeAcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partySizeAcceptButton.Location = new System.Drawing.Point(537, 274);
            this.partySizeAcceptButton.Name = "partySizeAcceptButton";
            this.partySizeAcceptButton.Size = new System.Drawing.Size(256, 58);
            this.partySizeAcceptButton.TabIndex = 4;
            this.partySizeAcceptButton.Text = "Confirm";
            this.partySizeAcceptButton.UseVisualStyleBackColor = true;
            this.partySizeAcceptButton.Click += new System.EventHandler(this.partySizeAcceptButton_Click);
            // 
            // chooseCharacterLabel
            // 
            this.chooseCharacterLabel.AutoSize = true;
            this.chooseCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseCharacterLabel.Location = new System.Drawing.Point(213, 12);
            this.chooseCharacterLabel.Name = "chooseCharacterLabel";
            this.chooseCharacterLabel.Size = new System.Drawing.Size(375, 37);
            this.chooseCharacterLabel.TabIndex = 5;
            this.chooseCharacterLabel.Text = "Choose character to edit:";
            this.chooseCharacterLabel.Visible = false;
            // 
            // partyCharacter1
            // 
            this.partyCharacter1.AutoSize = true;
            this.partyCharacter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyCharacter1.Location = new System.Drawing.Point(278, 153);
            this.partyCharacter1.Name = "partyCharacter1";
            this.partyCharacter1.Size = new System.Drawing.Size(700, 289);
            this.partyCharacter1.TabIndex = 6;
            this.partyCharacter1.Visible = false;
            // 
            // partyCharacter2
            // 
            this.partyCharacter2.AutoSize = true;
            this.partyCharacter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyCharacter2.Location = new System.Drawing.Point(278, 153);
            this.partyCharacter2.Name = "partyCharacter2";
            this.partyCharacter2.Size = new System.Drawing.Size(700, 289);
            this.partyCharacter2.TabIndex = 7;
            this.partyCharacter2.Visible = false;
            // 
            // partyCharacter3
            // 
            this.partyCharacter3.AutoSize = true;
            this.partyCharacter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyCharacter3.Location = new System.Drawing.Point(278, 153);
            this.partyCharacter3.Name = "partyCharacter3";
            this.partyCharacter3.Size = new System.Drawing.Size(700, 289);
            this.partyCharacter3.TabIndex = 8;
            this.partyCharacter3.Visible = false;
            // 
            // partyCharacter4
            // 
            this.partyCharacter4.AutoSize = true;
            this.partyCharacter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyCharacter4.Location = new System.Drawing.Point(278, 153);
            this.partyCharacter4.Name = "partyCharacter4";
            this.partyCharacter4.Size = new System.Drawing.Size(700, 289);
            this.partyCharacter4.TabIndex = 9;
            this.partyCharacter4.Visible = false;
            // 
            // enemyCharacter
            // 
            this.enemyCharacter.AutoSize = true;
            this.enemyCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyCharacter.Location = new System.Drawing.Point(278, 153);
            this.enemyCharacter.Name = "enemyCharacter";
            this.enemyCharacter.Size = new System.Drawing.Size(700, 289);
            this.enemyCharacter.TabIndex = 10;
            this.enemyCharacter.Visible = false;
            // 
            // battleStartButton
            // 
            this.battleStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.battleStartButton.Location = new System.Drawing.Point(944, 616);
            this.battleStartButton.Name = "battleStartButton";
            this.battleStartButton.Size = new System.Drawing.Size(324, 86);
            this.battleStartButton.TabIndex = 11;
            this.battleStartButton.Text = "Start Battle";
            this.battleStartButton.UseVisualStyleBackColor = true;
            this.battleStartButton.Visible = false;
            this.battleStartButton.Click += new System.EventHandler(this.battleStartButton_Click);
            // 
            // CharacterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.battleStartButton);
            this.Controls.Add(this.enemyCharacter);
            this.Controls.Add(this.partyCharacter4);
            this.Controls.Add(this.partyCharacter3);
            this.Controls.Add(this.partyCharacter2);
            this.Controls.Add(this.partyCharacter1);
            this.Controls.Add(this.chooseCharacterLabel);
            this.Controls.Add(this.partySizeAcceptButton);
            this.Controls.Add(this.partySizeNumeric);
            this.Controls.Add(this.partySizeLabel);
            this.Controls.Add(this.characterCombo);
            this.Controls.Add(this.backButton);
            this.Name = "CharacterControl";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.partySizeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox characterCombo;
        private System.Windows.Forms.Label partySizeLabel;
        private System.Windows.Forms.NumericUpDown partySizeNumeric;
        private System.Windows.Forms.Button partySizeAcceptButton;
        private System.Windows.Forms.Label chooseCharacterLabel;
        private UserControls.CharacterView partyCharacter1;
        private UserControls.CharacterView partyCharacter2;
        private UserControls.CharacterView partyCharacter3;
        private UserControls.CharacterView partyCharacter4;
        private UserControls.CharacterView enemyCharacter;
        private System.Windows.Forms.Button battleStartButton;
    }
}
