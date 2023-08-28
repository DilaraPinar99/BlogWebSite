using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.Models.ViewModels.ArticleVMs
{
    public class ArticleCreateVM : ArticleBaseVM
    {
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public DateTime CreationDate { get; set; }
        public int ViewsCount { get; set; } //Görüntülenme Sayısı
        public int NumberOfLikes { get; set; } //Beğeni sayısı

        public string? Image { get; set; }
    }
}
