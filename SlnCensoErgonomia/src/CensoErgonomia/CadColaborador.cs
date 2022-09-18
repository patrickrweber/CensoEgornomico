using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CensoErgonomia.Classes;
using System.Windows.Forms;

namespace CensoErgonomia
{
    public partial class CadColaborador : Form
    {

        public CadColaborador()
        {
            InitializeComponent();
        }

        private void ListBoxSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indexSelecionado = ListBoxSetor.SelectedItem.ToString();

            if (indexSelecionado.Equals("Fiacao"))
            {
                ListaFuncoesFiacao();
            }
            if (indexSelecionado.Equals("Tecelagem"))
            {
                ListaFuncoesTecelagem();
            }
            if (indexSelecionado.Equals("Preparacao Tecelagem"))
            {
                ListaFuncoesPreparacaoTecelagem();
            }
            if (indexSelecionado.Equals("Confeccao Felpudo"))
            {
                ListaFuncoesConfeccaoFelpudo();
            }
            if (indexSelecionado.Equals("Confeccao Cama"))
            {
                ListaFuncoesConfeccaoCama();
            }
            if (indexSelecionado.Equals("Beneficiamento"))
            {
                ListaFuncoesBeneficiamento();
            }
            
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            AbrirTelaInicial();
        }

        #region Metodos
        private void AbrirTelaInicial() 
        {
            Hide();
            Form f = new MenuInicial();
            f.Closed += (s, args) => Close();
            f.Show();
        }
        private void AbrirTelaHabitos()
        {
            Hide();
            Form f = new Habitos();
            f.Closed += (s, args) => Close();
            f.Show();
        }
        private void ListaFuncoesFiacao()
        {
            Setor setor = new Setor();
            
            string[] fiacao = new string[]
            {
                "LIDER DE PRODUCAO",
                "MONITOR DE PRODUCAO",
                "OP DE ABERTURA DE CARDAS",
                "OP DE BOBINADEIRA",
                "OP DE CARDAS",
                "OP DE CENTRAL DE RESIDUOS",
                "OP DE FIACAO",
                "OP DE FILATORIO",
                "OP DE MACAROQUEIRA",
                "OP DE MAQUINA",
                "OP DE PASSADEIRAS",
                "OP DE PASSADORES",
                "OP DE PENTEADEIRA",
                "OP DE RETROCEDEIRA",
                "SUPERVISOR",
            };
            foreach (string funcao in fiacao)
            {
                setor.Fiacao.Add(funcao);
            }
            setor.Fiacao.Sort();
            ListBoxFuncao.DataSource = setor.Fiacao;
        }
        private void ListaFuncoesTecelagem()
        {
            Setor setor = new Setor();
           
            string[] tecelagem = new string[]
            {
                "APOIO TECNICO",
                "AUXILIAR DE TECELAO",
                "AUXILIAR OPERACIONAL",
                "CORTADOR DE PECA",
                "INSPETOR DE QUALIDADE",
                "INSPETOR DE PRODUCAO",
                "INSTALADOR DE URDUME",
                "MECANICO",
                "MONITOR DE PRODUCAO",
                "OP DE MAQUINA",
                "OP DE CONICALEIRA",
                "OP DE ENGOMADEIRA",
                "OP DE TECELAGEM",
                "OP DE URDIDEIRA",
                "REVISOR",
                "TECELAO",
                "TECNICO TEXTIL"
            };
            foreach (string funcao in tecelagem)
            {
                setor.Tecelagem.Add(funcao);
            }
            setor.Tecelagem.Sort();
            ListBoxFuncao.DataSource = setor.Tecelagem;
        }
        private void ListaFuncoesPreparacaoTecelagem()
        {
            Setor setor = new Setor();

            string[] preparacaoTecelagem = new string[]
            {
                "MONITOR DE PRODUÇÃO",
                "AUXILIAR DE TECELAGEM",
                "OP DE MÁQUINA",
                "OP DE MÁQUINA",

            };
            foreach (string funcao in preparacaoTecelagem)
            {
                setor.PreparacaoTecelagem.Add(funcao);
            }
            setor.PreparacaoTecelagem.Sort();
            ListBoxFuncao.DataSource = setor.PreparacaoTecelagem;
        }
        private void ListaFuncoesConfeccaoFelpudo()
        {
            Setor setor = new Setor();

            string[] confFelpudo = new string[]
            {
                "CLASSIFICADORA SEGUNDA QUALIDADE",
                "COSTUREIRA",
                "REVISORA",
                "OP DE MÁQUINA",
                "OP DE CONFECÇÃO",
                "PISTOLAR",
                "OP EMBALAGEM",
                "OP DE TRANSPORTE",
                "ALIMENTADOR",
            };
            foreach (string funcao in confFelpudo)
            {
                setor.ConfeccaoFelpudo.Add(funcao);
            }
            setor.ConfeccaoFelpudo.Sort();
            ListBoxFuncao.DataSource = setor.ConfeccaoFelpudo;
        }
        private void ListaFuncoesConfeccaoCama()
        {
            Setor setor = new Setor();

            string[] confCama = new string[]
            {
                "OP DE CONFECÇÃO",
                "OP DE QUILTING",
                "OP DE CORTE",
                "REVISORA",
                "OP DE MÁQUINA",
                "COSTUREIRA",
            };
            foreach (string funcao in confCama)
            {
                setor.ConfeccaoCama.Add(funcao);
            }
            setor.ConfeccaoCama.Sort();
            ListBoxFuncao.DataSource = setor.ConfeccaoCama;
        }
        private void ListaFuncoesBeneficiamento()
        {
            Setor setor = new Setor();

            string[] beneficiamento = new string[]
            {
                "OP DE TINTURARIA",
                "OP DE ESTAMPARIA",
                "MONITOR",
                "SUPERVISOR",
                "OP DE TRANSPORTE",
                "OP DE MÁQUINA",
                "OP DE ACABAMENTO",
                "OP DE RAMA",
                "INSPETOR DE QUALIDADE",                
            };
            foreach (string funcao in beneficiamento)
            {
                setor.Beneficiamento.Add(funcao);
            }
            setor.Beneficiamento.Sort();
            ListBoxFuncao.DataSource = setor.Beneficiamento;
        }

        #endregion

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            string turno = LbTurno.SelectedItem.ToString();
            Int32.TryParse(TxtCadastro.Text, out int cadastro);
            string setor = ListBoxSetor.SelectedItem.ToString();
            string funcao = ListBoxFuncao.SelectedItem.ToString();

            Colaborador colaborador = new Colaborador(turno, cadastro, setor, funcao);

            AbrirTelaHabitos();
        }
    }
}
