namespace WachtrijApp
{
    partial class Registeren
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.tbVolledigNaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbWachtwoordRewrite = new System.Windows.Forms.TextBox();
            this.tbDocentCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volledige naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wachtwoord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wachtwoord herhalen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Docent code:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Laat dit veld leeg als je geen docent bent";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Location = new System.Drawing.Point(230, 200);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(129, 29);
            this.btnRegisteren.TabIndex = 5;
            this.btnRegisteren.Text = "Registreer";
            this.btnRegisteren.UseVisualStyleBackColor = true;
            // 
            // tbVolledigNaam
            // 
            this.tbVolledigNaam.Location = new System.Drawing.Point(185, 34);
            this.tbVolledigNaam.Name = "tbVolledigNaam";
            this.tbVolledigNaam.Size = new System.Drawing.Size(100, 22);
            this.tbVolledigNaam.TabIndex = 6;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(185, 72);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(100, 22);
            this.tbWachtwoord.TabIndex = 7;
            // 
            // tbWachtwoordRewrite
            // 
            this.tbWachtwoordRewrite.Location = new System.Drawing.Point(185, 109);
            this.tbWachtwoordRewrite.Name = "tbWachtwoordRewrite";
            this.tbWachtwoordRewrite.Size = new System.Drawing.Size(100, 22);
            this.tbWachtwoordRewrite.TabIndex = 8;
            // 
            // tbDocentCode
            // 
            this.tbDocentCode.Location = new System.Drawing.Point(185, 144);
            this.tbDocentCode.Name = "tbDocentCode";
            this.tbDocentCode.Size = new System.Drawing.Size(100, 22);
            this.tbDocentCode.TabIndex = 9;
            // 
            // Registeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 245);
            this.Controls.Add(this.tbDocentCode);
            this.Controls.Add(this.tbWachtwoordRewrite);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbVolledigNaam);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registeren";
            this.Text = "Registeren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegisteren;
        private System.Windows.Forms.TextBox tbVolledigNaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbWachtwoordRewrite;
        private System.Windows.Forms.TextBox tbDocentCode;
    }
}