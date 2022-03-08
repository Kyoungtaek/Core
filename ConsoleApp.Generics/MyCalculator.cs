using System;

namespace ConsoleApp.Generics
{
    public class MyCalculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            return da + db;
        }

        public T Substract(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            return da - db;
        }

        public T Multiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            return da * db;
        }

        public T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            if(db == 0)
            {
                throw new DivideByZeroException();
            }

            return da / db;
        }
    }
}
