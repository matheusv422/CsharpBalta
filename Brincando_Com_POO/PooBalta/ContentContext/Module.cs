using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooBalta.ContentContext
{
    public class Module
    {
    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }

    public Module()
    {
        Lectures = new List<Lecture>();
    }
    }
}