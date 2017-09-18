using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Portfolio.Persistence.Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public string VideoLink { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsFeatured { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public Project()
        {
            Tags = new Collection<Tag>();
        }
    }
}