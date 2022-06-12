using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PooBalta.ContentContext.Enums;
using PooBalta.SharedContext;

namespace PooBalta.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}