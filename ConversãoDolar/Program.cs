using System;
using System.Globalization;

namespace ConversaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar din = new Dolar();
            double ValorDolar = 5.62;
            Dolar.Cotacao = ValorDolar;

            Console.WriteLine("Hoje a cotação do Dólar está em: $:" + Dolar.Cotacao);
            Console.Write("Digite quanto(s) $ deseja comprar: R$:");
            double Quantia = double.Parse(Console.ReadLine());
            din.Quantidade = Quantia;
            din.Total = Dolar.Cotacao * din.Quantidade;
            Console.Write($"Você comprou: $: {din.Total}");
            Console.ReadLine();
        }
    }
}