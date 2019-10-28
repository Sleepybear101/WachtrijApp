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
            ((System.ComponentModel.ISupportInitialize)(this.dtVraag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vraag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Onderwerp/Vak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gevraagde docent:";
            // 
            // btnOpgelost
            // 
            this.btnOpgelost.Location = new System.Drawing.Point(822, 361);
            this.btnOpgelost.Name = "btnOpgelost";
            this.btnOpgelost.Size = new System.Drawing.Size(88, 33);
            this.btnOpgelost.TabIndex = 5;
            this.btnOpgelost.Text = "Opgelost?";
            this.btnOpgelost.UseVisualStyleBackColor = true;
            this.btnOpgelost.Click += new System.EventHandler(this.btnOpgelost_Click);
            // 
            // btnArchiefOpenen
            // 
            this.btnArchiefOpenen.Location = new System.Drawing.Point(622, 361);
            this.btnArchiefOpenen.Name = "btnArchiefOpenen";
            this.btnArchiefOpenen.Size = new System.Drawing.Size(80, 33);
            this.btnArchiefOpenen.TabIndex = 6;
            this.btnArchiefOpenen.Text = "Archief ";
            this.btnArchiefOpenen.UseVisualStyleBackColor = true;
            this.btnArchiefOpenen.Click += new System.EventHandler(this.btnArchief_Click);
            // 
            // tbOnderwerp
            // 
            this.tbOnderwerp.Location = new System.Drawing.Point(767, 156);
            this.tbOnderwerp.Name = "tbOnderwerp";
            this.tbOnderwerp.ReadOnly = true;
            this.tbOnderwerp.Size = new System.Drawing.Size(143, 22);
            this.tbOnderwerp.TabIndex = 7;
            // 
            // lbGeholpenDoor
            // 
            this.lbGeholpenDoor.AutoSize = true;
            this.lbGeholpenDoor.Location = new System.Drawing.Point(633, 215);
            this.lbGeholpenDoor.Name = "lbGeholpenDoor";
            this.lbGeholpenDoor.Size = new System.Drawing.Size(107, 17);
            this.lbGeholpenDoor.TabIndex = 9;
            this.lbGeholpenDoor.Text = "Geholpen door:";
            // 
            // lbNotitie
            // 
            this.lbNotitie.AutoSize = true;
            this.lbNotitie.Location = new System.Drawing.Point(633, 242);
            this.lbNotitie.Name = "lbNotitie";
            this.lbNotitie.Size = new System.Drawing.Size(52, 17);
            this.lbNotitie.TabIndex = 11;
            this.lbNotitie.Text = "Notitie:";
            // 
            // rtbNotities
            // 
            this.rtbNotities.Location = new System.Drawing.Point(696, 242);
            this.rtbNotities.Name = "rtbNotities";
            this.rtbNotities.Size = new System.Drawing.Size(214, 110);
            this.rtbNotities.TabIndex = 12;
            this.rtbNotities.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Volledig naam";
            // 
            // tbVolledig_naam
            // 
            this.tbVolledig_naam.Location = new System.Drawing.Point(748, 11);
            this.tbVolledig_naam.Name = "tbVolledig_naam";
            this.tbVolledig_naam.ReadOnly = true;
            this.tbVolledig_naam.Size = new System.Drawing.Size(169, 22);
            this.tbVolledig_naam.TabIndex = 14;
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
            this.dtVraag.Size = new System.Drawing.Size(604, 387);
            this.dtVraag.TabIndex = 16;
            this.dtVraag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVraag_CellClick);
            // 
            // tbGevraagdDocent
            // 
            this.tbGevraagdDocent.Location = new System.Drawing.Point(767, 184);
            this.tbGevraagdDocent.Name = "tbGevraagdDocent";
            this.tbGevraagdDocent.ReadOnly = true;
            this.tbGevraagdDocent.Size = new System.Drawing.Size(143, 22);
            this.tbGevraagdDocent.TabIndex = 15;
            // 
            // rtbVraag
            // 
            this.rtbVraag.Location = new System.Drawing.Point(703, 39);
            this.rtbVraag.Name = "rtbVraag";
            this.rtbVraag.ReadOnly = true;
            this.rtbVraag.Size = new System.Drawing.Size(214, 103);
            this.rtbVraag.TabIndex = 18;
            this.rtbVraag.Text = "";
            // 
            // btnLijst_vernieuw
            // 
            this.btnLijst_vernieuw.Location = new System.Drawing.Point(708, 361);
            this.btnLijst_vernieuw.Name = "btnLijst_vernieuw";
            this.btnLijst_vernieuw.Size = new System.Drawing.Size(108, 33);
            this.btnLijst_vernieuw.TabIndex = 19;
            this.btnLijst_vernieuw.Text = "Lijst vernieuw";
            this.btnLijst_vernieuw.UseVisualStyleBackColor = true;
            this.btnLijst_vernieuw.Click += new System.EventHandler(this.btnLijst_vernieuw_Click);
            // 
            // txbGeholpendocent
            // 
            this.txbGeholpendocent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGeholpendocent.Location = new System.Drawing.Point(767, 215);
            this.txbGeholpendocent.Name = "txbGeholpendocent";
            this.txbGeholpendocent.ReadOnly = true;
            this.txbGeholpendocent.Size = new System.Drawing.Size(143, 22);
            this.txbGeholpendocent.TabIndex = 20;
            // 
            // VraagVanStudenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(926, 404);
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
    }
}