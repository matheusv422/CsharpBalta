using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooBalta.ContentContext
{
    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}