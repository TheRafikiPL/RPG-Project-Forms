namespace RPG_Project.UserControls
{
    partial class CharacterStatus
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
            this.lblName = new System.Windows.Forms.Label();
            this.barHP = new System.Windows.Forms.ProgressBar();
            this.barMP = new System.Windows.Forms.ProgressBar();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.effectsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(263, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "PlaceholderNamePlaceholder";
            // 
            // barHP
            // 
            this.barHP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barHP.Location = new System.Drawing.Point(280, 26);
            this.barHP.Name = "barHP";
            this.barHP.Size = new System.Drawing.Size(100, 10);
            this.barHP.Step = 1;
            this.barHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHP.TabIndex = 1;
            // 
            // barMP
            // 
            this.barMP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barMP.ForeColor = System.Drawing.Color.Cyan;
            this.barMP.Location = new System.Drawing.Point(398, 26);
            this.barMP.Name = "barMP";
            this.barMP.Size = new System.Drawing.Size(100, 10);
            this.barMP.Step = 1;
            this.barMP.TabIndex = 2;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(302, 7);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(54, 13);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "0/100 HP";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(421, 7);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(55, 13);
            this.lblMP.TabIndex = 4;
            this.lblMP.Text = "0/100 MP";
            // 
            // effectsLabel
            // 
            this.effectsLabel.AutoSize = true;
            this.effectsLabel.Location = new System.Drawing.Point(4, 31);
            this.effectsLabel.Name = "effectsLabel";
            this.effectsLabel.Size = new System.Drawing.Size(0, 13);
            this.effectsLabel.TabIndex = 5;
            // 
            // CharacterStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.effectsLabel);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.barMP);
            this.Controls.Add(this.barHP);
            this.Controls.Add(this.lblName);
            this.Name = "CharacterStatus";
            this.Size = new System.Drawing.Size(501, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar barHP;
        private System.Windows.Forms.ProgressBar barMP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label effectsLabel;
    }
}
