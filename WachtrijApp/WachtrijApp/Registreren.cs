using System;
using System.Data;
using System.Net;
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
        bool EmailBestaat = false;
        private SqlDbConnection con = new SqlDbConnection();
        public void VoegGebruiker(object sender, EventArgs e)
        {         
            VolledigNaam = tbVolledigNaam.Text;
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
            Email = tbEmail.Text;
            //Kijkt of er een email is ingevuld
            try
            {
                var eMailValidator = new MailAddress(Email);
            }
            catch (FormatException)
            {
                MessageBox.Show("E-mail niet goed ingevuld");
                return;
            }
            Check_Email_In_Database("SELECT * FROM `student` WHERE `Email_Adres`= @Email");
            if (EmailBestaat) return;
            Check_Email_In_Database("SELECT * FROM `docent` WHERE `Email_Adres`= @Email");
            if (EmailBestaat) return;

            //Hash de ingevuld wachtwoord
            var hPassword =  ComputeSha256Hash(Wachtwoord);
            
            //Kijkt of de docentcode gelijk is met ingevuld docentcode
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
            //verstuurt mail naar de nieuw gebruiker
            sendMail(VolledigNaam);
            //Voert Query uit naar database
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
        public void Check_Email_In_Database(string Query)
        {
            con.SqlQuery(Query);
            con.Cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                if (Convert.ToInt32(dr[0]) >= 1)
                {
                    EmailBestaat = true;
                    MessageBox.Show("E-mail is al in het systeem");
                    return;
                }
            }
            EmailBestaat = false;
        }
        public void sendMail(string VolledigNaam)
        {
            MailMessage mailMessage = new MailMessage("testersmailbloem1@gmail.com",tbEmail.Text); 
            mailMessage.Subject = "Je bent ingeschreven";
            mailMessage.Body = "Beste "+VolledigNaam+", \n \nUw account is aangemaakt, u kunt nu gebruikmaken van uw account.\n \n";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "testersmailbloem1@gmail.com",
                Password = "1234test@"
            };
            smtpClient.Send(mailMessage);
            MessageBox.Show("Mail delivered successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Enter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (lbl_Incorrect.Visible || tbWachtwoord.Text.Length == 0 || tbWachtwoordRe.Text.Length == 0 || tbVolledigNaam.Text.Length == 0 || tbEmail.Text.Length == 0)
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld");
                    e.Handled = true;
                    return;
                }
               
            }
        }
    }
}
