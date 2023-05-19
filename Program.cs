const double jurosmes = 0.0038;
const double jurosdia =  0.000082;

Console.WriteLine("digite o valor da fatura");
decimal fatura=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite o valor do pagamento minimo");
double pagamentominimo=Convert.ToDouble(Console.ReadLine())/ 100;
Console.WriteLine("digite a Taxa de juros mensais");
double juros=Convert.ToDouble(Console.ReadLine())/ 100;
decimal valorminimo = fatura * Convert.ToDecimal(pagamentominimo);
Console.WriteLine($" pagamento minimo ${valorminimo}");
Console.WriteLine("caso esse valor nao for pago:");
decimal valornaopago = fatura - valorminimo;
decimal taxadejuros = valornaopago * Convert.ToDecimal(juros);
decimal taxadejurosmes = valornaopago * Convert.ToDecimal(jurosmes);
decimal taxadejurosdia = valornaopago * Convert.ToDecimal(jurosdia * 30);
decimal valorapagarnaproximafatura = valornaopago + taxadejurosdia + taxadejurosmes;
decimal valordetaxaapagarnofinal = taxadejuros + taxadejurosdia + taxadejurosmes;
Console.WriteLine($"valor nao pago ----------{valornaopago}");
Console.WriteLine($"juros----------{taxadejuros}");
Console.WriteLine($"IOF mensal ----------{taxadejurosmes}");
Console.WriteLine($"IOF diario ----------{taxadejurosdia}");
Console.WriteLine($"valor a pagar na proxima farura ----------{valorapagarnaproximafatura}");
Console.WriteLine($"custo de todos os creditos rotativo ----------{valordetaxaapagarnofinal}");









