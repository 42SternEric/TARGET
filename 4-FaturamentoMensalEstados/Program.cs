
decimal SP = 67836.43m;
decimal RJ = 36678.66m;
decimal MG = 29229.88m;
decimal ES = 27165.48m;
decimal OUTROS = 19849.53m;

decimal TOTAL = SP + RJ + MG + ES + OUTROS;

decimal porcSP = SP / TOTAL;
decimal porcRJ = RJ / TOTAL;
decimal porcMG = MG / TOTAL;
decimal porcES = ES / TOTAL;
decimal porcOUTROS = OUTROS / TOTAL;

Console.WriteLine($"\n O Faturamento mensal da distribuidora foi de : {TOTAL.ToString("c")} \n");
Console.WriteLine($"O Faturamento do estado de São Paulo corresponde á { porcSP.ToString("p")} do faturamento mensal");
Console.WriteLine($"O Faturamento do estado dO Rio de Janeiro corresponde á { porcRJ.ToString("p")} do faturamento mensal");
Console.WriteLine($"O Faturamento do estado de Minas Gerais corresponde á { porcMG.ToString("p")} do faturamento mensal");
Console.WriteLine($"O Faturamento do estado de Espirito Santo corresponde á { porcES.ToString("p")} do faturamento mensal");
Console.WriteLine($"O Faturamento de Outros Estados corresponde á { porcOUTROS.ToString("p")} do faturamento mensal\n");

//Eric Stern