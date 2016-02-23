using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Randomizer
{
    interface IRandomizer
    {
        void SetSeed(int seed);
        int RandSeed();
        int RandRange(int lower, int upper);
        double Random();
    }
}
