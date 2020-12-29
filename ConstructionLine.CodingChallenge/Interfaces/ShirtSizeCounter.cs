using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionLine.CodingChallenge.Interfaces
{
    public class ShirtSizeCounter : IShirtSizeCounter
    {
        private readonly SizeCount _small;
        private readonly SizeCount _medium;
        private readonly SizeCount _large;
        public List<SizeCount> GetSizeCount(List<Shirt> shirts)
        {
            List<SizeCount> sizeCounts = new List<SizeCount>();
            foreach (Shirt shirt in shirts)
            {
                CalculateSizeCounts(shirt);
            }
            sizeCounts.Add(_small);
            sizeCounts.Add(_medium);
            sizeCounts.Add(_large);
            
            return sizeCounts;
        }

        private void CalculateSizeCounts(Shirt shirt)
        {
            switch (shirt.Size.Name)
            {
                case "Small":
                    _small.Count++;
                    break;
                case "Medium":
                    _medium.Count++;
                    break;
                case "Large":
                    _large.Count++;
                    break;
            }
        }
    }
}
