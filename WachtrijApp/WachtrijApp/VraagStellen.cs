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
            VoegDocent();
            EnableButton();
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
        public void EnableButton()
        {
            if (cbxPersoonlijkeVraag.Checked)
            {
                tbVraag.Enabled = false;
                tbOnderwerp.Enabled = false;
                cbxGegoogled.Enabled = false;
                cbxAnderegesteld.Enabled = false;
                if( cobGevraagdDocent.SelectedItem == null)
                {
                    btnStelVraag.Enabled = false;
                }
                else
                {
                    btnStelVraag.Enabled = true;
                }
            }
            else if(!cbxPersoonlijkeVraag.Checked)
            {
                tbVraag.Enabled = true;
                tbOnderwerp.Enabled = true;
                cbxGegoogled.Enabled = true;
                cbxAnderegesteld.Enabled = true;
                if (tbVraag.Text == "" || tbOnderwerp.Text == "" || cobGevraagdDocent.SelectedItem == null || cbxGegoogled.Checked == false || cbxAnderegesteld.Checked == false)
                {
                    btnStelVraag.Enabled = false;
                }
                else
                {
                    btnStelVraag.Enabled = true;
                }
            }
        }

        private void btnStelVraag_Click(object sender, EventArgs e)
        {
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("INSERT INTO `vragenlijst` (`id_Gebruiker`, `Vraag`, `Onderwerp`, `Gevraagde_Docent`, `Persoonlijke_Vraag`, `Geholpen_Docent`, `Status`, `Notities`) VALUES('1', 'poenk', 'poenk', '3', '0', '3', 'open', NULL);");
        }
        public void VoegDocent()
        {
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("SELECT Volledige_Naam FROM `docent`");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                cobGevraagdDocent.Items.Add(dr[0].ToString());
            }
        }


        private void InputChanged(object sender, EventArgs e)
        {
            EnableButton();
        }
    }
   
}
