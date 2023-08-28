using BlogWebSite.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.Core.IBaseRepositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity? Create(TEntity entity);

        void Update(TEntity entity);

        bool Delete(TEntity entity);


        TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter);

        ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter);

        ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                       Expression<Func<TEntity, bool>> where,
                                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                      params Expression<Func<TEntity, object>>[] inculudes);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties); //Bu metotta getAll değil de sadece bir nesne döndürmesini istediğimiz algoritmalar için yazdık.

        Task<TEntity> GetById(int id); // Id ye göre alacağımız entity metodu

        Task<bool> Any(Expression<Func<TEntity, bool>> predicate); //Sadece değeri verip onun içindeki işlemleri anyye göre yaptırmış olacağız

        Task<int> Count(Expression<Func<TEntity, bool>> predicate = null); // Bu metot da makale içinde kaç tane veri var onu döndürecek
    }
}
