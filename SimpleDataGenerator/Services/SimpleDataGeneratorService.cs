using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDataGenerator.Services
{
    public class SimpleDataGeneratorService : ISimpleDataGeneratorService
    {
        public IEnumerable<int> GenerateRandomNumbers(int records)
        {
            if (records > 10000) throw new OverflowException("Maximum limit is 10000");
            Random rand = new Random();
            return Enumerable.Range(0, records)
                                         .Select(i => new Tuple<int, int>(rand.Next(records), i))
                                         .OrderBy(i => i.Item1)
                                         .Select(i => i.Item2);
        }

        public IEnumerable<string> GenerateRandomStrings(int records)
        {
            Random random = new Random();

            //const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //return Enumerable.Repeat(chars, records)
            //  .Select(s => s[random.Next(s.Length)]).ToArray();

            return null;
        }
    }
}
