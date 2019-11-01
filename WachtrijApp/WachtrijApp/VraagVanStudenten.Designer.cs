namespace WachtrijApp
{
    partial class VraagVanStudenten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VraagVanStudenten));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpgelost = new System.Windows.Forms.Button();
            this.btnArchiefOpenen = new System.Windows.Forms.Button();
            this.tbOnderwerp = new System.Windows.Forms.TextBox();
            this.lbGeholpenDoor = new System.Windows.Forms.Label();
            this.lbNotitie = new System.Windows.Forms.Label();
            this.rtbNotities = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVolledig_naam = new System.Windows.Forms.TextBox();
            this.dtVraag = new System.Windows.Forms.DataGridView();
            this.tbGevraagdDocent = new System.Windows.Forms.TextBox();
            this.rtbVraag = new System.Windows.Forms.RichTextBox();
            this.btnLijst_vernieuw = new System.Windows.Forms.Button();
            this.txbGeholpendocent = new System.Windows.Forms.TextBox();
            this.txbDatumVraag = new System.Windows.Forms.TextBox();
            this.lbDatumvraag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtVraag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vraag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Onderwerp/Vak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gevraagde docent:";
            // 
            // btnOpgelost
            // 
            this.btnOpgelost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpgelost.Location = new System.Drawing.Point(958, 385);
            this.btnOpgelost.Name = "btnOpgelost";
            this.btnOpgelost.Size = new System.Drawing.Size(88, 33);
            this.btnOpgelost.TabIndex = 1;
            this.btnOpgelost.Text = "Opgelost";
            this.btnOpgelost.UseVisualStyleBackColor = true;
            this.btnOpgelost.Click += new System.EventHandler(this.btnOpgelost_Click);
            // 
            // btnArchiefOpenen
            // 
            this.btnArchiefOpenen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchiefOpenen.Location = new System.Drawing.Point(758, 385);
            this.btnArchiefOpenen.Name = "btnArchiefOpenen";
            this.btnArchiefOpenen.Size = new System.Drawing.Size(80, 33);
            this.btnArchiefOpenen.TabIndex = 9;
            this.btnArchiefOpenen.Text = "Archief ";
            this.btnArchiefOpenen.UseVisualStyleBackColor = true;
            this.btnArchiefOpenen.Click += new System.EventHandler(this.btnArchief_Click);
            // 
            // tbOnderwerp
            // 
            this.tbOnderwerp.Location = new System.Drawing.Point(903, 152);
            this.tbOnderwerp.Name = "tbOnderwerp";
            this.tbOnderwerp.ReadOnly = true;
            this.tbOnderwerp.Size = new System.Drawing.Size(143, 22);
            this.tbOnderwerp.TabIndex = 3;
            // 
            // lbGeholpenDoor
            // 
            this.lbGeholpenDoor.AutoSize = true;
            this.lbGeholpenDoor.Location = new System.Drawing.Point(769, 237);
            this.lbGeholpenDoor.Name = "lbGeholpenDoor";
            this.lbGeholpenDoor.Size = new System.Drawing.Size(107, 17);
            this.lbGeholpenDoor.TabIndex = 9;
            this.lbGeholpenDoor.Text = "Geholpen door:";
            // 
            // lbNotitie
            // 
            this.lbNotitie.AutoSize = true;
            this.lbNotitie.Location = new System.Drawing.Point(769, 269);
            this.lbNotitie.Name = "lbNotitie";
            this.lbNotitie.Size = new System.Drawing.Size(52, 17);
            this.lbNotitie.TabIndex = 11;
            this.lbNotitie.Text = "Notitie:";
            // 
            // rtbNotities
            // 
            this.rtbNotities.Location = new System.Drawing.Point(832, 269);
            this.rtbNotities.Name = "rtbNotities";
            this.rtbNotities.Size = new System.Drawing.Size(214, 110);
            this.rtbNotities.TabIndex = 6;
            this.rtbNotities.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Volledig naam";
            // 
            // tbVolledig_naam
            // 
            this.tbVolledig_naam.Location = new System.Drawing.Point(884, 7);
            this.tbVolledig_naam.Name = "tbVolledig_naam";
            this.tbVolledig_naam.ReadOnly = true;
            this.tbVolledig_naam.Size = new System.Drawing.Size(169, 22);
            this.tbVolledig_naam.TabIndex = 2;
            // 
            // dtVraag
            // 
            this.dtVraag.AllowUserToAddRows = false;
            this.dtVraag.AllowUserToDeleteRows = false;
            this.dtVraag.AllowUserToResizeColumns = false;
            this.dtVraag.AllowUserToResizeRows = false;
            this.dtVraag.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtVraag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVraag.Location = new System.Drawing.Point(12, 4);
            this.dtVraag.MultiSelect = false;
            this.dtVraag.Name = "dtVraag";
            this.dtVraag.ReadOnly = true;
            this.dtVraag.RowHeadersWidth = 51;
            this.dtVraag.RowTemplate.Height = 24;
            this.dtVraag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtVraag.ShowEditingIcon = false;
            this.dtVraag.Size = new System.Drawing.Size(737, 410);
            this.dtVraag.TabIndex = 16;
            this.dtVraag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVraag_CellClick);
            this.dtVraag.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtVraag_CellDoubleClick);
            // 
            // tbGevraagdDocent
            // 
            this.tbGevraagdDocent.Location = new System.Drawing.Point(903, 180);
            this.tbGevraagdDocent.Name = "tbGevraagdDocent";
            this.tbGevraagdDocent.ReadOnly = true;
            this.tbGevraagdDocent.Size = new System.Drawing.Size(143, 22);
            this.tbGevraagdDocent.TabIndex = 4;
            // 
            // rtbVraag
            // 
            this.rtbVraag.Location = new System.Drawing.Point(839, 35);
            this.rtbVraag.Name = "rtbVraag";
            this.rtbVraag.ReadOnly = true;
            this.rtbVraag.Size = new System.Drawing.Size(214, 103);
            this.rtbVraag.TabIndex = 2;
            this.rtbVraag.Text = "";
            // 
            // btnLijst_vernieuw
            // 
            this.btnLijst_vernieuw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLijst_vernieuw.Location = new System.Drawing.Point(844, 385);
            this.btnLijst_vernieuw.Name = "btnLijst_vernieuw";
            this.btnLijst_vernieuw.Size = new System.Drawing.Size(108, 33);
            this.btnLijst_vernieuw.TabIndex = 8;
            this.btnLijst_vernieuw.Text = "Vernieuw lijst";
            this.btnLijst_vernieuw.UseVisualStyleBackColor = true;
            this.btnLijst_vernieuw.Click += new System.EventHandler(this.btnLijst_vernieuw_Click);
            // 
            // txbGeholpendocent
            // 
            this.txbGeholpendocent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGeholpendocent.Location = new System.Drawing.Point(903, 234);
            this.txbGeholpendocent.Name = "txbGeholpendocent";
            this.txbGeholpendocent.ReadOnly = true;
            this.txbGeholpendocent.Size = new System.Drawing.Size(143, 22);
            this.txbGeholpendocent.TabIndex = 5;
            // 
            // txbDatumVraag
            // 
            this.txbDatumVraag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDatumVraag.Location = new System.Drawing.Point(903, 206);
            this.txbDatumVraag.Name = "txbDatumVraag";
            this.txbDatumVraag.ReadOnly = true;
            this.txbDatumVraag.Size = new System.Drawing.Size(143, 22);
            this.txbDatumVraag.TabIndex = 17;
            // 
            // lbDatumvraag
            // 
            this.lbDatumvraag.AutoSize = true;
            this.lbDatumvraag.Location = new System.Drawing.Point(771, 206);
            this.lbDatumvraag.Name = "lbDatumvraag";
            this.lbDatumvraag.Size = new System.Drawing.Size(93, 17);
            this.lbDatumvraag.TabIndex = 18;
            this.lbDatumvraag.Text = "Datum vraag:";
            // 
            // VraagVanStudenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 424);
            this.Controls.Add(this.lbDatumvraag);
            this.Controls.Add(this.txbDatumVraag);
            this.Controls.Add(this.txbGeholpendocent);
            this.Controls.Add(this.btnLijst_vernieuw);
            this.Controls.Add(this.rtbVraag);
            this.Controls.Add(this.dtVraag);
            this.Controls.Add(this.tbGevraagdDocent);
            this.Controls.Add(this.tbVolledig_naam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbNotities);
            this.Controls.Add(this.lbNotitie);
            this.Controls.Add(this.lbGeholpenDoor);
            this.Controls.Add(this.tbOnderwerp);
            this.Controls.Add(this.btnArchiefOpenen);
            this.Controls.Add(this.btnOpgelost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VraagVanStudenten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vraag van studenten";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VraagVanStudenten_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtVraag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpgelost;
        private System.Windows.Forms.Button btnArchiefOpenen;
        private System.Windows.Forms.TextBox tbOnderwerp;
        private System.Windows.Forms.Label lbGeholpenDoor;
        private System.Windows.Forms.Label lbNotitie;
        private System.Windows.Forms.RichTextBox rtbNotities;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVolledig_naam;
        private System.Windows.Forms.DataGridView dtVraag;
        private System.Windows.Forms.TextBox tbGevraagdDocent;
        private System.Windows.Forms.RichTextBox rtbVraag;
        private System.Windows.Forms.Button btnLijst_vernieuw;
        private System.Windows.Forms.TextBox txbGeholpendocent;
        private System.Windows.Forms.TextBox txbDatumVraag;
        private System.Windows.Forms.Label lbDatumvraag;
    }
}