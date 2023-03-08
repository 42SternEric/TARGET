using System.Globalization;
using Models;
using Newtonsoft.Json;


decimal maiorValor = 0;
decimal menorValor = 60000;
decimal pMedia = 0;
decimal Media = 0;
int dias = 0;
int diasAcimaDaMedia = 0;

string conteudoArquivo = File.ReadAllText("BaseDeDados/dados.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Dia nº {venda.dia} , valor em vendas {venda.valor.ToString("c")}");

        dias++;
        pMedia += venda.valor;

    if (venda.valor > maiorValor)
        {
        maiorValor = venda.valor;
        }
    if (venda.valor < menorValor)
        {
        menorValor = venda.valor;
        }
}

Media = pMedia / dias;

foreach (Venda venda in listaVenda)
{
    if (venda.valor > Media)
    diasAcimaDaMedia++;
}

Console.WriteLine($"\n------- Análise de Faturamento -------\n");
Console.WriteLine($" O maior valor de faturamento ocorrido em um dia do mês foi de: {maiorValor.ToString("c")}");
Console.WriteLine($" O menor valor de faturamento ocorrido em um dia do mês foi de: {menorValor.ToString("c")}");
Console.WriteLine($" A quantidade de dias com faturamento acima da media foi de : {diasAcimaDaMedia}\n");

//Eric Stern