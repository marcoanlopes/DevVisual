using PrimeiroApp.Models;
using System;


namespace PrimeiroApp.Views
{
    public class newclass
    {
        public static void rend(){
            Produto produto = new Produto();
            produto.Nome = "Biscoito";
            double precoFinal = produto.Price * 2;
            Console.WriteLine($"Nome do produto { produto.Nome } ");
            Console.WriteLine($"Nome do produto { precoFinal } ");


        }
    }
}