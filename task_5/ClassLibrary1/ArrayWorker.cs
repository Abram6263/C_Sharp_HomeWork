using System;

namespace ClassLibrary1
{
    public static class ArrayWorker
    {
        public static int[] MassInvert( int[] mass)
        {
            Array.Reverse(mass);
            return mass;
        }

        public static int[] MassNewValue(int[] source, int index, int newValue)
        {
            Array.Resize(ref source, source.Length + 1);
            for(int i = source.Length - 1, j = i - 1; j >= index; i--, j--)
            {
                source[i] = source[j];
            }
            source[index] = newValue;

            return source;
        }
    }
}
