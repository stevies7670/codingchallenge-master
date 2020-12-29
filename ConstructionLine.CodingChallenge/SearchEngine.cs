using ConstructionLine.CodingChallenge.Interfaces;
using System;
using System.Collections.Generic;

namespace ConstructionLine.CodingChallenge
{
    public class SearchEngine
    {
        private readonly List<Shirt> _shirts; 
        private SearchEngineResults results;


        public SearchEngine(List<Shirt> shirts)
        {
            _shirts = shirts;
            results = new SearchEngineResults();
            GetColorCount(_shirts);
            GetSizeCount(_shirts);


         }        

        private void GetColorCount(List<Shirt> shirts)
        {
            IShirtColorCounter colorCounter = new ShirtColorCounter();
            results.colorCounts = colorCounter.GetColorCount(shirts);            
        }

        private void GetSizeCount(List<Shirt> shirts)
        {
            IShirtSizeCounter sizeCounter = new ShirtSizeCounter();
            results.sizeCounts = sizeCounter.GetSizeCount(shirts);
        }


        public SearchResults Search(SearchOptions options)
        {
            

            return new SearchResults
            {
            };
        }
    }
}