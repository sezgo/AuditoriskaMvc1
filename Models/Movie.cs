using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuditoriskaMvc1.Models
{
    public class Movie
    {
        public Movie()
        {
            clients = new List<Client>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Rating { get; set; }
        [Display(Name = "The Download URL")]
        public string DownloadURL { get; set; }
        [Display(Name = "The Image URL")]
        public string ImageURL { get; set; }
        public virtual ICollection<Client> clients { get; set; }
    }
}