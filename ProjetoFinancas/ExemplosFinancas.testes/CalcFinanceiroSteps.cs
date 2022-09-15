using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ExemplosFinancas;
using ProjetoFinancas;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ExemplosFinancas.testes
{
    [Binding]
    public sealed class CalcFinanceiroSteps
    {
        private double _valorEmprestimo;
        private double _taxa;
        private int _meses;
        private double _valorFinalPeriodo;
     

        private readonly ScenarioContext _scenarioContext;

        

        public CalcFinanceiroSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("que o valor do empréstimo foi R$ (.*)")]
        public void CarreegarValorEmprestimo(double valorEmprestimo)
        {
            this._valorEmprestimo = valorEmprestimo;
        }

        [Given("foi definida uma taxa de (.*)% mensais")]
        public void CarregarTaxa(double taxa)
        {
            this._taxa = taxa;
        }

        [Given("em um período de (.*) meses")]
        public void CarregarNumMeses(int meses)
        {
            this._meses = meses;
        }

        [When("eu solicitar o valor ao final do período")]
        public void ProcessarCalculo()
        {
            this._valorFinalPeriodo =
                CalculoFinanceiro.CalcularValorComJurosCompostos(this._valorEmprestimo, this._meses, this._valorFinalPeriodo);
        }

        [Then("o valor toral a ser pago será de R$ (.*)")]
        public void VerificarResultado(double valoFinalPeriodo)
        {
           
        }
    }
    public static class CalculoFinanceiro
    {
        public static double CalcularValorComJurosCompostos(double valorEmprestimo, int numMeses, double taxa)
        {
            return double.MinValue;
        }
    }
}
