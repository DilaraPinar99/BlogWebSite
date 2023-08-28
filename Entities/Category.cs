using BlogWebSite.Core.BaseEntities;
using BlogWebSite.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
     
        public Category()
        {
            Articles = new HashSet<Article>();
        }

    }
}
