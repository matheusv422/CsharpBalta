using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PooBalta.SharedContext;

namespace PooBalta.ContentContext
{
    public abstract class Content : Base
    {
    public Content (string title, string url){ 
    Title = title;
    Url = url;
     
    }

    public string Url { get; set; }
    public string Title { get; set; }
        
    }
}