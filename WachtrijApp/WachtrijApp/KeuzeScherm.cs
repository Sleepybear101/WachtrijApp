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
    public partial class KeuzeScherm : Form
    {
        public string id_user;
        public string rol;
        public KeuzeScherm(Inloggen inloggen)
        {

            id_user = inloggen.id_user;
            rol = inloggen.rol;
            InitializeComponent();

            if (rol == "0")
            {
                VraagVanStudenten vraagVanStudenten = new VraagVanStudenten(this);
                vraagVanStudenten.ShowDialog();

            }
        }
        private void btnVraagStellen_Click(object sender, EventArgs e)
        {
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("SELECT COUNT(*) FROM `vragenlijst` WHERE `id_student`=@IdUser AND `Status`= 'open'");
            con.Cmd.Parameters.AddWithValue("@IdUser", id_user);
            con.QueryEx();

            foreach (DataRow dr in con.QueryEx().Rows)
            {

                if (Convert.ToInt32(dr[0]) >= 1)
                {
                    MessageBox.Show("Je hebt al 1 vraag gestelt");
                    return;
                }
            }
           VraagStellen vraagstellen = new VraagStellen(this);
           vraagstellen.ShowDialog();

        }
        
        private void btnVraagbekijken_Click(object sender, EventArgs e)
        {
            VraagVanStudenten vraagVanStudenten = new VraagVanStudenten(this);
            vraagVanStudenten.ShowDialog();
        }
    }
}
