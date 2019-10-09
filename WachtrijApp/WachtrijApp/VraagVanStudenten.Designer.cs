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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVraag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpgelost = new System.Windows.Forms.Button();
            this.btnArchiefOpenen = new System.Windows.Forms.Button();
            this.tbOnderwerp = new System.Windows.Forms.TextBox();
            this.lbGeholpenDoor = new System.Windows.Forms.Label();
            this.tbGeholpenDoor = new System.Windows.Forms.TextBox();
            this.lbNotitie = new System.Windows.Forms.Label();
            this.rtbNotities = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVolledig_naam = new System.Windows.Forms.TextBox();
            this.tbGevraagdDocent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vraag";
            // 
            // tbVraag
            // 
            this.tbVraag.Enabled = false;
            this.tbVraag.Location = new System.Drawing.Point(645, 66);
            this.tbVraag.Name = "tbVraag";
            this.tbVraag.Size = new System.Drawing.Size(143, 22);
            this.tbVraag.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Onderwerp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "gevraagd docent:";
            // 
            // btnOpgelost
            // 
            this.btnOpgelost.Location = new System.Drawing.Point(713, 273);
            this.btnOpgelost.Name = "btnOpgelost";
            this.btnOpgelost.Size = new System.Drawing.Size(88, 33);
            this.btnOpgelost.TabIndex = 5;
            this.btnOpgelost.Text = "Opgelost?";
            this.btnOpgelost.UseVisualStyleBackColor = true;
            this.btnOpgelost.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnArchiefOpenen
            // 
            this.btnArchiefOpenen.Location = new System.Drawing.Point(536, 273);
            this.btnArchiefOpenen.Name = "btnArchiefOpenen";
            this.btnArchiefOpenen.Size = new System.Drawing.Size(128, 31);
            this.btnArchiefOpenen.TabIndex = 6;
            this.btnArchiefOpenen.Text = "Archief openen";
            this.btnArchiefOpenen.UseVisualStyleBackColor = true;
            this.btnArchiefOpenen.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tbOnderwerp
            // 
            this.tbOnderwerp.Enabled = false;
            this.tbOnderwerp.Location = new System.Drawing.Point(645, 94);
            this.tbOnderwerp.Name = "tbOnderwerp";
            this.tbOnderwerp.Size = new System.Drawing.Size(143, 22);
            this.tbOnderwerp.TabIndex = 7;
            // 
            // lbGeholpenDoor
            // 
            this.lbGeholpenDoor.AutoSize = true;
            this.lbGeholpenDoor.Location = new System.Drawing.Point(532, 156);
            this.lbGeholpenDoor.Name = "lbGeholpenDoor";
            this.lbGeholpenDoor.Size = new System.Drawing.Size(107, 17);
            this.lbGeholpenDoor.TabIndex = 9;
            this.lbGeholpenDoor.Text = "Geholpen door:";
            // 
            // tbGeholpenDoor
            // 
            this.tbGeholpenDoor.Location = new System.Drawing.Point(645, 156);
            this.tbGeholpenDoor.Name = "tbGeholpenDoor";
            this.tbGeholpenDoor.Size = new System.Drawing.Size(143, 22);
            this.tbGeholpenDoor.TabIndex = 10;
            // 
            // lbNotitie
            // 
            this.lbNotitie.AutoSize = true;
            this.lbNotitie.Location = new System.Drawing.Point(532, 188);
            this.lbNotitie.Name = "lbNotitie";
            this.lbNotitie.Size = new System.Drawing.Size(52, 17);
            this.lbNotitie.TabIndex = 11;
            this.lbNotitie.Text = "Notitie:";
            // 
            // rtbNotities
            // 
            this.rtbNotities.Location = new System.Drawing.Point(586, 188);
            this.rtbNotities.Name = "rtbNotities";
            this.rtbNotities.Size = new System.Drawing.Size(214, 68);
            this.rtbNotities.TabIndex = 12;
            this.rtbNotities.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Volledig naam";
            // 
            // tbVolledig_naam
            // 
            this.tbVolledig_naam.Enabled = false;
            this.tbVolledig_naam.Location = new System.Drawing.Point(645, 35);
            this.tbVolledig_naam.Name = "tbVolledig_naam";
            this.tbVolledig_naam.Size = new System.Drawing.Size(143, 22);
            this.tbVolledig_naam.TabIndex = 14;
            // 
            // tbGevraagdDocent
            // 
            this.tbGevraagdDocent.Enabled = false;
            this.tbGevraagdDocent.Location = new System.Drawing.Point(645, 122);
            this.tbGevraagdDocent.Name = "tbGevraagdDocent";
            this.tbGevraagdDocent.Size = new System.Drawing.Size(143, 22);
            this.tbGevraagdDocent.TabIndex = 15;
            // 
            // VraagVanStudenten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(811, 315);
            this.Controls.Add(this.tbGevraagdDocent);
            this.Controls.Add(this.tbVolledig_naam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbNotities);
            this.Controls.Add(this.lbNotitie);
            this.Controls.Add(this.tbGeholpenDoor);
            this.Controls.Add(this.lbGeholpenDoor);
            this.Controls.Add(this.tbOnderwerp);
            this.Controls.Add(this.btnArchiefOpenen);
            this.Controls.Add(this.btnOpgelost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVraag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VraagVanStudenten";
            this.Text = "Vraag van studenten";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVraag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpgelost;
        private System.Windows.Forms.Button btnArchiefOpenen;
        private System.Windows.Forms.TextBox tbOnderwerp;
        private System.Windows.Forms.Label lbGeholpenDoor;
        private System.Windows.Forms.TextBox tbGeholpenDoor;
        private System.Windows.Forms.Label lbNotitie;
        private System.Windows.Forms.RichTextBox rtbNotities;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVolledig_naam;
        private System.Windows.Forms.TextBox tbGevraagdDocent;
    }
}