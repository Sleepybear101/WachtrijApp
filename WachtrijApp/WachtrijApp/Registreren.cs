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
        int rol;
        string DocentCode = "234";
        public void VoegGebruiker()
        {
            SqlDbConnection con = new SqlDbConnection();
            string VolledigNaam;

            
            VolledigNaam = tbVolledigNaam.Text;
            Wachtwoord = tbWachtwoord.Text;
            WachtwoordR = tbWachtwoordRe.Text;
             if (tbDocentCode.Text == null)
            {
                rol = 0;
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
