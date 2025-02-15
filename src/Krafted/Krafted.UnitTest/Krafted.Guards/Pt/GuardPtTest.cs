using System;
using Krafted.Guards;
using Xunit;
using Assert = Krafted.UnitTests.Xunit.AssertExtension;

namespace Krafted.UnitTest.Krafted.Guards.Pt
{
    [Trait(nameof(UnitTest), "Krafted.Guards")]
    public class GuardPtTest
    {
        [Theory]
        [InlineData("5021550510")]
        [InlineData("ABCDEFGHI")]
        [InlineData("008559600")]
        [InlineData("507408979")]
        [InlineData("503623797")]
        [InlineData("510421497")]
        [InlineData("510429047")]
        [InlineData("980422437")]
        [InlineData("506821147")]
        [InlineData("507127747")]
        [InlineData("510523727")]
        [InlineData("500627997")]
        [InlineData("542623497")]
        [InlineData("511126427")]
        [InlineData("504628767")]
        [InlineData("510520027")]
        [InlineData("562427957")]
        [InlineData("505420067")]
        [InlineData("505425767")]
        [InlineData("504026037")]
        [InlineData("507022387")]
        [InlineData("506720437")]
        [InlineData("504027397")]
        [InlineData("507020307")]
        [InlineData("503529137")]
        [InlineData("503929647")]
        [InlineData("502121037")]
        [InlineData("500522097")]
        [InlineData("514727087")]
        [InlineData("505924437")]
        public void GuardAgainstInvalidNif_InvalidNif_ThrowsException(string invalidNif)
        {
            var ex = Assert.Throws<FormatException>(() => Guard.Against.InvalidNif(invalidNif));
            Assert.Equal("Invalid NIF: {0}.".Format(invalidNif), ex.Message);
        }

        [Theory]
        [InlineData("502155051")]
        [InlineData("501813713")]
        [InlineData("508559600")]
        [InlineData("507408977")]
        [InlineData("503623792")]
        [InlineData("510451497")]
        [InlineData("510469043")]
        [InlineData("980462436")]
        [InlineData("506861147")]
        [InlineData("507187741")]
        [InlineData("510523722")]
        [InlineData("500617996")]
        [InlineData("502613491")]
        [InlineData("511136420")]
        [InlineData("504678760")]
        [InlineData("510570020")]
        [InlineData("502447958")]
        [InlineData("505480069")]
        [InlineData("505435764")]
        [InlineData("504006037")]
        [InlineData("507082389")]
        [InlineData("506740439")]
        [InlineData("504097393")]
        [InlineData("507040309")]
        [InlineData("503539139")]
        [InlineData("503949647")]
        [InlineData("502151030")]
        [InlineData("500582092")]
        [InlineData("504777084")]
        [InlineData("505934434")]
        [InlineData("746225482")]
        public void GuardAgainstInvalidNif_ValidNif_DoesNotThrows(string validNif)
        {
            Assert.DoesNotThrows(() => Guard.Against.InvalidNif(validNif));
        }
    }
}
