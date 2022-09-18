using CensoErgonomia.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CensoErgonomia
{
    public partial class Habitos : Form
    {
        public Habitos()
        {
            InitializeComponent();
        }

        private void Habitos_Load(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador();
            lblCadastro.Text = colaborador.Cadastro.ToString();
            lblFuncao.Text = colaborador.Funcao;
            lblSetor.Text = colaborador.Setor;
            lblTurno.Text = colaborador.Turno;
        }
    }
}
