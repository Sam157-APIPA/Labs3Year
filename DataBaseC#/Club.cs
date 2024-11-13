using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Club
    {
        public int ClubID {  get; set; }    
        public  string ClubName { get; set; }   
        public Coaches CoachID { get; set; }
        public Sportsman? Sportsman { get; set; }
    }
}
