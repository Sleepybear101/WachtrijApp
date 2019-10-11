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
