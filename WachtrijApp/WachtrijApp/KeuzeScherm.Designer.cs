namespace WachtrijApp
{
    partial class KeuzeScherm
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
            this.btnVraagStellen = new System.Windows.Forms.Button();
            this.btnVraagbekijken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVraagStellen
            // 
            this.btnVraagStellen.Location = new System.Drawing.Point(26, 36);
            this.btnVraagStellen.Name = "btnVraagStellen";
            this.btnVraagStellen.Size = new System.Drawing.Size(118, 51);
            this.btnVraagStellen.TabIndex = 0;
            this.btnVraagStellen.Text = "Vraag stellen";
            this.btnVraagStellen.UseVisualStyleBackColor = true;
            this.btnVraagStellen.Click += new System.EventHandler(this.btnVraagStellen_Click);
            // 
            // btnVraagbekijken
            // 
            this.btnVraagbekijken.Location = new System.Drawing.Point(165, 36);
            this.btnVraagbekijken.Name = "btnVraagbekijken";
            this.btnVraagbekijken.Size = new System.Drawing.Size(150, 51);
            this.btnVraagbekijken.TabIndex = 1;
            this.btnVraagbekijken.Text = "Vragen bekijken";
            this.btnVraagbekijken.UseVisualStyleBackColor = true;
            this.btnVraagbekijken.Click += new System.EventHandler(this.btnVraagbekijken_Click);
            // 
            // KeuzeScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 112);
            this.Controls.Add(this.btnVraagbekijken);
            this.Controls.Add(this.btnVraagStellen);
            this.Name = "KeuzeScherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeuzeScherm";
            this.Load += new System.EventHandler(this.KeuzeScherm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVraagStellen;
        private System.Windows.Forms.Button btnVraagbekijken;
    }
}