namespace g_Convertissor
{
    partial class Monnaies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monnaies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxResultat = new System.Windows.Forms.TextBox();
            this.comboBoxResultat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.comboBoxSauvegarde = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelClipBoard = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelResultat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipClipBoard = new System.Windows.Forms.ToolTip(this.components);
            this.labelExport = new System.Windows.Forms.Label();
            this.labelImport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBoxSource.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBoxSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSource.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Items.AddRange(new object[] {
            "Euro",
            "Dollar",
            "Pounds",
            "Yen"});
            this.comboBoxSource.Location = new System.Drawing.Point(210, 62);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSource.Size = new System.Drawing.Size(200, 27);
            this.comboBoxSource.TabIndex = 0;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(416, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // textBoxSource
            // 
            this.textBoxSource.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSource.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSource.Location = new System.Drawing.Point(6, 61);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(200, 28);
            this.textBoxSource.TabIndex = 2;
            this.textBoxSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxResultat
            // 
            this.textBoxResultat.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxResultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultat.Location = new System.Drawing.Point(655, 61);
            this.textBoxResultat.Name = "textBoxResultat";
            this.textBoxResultat.Size = new System.Drawing.Size(200, 28);
            this.textBoxResultat.TabIndex = 4;
            this.textBoxResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResultat.TextChanged += new System.EventHandler(this.textBoxResultat_TextChanged);
            // 
            // comboBoxResultat
            // 
            this.comboBoxResultat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBoxResultat.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBoxResultat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxResultat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxResultat.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxResultat.FormattingEnabled = true;
            this.comboBoxResultat.Location = new System.Drawing.Point(449, 62);
            this.comboBoxResultat.Name = "comboBoxResultat";
            this.comboBoxResultat.Size = new System.Drawing.Size(200, 27);
            this.comboBoxResultat.TabIndex = 1;
            this.comboBoxResultat.SelectedIndexChanged += new System.EventHandler(this.comboBoxResultat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(416, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(449, 88);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.Location = new System.Drawing.Point(8, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "VOID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(372, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.labelImport);
            this.groupBox1.Controls.Add(this.labelExport);
            this.groupBox1.Controls.Add(this.buttonImport);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.comboBoxSauvegarde);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelClipBoard);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSource);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboBoxSource);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxResultat);
            this.groupBox1.Controls.Add(this.textBoxResultat);
            this.groupBox1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 540);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion de monnaies !";
            // 
            // buttonImport
            // 
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
            this.buttonImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImport.Location = new System.Drawing.Point(766, 345);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(99, 26);
            this.buttonImport.TabIndex = 20;
            this.buttonImport.Text = "Import...";
            this.buttonImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClipBoard.SetToolTip(this.buttonImport, "Permet d\'importer le fichier de sauvegarde !");
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(661, 345);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(99, 26);
            this.buttonExport.TabIndex = 19;
            this.buttonExport.Text = "Export...";
            this.buttonExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClipBoard.SetToolTip(this.buttonExport, "Permet d\'exporter vers le fichier de sauvegarde !");
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // comboBoxSauvegarde
            // 
            this.comboBoxSauvegarde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxSauvegarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSauvegarde.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSauvegarde.FormattingEnabled = true;
            this.comboBoxSauvegarde.Location = new System.Drawing.Point(416, 345);
            this.comboBoxSauvegarde.Name = "comboBoxSauvegarde";
            this.comboBoxSauvegarde.Size = new System.Drawing.Size(245, 26);
            this.comboBoxSauvegarde.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(416, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(512, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Liste des dernières opérations :";
            // 
            // labelClipBoard
            // 
            this.labelClipBoard.AutoSize = true;
            this.labelClipBoard.BackColor = System.Drawing.SystemColors.Info;
            this.labelClipBoard.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClipBoard.Location = new System.Drawing.Point(620, 304);
            this.labelClipBoard.Name = "labelClipBoard";
            this.labelClipBoard.Size = new System.Drawing.Size(245, 13);
            this.labelClipBoard.TabIndex = 14;
            this.labelClipBoard.Text = "Copie dans le presse-papier avec succès!";
            this.labelClipBoard.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.labelResultat);
            this.groupBox2.Font = new System.Drawing.Font("Engravers MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(416, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 104);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultat :";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(393, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 13;
            this.toolTipClipBoard.SetToolTip(this.button2, "Cliquez ici pour copier dans le presse-papier !");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelResultat
            // 
            this.labelResultat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultat.Location = new System.Drawing.Point(6, 31);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(433, 63);
            this.labelResultat.TabIndex = 12;
            this.labelResultat.Text = "Merci de faire votre saisie !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Engravers MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Table de conversion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "En :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "De :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montant :";
            // 
            // labelExport
            // 
            this.labelExport.AutoSize = true;
            this.labelExport.BackColor = System.Drawing.SystemColors.Info;
            this.labelExport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExport.Location = new System.Drawing.Point(611, 374);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(149, 13);
            this.labelExport.TabIndex = 21;
            this.labelExport.Text = "Exportation avec succès!";
            this.labelExport.Visible = false;
            // 
            // labelImport
            // 
            this.labelImport.AutoSize = true;
            this.labelImport.BackColor = System.Drawing.SystemColors.Info;
            this.labelImport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImport.Location = new System.Drawing.Point(716, 374);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(151, 13);
            this.labelImport.TabIndex = 22;
            this.labelImport.Text = "Importation avec succès!";
            this.labelImport.Visible = false;
            // 
            // Monnaies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(975, 564);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monnaies";
            this.Text = "Convertissor - Monnaies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxSource;
        private Label label1;
        private TextBox textBoxSource;
        private TextBox textBoxResultat;
        private ComboBox comboBoxResultat;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label labelResultat;
        private GroupBox groupBox2;
        private Button button2;
        private ToolTip toolTipClipBoard;
        private Label labelClipBoard;
        private Label label7;
        private ComboBox comboBoxSauvegarde;
        private Button buttonImport;
        private Button buttonExport;
        private Label labelImport;
        private Label labelExport;
    }
}