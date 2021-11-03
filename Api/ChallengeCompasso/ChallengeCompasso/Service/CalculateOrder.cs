using ChallengeCompasso.Models;
using System;

namespace ChallengeCompasso.Service
{
    public class CalculateOrder
    {
        private CalculateOrderModel _result { get; set; }
        #region Calculate Method
        public CalculateOrderModel Calculate(string tamanhoPizza, string salgadaDoce, string borda, string bebida, string tipoEntrega)
        {
            _result = new CalculateOrderModel();

            double valorTamanho, valorSalgadaDoce, valorPizzaBorda, valorBebida, valorTipoEntrega;

            try
            {
                valorTamanho = PizzaSize(tamanhoPizza);
                valorSalgadaDoce = PizzaFlavor(salgadaDoce);
                valorPizzaBorda = PizzaEdge(borda);
                valorBebida = Beverage(bebida);
                valorTipoEntrega = Convert.ToDouble(tipoEntrega);

                
                _result.Total = (valorTamanho + valorSalgadaDoce + valorPizzaBorda + valorBebida + valorTipoEntrega);
            }
            catch (Exception e)
            {
                throw e;
            }

            return _result;
        }
        #endregion
        #region Private Method
        private double PizzaSize(string tamanhoPizza)
        {
            double valorTamanho;

            if (tamanhoPizza == "1")
            {
                valorTamanho = Constants.PizzaFamilia;
            }
            else if (tamanhoPizza == "2")
            {
                valorTamanho = Constants.PizzaGrande;
            }
            else if (tamanhoPizza == "3")
            {
                valorTamanho = Constants.PizzaMedia;
            }
            else if (tamanhoPizza == "4")
            {
                valorTamanho = Constants.PizzaBroto;
            }
            else
            {
                valorTamanho = 0;
            }

            return valorTamanho;
        }
        private double PizzaFlavor(string salgadaDoce)
        {
            double valorSabor;

            if (salgadaDoce == "1")
            {
                valorSabor = Constants.PizzaSalgada;
            }
            else if (salgadaDoce == "2")
            {
                valorSabor = Constants.PizzaDoce;
            }
            else
            {
                valorSabor = 0;
            }

            return valorSabor;
        }
        private double PizzaEdge(string borda)
        {
            double valorBorda;

            if (borda == "1")
            {
                valorBorda = Constants.PizzaComBorda;
            }
            else if (borda == "2")
            {
                valorBorda = Constants.PizzaSemBorda;
            }
            else
            {
                valorBorda = 0;
            }

            return valorBorda;
        }
        private double Beverage(string bebida)
        {
            double valorBebida;

            if (bebida == "1")
            {
                valorBebida = Constants.BebidaRefrigerante;
            }
            else if (bebida == "2")
            {
                valorBebida = Constants.BebidaSuco;
            }
            else if (bebida == "3")
            {
                valorBebida = Constants.BebidaAgua;
            }
            else if (bebida == "4")
            {
                valorBebida = Constants.BebidaAguaCoco;
            }
            else
            {
                valorBebida = 0;
            }

            return valorBebida;
        }
        #endregion
    }
}