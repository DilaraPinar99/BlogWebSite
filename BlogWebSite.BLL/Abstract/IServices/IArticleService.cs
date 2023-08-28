using BlogWebSite.BLL.Concrete.Services;
using BlogWebSite.Models.DatabaseModels.ArticleDTOs;
using BlogWebSite.Models.ViewModels.ArticleVMs;
using BlogWebSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.BLL.Abstract.IServices
{
    public interface IArticleService
    {
        ResultService<ArticleCreateDTO> Create(ArticleCreateVM articleCreateVM);

        bool Delete(int id);

        ResultService<ArticleUpdateDTO> Update(ArticleUpdateVM articleUpdateVM);

        ResultService<List<ArticleDetailVM>> GetAll();



    }
}
