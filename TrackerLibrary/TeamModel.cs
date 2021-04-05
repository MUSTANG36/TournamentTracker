using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TeamModel
    {
        //by deflaut this will be an uninliatize 
        public List<Person> TeamMembers { get; set; } = new List<Person>();

       /* same as above
        * public TeamModel()
        {
            TeamMebers = new List<Person>();
        }*/

        public string TeamName { get; set; }
    }
}
