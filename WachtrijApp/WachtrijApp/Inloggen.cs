﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class Inloggen : Form
    {
        public string id_user;
        public string rol;
        private SqlDbConnection con = new SqlDbConnection();
        public Inloggen()
        {
            InitializeComponent();
        }
        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            // functie om in te loggen
            inloggen();
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
        private void BtnRegisteren_Click(object sender, EventArgs e)
        {
            Registreren registreren = new Registreren(new Inloggen());
            registreren.ShowDialog();
        }
        private void Enter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                inloggen();
                e.Handled = true;
            }
        }
        void inloggen()
        {
       
            // hash de ingevoerd wachtwoord
            var hWachtwoord = ComputeSha256Hash(tbWachtwoord.Text);
            //Kijkt of de gegevens in de tabel student staat
            con.SqlQuery("SELECT `id_student` FROM `student` WHERE `Email_Adres`=@Email AND `Wachtwoord`=@Wachtwoord");
            con.Cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
            con.Cmd.Parameters.AddWithValue("@Wachtwoord", hWachtwoord);
            con.QueryEx();
         
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                if (Convert.ToInt32(dr[0]) >= 0)
                {
                    id_user = dr[0].ToString();
                    rol = "1";
                    this.Hide();
                    KeuzeScherm keuzescherm = new KeuzeScherm(this);
                    keuzescherm.ShowDialog();
                    this.Close();
                }
            }
            //Kijkt of de gegevens in de tabel docent staat
            con.SqlQuery("SELECT `id_docent` FROM `docent` WHERE `Email_Adres`=@Email AND `Wachtwoord`=@Wachtwoord");
            con.Cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
            con.Cmd.Parameters.AddWithValue("@Wachtwoord", hWachtwoord);
            con.QueryEx();

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                if (Convert.ToInt32(dr[0]) >= 0)
                {
                    id_user = dr[0].ToString();
                    rol = "0";
                    this.Hide();
                  KeuzeScherm keuzescherm = new KeuzeScherm(this);
                    this.Close();
                    try
                    {
                        keuzescherm.ShowDialog();
                    }
                    catch
                    {
                        Application.Exit();
                    }
                }
            }
            MessageBox.Show("Combinatie Email/wachtwoord niet gevonden.", "Verkeerde invoer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

 
    }
}
