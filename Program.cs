using dotnet.Models;

Pessoa pessoa = new Pessoa("Davidson", 24);
pessoa.Apresentar();

Carro carro = new Carro();
carro.Marca = "Ford";
carro.Nome = "Mustang";
carro.Ano = 2025;
carro.AdicionarCarro();