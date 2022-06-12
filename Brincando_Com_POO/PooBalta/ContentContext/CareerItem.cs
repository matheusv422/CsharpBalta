using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PooBalta.NotificationContext;
using PooBalta.SharedContext;

namespace PooBalta.ContentContext
{
    public class CareerItem : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Courses Course { get; set; }
        public CareerItem(int order, string title, string description, Courses course)
        {
            if (Course == null)
            AddNotification(new Notification("Course", "O curso não pode ser nulo"));
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}