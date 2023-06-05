using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Usuarios 
{
    internal class Program
    {
        //Método para deixar a senha invisível
        private static string ReadPassword()
        {
            string senhaOculta = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    senhaOculta += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && senhaOculta.Length > 0)
                    {
                        senhaOculta = senhaOculta.Remove(senhaOculta.Length - 1);
                        Console.Write("\b\b");
                    }
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine(); // Adicionando uma nova linha após a senha ser lida

            return senhaOculta;
        }

        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para se cadastrar ou S para sair");
                opcao = Console.ReadKey(true).Key.ToString().ToLower();
                if(opcao == "c")
                {
                    Console.WriteLine("Digite o seu nome de usuário: ");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite uma senha de até 10 digitos: ");
                    string senha = ReadPassword();

                    Console.WriteLine("O usuário e senha foram cadastrados com sucesso!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(opcao == "s")
                {
                    Console.WriteLine("Encerrando o programa");
                }
                else
                {
                    Console.WriteLine("Opção desconhecida");
                }
            } while (opcao != "s");

            Console.WriteLine("Pressione qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
