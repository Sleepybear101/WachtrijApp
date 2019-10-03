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
    public partial class VraagStellen : Form
    {
        public VraagStellen(Inloggen inloggen)
        {
            InitializeComponent();
            btnStelVraag.Enabled = false;
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("SELECT Volledige_Naam FROM `Gebruiker` WHERE Rol = 1");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                cobGevraagdDocent.Items.Add(dr[0].ToString());
            }
                
        }

        private void cbxPersoonlijkeVraag_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPersoonlijkeVraag.Checked)
            {
                tbVraag.Enabled = false;
                tbOnderwerp.Enabled = false;
                cbxGegoogled.Enabled = false;
                cbxAnderegesteld.Enabled = false;
            }
            if (!cbxPersoonlijkeVraag.Checked)
            {
                tbVraag.Enabled = false;
                tbOnderwerp.Enabled = true;
                cbxGegoogled.Enabled = true;
                cbxAnderegesteld.Enabled = true;
            }
        }

        private void InputChanged(object sender , EventArgs e)
        {

        }

        private void btnStelVraag_Click(object sender, EventArgs e)
        {

        }
    }
}
