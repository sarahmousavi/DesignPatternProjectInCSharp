using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //Context Class
    public class SortContext
    {
        private ISortStrategy _sortStrategy;

        //Set the strategy dynamically
        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        //Execute the sorting Strategy
        public void Sort(List<int> list)
        {
            _sortStrategy.Sort(list);
        }
    }
}