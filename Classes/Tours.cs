using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTours { 

        public class Tour
        {
            public string name;
            public string details;

            public int cost;
        }

    public class BusinessTour : Tour
    {
        public string organization;
    }

    public class WorldTour : Tour
    {
        public List<string> countries = new List<string>();
    }

    public class ExclusiveTour : Tour
    {
        public string exclusiveDetails;
    }


}
