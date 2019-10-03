using System;
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

      
        public Inloggen()
        {
            InitializeComponent();
            

        }

        //tbWachtwoord
        //tbVolledigeNaam
        

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
           
            SqlDbConnection con = new SqlDbConnection();
      
            var hWachtwoord = ComputeSha256Hash(tbWachtwoord.Text); 
            con.SqlQuery("SELECT * FROM `gebruiker` WHERE `Volledige_Naam`=@VolledigNaam ");
            con.Cmd.Parameters.Add("@VolledigNaam", tbVolledigNaam.Text);
            con.QueryEx();

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                 string id_user = dr[0].ToString();
                string wUser = dr[2].ToString();
                string Tuser = hWachtwoord.ToString();
                if(Tuser == wUser)
                {
                    MessageBox.Show("id =" );
                }else
                {
                    MessageBox.Show("Na");
                }
           
            }
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
    }
}
