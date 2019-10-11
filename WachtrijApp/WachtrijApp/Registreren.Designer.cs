namespace WachtrijApp
{
    partial class Registreren
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
            this.lblVolledigNaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVolledigNaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbWachtwoordRe = new System.Windows.Forms.TextBox();
            this.tbDocentCode = new System.Windows.Forms.TextBox();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.lbl_Incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVolledigNaam
            // 
            this.lblVolledigNaam.AutoSize = true;
            this.lblVolledigNaam.Location = new System.Drawing.Point(31, 36);
            this.lblVolledigNaam.Name = "lblVolledigNaam";
            this.lblVolledigNaam.Size = new System.Drawing.Size(109, 17);
            this.lblVolledigNaam.TabIndex = 0;
            this.lblVolledigNaam.Text = "Volledige naam:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(31, 94);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtwoord.TabIndex = 1;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wachtwoord herhalen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Docent Code: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Laat dit veld leeg als je geen docent bent";
            // 
            // tbVolledigNaam
            // 
            this.tbVolledigNaam.Location = new System.Drawing.Point(185, 36);
            this.tbVolledigNaam.Name = "tbVolledigNaam";
            this.tbVolledigNaam.Size = new System.Drawing.Size(100, 22);
            this.tbVolledigNaam.TabIndex = 5;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(185, 89);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(100, 22);
            this.tbWachtwoord.TabIndex = 6;
            this.tbWachtwoord.UseSystemPasswordChar = true;
            this.tbWachtwoord.TextChanged += new System.EventHandler(this.TbWachtwoord_TextChanged);
            // 
            // tbWachtwoordRe
            // 
            this.tbWachtwoordRe.Location = new System.Drawing.Point(185, 117);
            this.tbWachtwoordRe.Name = "tbWachtwoordRe";
            this.tbWachtwoordRe.Size = new System.Drawing.Size(100, 22);
            this.tbWachtwoordRe.TabIndex = 7;
            this.tbWachtwoordRe.UseSystemPasswordChar = true;
            this.tbWachtwoordRe.TextChanged += new System.EventHandler(this.TbWachtwoordRe_TextChanged);
            // 
            // tbDocentCode
            // 
            this.tbDocentCode.Location = new System.Drawing.Point(186, 160);
            this.tbDocentCode.Name = "tbDocentCode";
            this.tbDocentCode.Size = new System.Drawing.Size(100, 22);
            this.tbDocentCode.TabIndex = 8;
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Location = new System.Drawing.Point(237, 225);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(88, 33);
            this.btnRegistreer.TabIndex = 9;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // lbl_Incorrect
            // 
            this.lbl_Incorrect.AutoSize = true;
            this.lbl_Incorrect.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Incorrect.Location = new System.Drawing.Point(29, 69);
            this.lbl_Incorrect.Name = "lbl_Incorrect";
            this.lbl_Incorrect.Size = new System.Drawing.Size(179, 17);
            this.lbl_Incorrect.TabIndex = 10;
            this.lbl_Incorrect.Text = "*Wachtwoord zijn niet gelijk";
            this.lbl_Incorrect.Visible = false;
            // 
            // Registreren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 270);
            this.Controls.Add(this.lbl_Incorrect);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.tbDocentCode);
            this.Controls.Add(this.tbWachtwoordRe);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbVolledigNaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblVolledigNaam);
            this.Name = "Registreren";
            this.Text = "Registreren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolledigNaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVolledigNaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbWachtwoordRe;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.TextBox tbDocentCode;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Label lbl_Incorrect;
    }
}