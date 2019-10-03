using System;
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
        int rol;
        string DocentCode = "234";
        public void VoegGebruiker()
        {
            SqlDbConnection con = new SqlDbConnection();

            
            VolledigNaam = tbVolledigNaam.Text;
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
             if (tbDocentCode.Text == null)
            {
                rol = 0;
            }
           var hPassword =  ComputeSha256Hash(Wachtwoord);
            label5.Text = ComputeSha256Hash(WachtwoordR);

            con.SqlQuery("INSERT INTO `Gebruiker`(`Volledige_Naam`, `Wachtwoord`, `Rol`) VALUES(@VolledigNaam , @Wachtwoord , @Rol)");
            con.Cmd.Parameters.Add("@VolledigNaam", VolledigNaam);
            con.Cmd.Parameters.Add("@Wachtwoord", hPassword);
            con.Cmd.Parameters.Add("@Rol", rol);
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
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
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

        private void TbDocentCode_TextChanged(object sender, EventArgs e)
        {
            if(tbDocentCode.Text == DocentCode)
            {
                rol = 1; 

            }
       
        }
    }
}
