using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditoriskaMvc1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; }
        public string DownloadURL { get; set; }
        public string ImageURL { get; set; }
    }
}