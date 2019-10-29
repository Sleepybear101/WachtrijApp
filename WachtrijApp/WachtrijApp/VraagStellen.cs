using System;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class VraagStellen : Form
    {
        public string id_user;
        public string vraag;
        public string onderwerp;
        private string idDocent;
        private int persoonlijke;
        private SqlDbConnection con = new SqlDbConnection();
        public VraagStellen(KeuzeScherm keuzeScherm)
        {
            InitializeComponent();
            id_user = keuzeScherm.id_user;
            VoegGevraagdeDocent();
            EnableButton();
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
            if (cbxPersoonlijkeVraag.Checked == true)
            {
                vraag = "persoonlijke vraag";
                idDocent = cobGevraagdDocent.SelectedValue.ToString();
                persoonlijke = 1;
            }
            else
            {
                vraag = tbVraag.Text;
                onderwerp = tbOnderwerp.Text;
                idDocent = cobGevraagdDocent.SelectedValue.ToString();
                persoonlijke = 0;
            }

            con.SqlQuery("INSERT INTO `vragenlijst` (`id_students`, `Vraag`, `Onderwerp`, `Gevraagde_Docent`, `Status`,`Geholpen_Docent`, `Persoonlijke_Vraag`) VALUES (@IdUser, @vraag, @onderwerp, @gevraagdeDocent, 'Open',@gevraagdeDocent, @Persoonlijke)");
            con.Cmd.Parameters.AddWithValue("@IdUser", id_user);
            con.Cmd.Parameters.AddWithValue("@vraag", vraag);
            con.Cmd.Parameters.AddWithValue("@onderwerp", onderwerp);
            con.Cmd.Parameters.AddWithValue("@gevraagdeDocent", idDocent);
            con.Cmd.Parameters.AddWithValue("@Persoonlijke", persoonlijke);
            con.NonQueryEx();
            MessageBox.Show("vraag gestelt");
            this.Close();
        }


        public void VoegGevraagdeDocent()
        {
            con.SqlQuery("SELECT id_docent, Volledige_Naam FROM `docent`");
               cobGevraagdDocent.ValueMember = "id_docent";
               cobGevraagdDocent.DisplayMember = "Volledige_Naam";
               cobGevraagdDocent.DataSource = con.QueryEx();
        }
   
        private void InputChanged(object sender, EventArgs e)
        {
            EnableButton();
        }
    }
   
}
