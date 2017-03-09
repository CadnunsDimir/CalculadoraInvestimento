using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadnunsDev.CalculadoraInvestimento
{
    public partial class Form1 : Form
    {
        bool _allowEditing = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tboxTxAnual.TextChanged += (obj, evt) =>
            {
                if (_allowEditing)
                {
                    _allowEditing = false;

                    decimal taxaJuros = 0;

                    if(decimal.TryParse(tboxTxAnual.Text, out taxaJuros))
                    {

                        //1 + ia = (1 + ip)n;

                        //1 + taxaAnual = (1 + taxaPeriodo)^periodo
                        //1 + 0,12 = (1 + taxaPeriodo)^periodo
                        //1,12 = (1 + taxaPeriodo)^periodo
                        //periodo V 1,12 = 1 + taxaPeriodo;

                        //resultado - 1 = taxaPeriodo;

                        var montante = 1 + taxaJuros/100;
                        var taxa = (EnesimaRaiz(montante, 12) -1)* 100;

                        tboxTxMensal.Text = decimal.Round(taxa,4).ToString();
                    }

                    CalcularRendimentos();

                    _allowEditing = true;
                }
            };

            tboxTxMensal.TextChanged += (obj, evt) =>
            {
                if (_allowEditing)
                {
                    _allowEditing = false;

                    decimal taxaJuros = 0;

                    if (decimal.TryParse(tboxTxMensal.Text, out taxaJuros))
                    {

                        //1 + ia = (1 + ip)n;

                        //1 + taxaAnual = (1 + taxaPeriodo)^periodo
                        //1 + 0,12 = (1 + taxaPeriodo)^periodo
                        //1,12 = (1 + taxaPeriodo)^periodo
                        //periodo V 1,12 = 1 + taxaPeriodo;

                        //resultado - 1 = taxaPeriodo;

                        //var montante = 1 + taxaJuros / 100;
                        //var taxa = (EnesimaRaiz(montante, 12) - 1) * 100;

                        var taxa = ((decimal)Math.Pow((double)(1 + taxaJuros/100) , 12d) -1)*100M;

                        tboxTxAnual.Text = decimal.Round(taxa, 2).ToString();
                    }

                    CalcularRendimentos();

                    _allowEditing = true;
                }
            };
            
            tboxVlrInicial.TextChanged += (obj, evt) =>
             {

                 if (_allowEditing)
                 {
                     _allowEditing = false;

                     CalcularRendimentos();

                     _allowEditing = true;
                 }
             };

            tboxPeriodo.TextChanged += (obj, evt) =>
            {

                if (_allowEditing)
                {
                    _allowEditing = false;

                    CalcularRendimentos();

                    _allowEditing = true;
                }
            };

            foreach(RadioButton rdb in tipoPeriodo.Controls)
            {
                rdb.CheckedChanged += (obj, evt) => {
                    CalcularRendimentos();
                };
            }
        }

        private void CalcularRendimentos()
        {
            var valorInicial = 0M;
            var periodo = 0d;
            var taxaMensal = 0M;
            var taxaAnual = 0M;

            decimal.TryParse(tboxVlrInicial.Text, out valorInicial);
            double.TryParse(tboxPeriodo.Text, out periodo);
            decimal.TryParse(tboxTxMensal.Text, out taxaMensal);
            decimal.TryParse(tboxTxAnual.Text, out taxaAnual);

            var taxa = (double)((rdbAnual.Checked ? taxaAnual : taxaMensal) / 100M);



            var valorFututro = valorInicial * Convert.ToDecimal(Math.Pow((1d + taxa), periodo));
            var rendimentos = valorInicial * Convert.ToDecimal(Math.Pow((1d + taxa), periodo)-1d);

            lbValorFinal.Text = "R$ " + valorFututro.ToString("0.00");

            lbRendimentos.Text = "R$ " + rendimentos.ToString("0.00");
        }

        private decimal EnesimaRaiz(decimal valor, decimal raizDesejada)
        {


            double radicando = Convert.ToDouble(valor);
            double potencia = 1.0 / Convert.ToDouble(raizDesejada);
            double resultado = Math.Pow(radicando, potencia);
            return Convert.ToDecimal(resultado);
        }

       
    }
}
