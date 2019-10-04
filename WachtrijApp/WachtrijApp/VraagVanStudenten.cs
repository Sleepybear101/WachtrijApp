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
        public VraagVanStudenten(Inloggen inloggen)
        {
            InitializeComponent();
            SqlDbConnection con = new SqlDbConnection();
            con.SqlQuery("SELECT Volledige_Naam FROM `Gebruiker` WHERE Rol = 1");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                cobGevraagdDocent.Items.Add(dr[0].ToString());
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
