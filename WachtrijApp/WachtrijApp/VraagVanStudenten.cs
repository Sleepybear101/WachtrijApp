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

        private SqlDbConnection con;
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
            tbOnderwerp.ReadOnly = true;
            rtbVraag.ReadOnly = true;
            con = new SqlDbConnection();

            if ("0" == rol)

            {
                VoegGeholpenDocent();
                con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' AND `Persoonlijke_Vraag`='1'  OR `Persoonlijke_Vraag`= '0' AND `Status`='open' ");

                dtVraag.DataSource = con.QueryEx();

            }
            else if ("1" == rol)
            {
                con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' AND `Persoonlijke_Vraag`='0'");
                dtVraag.DataSource = con.QueryEx();

                con.SqlQuery("SELECT student.Volledige_Naam AS `Naam student`, `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Gevraagde docent` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `id_students`=@Gebruiker AND `Status`='open' AND `Persoonlijke_Vraag`='0' OR  `id_student`=@Gebruiker AND `Status`='open' AND `Persoonlijke_Vraag`='1'");
                con.Cmd.Parameters.AddWithValue("@Gebruiker", id);
                if (con.QueryEx() != null)
                {
                    foreach (DataRow dr in con.QueryEx().Rows)
                    {
                        tbVolledig_naam.Text = dr[0].ToString();
                        rtbVraag.Text = dr[1].ToString();
                        tbOnderwerp.Text = dr[2].ToString();
                        tbGevraagdDocent.Text = dr[3].ToString();
                    }
                }
                    //Wordt niet zichtbaar voor studenten
                    rtbNotities.Visible = false;
                    lbNotitie.Visible = false;
                    lbGeholpenDoor.Visible = false;
                    cobGeholpenDocent.Visible = false;
                    btnArchiefOpenen.Visible = false;
                    btnOpgelost.Visible = false;
                }

          dtVraag.Columns[0].Visible = false;
        }

        public void VoegGeholpenDocent()
        {
            SqlDbConnection con = new SqlDbConnection();
            //vult de com
            con.SqlQuery("SELECT id_docent, Volledige_Naam FROM `docent`");
            cobGeholpenDocent.ValueMember = "id_docent";
            cobGeholpenDocent.DisplayMember = "Volledige_Naam";

            cobGeholpenDocent.DataSource = con.QueryEx();
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
            SqlDbConnection con = new SqlDbConnection();
            string status = "opgelost";
            id = cobGeholpenDocent.SelectedValue.ToString();
            //Query voor het opgelost vraag en persoonlijke vraag wordt verwijderd
            if (rtbVraag.Text == "persoonlijke vraag")
            {
                con.SqlQuery("DELETE FROM `vragenlijst` WHERE `id_Vraag`=@idVraag AND `Persoonlijke_Vraag`=1");
                con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
                con.NonQueryEx();
            }
            else
            {
                con.SqlQuery("UPDATE `vragenlijst` SET `Geholpen_Docent`=@GeholpenDocent, `Notities`=@Notitie,`Status`=@Status WHERE `id_Vraag`=@idVraag");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", id);
                con.Cmd.Parameters.AddWithValue("@Status", status);
                con.Cmd.Parameters.AddWithValue("@Notitie", rtbNotities.Text);
                con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
                con.NonQueryEx();
            }
            GetInfo();
            vraag = null;
        }
    }
}
