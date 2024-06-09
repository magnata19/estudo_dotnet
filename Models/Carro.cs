using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }

        public void AdicionarCarro()
        {
            Console.WriteLine($"Marca: {Marca} \nNome do Veículo: {Nome} \nAno do Veículo: {Ano}");
        }
    }
}