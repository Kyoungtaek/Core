using System;

namespace ConsoleApp.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator<int> testInt = new MyCalculator<int>();

            int iA = 23;
            int iB = 12;
            Console.WriteLine($"int Parameters: {iA}, {iB}");
            Console.WriteLine($"int Add: {testInt.Add(iA, iB)}");
            Console.WriteLine($"int Substract: {testInt.Substract(iA, iB)}");
            Console.WriteLine($"int Multiply: {testInt.Multiply(iA, iB)}");
            Console.WriteLine("==========");

            MyCalculator<float> testFloat = new MyCalculator<float>();

            float fA = 23.234F;
            float fB = 12.3F;
            Console.WriteLine($"float Parameters: {fA}, {fB}");
            Console.WriteLine($"float Add: {testFloat.Add(fA, fB)}");
            Console.WriteLine($"float Substract: {testFloat.Substract(fA, fB)}");
            Console.WriteLine($"float Multiply: {testFloat.Multiply(fA, fB)}");
            Console.WriteLine("==========");

            MyCalculator<double> testDouble = new MyCalculator<double>();

            double dbA = 1.235235;
            double dbB = 0.12;
            Console.WriteLine($"double Parameters: {dbA}, {dbB}");
            Console.WriteLine($"double Add: {testDouble.Add(dbA, dbB)}");
            Console.WriteLine($"double Substract: {testDouble.Substract(dbA, dbB)}");
            Console.WriteLine($"double Multiply: {testDouble.Multiply(dbA, dbB)}");
            Console.WriteLine("==========");

            // Exception handlign for division.
            try
            {
                Console.WriteLine($"int Divide: {testInt.Divide(1, 1)}");
                Console.WriteLine($"float Divide: {testFloat.Divide(fA, 0)}");
                Console.WriteLine($"double Divide: {testDouble.Divide(dbA, 0)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("==========");
        }
    }
}
