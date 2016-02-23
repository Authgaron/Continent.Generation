using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Randomizer
{
    abstract class Randomizer : IRandomizer
    {
        public int seed { get; set; }

        public Randomizer(int? seed = null)
        {
            if (seed != null)
            {
                this.seed = (int)seed;
                SetSeed((int)seed);
            }
            else
            {
                this.seed = RandSeed();    
            }
        }

        public void SetSeed(int seed)
        {
            throw new NotImplementedException();
        }

        public int RandSeed()
        {
            throw new NotImplementedException();
        }

        public int RandRange(int lower, int upper)
        {
            throw new NotImplementedException();
        }

        public double Random()
        {
            throw new NotImplementedException();
        }
    }
}
