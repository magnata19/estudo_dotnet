using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Carro(string Marca, string Nome, int Ano)
    {
        public string Marca { get; set; } = Marca;
        public string Nome { get; set; } = Nome;
        public int Ano { get; set; } = Ano;

        public void AdicionarCarro()
        {
            Console.WriteLine($"Marca: {Marca} \nNome do Veículo: {Nome} \nAno do Veículo: {Ano}");
        }
    }
}