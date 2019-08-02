namespace Fixie_experimentation
{
    public class Calculator
    {
        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public int SubtractInts(int a, int b)
        {
            return a - b;
        }

        public int DivideInts(int a, int b)
        {
            if (b == 0)
            {
                throw new System.NotSupportedException();
            }
            return a / b;
        }

        public bool TryDivideInts(int a, int b, out int result)
        {
            result = 0;
            if (b != 0)
            {
                result = a / b;
            }
            return b != 0;
        }

        public int MultiplyInts(int a, int b)
        {
            return a * b;
        }
    }
}
