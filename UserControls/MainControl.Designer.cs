namespace RPG_Project
{
    partial class MainControl
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
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(439, 141);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(402, 70);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(287, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(705, 73);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "RPG Simulation Project";
            // 
            // tutorialButton
            // 
            this.tutorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tutorialButton.Location = new System.Drawing.Point(439, 261);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(402, 70);
            this.tutorialButton.TabIndex = 2;
            this.tutorialButton.Text = "Basic Information";
            this.tutorialButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(439, 381);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(402, 70);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Quit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button closeButton;
    }
}
