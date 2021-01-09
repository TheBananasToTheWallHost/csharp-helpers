using System;

namespace BananaTurtles.CSharp.Utils
{
    public static class MathUtils
    {
        /// <summary>
        /// Finds the nearest power of 2 less than or equal to <paramref name="x"/>.
        /// </summary>
        /// <param name="x">an integer</param>
        /// <returns>The nearest power of 2 less than or equal to <paramref name="x"/> or
        /// 0 if there are no powers of 2 less than or equal to <paramref name="x"/>.</returns>
        public static int FloorToPowerOfTwo(int x) {
            if(x <= 0) {
                return 0;
            }

            for(int i = 1; i < 32; i*=2) {
                x |= (x >> i);
            }
            return x - (x >> 1);
        }

        /// <summary>
        /// Finds the nearest power of 2 greater than or equal to <paramref name="x"/>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="strict"></param>
        /// <returns></returns>
        public static int CeilingToPowerOfTwo(int x, bool strict) {
            if(x <= 0) {
                return 1;
            }


        }
    }
}
