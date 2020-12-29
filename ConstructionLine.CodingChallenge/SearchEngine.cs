using System;
using System.Collections.Generic;

namespace ConstructionLine.CodingChallenge
{
    public class SearchEngine
    {
        private readonly List<Shirt> _shirts;

        private readonly SizeCount _small;

        private readonly SizeCount _medium;

        private readonly SizeCount _large;

        private readonly ColorCount _red;

        private readonly ColorCount _blue;

        private readonly ColorCount _yellow;

        private readonly ColorCount _white;

        private readonly ColorCount _black;



        public SearchEngine(List<Shirt> shirts)
        {
            _shirts = shirts;
            _small = new SizeCount();
            _medium = new SizeCount();
            _large = new SizeCount();
            _red = new ColorCount();
            _blue = new ColorCount();
            _yellow = new ColorCount();
            _white = new ColorCount();
            _black = new ColorCount();
            foreach (Shirt shirt in _shirts)
            {
                GetSizeCount(shirt);
                GetColorCount(shirt);
            }
         }

        private void GetColorCount(Shirt shirt)
        {
            switch(shirt.Color.Name)
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

        private void GetSizeCount(Shirt shirt)
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

        public SearchResults Search(SearchOptions options)
        {
            

            return new SearchResults
            {
            };
        }
    }
}