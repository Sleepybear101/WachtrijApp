namespace WachtrijApp
{
    partial class Inloggen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inloggen));
            this.lblVolledigNaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.lblRegisteren = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVolledigNaam
            // 
            this.lblVolledigNaam.AutoSize = true;
            this.lblVolledigNaam.Location = new System.Drawing.Point(10, 17);
            this.lblVolledigNaam.Name = "lblVolledigNaam";
            this.lblVolledigNaam.Size = new System.Drawing.Size(51, 17);
            this.lblVolledigNaam.TabIndex = 0;
            this.lblVolledigNaam.Text = "E-mail:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(10, 50);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtwoord.TabIndex = 1;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // lblRegisteren
            // 
            this.lblRegisteren.AutoSize = true;
            this.lblRegisteren.Location = new System.Drawing.Point(10, 152);
            this.lblRegisteren.Name = "lblRegisteren";
            this.lblRegisteren.Size = new System.Drawing.Size(132, 17);
            this.lblRegisteren.TabIndex = 2;
            this.lblRegisteren.Text = "Nog geen account?";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(124, 14);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(209, 22);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Pressed);
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(124, 50);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.ShortcutsEnabled = false;
            this.tbWachtwoord.Size = new System.Drawing.Size(209, 22);
            this.tbWachtwoord.TabIndex = 2;
            this.tbWachtwoord.UseSystemPasswordChar = true;
            this.tbWachtwoord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Pressed);
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisteren.Location = new System.Drawing.Point(245, 144);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(88, 33);
            this.btnRegisteren.TabIndex = 4;
            this.btnRegisteren.Text = "Registeren";
            this.btnRegisteren.UseVisualStyleBackColor = true;
            this.btnRegisteren.Click += new System.EventHandler(this.BtnRegisteren_Click);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInloggen.Location = new System.Drawing.Point(245, 101);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(88, 33);
            this.btnInloggen.TabIndex = 3;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.BtnInloggen_Click);
            // 
            // Inloggen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 183);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblRegisteren);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblVolledigNaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inloggen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wachtrij - Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolledigNaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Label lblRegisteren;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Button btnRegisteren;
        private System.Windows.Forms.Button btnInloggen;
    }
}

