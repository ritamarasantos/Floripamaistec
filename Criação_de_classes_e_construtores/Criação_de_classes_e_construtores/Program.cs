
using Criação_de_classes_e_construtores;

Produto produto1 = new Produto("calculadora", 5.75, 199);
Produto produto2 = new Produto();
Console.WriteLine($"O produto1 tem nome: {produto1.nome}, valor: {produto1.preco}, quantidade {produto1.quantidade}.");
Console.WriteLine($"O produto2 tem nome: {produto2.nome}, valor: {produto2.preco}, quantidade {produto2.quantidade}.");
