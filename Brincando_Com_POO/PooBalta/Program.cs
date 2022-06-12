using System;
using PooBalta.ContentContext;
using System.Collections.Generic;
using System.Linq;
using PooBalta.SubscriptionContext;

namespace PooBalta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-csharp"));
            articles.Add(new Article("Artigo sobre .NET", "orientacao-dotnet"));
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Courses>();

            var coursesOOP = new Courses("Fundamentos OOP", "fundamentos-objetos");
            var coursesCsharp = new Courses("Fundamentos C#", "fundamentos-csharp");
            var coursesAspNet = new Courses("Fundamentos .NET", "fundamentos-dotnet");

            courses.Add(coursesOOP);
            courses.Add(coursesCsharp);
            courses.Add(coursesAspNet);

            var careers = new List<Career>();

            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", coursesOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", coursesCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", coursesAspNet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Title}");
                    Console.WriteLine($"{item.Course?.Level}");

                    foreach(var notification in item.Notifications){
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var paypalSubscritpion = new PaypalSubscription();
            var student = new Student();

            student.CreateSubscription(paypalSubscritpion);

        }
    }


}
