using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInicial
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            int opc = 4;
            while (opc != 0)
            {
                Console.WriteLine("##______Menu Principal______##\n");
                Console.WriteLine("1 -- Método de Bisseção\n");
                Console.WriteLine("2 -- Método de Newton\n");
                Console.WriteLine("0 -- Sair\n");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            double valorA = 0;
                            double valorB = 0;
                            double valorPrecissao = 0;

                            Console.WriteLine("Digite o valor A:\n");
                            valorA = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite o valor B:\n");
                            valorB = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite o valor da Precissão:\n");
                            valorPrecissao = Convert.ToDouble(Console.ReadLine().ToString());

                            MetodoBissecao.metodoBissecao(valorA, valorB, valorPrecissao);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            double valorA = 0;
                            int numeroInteracoes = 0;
                            double valorPrecissao = 0;

                            Console.WriteLine("Digite o valor A:\n");
                            valorA = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite o numero de interações:\n");
                            numeroInteracoes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o valor da Precissão:\n");
                            valorPrecissao = Convert.ToDouble(Console.ReadLine());

                            MetodoNewton.metodoNewton(valorA, valorPrecissao, numeroInteracoes);
                            Console.Clear();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
