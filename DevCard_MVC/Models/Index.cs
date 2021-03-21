using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace DevCard_MVC.Models
{
    public class Index
    {
        public List<Project> Projects { get; set; }
        public List<Article> Articles { get; set; }
    }
}