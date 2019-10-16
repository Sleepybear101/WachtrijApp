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
    public partial class Archief : Form
    {
        private SqlDbConnection con;
        public VraagVanStudenten _VraagVanStudenten;
        public string IUser;
        public string vraag;
        public Archief(VraagVanStudenten vraagVanStudenten)
        {
            InitializeComponent();
            _VraagVanStudenten = vraagVanStudenten;
            IUser = vraagVanStudenten.id;
            vraag = vraagVanStudenten.vraag;
            GetInfo();
        }
        public void GetInfo()
        {
            dtArchief.Refresh();
            con = new SqlDbConnection();

            if (cbxAlleDocenten.Checked == true)
            {
                SqlDbConnection con = new SqlDbConnection();

                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam AS 'Naam student', `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Geholpen docent`, `Notities` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Geholpen_Docent=docent.id_docent WHERE `Status`='opgelost'");
                dtArchief.DataSource = con.QueryEx();
                dtArchief.Columns[0].Visible = false;
            }
            else
            {
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam AS 'Naam student', `Vraag`, `Onderwerp`, docent.Volledige_Naam AS 'geholpen docent', `Notities` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN `docent` ON vragenlijst.Geholpen_Docent=docent.id_docent WHERE `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", IUser);
                dtArchief.DataSource = con.QueryEx();
                dtArchief.Columns[0].Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("UPDATE `vragenlijst` SET  `Notities`=@Notitie WHERE `id_Vraag`=@idVraag");
            con.Cmd.Parameters.AddWithValue("@Notitie", textBox1.Text);
            con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
            con.NonQueryEx();
            GetInfo();
        }

        private void CbxAlleDocenten_CheckedChanged(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void DtArchief_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtArchief.Rows[e.RowIndex];

            if (e.RowIndex >= 0)
            {
                vraag = row.Cells["id_Vraag"].Value.ToString();
                textBox1.Text = row.Cells["Notities"].Value.ToString();
            }
        }
    }
}
