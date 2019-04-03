using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Nexure.CountService.Validators
{
    public interface IParamsValidator
    {
        void Validate(int[] scooters, int c, int p);
    }
}
