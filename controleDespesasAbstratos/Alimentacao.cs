using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace controleDespesasAbstratos
{
    class Alimentacao : Despesa
    {
        public string nomeRestaurante{get;set;}

        public Alimentacao()
        {
            nomeRestaurante = "";
        }
        
        public override void calcularDespesa()
        {
            valorTotal = Convert.ToDouble(Interaction.InputBox("Total gasto no restaurante"));
        }

        public override void listarDespesa()
        {
            MessageBox.Show("Descrição: " + descricao +
                "\nNome Restaurante: " + nomeRestaurante +
                "\nValor Total: " + valorTotal.ToString());
        }
    }
}
