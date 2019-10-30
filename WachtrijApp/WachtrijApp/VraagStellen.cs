using System;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class VraagStellen : Form
    {
        public string idGebruiker;
        public string vraag;
        public string onderwerp;
        private string idDocent;
        private int persoonlijke;
        private SqlDbConnection con = new SqlDbConnection();
        public VraagStellen(KeuzeScherm keuzeScherm)
        {
            InitializeComponent();
            //id van gebruiker wordt opgehaald
            idGebruiker = keuzeScherm.id_user;
            VoegGevraagdeDocent();
            EnableButton();
        }
        
        public void EnableButton()
        {
            //Kijkt of persoonelijke vraag is aangevinkt
            if (cbxPersoonlijkeVraag.Checked)
            {
                //velden worden niet gebruikbaar gemaakt
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
                //Kijkt of er een veld niet is ingevoerd
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
            //Kijkt na of checkbox persoonlijke vraag is aangevinkt
            if (cbxPersoonlijkeVraag.Checked == true)
            {
                vraag = "persoonlijke vraag";
                onderwerp = "persoonlijke vraag";
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
            con.Cmd.Parameters.AddWithValue("@IdUser", idGebruiker);
            con.Cmd.Parameters.AddWithValue("@vraag", vraag);
            con.Cmd.Parameters.AddWithValue("@onderwerp", onderwerp);
            con.Cmd.Parameters.AddWithValue("@gevraagdeDocent", idDocent);
            con.Cmd.Parameters.AddWithValue("@Persoonlijke", persoonlijke);

            DialogResult resultaat = MessageBox.Show("Je vraag voor docent is:\n" + vraag + " \n", "Is vraag juist gesteld?",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(resultaat == DialogResult.Cancel)
            {
                return;
            }
                //Query wordt uitgevoerd     
                con.NonQueryEx();
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
