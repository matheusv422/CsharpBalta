using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooBalta.ContentContext
{
public class Courses : Content
{

public string Tag { get; set; }
public IList<Module> Modules { get; set; }
public int DurationInMinutes { get; set; } 
public EContentLevel Level { get; set; }    
        
public Courses()
{
    Modules = new List<Module>();
}
}
}