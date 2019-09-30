using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class Inloggen : Form
    {
    
        private vollige
        public Inloggen()
        {
            InitializeComponent();
            

        }

        //tbWachtwoord
        //tbVolledigeNaam
        

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            /*
            SqlDbConnection con = new SqlDbConnection();
            var qeury = " INTO `Gebruiker`(`Volledige_Naam`, `Wachtwoord`, `Rol`) VALUES ('Henk', 'heyHallo', 0)";

            con.SqlQuery(qeury);
            con.NonQueryEx();*/

        }

        private void BtnRegisteren_Click(object sender, EventArgs e)
        {
            Registreren registreren = new Registreren(new Inloggen());
            registreren.ShowDialog();

        }
    }
}
