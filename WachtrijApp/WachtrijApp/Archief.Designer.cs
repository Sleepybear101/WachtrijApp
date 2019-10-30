namespace WachtrijApp
{
    partial class Archief
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archief));
            this.dtArchief = new System.Windows.Forms.DataGridView();
            this.BtnOpslaan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAlleDocenten = new System.Windows.Forms.CheckBox();
            this.txbGeholpendocent = new System.Windows.Forms.TextBox();
            this.rtbVraag = new System.Windows.Forms.RichTextBox();
            this.tbVolledig_naam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbGeholpenDoor = new System.Windows.Forms.Label();
            this.tbOnderwerp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotitiesVeld = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtArchief)).BeginInit();
            this.SuspendLayout();
            // 
            // dtArchief
            // 
            this.dtArchief.AllowUserToAddRows = false;
            this.dtArchief.AllowUserToDeleteRows = false;
            this.dtArchief.AllowUserToResizeColumns = false;
            this.dtArchief.AllowUserToResizeRows = false;
            this.dtArchief.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtArchief.Location = new System.Drawing.Point(12, 12);
            this.dtArchief.Name = "dtArchief";
            this.dtArchief.ReadOnly = true;
            this.dtArchief.RowHeadersWidth = 52;
            this.dtArchief.RowTemplate.Height = 24;
            this.dtArchief.Size = new System.Drawing.Size(738, 387);
            this.dtArchief.TabIndex = 0;
            this.dtArchief.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtArchief_CellClick);
            this.dtArchief.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtArchief_CellLeave);
            // 
            // BtnOpslaan
            // 
            this.BtnOpslaan.Location = new System.Drawing.Point(948, 369);
            this.BtnOpslaan.Name = "BtnOpslaan";
            this.BtnOpslaan.Size = new System.Drawing.Size(88, 30);
            this.BtnOpslaan.TabIndex = 1;
            this.BtnOpslaan.Text = "Opslaan";
            this.BtnOpslaan.UseVisualStyleBackColor = true;
            this.BtnOpslaan.Click += new System.EventHandler(this.BtnOpslaan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notitie\'s";
            // 
            // cbxAlleDocenten
            // 
            this.cbxAlleDocenten.AutoSize = true;
            this.cbxAlleDocenten.Location = new System.Drawing.Point(756, 375);
            this.cbxAlleDocenten.Name = "cbxAlleDocenten";
            this.cbxAlleDocenten.Size = new System.Drawing.Size(116, 21);
            this.cbxAlleDocenten.TabIndex = 4;
            this.cbxAlleDocenten.Text = "Alle docenten";
            this.cbxAlleDocenten.UseVisualStyleBackColor = true;
            this.cbxAlleDocenten.CheckedChanged += new System.EventHandler(this.CbxAlleDocenten_CheckedChanged);
            // 
            // txbGeholpendocent
            // 
            this.txbGeholpendocent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGeholpendocent.Location = new System.Drawing.Point(893, 203);
            this.txbGeholpendocent.Name = "txbGeholpendocent";
            this.txbGeholpendocent.ReadOnly = true;
            this.txbGeholpendocent.Size = new System.Drawing.Size(143, 22);
            this.txbGeholpendocent.TabIndex = 28;
            // 
            // rtbVraag
            // 
            this.rtbVraag.Location = new System.Drawing.Point(829, 58);
            this.rtbVraag.Name = "rtbVraag";
            this.rtbVraag.ReadOnly = true;
            this.rtbVraag.Size = new System.Drawing.Size(214, 103);
            this.rtbVraag.TabIndex = 27;
            this.rtbVraag.Text = "";
            // 
            // tbVolledig_naam
            // 
            this.tbVolledig_naam.Location = new System.Drawing.Point(874, 30);
            this.tbVolledig_naam.Name = "tbVolledig_naam";
            this.tbVolledig_naam.ReadOnly = true;
            this.tbVolledig_naam.Size = new System.Drawing.Size(169, 22);
            this.tbVolledig_naam.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(759, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Volledig naam";
            // 
            // lbGeholpenDoor
            // 
            this.lbGeholpenDoor.AutoSize = true;
            this.lbGeholpenDoor.Location = new System.Drawing.Point(762, 208);
            this.lbGeholpenDoor.Name = "lbGeholpenDoor";
            this.lbGeholpenDoor.Size = new System.Drawing.Size(107, 17);
            this.lbGeholpenDoor.TabIndex = 24;
            this.lbGeholpenDoor.Text = "Geholpen door:";
            // 
            // tbOnderwerp
            // 
            this.tbOnderwerp.Location = new System.Drawing.Point(893, 175);
            this.tbOnderwerp.Name = "tbOnderwerp";
            this.tbOnderwerp.ReadOnly = true;
            this.tbOnderwerp.Size = new System.Drawing.Size(143, 22);
            this.tbOnderwerp.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Onderwerp/Vak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vraag";
            // 
            // NotitiesVeld
            // 
            this.NotitiesVeld.Location = new System.Drawing.Point(823, 231);
            this.NotitiesVeld.Name = "NotitiesVeld";
            this.NotitiesVeld.Size = new System.Drawing.Size(214, 103);
            this.NotitiesVeld.TabIndex = 29;
            this.NotitiesVeld.Text = "";
            // 
            // Archief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 411);
            this.Controls.Add(this.NotitiesVeld);
            this.Controls.Add(this.txbGeholpendocent);
            this.Controls.Add(this.rtbVraag);
            this.Controls.Add(this.tbVolledig_naam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbGeholpenDoor);
            this.Controls.Add(this.tbOnderwerp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxAlleDocenten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOpslaan);
            this.Controls.Add(this.dtArchief);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Archief";
            this.Text = "Archief";
            ((System.ComponentModel.ISupportInitialize)(this.dtArchief)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtArchief;
        private System.Windows.Forms.Button BtnOpslaan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxAlleDocenten;
        private System.Windows.Forms.TextBox txbGeholpendocent;
        private System.Windows.Forms.RichTextBox rtbVraag;
        private System.Windows.Forms.TextBox tbVolledig_naam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbGeholpenDoor;
        private System.Windows.Forms.TextBox tbOnderwerp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox NotitiesVeld;
    }
}
