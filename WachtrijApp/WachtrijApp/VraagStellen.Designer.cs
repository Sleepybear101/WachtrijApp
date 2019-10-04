namespace WachtrijApp
{
    partial class VraagStellen
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
            this.cbxPersoonlijkeVraag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGegoogled = new System.Windows.Forms.CheckBox();
            this.cbxAnderegesteld = new System.Windows.Forms.CheckBox();
            this.btnStelVraag = new System.Windows.Forms.Button();
            this.tbVraag = new System.Windows.Forms.TextBox();
            this.tbOnderwerp = new System.Windows.Forms.TextBox();
            this.cobGevraagdDocent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxPersoonlijkeVraag
            // 
            this.cbxPersoonlijkeVraag.AutoSize = true;
            this.cbxPersoonlijkeVraag.Location = new System.Drawing.Point(17, 10);
            this.cbxPersoonlijkeVraag.Name = "cbxPersoonlijkeVraag";
            this.cbxPersoonlijkeVraag.Size = new System.Drawing.Size(147, 21);
            this.cbxPersoonlijkeVraag.TabIndex = 0;
            this.cbxPersoonlijkeVraag.Text = "Persoonlijke vraag";
            this.cbxPersoonlijkeVraag.UseVisualStyleBackColor = true;
            this.cbxPersoonlijkeVraag.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vraag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Onderwerp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gevraagd docent";
            // 
            // cbxGegoogled
            // 
            this.cbxGegoogled.AutoSize = true;
            this.cbxGegoogled.Location = new System.Drawing.Point(17, 161);
            this.cbxGegoogled.Name = "cbxGegoogled";
            this.cbxGegoogled.Size = new System.Drawing.Size(208, 21);
            this.cbxGegoogled.TabIndex = 4;
            this.cbxGegoogled.Text = "Ik heb mijn vraag gegoogled";
            this.cbxGegoogled.UseVisualStyleBackColor = true;
            this.cbxGegoogled.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // cbxAnderegesteld
            // 
            this.cbxAnderegesteld.AutoSize = true;
            this.cbxAnderegesteld.Location = new System.Drawing.Point(17, 188);
            this.cbxAnderegesteld.Name = "cbxAnderegesteld";
            this.cbxAnderegesteld.Size = new System.Drawing.Size(331, 21);
            this.cbxAnderegesteld.TabIndex = 5;
            this.cbxAnderegesteld.Text = "Ik heb mijn vraag aan andere studenten gesteld";
            this.cbxAnderegesteld.UseVisualStyleBackColor = true;
            this.cbxAnderegesteld.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // btnStelVraag
            // 
            this.btnStelVraag.Location = new System.Drawing.Point(17, 216);
            this.btnStelVraag.Name = "btnStelVraag";
            this.btnStelVraag.Size = new System.Drawing.Size(88, 33);
            this.btnStelVraag.TabIndex = 6;
            this.btnStelVraag.Text = "Stel vraag";
            this.btnStelVraag.UseVisualStyleBackColor = true;
            this.btnStelVraag.Click += new System.EventHandler(this.btnStelVraag_Click);
            // 
            // tbVraag
            // 
            this.tbVraag.Location = new System.Drawing.Point(98, 37);
            this.tbVraag.Multiline = true;
            this.tbVraag.Name = "tbVraag";
            this.tbVraag.Size = new System.Drawing.Size(294, 55);
            this.tbVraag.TabIndex = 7;
            this.tbVraag.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // tbOnderwerp
            // 
            this.tbOnderwerp.Location = new System.Drawing.Point(129, 103);
            this.tbOnderwerp.Name = "tbOnderwerp";
            this.tbOnderwerp.Size = new System.Drawing.Size(263, 22);
            this.tbOnderwerp.TabIndex = 8;
            this.tbOnderwerp.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // cobGevraagdDocent
            // 
            this.cobGevraagdDocent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobGevraagdDocent.FormattingEnabled = true;
            this.cobGevraagdDocent.Location = new System.Drawing.Point(138, 131);
            this.cobGevraagdDocent.Name = "cobGevraagdDocent";
            this.cobGevraagdDocent.Size = new System.Drawing.Size(121, 24);
            this.cobGevraagdDocent.TabIndex = 9;
            this.cobGevraagdDocent.SelectedIndexChanged += new System.EventHandler(this.InputChanged);
            // 
            // VraagStellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 266);
            this.Controls.Add(this.cobGevraagdDocent);
            this.Controls.Add(this.tbOnderwerp);
            this.Controls.Add(this.tbVraag);
            this.Controls.Add(this.btnStelVraag);
            this.Controls.Add(this.cbxAnderegesteld);
            this.Controls.Add(this.cbxGegoogled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPersoonlijkeVraag);
            this.Name = "VraagStellen";
            this.Text = "Vraag stellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPersoonlijkeVraag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxGegoogled;
        private System.Windows.Forms.CheckBox cbxAnderegesteld;
        private System.Windows.Forms.Button btnStelVraag;
        private System.Windows.Forms.TextBox tbVraag;
        private System.Windows.Forms.TextBox tbOnderwerp;
        private System.Windows.Forms.ComboBox cobGevraagdDocent;
    }
}