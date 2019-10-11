﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class Registreren : Form
    {
        public Registreren(Inloggen inloggen)
        {
            InitializeComponent();
        }
        string VolledigNaam;
        string Wachtwoord;
        string WachtwoordR;
    
        string DocentCode = "234";
        public void VoegGebruiker()
        {
            SqlDbConnection con = new SqlDbConnection();

            
            VolledigNaam = tbVolledigNaam.Text;
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;

            var hPassword =  ComputeSha256Hash(Wachtwoord);
             if (tbDocentCode.Text != DocentCode || tbDocentCode.Text == null)
            {
                con.SqlQuery("INSERT INTO `student`(`Volledige_Naam`, `Wachtwoord`) VALUES (@VolledigNaam,@Wachtwoord)");
                con.Cmd.Parameters.AddWithValue("@VolledigNaam", VolledigNaam);
                con.Cmd.Parameters.AddWithValue("@Wachtwoord", hPassword);
                      MessageBox.Show("Gelukt met opslaan ", " Students Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                con.SqlQuery("INSERT INTO `docent`(`Volledige_Naam`, `Wachtwoord`) VALUES (@VolledigNaam,@Wachtwoord)");
                con.Cmd.Parameters.AddWithValue("@VolledigNaam", VolledigNaam);
                con.Cmd.Parameters.AddWithValue("@Wachtwoord", hPassword);
                MessageBox.Show("Gelukt met opslaan ", "docent Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
       
         con.NonQueryEx();
        }

        static string ComputeSha256Hash(string rawData)
            {
                // Create a SHA256   
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // ComputeHash - returns byte array  
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                    // Convert byte array to a string   
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            VoegGebruiker();

        }
        public void Incorrect()
        {
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
            if (WachtwoordR != Wachtwoord)
            {
                lbl_Incorrect.Visible = true;

            }
            else if(WachtwoordR == null || WachtwoordR == Wachtwoord)
            {
                lbl_Incorrect.Visible = false;
            }
        }
        private void TbWachtwoord_TextChanged(object sender, EventArgs e)
           {
             Incorrect();
        }
        private void TbWachtwoordRe_TextChanged(object sender, EventArgs e)
        {
            Incorrect();
        }
       /* private void TbDocentCode_TextChanged(object sender, EventArgs e)
        {
            if(tbDocentCode.Text == DocentCode)
            {
              int rol = 1; 

            }
       
        }
        */
    }
}
