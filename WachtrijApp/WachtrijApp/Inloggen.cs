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
        public string id_user;
        public string rol;
        private void BtnInloggen_Click(object sender, EventArgs e)
        {

            SqlDbConnection con = new SqlDbConnection();

            var hWachtwoord = ComputeSha256Hash(tbWachtwoord.Text);

            con.SqlQuery("SELECT COUNT(*), `id_student` FROM `student` WHERE `Volledige_Naam`=@VolledigNaam AND `Wachtwoord`=@Wachtwoord");
            con.Cmd.Parameters.AddWithValue("@VolledigNaam", tbVolledigNaam.Text);
            con.Cmd.Parameters.AddWithValue("@Wachtwoord", hWachtwoord);
            con.QueryEx();

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                if (dr[0].ToString() == "1")
                {
                    id_user = dr[1].ToString();
                    KeuzeScherm keuzescherm = new KeuzeScherm(this);
                    keuzescherm.ShowDialog();
                    this.Hide();
                    this.Close();
                     rol = "1";
                 
                }

            }
                

            con.SqlQuery("SELECT COUNT(*),  `id_docent` FROM `docent` WHERE `Volledige_Naam`=@VolledigNaam AND `Wachtwoord`=@Wachtwoord");
            con.Cmd.Parameters.AddWithValue("@VolledigNaam", tbVolledigNaam.Text);
            con.Cmd.Parameters.AddWithValue("@Wachtwoord", hWachtwoord);
            con.QueryEx();

            foreach (DataRow dr in con.QueryEx().Rows)
            {
                if (dr[0].ToString() == "1")
                {
                    id_user = dr[1].ToString();
                    rol= "0";
                    VraagVanStudenten vanStudenten = new VraagVanStudenten(this);              
                    vanStudenten.ShowDialog();
                    this.Hide();
                    this.Close();

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
            Registreren registreren = new Registreren(this);
            registreren.ShowDialog();
            this.Hide();

        }

    }
}
