namespace RPG_Project.UserControls
{
    partial class BattleLog
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
            this.Log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(0, 0);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(181, 122);
            this.Log.TabIndex = 0;
            this.Log.Text = "";
            // 
            // BattleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Log);
            this.Name = "BattleLog";
            this.Size = new System.Drawing.Size(181, 122);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Log;
    }
}
