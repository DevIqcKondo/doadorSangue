using System;

namespace doadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = 0;
            Console.BackgroundColor=ConsoleColor.DarkBlue;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("TRIAGEM PARA DOADORES DE SANGUE");
            Console.ResetColor();

            Console.Write("Digite sua idade: ");
            idade=Convert.ToDouble(Console.ReadLine());

            if(idade>67||idade<18){
                Console.BackgroundColor=ConsoleColor.Red;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.WriteLine("Desculpe, você não pode ser doador de sangue!");
                Console.ResetColor();

           

            }else{
                Console.BackgroundColor=ConsoleColor.Green;
                Console.ForegroundColor=ConsoleColor.Black;
                Console.WriteLine("Parabéns, você pode ser doador de sangue!");
                Console.ResetColor();
            }
        }
    }
}
