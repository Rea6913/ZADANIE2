using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            int symm = 0;
            if (count < 1)
                throw new NotImplementedException();
            for (int i = 1; i <= count; i++)
            {
                symm += number;
                number = number + add;

            }
            return symm;
        }
    }
}
