using RomanNumerals;
using System;
using System.Net;
using System.Runtime.CompilerServices;
using Xunit;

namespace Roman.UnitTest
{
    public class RomanTest
    {
        [Fact]
        public void GivenInteger1_ReturnI()
        {
            string romanNumber = 1.ToRoman();
            Assert.Equal<string>("I", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger5_ReturnV()
        {
            string romanNumber = 5.ToRoman();
            Assert.Equal<string>("V", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger10_ReturnX()
        {
            string romanNumber = 10.ToRoman();
            Assert.Equal<string>("X", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger50_ReturnL()
        {
            string romanNumber = 50.ToRoman();
            Assert.Equal<string>("L", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger100_ReturnC()
        {
            string romanNumber = 100.ToRoman();
            Assert.Equal<string>("C", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger500_ReturnD()
        {
            string romanNumber = 500.ToRoman();
            Assert.Equal<string>("D", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger1000_ReturnM()
        {
            string romanNumber = 1000.ToRoman();
            Assert.Equal<string>("M", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger2_ReturnII()
        {
            string romanNumber = 2.ToRoman();
            Assert.Equal<string>("II", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger4_ReturnIV()
        {
            string romanNumber = 4.ToRoman();
            Assert.Equal<string>("IV", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger9_ReturnIX()
        {
            string romanNumber = 9.ToRoman();
            Assert.Equal<string>("IX", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger40_ReturnXL()
        {
            string romanNumber = 40.ToRoman();
            Assert.Equal<string>("XL", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger94_ReturnXCIV()
        {
            string romanNumber = 94.ToRoman();
            Assert.Equal<string>("XCIV", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void GivenInteger9494_ReturnMMMMMMMMMCLXCIV()
        {
            string romanNumber = 9494.ToRoman();
            Assert.Equal<string>("MMMMMMMMMCDXCIV", romanNumber, StringComparer.Ordinal);
        }

        [Fact]
        public void CompareToThirdParty()
        {
            for (int i = 1; i < 500; ++i)
            {
                Assert.Equal(i.ToRoman(), i.ToRomanNumerals());
            }
        }
    }
}
