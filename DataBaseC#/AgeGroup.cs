using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class AgeGroup
    {
        public int AgeGroupID { get; set; } 
        public Sportsman SportsManID {  get; set; }
        public int Age {  get; set; }   
        public string GroupName {  get; set; }
    }
}
