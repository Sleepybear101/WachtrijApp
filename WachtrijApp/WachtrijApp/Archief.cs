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
            GetInfo();
            _VraagVanStudenten = vraagVanStudenten;
            IUser = vraagVanStudenten.IUser;
            vraag = vraagVanStudenten.vraag;

        }
        public void GetInfo()
        {
            this.Controls.Clear();
            this.Refresh();
            InitializeComponent();
                con = new SqlDbConnection();

             if (radioButton1.Checked == true)
            {
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam, `Vraag`, `Onderwerp`, docent.Volledige_Naam, `Geholpen_Docent`, `Notities` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_Gebruiker=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='opgelost' AND `Geholpen_Docent`='3'");
                con.Cmd.Parameters.AddWithValue("@GeholpenDocent", IUser);
                con.Cmd.Parameters.AddWithValue("@Notitie", textBox1.Text);
                con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
            
                dataGridView1.DataSource = con.QueryEx();
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {

                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam, `Vraag`, `Onderwerp`, docent.Volledige_Naam, `Geholpen_Docent`, `Notities` FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_Gebruiker=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='opgelost' ");
                dataGridView1.DataSource = con.QueryEx();
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlDbConnection con = new SqlDbConnection();
            string status = "opgelost";
            con.SqlQuery("UPDATE `vragenlijst` SET `Geholpen_Docent`=@GeholpenDocent, `Notities`=@Notitie, WHERE `id_Vraag`=@idVraag");
            con.Cmd.Parameters.AddWithValue("@GeholpenDocent", IUser);
            con.Cmd.Parameters.AddWithValue("@Notitie", textBox1.Text);
            con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
            con.NonQueryEx();
            GetInfo();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {    GetInfo();
        
        }
    }
}
