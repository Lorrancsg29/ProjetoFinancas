Feature: Cálculo de juros compostos
	

	Scenario: SimulacaoCalculo01
	Given que o valor do empréstimo foi  1000,00
	And foi definida uma taza de 2% mensais
	And em um período de 12 meses
	When eu solicitar o valor ao final do período
	Then o valor toral a ser pago será de R$ 12682,42

	Scenario: SimulacaoCalculo02
	Given que o valor do empréstimo foi  11937,28
	And foi definida uma taza de 4% mensais
	And em um período de 24 meses
	When eu solicitar o valor ao final do período
	Then o valor toral a ser pago será de  30598,88

	Scenario: SimulacaoCalculo03
	Given que o valor do empréstimo foi  15000,00
	And foi definida uma taza de 6% mensais
	And em um período de 36 meses
	When eu solicitar o valor ao final do período
	Then o valor toral a ser pago será de  122208,78