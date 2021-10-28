using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDespesasAbstratos
{
    abstract class Despesa
    {
        public string descricao { get; set; }
        public double valorTotal { get; set; }

        public Despesa()
        {
            descricao = "";
            valorTotal = 0;
        }

        public abstract void calcularDespesa();
        public abstract void listarDespesa();
    }
}
