using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooBalta.ContentContext
{
    public class Career : Content
    {
        public int Courses { get; set; }
        public List<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        
        
      public Career()
      {
          Items = new List<CareerItem>();
      }  
    }
}