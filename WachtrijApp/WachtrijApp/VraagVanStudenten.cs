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

    public partial class VraagVanStudenten : Form
    {
        private SqlDbConnection con = new SqlDbConnection();
        public KeuzeScherm KeuzeScherm;
        public string vraag;
        public string id;
        public string rol;

        public VraagVanStudenten(KeuzeScherm keuzeScherm)
        {
            InitializeComponent();
            rol = keuzeScherm.rol;
            id = keuzeScherm.id_user;
            GetInfo();
        }

        public void GetInfo()
        {
            //datagridview wordt gerefresht
            dtVraag.Refresh();
            
      
            if ("0" == rol)
            {
                con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' AND `Persoonlijke_Vraag`='1'  OR `Persoonlijke_Vraag`= '0' AND `Status`='open' ");
                dtVraag.DataSource = con.QueryEx();
                con.SqlQuery("SELECT `Volledige_Naam` FROM `docent` WHERE `id_docent`=@docent");
                con.Cmd.Parameters.AddWithValue("@docent", id);

                foreach (DataRow dr in con.QueryEx().Rows)
                {
                   txbGeholpendocent.Text = dr[0].ToString();
                }

            }
            else if ("1" == rol)
            {
                con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent` FROM `vragenlijst` " +
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
                    //Wordt niet zichtbaar voor studenten
                    rtbNotities.Visible = false;
                    lbNotitie.Visible = false;
                    lbGeholpenDoor.Visible = false;
                    txbGeholpendocent.Visible = false;
                    btnArchiefOpenen.Visible = false;
                    btnOpgelost.Visible = false;
                }
          dtVraag.Columns[0].Visible = false;
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
            GetInfo();
        }
    }
}
