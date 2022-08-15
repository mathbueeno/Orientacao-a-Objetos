using System;
using Balta.ContentContext;
namespace Balta.ContentContext
{
    public class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

    }


}