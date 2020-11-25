using System;

namespace condicionais_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual: ");
            int hoje = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano em que você nasceu: ");
            int nasc = int.Parse(Console.ReadLine());

            int vote = hoje - nasc;

            if(vote >= 18){
                Console.WriteLine("Cumpra seu dever de cidadão e vote!");
            }else {
                Console.WriteLine("Você ainda não deve votar! Aguarde completar a idade!");
            }

            Console.ReadKey();

        }
    }
}
