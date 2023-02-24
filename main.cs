using System;

class Program
{
    public static void Main(string[] args)
    {
        //Tarefa 1 - Fazer soma
        /*
        int num1 = 0, num2 = 0, soma = 0;
        Console.WriteLine("Insira o primeiro número:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número:");
        num2 = int.Parse(Console.ReadLine());
        soma = num1 + num2;
        Console.WriteLine("Resultado: {0} + {1} = {2}", num1, num2, soma);
        */

        //Tarefa 2 - Fazer soma, média e quadrado
        /*
        int num1 = 0, num2 = 0, soma = 0, med = 0, quad1 = 0, quad2 = 0;
        Console.WriteLine("Insira o primeiro número:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número:");
        num2 = int.Parse(Console.ReadLine());
        soma = num1 + num2;
        quad1 = num1 * num1;
        quad2 = num2 * num2;
        med = (num1 + num2) / 2;
        Console.WriteLine("Soma: {0} + {1} = {2}", num1, num2, soma);
        Console.WriteLine("Quadrado do primeiro: {0} * {1} = {2}", num1, num1, quad1);
        Console.WriteLine("Quadrado do segundo: {0} * {1} = {2}", num2, num2, quad2);
        Console.WriteLine("Média: ({0} + {1}) / 2 = {2}", num1, num2, med);
        */

        //Tarefa 3 - Calcular idade atual e futura
        int ano_atual = 0, ano_nascimento = 0, idade = 0, idade2 = 0;
        Console.WriteLine("Insira o ano atual: ");
        ano_atual = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o ano de seu nascimento: ");
        ano_nascimento = int.Parse(Console.ReadLine());
        idade = ano_atual - ano_nascimento;
        idade2 = 2050 - ano_nascimento;
        Console.WriteLine("Você têm {0} anos.", idade);
        Console.WriteLine("Você terá {0} anos em 2050!", idade2);
    }

}