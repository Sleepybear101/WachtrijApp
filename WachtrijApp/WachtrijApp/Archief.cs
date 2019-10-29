using System;
using System.Drawing;
using System.Windows.Forms;

namespace WachtrijApp
{
    public partial class Archief : Form
    {
        private SqlDbConnection con = new SqlDbConnection();
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

            if (cbxAlleDocenten.Checked == true)
            {
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam AS 'Naam student', `Vraag`, `Onderwerp`, docent.Volledige_Naam AS `Geholpen docent`, `Notities`" +
                    " FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN docent ON vragenlijst.Geholpen_Docent=docent.id_docent " +
                    "WHERE `Status`='opgelost' AND `Persoonlijke_Vraag`=0 OR `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent AND `Persoonlijke_Vraag`=1 ");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", IUser);
                dtArchief.DataSource = con.QueryEx();
                dtArchief.Columns[0].Visible = false;
                
            }
            else
            {
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam AS 'Naam student', `Vraag`, `Onderwerp`, docent.Volledige_Naam AS 'geholpen docent', `Notities` " +
                    "FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_students=student.id_student INNER JOIN `docent` ON vragenlijst.Geholpen_Docent=docent.id_docent " +
                    "WHERE `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent OR `Status`='opgelost' AND `Geholpen_Docent`= @GeholpenDocent AND `Persoonlijke_Vraag`=1");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", IUser);
                dtArchief.DataSource = con.QueryEx();
                dtArchief.Columns[0].Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
         
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtArchief.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = SystemColors.Highlight;
                row.DefaultCellStyle.ForeColor = Color.White;
                vraag = row.Cells["id_Vraag"].Value.ToString();
                textBox1.Text = row.Cells["Notities"].Value.ToString();
            }

        }

        private void dtArchief_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtArchief.Rows[e.RowIndex];
            row.DefaultCellStyle.ForeColor = Color.Black;
            row.DefaultCellStyle.BackColor = Color.White;

        }
    }
}
