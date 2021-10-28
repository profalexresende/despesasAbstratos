using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace controleDespesasAbstratos
{
    class Diaria : Despesa
    {
        public double qtdeDiaria { get; set; }
        
        public override void calcularDespesa()
        {
            double vDiaria =Convert.ToDouble( Interaction.InputBox("Digite valor da Diária"));
            valorTotal = vDiaria * qtdeDiaria;
        }

        public override void listarDespesa()
        {
            MessageBox.Show("Descrição: " + descricao +
                "\nqtdeDiaria: " + qtdeDiaria.ToString() +
                "\nValor Total: " + valorTotal.ToString());
        }
    }
}
