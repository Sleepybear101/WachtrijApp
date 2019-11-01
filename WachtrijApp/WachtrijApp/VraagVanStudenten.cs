using System;
using System.Data;
using System.Windows.Forms;

namespace WachtrijApp
{

    public partial class VraagVanStudenten : Form
    {
        private SqlDbConnection con = new SqlDbConnection();
        public KeuzeScherm KeuzeScherm;
        public string vraag;
        public string id;
        public string rol;
        public string id_docent;
        public VraagVanStudenten(KeuzeScherm keuzeScherm)
        {
            InitializeComponent();
            //rol en id van gebruiker wordt opgehaald van keuzescherm
            rol = keuzeScherm.rol;
            id = keuzeScherm.id_user;
            //informatie wordt neergezet in de velden en datagridview
            GetInfo();
        }

        public void GetInfo()
        {
            //datagridview wordt vernieuwed
            dtVraag.Refresh();
            
            //Kijkt welke rol is ingelogd
            if ("0" == rol)
            {
                //Vragen van student wordt opgehaald
                con.SqlQuery("SELECT `id_Vraag`,  `id_students`, student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent`, `Datum vraag` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' AND `Persoonlijke_Vraag`='1'  OR `Persoonlijke_Vraag`= '0' AND `Status`='open' ");
                //Vragen van studenten worden neergezet in datagridview
                dtVraag.DataSource = con.QueryEx();
                //Naam van docent wordt opgehaald met id van ingelogd
                con.SqlQuery("SELECT `Volledige_Naam` FROM `docent` WHERE `id_docent`=@docent");
                con.Cmd.Parameters.AddWithValue("@docent", id);
               id_docent = id;
             
                foreach (DataRow dr in con.QueryEx().Rows)
                {
                    //Resultaat van Query wordt neergezet in textsbox
                   txbGeholpendocent.Text = dr[0].ToString();
                }

            }
            else if ("1" == rol)

            {   //Vragen van student wordt opgehaald en neergezet in de velden
                con.SqlQuery("SELECT `id_Vraag`, `id_students`, student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent` , `Datum vraag`  FROM `vragenlijst` " +
                    "INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' " +
                    "AND `Persoonlijke_Vraag`='0'  OR  `id_student`=@Gebruiker AND `Status`='open' AND `Persoonlijke_Vraag`='1'");
                 con.Cmd.Parameters.AddWithValue("@Gebruiker", id);
                if (con.QueryEx() != null)
                {
                    foreach (DataRow dr in con.QueryEx().Rows)
                    {
                        tbVolledig_naam.Text = dr[1].ToString();
                        rtbVraag.Text = dr[2].ToString();
                        tbOnderwerp.Text = dr[3].ToString();
                        tbGevraagdDocent.Text = dr[4].ToString();
                    }
                }
                dtVraag.DataSource = con.QueryEx();
                    //Velden worden niet zichtbaar voor studenten
                    rtbNotities.Visible = false;
                    lbNotitie.Visible = false;
                    lbGeholpenDoor.Visible = false;
                    txbGeholpendocent.Visible = false;
                    btnArchiefOpenen.Visible = false;
                    btnOpgelost.Visible = false;
               
                }
           dtVraag.Columns[0].Visible = false;
            dtVraag.Columns[1].Visible = false;

        }
        private void btnArchief_Click(object sender, EventArgs e)
        {
            // Archief wordt geopend
            Archief archief = new Archief(this);
            archief.ShowDialog();
        }

        private void DtVraag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Haalt de geselecteerde rij gegevens op van de datagridview
                DataGridViewRow row = dtVraag.Rows[e.RowIndex];
                vraag = row.Cells["id_Vraag"].Value.ToString();
                tbVolledig_naam.Text = row.Cells["Naam student"].Value.ToString();
                rtbVraag.Text = row.Cells["Vraag"].Value.ToString();
                tbOnderwerp.Text = row.Cells["Onderwerp"].Value.ToString();
                tbGevraagdDocent.Text = row.Cells["Gevraagde docent"].Value.ToString();
                txbDatumVraag.Text = row.Cells["Datum vraag"].Value.ToString();
                if(e.ColumnIndex == 1)
                 {  
                    rol = "1";
                    id = row.Cells["id_students"].Value.ToString();
                    btnArchief_Click(sender, e);
                    id = id_docent;
                    rol = "0";
                }
            }
       
        }
        private void VraagVanStudenten_FormClosed(object sender, FormClosedEventArgs e)
        {
            //als docent form sluit sluiten alle achtergrond processen
            if (rol == "0")
            {
                Environment.Exit(1);
            }
        }

        private void btnOpgelost_Click(object sender, EventArgs e)
        {
            DialogResult resultaat = MessageBox.Show("De vraag die u wilt oplossen is:\n" + rtbVraag.Text + " \n", "Weet u zeker dat u daze vraag wilt oplossen? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultaat == DialogResult.Cancel)
            {
                return;
            }
            string status = "opgelost";
            string idGeholpenDocent = id;
            //Query voor het opgelost vraag en persoonlijke vraag wordt verwijderd

                con.SqlQuery("UPDATE `vragenlijst` SET `Geholpen_Docent`=@GeholpenDocent, `Notities`=@Notitie,`Status`=@Status WHERE `id_Vraag`=@idVraag");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", idGeholpenDocent);
                con.Cmd.Parameters.AddWithValue("@Status", status);
                con.Cmd.Parameters.AddWithValue("@Notitie", rtbNotities.Text);
                con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
                con.NonQueryEx();

            GetInfo();

                vraag = null;
                rtbNotities.Text = "";
                rtbVraag.Text="";
                tbVolledig_naam.Text = "";
                tbOnderwerp.Text = "";
                tbGevraagdDocent.Text = "";

        }

        private void btnLijst_vernieuw_Click(object sender, EventArgs e)
        {
            //Het gehele datagridview en velden worden vernieuwed 
            GetInfo();
        }

        private void dtVraag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtVraag.Rows[e.RowIndex];
            if (e.ColumnIndex >= 0)
            {
                rol = "1";
                id = row.Cells["id_students"].Value.ToString();
                btnArchief_Click(sender, e);
                id = id_docent;
                rol = "0";
            }
        }
    }
}
