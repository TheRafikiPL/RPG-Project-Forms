namespace RPG_Project.UserControls
{
    partial class CharacterView
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpValue = new System.Windows.Forms.NumericUpDown();
            this.mpValue = new System.Windows.Forms.NumericUpDown();
            this.mpLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.affinityCombo7 = new System.Windows.Forms.ComboBox();
            this.affinityCombo6 = new System.Windows.Forms.ComboBox();
            this.affinityCombo5 = new System.Windows.Forms.ComboBox();
            this.affinityCombo4 = new System.Windows.Forms.ComboBox();
            this.affinityCombo3 = new System.Windows.Forms.ComboBox();
            this.affinityCombo2 = new System.Windows.Forms.ComboBox();
            this.affinityCombo1 = new System.Windows.Forms.ComboBox();
            this.affinityPicture7 = new System.Windows.Forms.PictureBox();
            this.affinityPicture6 = new System.Windows.Forms.PictureBox();
            this.affinityPicture5 = new System.Windows.Forms.PictureBox();
            this.affinityPicture4 = new System.Windows.Forms.PictureBox();
            this.affinityPicture3 = new System.Windows.Forms.PictureBox();
            this.affinityPicture1 = new System.Windows.Forms.PictureBox();
            this.affinityPicture2 = new System.Windows.Forms.PictureBox();
            this.strValue = new System.Windows.Forms.NumericUpDown();
            this.strLabel = new System.Windows.Forms.Label();
            this.mgValue = new System.Windows.Forms.NumericUpDown();
            this.mgLabel = new System.Windows.Forms.Label();
            this.dexValue = new System.Windows.Forms.NumericUpDown();
            this.dexLabel = new System.Windows.Forms.Label();
            this.agiValue = new System.Windows.Forms.NumericUpDown();
            this.agiLabel = new System.Windows.Forms.Label();
            this.lucValue = new System.Windows.Forms.NumericUpDown();
            this.lucLabel = new System.Windows.Forms.Label();
            this.characterArt = new System.Windows.Forms.PictureBox();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.skillDataGrid = new System.Windows.Forms.DataGridView();
            this.isHaving = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.skillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillAffinity = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.hpValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpValue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agiValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(137, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(202, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpLabel.Location = new System.Drawing.Point(137, 37);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(39, 20);
            this.hpLabel.TabIndex = 3;
            this.hpLabel.Text = "HP: ";
            // 
            // hpValue
            // 
            this.hpValue.AutoSize = true;
            this.hpValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpValue.Location = new System.Drawing.Point(202, 35);
            this.hpValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.hpValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hpValue.Name = "hpValue";
            this.hpValue.Size = new System.Drawing.Size(100, 26);
            this.hpValue.TabIndex = 4;
            this.hpValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mpValue
            // 
            this.mpValue.AutoSize = true;
            this.mpValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpValue.Location = new System.Drawing.Point(202, 64);
            this.mpValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.mpValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mpValue.Name = "mpValue";
            this.mpValue.Size = new System.Drawing.Size(100, 26);
            this.mpValue.TabIndex = 6;
            this.mpValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mpLabel
            // 
            this.mpLabel.AutoSize = true;
            this.mpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mpLabel.Location = new System.Drawing.Point(137, 66);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(40, 20);
            this.mpLabel.TabIndex = 5;
            this.mpLabel.Text = "MP: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo7, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityCombo1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.affinityPicture2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(308, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 85);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // affinityCombo7
            // 
            this.affinityCombo7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo7.FormattingEnabled = true;
            this.affinityCombo7.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo7.Location = new System.Drawing.Point(334, 59);
            this.affinityCombo7.Name = "affinityCombo7";
            this.affinityCombo7.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo7.TabIndex = 14;
            // 
            // affinityCombo6
            // 
            this.affinityCombo6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo6.FormattingEnabled = true;
            this.affinityCombo6.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo6.Location = new System.Drawing.Point(279, 59);
            this.affinityCombo6.Name = "affinityCombo6";
            this.affinityCombo6.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo6.TabIndex = 13;
            // 
            // affinityCombo5
            // 
            this.affinityCombo5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo5.FormattingEnabled = true;
            this.affinityCombo5.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo5.Location = new System.Drawing.Point(224, 59);
            this.affinityCombo5.Name = "affinityCombo5";
            this.affinityCombo5.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo5.TabIndex = 12;
            // 
            // affinityCombo4
            // 
            this.affinityCombo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo4.FormattingEnabled = true;
            this.affinityCombo4.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo4.Location = new System.Drawing.Point(169, 59);
            this.affinityCombo4.Name = "affinityCombo4";
            this.affinityCombo4.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo4.TabIndex = 11;
            // 
            // affinityCombo3
            // 
            this.affinityCombo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo3.FormattingEnabled = true;
            this.affinityCombo3.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo3.Location = new System.Drawing.Point(114, 59);
            this.affinityCombo3.Name = "affinityCombo3";
            this.affinityCombo3.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo3.TabIndex = 10;
            // 
            // affinityCombo2
            // 
            this.affinityCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo2.FormattingEnabled = true;
            this.affinityCombo2.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo2.Location = new System.Drawing.Point(59, 59);
            this.affinityCombo2.Name = "affinityCombo2";
            this.affinityCombo2.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo2.TabIndex = 9;
            // 
            // affinityCombo1
            // 
            this.affinityCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.affinityCombo1.FormattingEnabled = true;
            this.affinityCombo1.Items.AddRange(new object[] {
            "-",
            "Wk",
            "Str",
            "Nu",
            "Rep",
            "Abs"});
            this.affinityCombo1.Location = new System.Drawing.Point(4, 59);
            this.affinityCombo1.Name = "affinityCombo1";
            this.affinityCombo1.Size = new System.Drawing.Size(47, 21);
            this.affinityCombo1.TabIndex = 8;
            // 
            // affinityPicture7
            // 
            this.affinityPicture7.Image = global::RPG_Project.Properties.Resources.darkPlaceholder;
            this.affinityPicture7.Location = new System.Drawing.Point(334, 4);
            this.affinityPicture7.Name = "affinityPicture7";
            this.affinityPicture7.Size = new System.Drawing.Size(48, 48);
            this.affinityPicture7.TabIndex = 6;
            this.affinityPicture7.TabStop = false;
            // 
            // affinityPicture6
            // 
            this.affinityPicture6.Image = global::RPG_Project.Properties.Resources.lightPlaceholder;
            this.affinityPicture6.Location = new System.Drawing.Point(279, 4);
            this.affinityPicture6.Name = "affinityPicture6";
            this.affinityPicture6.Size = new System.Drawing.Size(47, 48);
            this.affinityPicture6.TabIndex = 5;
            this.affinityPicture6.TabStop = false;
            // 
            // affinityPicture5
            // 
            this.affinityPicture5.Image = global::RPG_Project.Properties.Resources.elecPlaceholder;
            this.affinityPicture5.Location = new System.Drawing.Point(224, 4);
            this.affinityPicture5.Name = "affinityPicture5";
            this.affinityPicture5.Size = new System.Drawing.Size(47, 48);
            this.affinityPicture5.TabIndex = 4;
            this.affinityPicture5.TabStop = false;
            // 
            // affinityPicture4
            // 
            this.affinityPicture4.Image = global::RPG_Project.Properties.Resources.windPlaceholder;
            this.affinityPicture4.Location = new System.Drawing.Point(169, 4);
            this.affinityPicture4.Name = "affinityPicture4";
            this.affinityPicture4.Size = new System.Drawing.Size(47, 48);
            this.affinityPicture4.TabIndex = 3;
            this.affinityPicture4.TabStop = false;
            // 
            // affinityPicture3
            // 
            this.affinityPicture3.Image = global::RPG_Project.Properties.Resources.icePlaceholder;
            this.affinityPicture3.Location = new System.Drawing.Point(114, 4);
            this.affinityPicture3.Name = "affinityPicture3";
            this.affinityPicture3.Size = new System.Drawing.Size(47, 48);
            this.affinityPicture3.TabIndex = 2;
            this.affinityPicture3.TabStop = false;
            // 
            // affinityPicture1
            // 
            this.affinityPicture1.Image = global::RPG_Project.Properties.Resources.physicalPlaceholder;
            this.affinityPicture1.Location = new System.Drawing.Point(4, 4);
            this.affinityPicture1.Name = "affinityPicture1";
            this.affinityPicture1.Size = new System.Drawing.Size(47, 48);
            this.affinityPicture1.TabIndex = 0;
            this.affinityPicture1.TabStop = false;
            // 
            // affinityPicture2
            // 
            this.affinityPicture2.Image = global::RPG_Project.Properties.Resources.firePlaceholder;
            this.affinityPicture2.Location = new System.Drawing.Point(59, 4);
            this.affinityPicture2.Name = "affinityPicture2";
            this.affinityPicture2.Size = new System.Drawing.Size(47, 48);
            this.affinityPicture2.TabIndex = 1;
            this.affinityPicture2.TabStop = false;
            // 
            // strValue
            // 
            this.strValue.AutoSize = true;
            this.strValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strValue.Location = new System.Drawing.Point(68, 132);
            this.strValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.strValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.strValue.Name = "strValue";
            this.strValue.Size = new System.Drawing.Size(63, 26);
            this.strValue.TabIndex = 9;
            this.strValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strLabel.Location = new System.Drawing.Point(3, 134);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(38, 20);
            this.strLabel.TabIndex = 8;
            this.strLabel.Text = "Str: ";
            // 
            // mgValue
            // 
            this.mgValue.AutoSize = true;
            this.mgValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgValue.Location = new System.Drawing.Point(68, 163);
            this.mgValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.mgValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mgValue.Name = "mgValue";
            this.mgValue.Size = new System.Drawing.Size(63, 26);
            this.mgValue.TabIndex = 11;
            this.mgValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mgLabel
            // 
            this.mgLabel.AutoSize = true;
            this.mgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgLabel.Location = new System.Drawing.Point(3, 165);
            this.mgLabel.Name = "mgLabel";
            this.mgLabel.Size = new System.Drawing.Size(39, 20);
            this.mgLabel.TabIndex = 10;
            this.mgLabel.Text = "Mg: ";
            // 
            // dexValue
            // 
            this.dexValue.AutoSize = true;
            this.dexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dexValue.Location = new System.Drawing.Point(68, 194);
            this.dexValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.dexValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dexValue.Name = "dexValue";
            this.dexValue.Size = new System.Drawing.Size(63, 26);
            this.dexValue.TabIndex = 13;
            this.dexValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dexLabel.Location = new System.Drawing.Point(3, 196);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(45, 20);
            this.dexLabel.TabIndex = 12;
            this.dexLabel.Text = "Dex: ";
            // 
            // agiValue
            // 
            this.agiValue.AutoSize = true;
            this.agiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agiValue.Location = new System.Drawing.Point(68, 226);
            this.agiValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.agiValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agiValue.Name = "agiValue";
            this.agiValue.Size = new System.Drawing.Size(63, 26);
            this.agiValue.TabIndex = 15;
            this.agiValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agiLabel
            // 
            this.agiLabel.AutoSize = true;
            this.agiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.agiLabel.Location = new System.Drawing.Point(3, 228);
            this.agiLabel.Name = "agiLabel";
            this.agiLabel.Size = new System.Drawing.Size(40, 20);
            this.agiLabel.TabIndex = 14;
            this.agiLabel.Text = "Agi: ";
            // 
            // lucValue
            // 
            this.lucValue.AutoSize = true;
            this.lucValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lucValue.Location = new System.Drawing.Point(68, 258);
            this.lucValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.lucValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lucValue.Name = "lucValue";
            this.lucValue.Size = new System.Drawing.Size(63, 26);
            this.lucValue.TabIndex = 17;
            this.lucValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lucLabel
            // 
            this.lucLabel.AutoSize = true;
            this.lucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lucLabel.Location = new System.Drawing.Point(3, 260);
            this.lucLabel.Name = "lucLabel";
            this.lucLabel.Size = new System.Drawing.Size(43, 20);
            this.lucLabel.TabIndex = 16;
            this.lucLabel.Text = "Luc: ";
            // 
            // characterArt
            // 
            this.characterArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterArt.Image = global::RPG_Project.Properties.Resources.placeholderCharacter;
            this.characterArt.InitialImage = null;
            this.characterArt.Location = new System.Drawing.Point(3, 3);
            this.characterArt.Name = "characterArt";
            this.characterArt.Size = new System.Drawing.Size(128, 128);
            this.characterArt.TabIndex = 0;
            this.characterArt.TabStop = false;
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skillsLabel.Location = new System.Drawing.Point(137, 103);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(49, 20);
            this.skillsLabel.TabIndex = 19;
            this.skillsLabel.Text = "Skills:";
            // 
            // skillDataGrid
            // 
            this.skillDataGrid.AllowUserToAddRows = false;
            this.skillDataGrid.AllowUserToDeleteRows = false;
            this.skillDataGrid.AllowUserToResizeColumns = false;
            this.skillDataGrid.AllowUserToResizeRows = false;
            this.skillDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.skillDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isHaving,
            this.skillName,
            this.skillCost,
            this.skillAffinity});
            this.skillDataGrid.Location = new System.Drawing.Point(141, 126);
            this.skillDataGrid.Name = "skillDataGrid";
            this.skillDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.skillDataGrid.RowHeadersVisible = false;
            this.skillDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.skillDataGrid.Size = new System.Drawing.Size(247, 150);
            this.skillDataGrid.TabIndex = 0;
            // 
            // isHaving
            // 
            this.isHaving.HeaderText = "Have";
            this.isHaving.Name = "isHaving";
            this.isHaving.Width = 39;
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
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(601, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 27);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoad.Location = new System.Drawing.Point(601, 165);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 27);
            this.buttonLoad.TabIndex = 21;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Character Files|*.cha";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            this.loadFileDialog.Filter = "Character Files|*.cha";
            // 
            // CharacterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.skillDataGrid);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.lucValue);
            this.Controls.Add(this.lucLabel);
            this.Controls.Add(this.agiValue);
            this.Controls.Add(this.agiLabel);
            this.Controls.Add(this.dexValue);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.mgValue);
            this.Controls.Add(this.mgLabel);
            this.Controls.Add(this.strValue);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mpValue);
            this.Controls.Add(this.mpLabel);
            this.Controls.Add(this.hpValue);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.characterArt);
            this.Name = "CharacterView";
            this.Size = new System.Drawing.Size(849, 287);
            ((System.ComponentModel.ISupportInitialize)(this.hpValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpValue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affinityPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agiValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox characterArt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.NumericUpDown hpValue;
        private System.Windows.Forms.NumericUpDown mpValue;
        private System.Windows.Forms.Label mpLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox affinityPicture4;
        private System.Windows.Forms.PictureBox affinityPicture3;
        private System.Windows.Forms.PictureBox affinityPicture1;
        private System.Windows.Forms.PictureBox affinityPicture2;
        private System.Windows.Forms.PictureBox affinityPicture7;
        private System.Windows.Forms.PictureBox affinityPicture6;
        private System.Windows.Forms.PictureBox affinityPicture5;
        private System.Windows.Forms.ComboBox affinityCombo1;
        private System.Windows.Forms.ComboBox affinityCombo7;
        private System.Windows.Forms.ComboBox affinityCombo6;
        private System.Windows.Forms.ComboBox affinityCombo5;
        private System.Windows.Forms.ComboBox affinityCombo4;
        private System.Windows.Forms.ComboBox affinityCombo3;
        private System.Windows.Forms.ComboBox affinityCombo2;
        private System.Windows.Forms.NumericUpDown strValue;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.NumericUpDown mgValue;
        private System.Windows.Forms.Label mgLabel;
        private System.Windows.Forms.NumericUpDown dexValue;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.NumericUpDown agiValue;
        private System.Windows.Forms.Label agiLabel;
        private System.Windows.Forms.NumericUpDown lucValue;
        private System.Windows.Forms.Label lucLabel;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.DataGridView skillDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isHaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillCost;
        private System.Windows.Forms.DataGridViewImageColumn skillAffinity;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
    }
}
