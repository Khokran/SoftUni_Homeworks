using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_CO_Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var article = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] splitCommand = Console.ReadLine().Split(", ");

                string title = splitCommand[0];
                string content = splitCommand[1];
                string author = splitCommand[2];

                var articles = new Article(title, content, author);
                article.Add(articles);

            }
            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                article = article.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy == "content")
            {
                article = article.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy == "author")
            {
                article = article.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, article));
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
