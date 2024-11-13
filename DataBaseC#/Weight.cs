using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    class Weight
    {
        public int WeightID {  get; set; }
        public ICollection<Sportsman> SportsmanID { get; set; }
        public int Date { get; set; }
        public int WeightKg {  get; set; } 
        public int  CatID {  get; set; }  
        public WeightCategory WeightCategory { get; set; }
        public Weight()
        {
            SportsmanID = new List<Sportsman>();
        }
    }
}
