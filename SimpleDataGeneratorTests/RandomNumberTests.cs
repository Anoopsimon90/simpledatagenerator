using SimpleDataGenerator.Services;
using System;
using System.Linq;
using Xunit;

namespace SimpleDataGeneratorTests
{
    public class RandomNumberTests
    {
        [Theory]
        [Trait("Module", "RandomNumber")]
        [InlineData(10,10)]
        [InlineData(0, 0)]
        [InlineData(9999, 9999)]
        public void VerifyRandomNumberListTests(int records,int expectedRecords)
        {
            ISimpleDataGeneratorService simpleDataGeneratorService = new SimpleDataGeneratorService();
            var output= simpleDataGeneratorService.GenerateRandomNumbers(records);

            Assert.True(output.Count()== expectedRecords);
        }

        [Fact]
        [Trait("Module", "RandomNumber")]
        public void VerifyMaxNumberOfRecordsIsSetTo10000()
        {
            ISimpleDataGeneratorService simpleDataGeneratorService = new SimpleDataGeneratorService();
            const string EXCEPTION_MESSAGE = "Maximum limit is 10000";

            var exception = Assert.Throws<OverflowException>(() => simpleDataGeneratorService.GenerateRandomNumbers(10001));

            Assert.True(exception.Message == EXCEPTION_MESSAGE);
        }
    }
}
