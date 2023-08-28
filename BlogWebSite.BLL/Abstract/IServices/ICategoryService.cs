using BlogWebSite.Models.ViewModels.CategoryVMs;
using BlogWebSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.BLL.Abstract.IServices
{
    public interface ICategoryService
    {
        ResultService<List<CategoryDetailVM>> GetAll();

    }
}
