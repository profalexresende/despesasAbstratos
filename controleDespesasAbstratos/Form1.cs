using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace controleDespesasAbstratos
{
    public partial class Form1 : Form
    {
        Alimentacao a = new Alimentacao();
        Transporte t = new Transporte();
        Diaria d = new Diaria();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.SelectedIndex)
            {
                case 0:
                    a.descricao = Interaction.InputBox("Digite a descrição da despesa com alimentação");
                    a.nomeRestaurante = Interaction.InputBox("Digite nome do restaurante");
                    a.calcularDespesa();
                    a.listarDespesa();
                    break;

                case 1:
                    t.descricao = Interaction.InputBox("Digite a descrição da despesa com transporte");
                    t.kmPercorrida=Convert.ToDouble( Interaction.InputBox("Digite a km percorrida"));
                    t.valorPedagios=Convert.ToDouble(Interaction.InputBox("Digite valor do pedágio"));
                    t.calcularDespesa();
                    t.listarDespesa();
                    break;

                case 2:
                    d.descricao = Interaction.InputBox("Digite a descrição da despesa com hospedagem");
                    d.qtdeDiaria = Convert.ToDouble(Interaction.InputBox("Digite qtde Diárias"));
                    d.calcularDespesa();
                    d.listarDespesa();
                    break;
            }
        }
    }
}
