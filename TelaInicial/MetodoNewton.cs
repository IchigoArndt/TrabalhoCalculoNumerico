using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaInicial
{
   public static class MetodoNewton
    {
        private static double funcao(double x)
        {
            //f(1) = Math.Pow(x,2) - 2 = 0

            return Math.Pow(x, 2) - 2; //(1)
        }

       private static double funcaoDerivada(double x)
        {
            //Depende exclusivamente da minha funcao()
            //Derivida da função 1 = Math.Pow(x,1) - 0;

            return Math.Pow(x,1) + 0; //Derivada de (1)
        }

       public static void metodoNewton(double xi, double epsilon, int qtdMaxLoop)
        {
            int count;

            for (count = 0; count < qtdMaxLoop; count++)
            {
                double x = xi - (funcao(xi) / funcaoDerivada(xi));

                //cout << "k = " << count << "; x = " << x;
                Console.WriteLine("K = {0}",count,"; x = {1}",x);
                Console.ReadKey();
                //Condição de parada:

                if ((Math.Abs(x - xi) < epsilon) || Math.Abs(x - xi) / Math.Abs(x) < epsilon || Math.Abs(xi) < epsilon)
                {
                    //cout << "Raiz encontrada: " << x << "\n";
                    Console.WriteLine("Raiz encontrada: {0}", x, "\n");
                    Console.ReadKey();
                    break;
                }

                xi = x;
                //Valor do erro absoluto:
                //cout << " Valor de fabs(x-xbarra): " << fabs(-1.31146 - xi) << endl;
                Console.WriteLine(" Valor de Abs(x-xBarra): {0}",Math.Abs(-1.31146 - xi),"\n");
                Console.ReadKey();
            }
        }
    }
}
