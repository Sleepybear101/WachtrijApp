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
        public KeuzeScherm(Inloggen inloggen)
        {
            InitializeComponent();
        }

        private void btnVraagStellen_Click(object sender, EventArgs e)
        {
            VraagStellen vraagstellen = new VraagStellen(new Inloggen());
            vraagstellen.ShowDialog();

        }
        
        private void btnVraagbekijken_Click(object sender, EventArgs e)
        {
            VraagVanStudenten vraagVanStudenten = new VraagVanStudenten(new Inloggen());
            vraagVanStudenten.ShowDialog();
        }
    }
}
