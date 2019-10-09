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
        public Inloggen _inloggen;
        public string vraag;
        public string IUser;
        public string rolUser;

        public VraagVanStudenten(Inloggen inloggen)
        {
            _inloggen = inloggen;
            rolUser = _inloggen.rol;
            IUser = _inloggen.id_user;
            GetInfo();
            InitializeComponent();
       
        }

        public void GetInfo()
        {
            this.Controls.Clear();
            this.Refresh();
            InitializeComponent();
            con = new SqlDbConnection();

            if ("0" == rolUser) {
                con.SqlQuery("SELECT`id_Vraag`, student.Volledige_Naam, `Vraag`, `Onderwerp`, docent.Volledige_Naam FROM `vragenlijst` INNER JOIN `student` ON vragenlijst.id_Gebruiker=student.id_student INNER JOIN docent ON vragenlijst.Gevraagde_Docent=docent.id_docent WHERE `Status`='open' ");
                dataGridView1.DataSource = con.QueryEx();
                dataGridView1.Columns[0].Visible = false;
            }
            else if ("1" == rolUser)
            {
               
                rtbNotities.Visible = false;
                lbNotitie.Visible = false;
                lbGeholpenDoor.Visible = false;
                tbGeholpenDoor.Visible = false;
                btnArchiefOpenen.Visible = false;
                btnOpgelost.Visible = false;
            }
        }
        
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                vraag = row.Cells[0].Value.ToString();
                //populate the textbox from specific value of the coordinates of column and row.
                tbVolledig_naam.Text = row.Cells[1].Value.ToString();
                tbVraag.Text = row.Cells[2].Value.ToString();
                tbOnderwerp.Text = row.Cells[3].Value.ToString();
                tbGevraagdDocent.Text = row.Cells[4].Value.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Archief archief = new Archief(this);
            archief.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
           
            SqlDbConnection con = new SqlDbConnection();
            string status = "opgelost";
            con.SqlQuery("UPDATE `vragenlijst` SET `Geholpen_Docent`=@GeholpenDocent, `Notities`=@Notitie,`Status`=@Status WHERE `id_Vraag`=@idVraag");
            con.Cmd.Parameters.AddWithValue("@GeholpenDocent", IUser);
            con.Cmd.Parameters.AddWithValue("@Status", status);
            con.Cmd.Parameters.AddWithValue("@Notitie", rtbNotities.Text);
            con.Cmd.Parameters.AddWithValue("@idVraag", vraag);
            con.NonQueryEx();
            GetInfo();
        }
    }
}
