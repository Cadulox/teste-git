using System;
using DelegateExample.Services;

namespace DelegateExample
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // tem o mesmo resultado da linha de cima, poré é mais verboso

            // double result = op(a, b);
            double result = op.Invoke(a, b); // tem o mesmo resultado da linha de cima
            Console.WriteLine(result);
        }
    }
}
