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

            con = new SqlDbConnection();

            con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam, `Vraag`, `Onderwerp`, docent.Volledige_Naam FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_Gebruiker=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' ");
            dtVraag.DataSource = con.QueryEx();

            dtVraag.Columns[0].Visible = false;
            if ("0" == rol)
            {

                con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam, `Vraag`, `Onderwerp`, docent.Volledige_Naam FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_Gebruiker=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' AND `Persoonlijke_Vraag`='1'  OR `Persoonlijke_Vraag`= '0' ");

                dtVraag.DataSource = con.QueryEx();

                dtVraag.Columns[0].Visible = false;




            }
            else if ("1" == rol)
            {
                con.SqlQuery("SELECT `id_Vraag`, student.Volledige_Naam, `Vraag`, `Onderwerp`, docent.Volledige_Naam FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_Gebruiker=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' AND `Persoonlijke_Vraag`='0'");
                dtVraag.DataSource = con.QueryEx();


                //Wordt niet zichtbaar voor studenten
                rtbNotities.Visible = false;
                lbNotitie.Visible = false;
                lbGeholpenDoor.Visible = false;
                tbGeholpenDoor.Visible = false;
                btnArchiefOpenen.Visible = false;
                btnOpgelost.Visible = false;
            }
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            // Archief wordt geopend
            Archief archief = new Archief(this);
            archief.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlDbConnection con = new SqlDbConnection();
            string status = "opgelost";

            //Query voor het opgelost vraag
            con.SqlQuery("UPDATE `vragenlijst` SET `Geholpen_Docent`=@GeholpenDocent, `Notities`=@Notitie,`Status`=@Status WHERE `id_Vraag`=@idVraag");
            con.Cmd.Parameters.AddWithValue("@GeholpenDocent", id);
            con.Cmd.Parameters.AddWithValue("@Status", status);
            con.Cmd.Parameters.AddWithValue("@Notitie", rtbNotities.Text);
            con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
            con.NonQueryEx();
            GetInfo();
        }



        private void DtVraag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                //Haalt de geselecteerde rij gegevens op van de datagridview
                DataGridViewRow row = dtVraag.Rows[e.RowIndex];

                vraag = row.Cells["id_Vraag"].Value.ToString();
                tbVolledig_naam.Text = row.Cells["Volledige_Naam"].Value.ToString();
                tbVraag.Text = row.Cells["Vraag"].Value.ToString();
                tbOnderwerp.Text = row.Cells["Onderwerp"].Value.ToString();
                tbGevraagdDocent.Text = row.Cells["Volledige_Naam1"].Value.ToString();
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
    }
}
