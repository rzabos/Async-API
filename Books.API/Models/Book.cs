using System;

namespace Books.API.Models
{
    public class Book
    {
        public string Author { get; set; }

        public string Description { get; set; }

        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}