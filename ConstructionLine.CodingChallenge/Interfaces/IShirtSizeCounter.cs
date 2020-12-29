using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionLine.CodingChallenge.Interfaces
{
    interface IShirtSizeCounter
    {
        List<SizeCount> GetSizeCount(List<Shirt> shirts);
    }
}
