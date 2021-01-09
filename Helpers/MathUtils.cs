using System;

namespace BananaTurtles.CSharp.Utils
{
    public static class MathUtils
    {
        /// <summary>
        /// Finds the nearest power of 2 less than or equal to <paramref name="x"/>.
        /// </summary>
        /// <param name="x">An integer</param>
        /// <returns>The nearest power of 2 less than or equal to <paramref name="x"/> or
        /// 0 if there are no powers of 2 less than or equal to <paramref name="x"/>.</returns>
        public static int FloorPow2(int x) {
            if(x <= 0) {
                return 0;
            }

            // if it's a power of 2 return it
            if((x & (x - 1)) == 0){
                return x;
            }

            for(int i = 1; i < 32; i*=2) {
                x |= (x >> i);
            }
            return x - (x >> 1);
        }

        /// <summary>
        /// Finds the nearest power of 2 greater than or equal to <paramref name="x"/>. It may also return
        /// <see cref="Int32.MaxValue"/> if <paramref name="strict"/> is false.
        /// </summary>
        /// <param name="x">An integer</param>
        /// <param name="strict">If true, the function will only return a power of 2, otherwise it may return the MaxValue of
        /// <see cref="Int32.MaxValue"/></param>
        /// <returns></returns>
        public static int CeilingPow2(int x, bool strict = true) {
            if(x <= 0) {
                return 1;
            }

            if(strict && x > 0x40_00_00_00){
                return 0x40_00_00_00;
            }

            if(!strict && x > 0x40_00_00_00){
                return Int32.MaxValue;
            }

            // if it's a power of 2 return it
            if((x & (x - 1)) == 0){
                return x;
            }

            x <<= 1;
            return FloorPow2(x);

        }
    }
}
