using System;
using System.Globalization;

namespace Dadosdepessoas
{
    class Program
    {



        static void Main(string[] args)
        {
            //Declaraçao da variavel da classe triangulo x
            usuario x;

            //Declaraçao da variavel da classe triangulo y
            usuario y;

            //instaciar a variavel
            x = new usuario();
            //instaciar a variavel
            y = new usuario();


            //informaçao para o meu usuario
            Console.WriteLine("Qual é o nome do Usuário?");
            x.nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade do usuário?");
            x.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           


            //informaçao para o meu usuario
            Console.WriteLine("Qual é o nome do segundo usuário?");
            y.nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade do segundo usuário?");
            y.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            


            //definição da area maior
            if (y.idade > x.idade)
            {
                Console.WriteLine(y.nome + " é a pessoa mais velha!!");
            }
            else
            {
                Console.WriteLine(x.nome + " é a pessoa mais velha!!");
            }

            Console.ReadKey();
           
        }
    }
}