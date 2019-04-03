using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nexure.CountService.Validators
{
    public class ParamsValidator : IParamsValidator
    {
        private int minNumDistricts = 1;
        private int maxNumDistricts = 100;
        private int minNumScootersInDistrict = 0;
        private int maxNumScootersInDistrict = 1000;
        private int minNumScootersForFM = 1;
        private int maxNumScootersForFM = 999;
        private int minNumScootersForFE = 1;
        private int maxNumScootersForFE = 1000;

        public void Validate(int[] scooters, int c, int p)
        {
            if (scooters.Length < minNumDistricts || scooters.Length > maxNumDistricts)
            {
                throw new Exception("Incorrect number of Districts");
            }

            for (int i = 0; i < scooters.Length; i++)
            {
                validateNumScootersInDistrict(scooters[i]);
            }

            if (c < minNumScootersForFM || c > maxNumScootersForFM)
            {
                throw new Exception("Incorrect number of Scooters For FM");
            }

            if (p < minNumScootersForFE || p > maxNumScootersForFE)
            {
                throw new Exception("Incorrect number of Scooters For FE");
            }
        }

        // verifies the number of scooters in a given district
        private void validateNumScootersInDistrict(int numScooters)
        {
            if (numScooters < minNumScootersInDistrict || numScooters > maxNumScootersInDistrict)
            {
                throw new Exception("Incorrect number of Scooters in district");
            }
        }
    }
}
