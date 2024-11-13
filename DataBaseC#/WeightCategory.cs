using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class WeightCategory
    {
        public int WeightCategoryID { get; set; }
        public ICollection<Weight> WeightID { get; set; }
        public string Category {  get; set; } 
        public WeightCategory()
        {
            WeightID = new List<Weight>();
        }
    }
}
