using System;
namespace _01Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa usuario=new Pessoa();
            
            Console.WriteLine("Insira sua Altura:");
                
                usuario.altura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira o seu peso:");
                
                usuario.peso = float.Parse(Console.ReadLine());
            
            usuario.imc = (int)(usuario.peso/(usuario.altura*usuario.altura));
            Console.Write("Seu IMC é: ");
        usuario.mensagem(usuario.imc);

        }
    }
}
