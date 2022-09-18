using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CensoErgonomia
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }
        private void ColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form f = new CadColaborador();
            f.Closed += (s, args) => Close();
            f.Show();
        }
    }
}
