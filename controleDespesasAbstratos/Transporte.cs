using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace controleDespesasAbstratos
{
    class Transporte : Despesa
    {
        public double kmPercorrida { get; set; }
        public double valorPedagios { get; set; }

        public Transporte()
        {
            kmPercorrida = 0;
            valorPedagios = 0;
        }

        public override void calcularDespesa()
        {
            double combustivel =Convert.ToDouble( Interaction.InputBox("Digite o total com combustível"));
            valorTotal = combustivel + valorPedagios;
        }

        public override void listarDespesa()
        {
            MessageBox.Show("Descrição: " + descricao +
                "\nKM Percorrida: " + kmPercorrida.ToString() +
                "\nPedágios: " + valorPedagios.ToString() +
                "\nValor Total: " + valorTotal.ToString());
        }
    }
}

