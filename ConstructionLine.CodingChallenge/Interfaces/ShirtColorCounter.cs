using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionLine.CodingChallenge.Interfaces
{
    class ShirtColorCounter : IShirtColorCounter
    {
        private ColorCount _red = new ColorCount();
        private ColorCount _blue = new ColorCount();
        private ColorCount _yellow = new ColorCount();
        private ColorCount _white = new ColorCount();
        private ColorCount _black = new ColorCount();
        public List<ColorCount> GetColorCount(List<Shirt> shirts)
        {
            return ColourCount(shirts);
        }

        private List<ColorCount> ColourCount(List<Shirt> shirts)
        {
            List<ColorCount> colorCounts = new List<ColorCount>();
            
            foreach (Shirt shirt in shirts)
            {
                CalculateColourCounts(shirt);
            }
            colorCounts.Add(_red);
            colorCounts.Add(_blue);
            colorCounts.Add(_yellow);
            colorCounts.Add(_black);
            colorCounts.Add(_white);
            return colorCounts;
        }

        

        private void CalculateColourCounts(Shirt shirt)
        {
            switch (shirt.Color.Name)
            {
                case "Red":
                    _red.Count++;
                    break;
                case "Blue":
                    _blue.Count++;
                    break;
                case "Yellow":
                    _yellow.Count++;
                    break;
                case "White":
                    _white.Count++;
                    break;
                case "Black":
                    _black.Count++;
                    break;
            }
        }
    }
}
