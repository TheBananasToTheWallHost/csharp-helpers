using NUnit.Framework;
using BananaTurtles.CSharp.Utils;

namespace Testing
{
    public class MathUtilTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category(nameof(MathUtils))]
        [Category(nameof(MathUtils.FloorPow2))]
        [Test, Sequential]
        public void TestFloorPow2(
            [ValueSource(nameof(Pow2RoundingTestData))] int x, 
            [ValueSource(nameof(FloorPow2Expected))] int expected)
        {
             Assert.AreEqual(MathUtils.FloorPow2(x), expected);
        }

        [Category(nameof(MathUtils))]
        [Category(nameof(MathUtils.CeilingPow2))]
        [Test, Sequential]
        public void TestStrictCeilingPow2(
            [ValueSource(nameof(Pow2RoundingTestData))] int x, 
            [ValueSource(nameof(StrictCeilingPow2Expected))] int expected)
        {
            Assert.AreEqual(MathUtils.CeilingPow2(x), expected);
        }

        [Category(nameof(MathUtils))]
        [Category(nameof(MathUtils.CeilingPow2))]
        [Test, Sequential]
        public void TestLenientCeilingPow2(
            [ValueSource(nameof(Pow2RoundingTestData))] int x, 
            [ValueSource(nameof(LenientCeilingPow2Expected))] int expected)
        {
            Assert.AreEqual(MathUtils.CeilingPow2(x, strict: false), expected);
        }

        private static int[] Pow2RoundingTestData = {
            3, 6, 678, 1024, 33_554_432, 16_777_215, 0x4f_ff_ff_ff,
            0x40_00_00_01, 0x40_00_00_00, 0, -10, -3_000_000
        };

        private static int[] FloorPow2Expected = {
            2, 4, 512, 1024, 33_554_432, 8_388_608, 0x40_00_00_00,
            0x40_00_00_00, 0x40_00_00_00,  0, 0, 0
        };

        private static int[] StrictCeilingPow2Expected = {
            4,  8,  1024, 1024, 33_554_432, 16_777_216, 0x40_00_00_00,
            0x40_00_00_00, 0x40_00_00_00,  1, 1, 1
        };

        private static int[] LenientCeilingPow2Expected = {
            4,  8,  1024, 1024, 33_554_432, 16_777_216, 0x7f_ff_ff_ff, 
            0x7f_ff_ff_ff, 0x40_00_00_00,  1, 1, 1
        };
    }
}