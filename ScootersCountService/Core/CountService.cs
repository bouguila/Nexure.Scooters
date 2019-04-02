using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScootersCountService.Core
{
    public class CountService : ICountService
    {
        public int CountMinFE(int[] scooters, int c, int p)
        {
            int totalFEs = 0;
            int remainFE = 0;

            foreach (int scooter in scooters)
            {
                int requiredFE = scooter / p + ((scooter % p == 0) ? 0 : 1);
                totalFEs += requiredFE;

                int remainingScooters = Math.Max(scooter - c, 0);
                int FEsupervise = remainingScooters / p + ((remainingScooters % p == 0) ? 0 : 1);
                int minimumFEs = requiredFE - FEsupervise;
                remainFE = minimumFEs > remainFE ? minimumFEs : remainFE;
            }

            return totalFEs - remainFE;
        }
    }
}
