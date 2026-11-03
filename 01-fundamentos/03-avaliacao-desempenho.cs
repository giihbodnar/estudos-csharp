using System;

class Programa
{
    public static void Main()
{
        string nome;
        int nota1;
        int nota2;
        int nota3;
        double media;
        Console.WriteLine("== Avaliação de Desempenho ==");
        Console.WriteLine("Nome do funcionário?");
        nome = Console.ReadLine();
        Console.WriteLine("Primeira nota:");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segunda nota:");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Terceira nota:");
        nota3 = int.Parse(Console.ReadLine());
        if ( nota1 >10 || nota2 >10 || nota3 >10 || nota1 < 0 || nota2 < 0 || nota3 < 0)
        {
        Console.WriteLine("Notas inválidas!");
        } else{ 
        media = (nota1+nota2+nota3)/3.0;
        Console.WriteLine("== Resultado ==");
        Console.WriteLine("Funcionário: " + nome);
        Console.WriteLine("Média: " + media);
        if(media <= 10 && media >= 9){
        Console.WriteLine("Classificação: Excelente");
        } else if(media < 9 && media >= 7){
        Console.WriteLine("Classificação: Bom");
        } else if(media < 7 && media >= 5){
        Console.WriteLine("Classificação: Regular");
        } else{ Console.WriteLine("Classificação: Insatisfatório");}
}
}
}