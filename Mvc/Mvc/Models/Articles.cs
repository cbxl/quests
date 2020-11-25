using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }       
        public string Content { get; set; }
    }
}