using System;
using System.Collections.Generic;
using System.Text;

namespace Nullabletypes {
    public class Major {


        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double GPA { get; set; }
        public int? SAT { get; set; }
        public string Description { get; internal set; }
        public int MinSat { get; internal set; }

        //public int? MajorId {get; set;}
    }
}
