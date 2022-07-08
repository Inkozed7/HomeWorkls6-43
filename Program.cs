using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkls6
{
    internal class Program
    {

       static double[,] coefficient = new double[2, 2];
        static double[] crossPoint = new double[2];


        static void InputCoefficients()
        {
            for (int i = 0; i < coefficient.GetLength(0); i++)
            {
                Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
                for (int j = 0; j < coefficient.GetLength(1); j++)
                    
                    if (j == 0) Console.Write($"Введите коэффициент k: ");
                    else Console.Write($"Введите коэффициент b: ");
                   coefficient[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void OutputResponse(double[,] coeff)
        {
            if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
            {
                Console.Write($"\nПрямые совпадают");
            }
            else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
            {
                Console.Write($"\nПрямые параллельны");
            }
            else
            {
                Decision(coeff);
                Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
            }
        }


        static double[] Decision(double[,] coeff)
        {
            crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
            crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
            return crossPoint;
        }

        static void Main(string[] args)
        {
          
            InputCoefficients();
            OutputResponse(coefficient);
            Console.Read();
        }
    }
}
