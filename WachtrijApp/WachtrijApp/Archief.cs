using System;
using System.Drawing;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class Archief : Form
    {
        private SqlDbConnection con = new SqlDbConnection();
        public VraagVanStudenten _VraagVanStudenten;
        public string idGebruiker;
        public string Vraag;
        public string rol;
        public Archief(VraagVanStudenten vraagVanStudenten)
        {
            InitializeComponent();
            _VraagVanStudenten = vraagVanStudenten;
            //id van gebruiker wordt opgehaald
            idGebruiker = vraagVanStudenten.id;
            rol = vraagVanStudenten.rol;
            if (rol == "0")
            {
                GetInfoArchief();

            } else if (rol == "1")
            {
                GetinfoStudent();
            }

        }
        public void GetInfoArchief()
        {
            //Datagridview wordt ververst
            dtArchief.Refresh();
            //Wordt gekeken of alle docenten checkbox is gefilterd

            if (cbxAlleDocenten.Checked == true)
            {
                //Opgelosten vragen worden opgehaald van alle docenten
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam AS 'Naam student', `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Geholpen docent`, `Notities`" +
                    " FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Geholpen_Docent=docent.id_docent " +
                    "WHERE `Status`='opgelost' AND `Persoonlijke_Vraag`=0 OR `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent AND `Persoonlijke_Vraag`=1 ");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", idGebruiker);
                //Opgehaald informatie wordt neergezet dtArchief
                dtArchief.DataSource = con.QueryEx();
                dtArchief.Columns[0].Visible = false;

            }
            else
            {
                //Opgelosten en persoonlijke vragen die ingelogd docent wordt opgehaald
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam AS 'Naam student', `Vraag`, `Onderwerp`, docent.Volledige_Naam AS 'geholpen docent', `Notities` " +
                    "FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN `docent` ON vragenlijst.Geholpen_Docent=docent.id_docent " +
                    "WHERE `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent OR `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent AND `Persoonlijke_Vraag`=1");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", idGebruiker);
                //Opgehaald informatie wordt neergezet dtArchief
                dtArchief.DataSource = con.QueryEx();
                dtArchief.Columns[0].Visible = false;
            }
        }
        public void GetinfoStudent()
        {
            //Opgelosten en persoonlijke vragen die ingelogd docent wordt opgehaald
            con.SqlQuery("SELECT`id_Vraag`,  student.Volledige_Naam AS 'Naam student',`Vraag`, `Onderwerp`, docent.Volledige_Naam AS 'geholpen docent', `Notities`, `status`  FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students = student.id_student INNER JOIN `docent` ON vragenlijst.Geholpen_Docent = docent.id_docent WHERE `id_students`=@GeholpenDocent ");
            con.Cmd.Parameters.AddWithValue("@GeholpenDocent", idGebruiker);
            //Opgehaald informatie wordt neergezet dtArchief
            dtArchief.DataSource = con.QueryEx();
            dtArchief.Columns[0].Visible = false;
            dtArchief.Columns[1].Visible = false;
            cbxAlleDocenten.Visible = false;
       
            


        }
        private void BtnOpslaan_Click(object sender, EventArgs e)
        {
            //het wijzigen van notitie's 
            con.SqlQuery("UPDATE `vragenlijst` SET  `Notities`=@Notitie WHERE `id_Vraag`=@idVraag");
            con.Cmd.Parameters.AddWithValue("@Notitie", NotitiesVeld.Text);
            con.Cmd.Parameters.AddWithValue("@idVraag", Vraag);
            con.NonQueryEx();
            if (rol =="0")
            {
                GetInfoArchief();
            }
            else
            {
                GetinfoStudent();
            }
           
          
        }


        private void CbxAlleDocenten_CheckedChanged(object sender, EventArgs e)
        {
            GetInfoArchief();
        }

        private void DtArchief_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kijkt of de rij groter is dan nul
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtArchief.Rows[e.RowIndex];
                //geselecteerde rij achtergrond krijgt een kleur
                row.DefaultCellStyle.BackColor = SystemColors.Highlight;
                //kleur van letter worden wit wordt beter leesbaar
                row.DefaultCellStyle.ForeColor = Color.White;

                Vraag = row.Cells["id_Vraag"].Value.ToString();
                rtbVraag.Text = row.Cells["Vraag"].Value.ToString();
                NotitiesVeld.Text = row.Cells["Notities"].Value.ToString();
                tbOnderwerp.Text = row.Cells["Onderwerp"].Value.ToString();
                tbVolledig_naam.Text = row.Cells["Naam student"].Value.ToString();
                txbGeholpendocent.Text = row.Cells["geholpen docent"].Value.ToString();

            }
        }

        private void dtArchief_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Kleur van de vorige rij krijgt weer een wit achtergrond en kleur letter wordt zwart
            DataGridViewRow row = dtArchief.Rows[e.RowIndex];
            row.DefaultCellStyle.ForeColor = Color.Black;
            row.DefaultCellStyle.BackColor = Color.White;

        }

      
    }
}
