using System;
using System.IO;

namespace programação_orientada_a_função
{
    class Program
    {
        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return  c;
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("================= Calculo da tabuada do " + numero + " ===========================================");
            for(int i = 1;i<= 10; i++)
            {
                Console.WriteLine(numero + "x" + i + "=" + (numero * i));
            }
            Console.WriteLine("==============================================");
        }

        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"D:\arquivos_c#\arq" + numeroArquivo + ".txt";
            Console.WriteLine("============ Lendo arquivo ========\n" + arquivoComCaminho + "\n==========================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }

            }

            string arquivoComCaminho2 = @"D:\arquivos_c#\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }
        } 

        private static void CalcularMediaAluno()
        {
            string nome;
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite o nome do Aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("digite a nota1 do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota2 do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a nota3 do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media > 6)
            {
                Console.WriteLine("Parabens voce foi aprovado");
            }
            else if (media == 6)
            {
                Console.WriteLine("foi aprovado por pouco");
            }
            else
            {
                Console.WriteLine("voce foi reprovado");
            }

            Console.WriteLine(" A média do aluno" + nome + " é: " + media);
        }
        
        
        //constante noemada com MAIUSCULO E UNDER_LINE
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULA_MEDIA = 3;


        public static void Main(string[] args)
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa \n" +
                "\n Utilizando programação funcional" +
                "\n\n" +
                "\n    Digite uma das opções abaixo" +
                "\n      0 - Sair do programa" +
                "\n      1 - Para Ler arquivos" +
                "\n      2 - Para executar a Tabuada" +
                "\n      3 - para Calcular Média";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("============================ Opção Ler arquivos ===================");
                    LerArquivo(1);
                    Console.WriteLine("\n==============================================================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("============================ Opção Tabuada ========================");
                    Console.WriteLine("Digite o numero que deseja na Tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                    Console.WriteLine("\n==============================================================\n");
                }
                else if (valor == CALCULA_MEDIA)
                {
                    CalcularMediaAluno();
                    Console.WriteLine("\n==============================================================\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida digite novamente");
                } 
            }
        }
    } 
}
