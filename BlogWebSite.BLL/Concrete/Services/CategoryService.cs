using AutoMapper;
using BlogWebSite.BLL.Abstract.IServices;
using BlogWebSite.Core.Enums;
using BlogWebSite.DAL.Abstract;
using BlogWebSite.Models.ViewModels.CategoryVMs;
using BlogWebSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.BLL.Concrete.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo categoryRepo , IMapper mapper)
        {
               _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public ResultService<List<CategoryDetailVM>> GetAll()
        {
            ResultService<List<CategoryDetailVM>> result = new ResultService<List<CategoryDetailVM>>();
            // "includes" parametresi ile kategori nesnelerinin Articles ilişkili öğelerini de yükleme yapılarak veritabanı sorgusu optimize ediliyor.
            var categories = _categoryRepo.GetFilteredList(select: x => new CategoryDetailVM
            {
                CategoryName = x.CategoryName
            }, where: x => x.State != State.Deleted, inculudes: x => x.Articles);

            if (categories != null)
            {
                result.Data = categories.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }
    }
}
