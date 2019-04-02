using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScootersCountService.Core
{
    public interface ICountService
    {
        int CountMinFE(int[] scooters, int c, int p);
    }
}
