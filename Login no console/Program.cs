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
            ConsoleKeyInfo chave;
            do
            {
                chave = Console.ReadKey(true);

                if (chave.Key != ConsoleKey.Backspace && chave.Key != ConsoleKey.Enter)
                {
                    senhaOculta += chave.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (chave.Key == ConsoleKey.Backspace && senhaOculta.Length > 0)
                    {
                        senhaOculta = senhaOculta.Remove(senhaOculta.Length - 1);
                        Console.Write("\b\b");
                    }
                }
            } while (chave.Key != ConsoleKey.Enter);

            Console.WriteLine("\r\n"); // Adicionando uma nova linha após a senha ser lida

            return senhaOculta;

        }

        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para se cadastrar ou S para sair");
                opcao = Console.ReadKey(true).Key.ToString().ToLower();
                Console.WriteLine();
                if (opcao == "c")
                {
                    Console.WriteLine("Digite o seu nome de usuário: ");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite uma senha: ");
                    string senha = ReadPassword();

                    Console.WriteLine("O usuário e senha foram cadastrados com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para encerrar");
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
