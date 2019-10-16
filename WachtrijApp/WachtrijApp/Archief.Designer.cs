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
            this.dtArchief = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxAlleDocenten = new System.Windows.Forms.CheckBox();
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
            this.dtArchief.Size = new System.Drawing.Size(738, 355);
            this.dtArchief.TabIndex = 0;
            this.dtArchief.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtArchief_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Opslaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notitie\'s";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 3;
            // 
            // cbxAlleDocenten
            // 
            this.cbxAlleDocenten.AutoSize = true;
            this.cbxAlleDocenten.Location = new System.Drawing.Point(12, 377);
            this.cbxAlleDocenten.Name = "cbxAlleDocenten";
            this.cbxAlleDocenten.Size = new System.Drawing.Size(116, 21);
            this.cbxAlleDocenten.TabIndex = 4;
            this.cbxAlleDocenten.Text = "Alle docenten";
            this.cbxAlleDocenten.UseVisualStyleBackColor = true;
            this.cbxAlleDocenten.CheckedChanged += new System.EventHandler(this.CbxAlleDocenten_CheckedChanged);
            // 
            // Archief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 411);
            this.Controls.Add(this.cbxAlleDocenten);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtArchief);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Archief";
            this.Text = "Archief";
            this.Load += new System.EventHandler(this.Archief_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtArchief)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtArchief;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbxAlleDocenten;
    }
}
