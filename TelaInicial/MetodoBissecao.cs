using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInicial
{
    public static class MetodoBissecao
    {
        private static int interacao = 0;
        private static double funcao(double x)
        {
            //Se desejar utilizar outra f(x), alterar essa função
            //f(x) = Math.Pow(x,2) - 2 => Primeira Função
            //f(x) = 
            //f(x) = Math.Pow(x,3) - 9 * Math.Pow(x,2) + 24 * x - 36

            return Math.Pow(x, 2) - 2;
        }
        private static bool verificaMultiplicacao(double a, double x)
        {
            double f1 = funcao(a);

            double f2 = funcao(x);

            if ((f1 * f2) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static double metodoBissecao(double a, double b, double epsilon)
        {
            interacao++;
            //cout << "Valor de a: " << a << " Valor de b: " << b;
            //Condição de Parada:
            if ((Math.Abs(b - a)) < epsilon)
            { //fabs() retorna o módulo da operação

                Console.WriteLine("\nFim. a precisão pertence a:");
                //cout << endl << "\nFim. Epsilon pertence a: ";
                Console.WriteLine("{0} e {1} \n", a, b);
                //cout << a << " e " << b << endl;
                Console.WriteLine("X = {0}", (a + b) / 2 + "\n");
                //cout << endl << "X = " << (a + b) / 2 << endl; //Raiz encontrada final
                Console.ReadKey();
                return 0;
            }
            else
            {
                if (verificaMultiplicacao(a, (a + b) / 2) == true)
                {
                    a = (a + b) / 2;
                    Console.WriteLine("\n Interação {0} \n", interacao);
                    Console.WriteLine("Valor de X: {0}", a);
                    //cout << "Valor de X: " << a; //Raiz encontrada
                    Console.WriteLine("Valor de abs(x-xbarra): {0}", Math.Abs(-1.31146 - a));
                    Console.ReadKey();
                    //cout << " Valor de fabs(x-xbarra): " << fabs(-1.31146 - a) << endl; //Valor do erro absoluto
                    return metodoBissecao(a, b, epsilon);
                }
                else
                {
                    b = (a + b) / 2;
                    Console.WriteLine("\n Interação {0} \n", interacao);
                    Console.WriteLine("Valor de X: {0}", b);
                    //cout << "Valor de X: " << b; //Raiz encontrada
                    Console.WriteLine("Valor de abs(x-xbarra): {0}", Math.Abs(-1.31146 - b));
                    Console.ReadKey();
                    //cout << " Valor de fabs(x-xbarra) = " << fabs(-1.31146 - b) << endl; //Valor do erro absoluto
                    return metodoBissecao(a, b, epsilon);
                }
            }
        }
    }
}
