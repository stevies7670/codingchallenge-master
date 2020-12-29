using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionLine.CodingChallenge.Interfaces
{
    public interface IShirtColorCounter
    {
         List<ColorCount> GetColorCount(List<Shirt> shirts);
    }
}
