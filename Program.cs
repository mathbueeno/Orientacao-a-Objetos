using System;
using Balta.ContentContext;

namespace Orientacao
{

    class Program
    {
        static void Main(string[] args)
        {

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamento OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamento C#", "fundamentos-csharp");
            var courseAspnet = new Course("Fundamento ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspnet);


            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Aprenda OOP", "", null);
            var careerItem1 = new CareerItem(2, "Comece por aqui", "", null);
            var careerItem2 = new CareerItem(3, "Aprenda .NET", "", null);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem2);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }

        }
    }
}

