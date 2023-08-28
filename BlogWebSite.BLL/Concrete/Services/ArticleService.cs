using AutoMapper;
using BlogWebSite.BLL.Abstract.IServices;
using BlogWebSite.Core.Enums;
using BlogWebSite.DAL.Abstract;
using BlogWebSite.Entities;
using BlogWebSite.Models.DatabaseModels.ArticleDTOs;
using BlogWebSite.Models.ViewModels.ArticleVMs;
using BlogWebSite.Models.ViewModels.CategoryVMs;
using BlogWebSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.BLL.Concrete.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepo _articleRepo;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepo articleRepo, IMapper mapper)
        {
            _mapper = mapper;
            _articleRepo = articleRepo;
        }

        public ResultService<ArticleCreateDTO> Create(ArticleCreateVM articleCreateVM)
        {
            ResultService<ArticleCreateDTO> result = new ResultService<ArticleCreateDTO>();

            ArticleCreateDTO createDto = _mapper.Map<ArticleCreateDTO>(articleCreateVM);
            Article newArticle = _mapper.Map<Article>(createDto);
            var addedArticle = _articleRepo.Create(newArticle);

            if (addedArticle != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public bool Delete(int id)
        {
            Article article = _articleRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if(article != null)
            {
                return _articleRepo.Delete(article);
            }
            return false;
        }

        public ResultService<List<ArticleDetailVM>> GetAll()
        {
            ResultService<List<ArticleDetailVM>> result = new ResultService<List<ArticleDetailVM>>();

            var articles = _articleRepo.GetFilteredList(
                select: article => new ArticleDetailVM
                {
                    ArticleTitle = article.ArticleTitle,                
                },
                where: article => article.State != State.Deleted,
                inculudes: article => article.Category);

            if (articles != null)
            {
                result.Data = articles.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }

            return result;
        }

        public ResultService<ArticleUpdateDTO> Update(ArticleUpdateVM articleUpdateVM)
        {
            throw new NotImplementedException();
        }
    }
}
