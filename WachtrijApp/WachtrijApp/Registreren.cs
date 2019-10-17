using System;
using System.Data;
using System.Net.Mail;
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
        string Email;
        string DocentCode = "234";
        
        public void VoegGebruiker()
        {
            SqlDbConnection con = new SqlDbConnection();

            
            VolledigNaam = tbVolledigNaam.Text;
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
            Email = tbEmail.Text;
            
            try
            {
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hello, dat is geen email");
                return;
            }

            var hPassword =  ComputeSha256Hash(Wachtwoord);
            if (tbDocentCode.Text != DocentCode || tbDocentCode.Text == null)
            {
                con.SqlQuery("INSERT INTO `student`(`Volledige_Naam`, `Email_Adres`, `Wachtwoord`) VALUES (@VolledigNaam,@Email,@Wachtwoord)");
                con.Cmd.Parameters.AddWithValue("@VolledigNaam", VolledigNaam);
                con.Cmd.Parameters.AddWithValue("@Email", Email);
                con.Cmd.Parameters.AddWithValue("@Wachtwoord", hPassword);
                MessageBox.Show("Gelukt met opslaan ", " Students Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                con.SqlQuery("INSERT INTO `docent`(`Volledige_Naam`, `Email_Adres`, `Wachtwoord`) VALUES (@VolledigNaam,@Email,@Wachtwoord)");
                con.Cmd.Parameters.AddWithValue("@VolledigNaam", VolledigNaam);
                con.Cmd.Parameters.AddWithValue("@Email", Email);
                con.Cmd.Parameters.AddWithValue("@Wachtwoord", hPassword);
                MessageBox.Show("Gelukt met opslaan ", "docent Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
       
         con.NonQueryEx();
            this.Close();
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

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("SELECT * FROM `student` WHERE `Email_Adres`=@Email");
            con.Cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
            var result = con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {

                if (Convert.ToInt32(dr[0]) >= 1)
                {
                    MessageBox.Show("E-mail is al in het systeem");
                    return;
                }
            }           
            VoegGebruiker();
        }
        public void Incorrect(object sender, EventArgs e)
        {
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
            VolledigNaam = tbVolledigNaam.Text;

            if (WachtwoordR != Wachtwoord)
            {
                lbl_Incorrect.Visible = true;

            }
            else if(WachtwoordR == null || WachtwoordR == Wachtwoord)
            {
                lbl_Incorrect.Visible = false;
            }
            if (lbl_Incorrect.Visible || tbWachtwoord.Text.Length == 0 || tbWachtwoordRe.Text.Length == 0 || tbVolledigNaam.Text.Length == 0|| tbEmail.Text.Length == 0)
            {
                btnRegistreer.Enabled = false;
            }
            else
            {
                btnRegistreer.Enabled = true;
            }
        }
    }
}
