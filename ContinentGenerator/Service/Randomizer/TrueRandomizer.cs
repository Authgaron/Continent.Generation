using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Randomizer
{
    class TrueRandomizer : Randomizer
    {
        private Random randomGenerator;
        public void SetSeed(int seed)
        {
            randomGenerator = new Random(seed);
        }

        public int RandSeed()
        {
            int newSeed = new Random().Next();
            randomGenerator = new Random(newSeed);
            return newSeed;
        }

        public int RandRange(int lower, int upper)
        {
            return randomGenerator.Next(lower, upper);
        }

        public double Random()
        {
            return randomGenerator.NextDouble();
        }
    }
}
