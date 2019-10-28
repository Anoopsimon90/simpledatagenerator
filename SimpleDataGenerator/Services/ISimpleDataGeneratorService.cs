using System.Collections.Generic;

namespace SimpleDataGenerator.Services
{
    public interface ISimpleDataGeneratorService
    {
        IEnumerable<int> GenerateRandomNumbers(int records);
        IEnumerable<string> GenerateRandomStrings(int records);
    }
}