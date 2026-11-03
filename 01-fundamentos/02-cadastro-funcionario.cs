using System;

class Programa{
public static void Main()
{
string nome;
int idade;
string cargo;
decimal salario;

Console.WriteLine("== Cadastro de Funcionário ==");
Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite seu Cargo:");
cargo = Console.ReadLine();
Console.WriteLine("Digite seu salário:");
salario = decimal.Parse(Console.ReadLine());

Console.WriteLine("== Dados Cadastrados ==");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Idade: " + idade + " anos");
Console.WriteLine("Cargo: " + cargo);
Console.WriteLine("Salário: R$" + salario);

}
}
