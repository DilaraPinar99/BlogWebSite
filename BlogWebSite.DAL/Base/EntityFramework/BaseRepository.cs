using BlogWebSite.Core.BaseEntities;
using BlogWebSite.Core.IBaseRepositories;
using BlogWebSite.DAL.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.DAL.Base.EntityFramework
{
    public abstract class BaseRepository<TEntity, TContext> :
        IBaseRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        private BlogWebSiteDbContext _context;

        protected readonly TContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(TContext context)
        {
            _db = context;
            _dbSet = context.Set<TEntity>();
        }

        //Metotlar Neden Asenkron?
        /*
         * Geleneksel senkron programlamada, bir işlem tamamlanana kadar, sonraki kod satırları çalıştırılmaz. Bu, özellikle uzun sürecek işlemlerle uğraşırken uygulamanın tepkisiz görünmesine neden olabilir. Asenkron programlamada ise, uzun sürecek işlemler başlatıldıktan sonra bile program akışı devam eder ve bu sırada başka işlemler yapılabilir.        
         */
        public async Task<bool> Any(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<int> Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return await _dbSet.CountAsync();
            }
            return await _dbSet.CountAsync(predicate);
        }

        public TEntity Create(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            return _db.SaveChanges() > 0 ? entity : null;
        }

        public bool Delete(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            _db.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter)
        {
           return _dbSet.Where(filter).ToList();
        }

        //Bu metodun getAll metodundan farkı şudur, bu metotta tek bir varlık geri göner bir liste değil. Teşekkürler
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include)); //Aggregate metodu, bir koleksiyon üzerinde döngü yaparken bir sonraki adım için bir fonksiyonun sonucunu kullanmanıza olanak tanır. Bu durumda, includes dizisindeki her ilişkili özellik, current olarak adlandırılan mevcut sorguya eklenir. Sonuç olarak, tüm ilişkili özellikler ana sorguya eklenir.
            }

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return query.Select(select).ToList();
        }

        public TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _db.SaveChanges();
        }
    }
}
