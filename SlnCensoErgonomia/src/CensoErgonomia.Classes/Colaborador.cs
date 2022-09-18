using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoErgonomia.Classes
{
    public class Colaborador
    {
        public string Turno { get; set; }
        public int Cadastro { get; set; }
        public string Setor { get; set; }
        public string Funcao { get; set; }

        public Colaborador() { }

        public Colaborador (string turno, int cadastro, string setor, string funcao)
        {
            Turno = turno;
            Cadastro = cadastro;
            Setor = setor;
            Funcao = funcao;
        }
    }
}
