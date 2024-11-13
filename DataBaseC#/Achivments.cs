using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Achivments
    {
        public int AchivmentID { get; set; }
        public ICollection<Sportsman> SportsmenAchiv { get; set; }    
        public string AchivmentName { get; set; }
        public Achivments()
        {
            SportsmenAchiv = new List<Sportsman>();
        }
    }
}
