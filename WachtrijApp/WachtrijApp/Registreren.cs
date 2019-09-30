using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class Registreren : Form
    {
        public Registreren(Inloggen inloggen)
        {
            InitializeComponent();
        }
        string Wachtwoord;
        string WachtwoordR;
        public void VoegGebruiker()
        {
            SqlDbConnection con = new SqlDbConnection();
            string VolledigNaam;
            string DocentCode;
            int rol;

            DocentCode = "DocentCode";
            VolledigNaam = tbVolledigNaam.Text;
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
            lbl_Incorrect.Visible = false;
            if (tbDocentCode.Text == DocentCode )
            {
                label5.Text = VolledigNaam;
                rol = 1;

            }else if (tbDocentCode.Text == null)
            {
                rol = 0;
                label5.Text = "wachtwoord correct";
            }

            /*
            var qeury = "INTO `Gebruiker`(`Volledige_Naam`, `Wachtwoord`, `Rol`) VALUES ('Henk', 'heyHallo', 0)";
            con.SqlQuery(qeury);
            con.NonQueryEx();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VoegGebruiker();

        }

        private void TbWachtwoord_TextChanged(object sender, EventArgs e)
        {
             Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
            if (WachtwoordR != Wachtwoord)
            {
                lbl_Incorrect.Visible = true;
                
            }
            else
            {
                lbl_Incorrect.Visible = false;
            }

        }
    }
}
