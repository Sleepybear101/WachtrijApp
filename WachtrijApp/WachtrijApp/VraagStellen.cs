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
        public string id_user;
        public string vraag;
        public string onderwerp;
      
        public VraagStellen(KeuzeScherm keuzeScherm)
        {
            InitializeComponent();
            id_user = keuzeScherm.id_user;
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
                btnStelVraag.Enabled = true;


            }
            if (!cbxPersoonlijkeVraag.Checked)
            {
                tbVraag.Enabled = false;
                tbOnderwerp.Enabled = true;
                cbxGegoogled.Enabled = true;
                cbxAnderegesteld.Enabled = true;
                btnStelVraag.Enabled = true;

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
                
                if(cobGevraagdDocent.SelectedItem == null)
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

            con.SqlQuery("SELECT COUNT(*) FROM `vragenlijst` WHERE `id_Gebruiker`=@IdUser AND `Status`= 'open'");
            con.Cmd.Parameters.AddWithValue("@IdUser", id_user);
            con.QueryEx();

            if(cbxPersoonlijkeVraag.Checked == true)
            {
                vraag = "persoonlijke vraag";
            }
            else
            {
                vraag = tbVraag.Text;
                onderwerp = tbOnderwerp.Text;
          //      cobGevraagdDocent = cobGevraagdDocent.SelectedItem;
            }
            

            foreach (DataRow dr in con.QueryEx().Rows)
            {

                if (Convert.ToInt32(dr[0]) >= 1)
                {
                    MessageBox.Show("Je hebt al 1 vraag gestelt");
                    this.Close();
                }
                else
                {
                    con.SqlQuery("INSERT INTO `vragenlijst` (`id_Gebruiker`, `Vraag`, `Onderwerp`, `Gevraagde_Docent`, `Status`,`Geholpen_Docent`) VALUES (@IdUser, @vraag, @onderwerp, @gevraagdeDocent, 'Open',@gevraagdeDocent)");
                    con.Cmd.Parameters.AddWithValue("@IdUser", id_user);
                    con.Cmd.Parameters.AddWithValue("@vraag" ,vraag);
                    con.Cmd.Parameters.AddWithValue("@onderwerp", onderwerp);
                    con.Cmd.Parameters.AddWithValue("@gevraagdeDocent", id_user);
                    MessageBox.Show("vraag gestelt");

                }
            }
        }
        public void VoegDocent()
        {
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("SELECT id_docent, Volledige_Naam FROM `docent`");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                cobGevraagdDocent.Items.Add(dr[0].ToString() + dr[1].ToString());
            }
        }


        private void InputChanged(object sender, EventArgs e)
        {
            EnableButton();
        }
    }
   
}
