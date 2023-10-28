using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ProjetoFrame
{
    internal class Program
    {
        public static void operacaoSoma()
        {
            int primeiroValor = 1;
            int segundoValor = 2;

            Console.WriteLine("O valor da some é: {0}", primeiroValor + segundoValor);
        }

        static void Main(string[] args)
        {
            operacaoSoma();
            Console.ReadLine();
        }
    }
}*/
/*namespace ProjetoFrame
{
    internal class Program
    {
        public static void operacaoSoma(int primeiroValor, int segundoValor)
        {
            Console.WriteLine("O valor da some é: {0}", primeiroValor + segundoValor);
        }

        static void Main(string[] args)
        {
            operacaoSoma(2,2);
            Console.ReadLine();
        }
    }
}*/

/*namespace ProjetoFrame
{
    internal class Program
    {
        public static void adicao(int primeiroValor, int segundoValor)
        {
            Console.WriteLine("O valor da some é: {0}", primeiroValor + segundoValor);
        }
        public static void subtracao(int primeiroValor, int segundoValor)
        {
            Console.WriteLine("O valor da some é: {0}", primeiroValor + segundoValor);
        }
        public static void multiplicacao(int primeiroValor, int segundoValor)
        {
            Console.WriteLine("O valor da some é: {0}", primeiroValor + segundoValor);
        }
        public static void divisao(int primeiroValor, int segundoValor)
        {
            Console.WriteLine("O valor da some é: {0}", primeiroValor + segundoValor);
        }

        static void Main(string[] args)
        {
            //int quantidade;
            //Console.Write("Quantos números deseja fazer a operação: ");
            //quantidade = Convert.ToInt32(Console.ReadLine());
            string operacao;
            int a;
            int b;
            Console.WriteLine("Escolha a operação necessária: ");
            Console.WriteLine("adição");
            Console.WriteLine("subtração");
            Console.WriteLine("divisão");
            Console.WriteLine("multiplicação");
            operacao = Convert.ToString(Console.ReadLine());

            Console.Write("Quantos números deseja fazer a operação: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.Write("Por favor insira o {0}º número: ", i + 1);
                numero = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case "adição":
                        adicao(numero);
                        break;
                    case "subtração":

                        break;
                    case "multiplicação":

                        break;
                    case "divisão":

                        break;
                }
            }

        }
    }
}*/

/*namespace ProjetoFrame
{
    internal class Program
    {
        public static int adicao(int primeiroValor, int segundoValor)
        {
           return primeiroValor + segundoValor;
        }
        public static int subtracao(int primeiroValor, int segundoValor)
        {
            return primeiroValor - segundoValor;
        }
        public static int multiplicacao(int primeiroValor, int segundoValor)
        {
            return primeiroValor * segundoValor;
        }
        public static int divisao(int primeiroValor, int segundoValor)
        {
            return primeiroValor / segundoValor;
        }

        static void Main(string[] args)
        {
            int operacao;
            int resultado = 0;
            int primeiroValor;
            int segundoValor;
            Console.WriteLine("Escolha a operação necessária: ");
            Console.WriteLine("1 - adição");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            operacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um número: ");
            primeiroValor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número: ");
            segundoValor = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                    case 1:
                        resultado = adicao(primeiroValor, segundoValor);
                        break;
                    case 2:
                        resultado = subtracao(primeiroValor, segundoValor);
                    break;
                    case 3:
                        resultado = multiplicacao(primeiroValor, segundoValor);
                    break;
                    case 4:
                        resultado = divisao(primeiroValor, segundoValor);
                    break;
            }
            Console.Write("O resultado é: {0}", resultado);
            Console.ReadLine();
        }
    }
}*/

/*Desenvolva um programa que leia o nome e o salário de uma pessoa, depois leia o valor do
índice percentual (%) de reajuste do salário. Calcule e apresente na tela, o valor do novo salário e
o nome da pessoa.

string nome;
double salario;
double porcentagem;

Console.Write("Insira seu nome: ");
nome = Console.ReadLine();
Console.Write("Insira seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o percentual (%) do reajuste: ");
porcentagem = Convert.ToDouble(Console.ReadLine());

double reajuste = (porcentagem / 100) * salario;
double salNovo = reajuste + salario;


Console.WriteLine("O aumento foi de R$" + reajuste + "");
Console.Write( nome + " seu salario atual é R$" + salNovo + "");
 */

/*namespace ProjetoFrame
{
    internal class Program
    {
        
        public static double reajuste(double porcentagem, double salario)
        {
            return salario + ((porcentagem / 100) * salario);
        }

        static void Main(string[] args)
        {
            string nome;
            double salario;
            double porcentagem;
            double salarioNovo;

            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Insira seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o percentual (%) do reajuste: ");
            porcentagem = Convert.ToDouble(Console.ReadLine());

            salarioNovo = reajuste(porcentagem, salario);
            Console.Write(" {0} seu salario atual é R$ {1}",nome, salarioNovo);

            Console.ReadLine();
        }
    }
}*/

namespace ProjetoFrame
{
    internal class Program
    {

        public static string getNome()
        {
            Console.Write("Insira seu nome: ");
            return Console.ReadLine();
        }
        public static double getSalario()
        {
            Console.Write("Insira o salário: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double setPercentual()
        {
            Console.Write("Insira o percentual de reajuste: ");
            return Convert.ToDouble(Console.ReadLine());
        } 
        public static double setSalarioNovo(double percentual, double salario)
        {
            return salario + ((percentual / 100) * salario);
        }

        static void Main(string[] args)
        {
            string nome = getNome();
            double salario = getSalario();
            double percentual = setPercentual();
            double salarioNovo = setSalarioNovo(percentual, salario);

            Console.Write(" {0} seu salario atual é R$ {1}", nome, salarioNovo);

            Console.ReadLine();
        }
    }
}