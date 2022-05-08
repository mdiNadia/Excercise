using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;


namespace Persistence
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
 
        void Insert(TEntity entity);
    

    }

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal readonly DataContext context;
        internal readonly IConfiguration _configuration;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(DataContext context, IConfiguration configuration, DbSet<TEntity> dbSet)
        {
            this.context = context;
            this._configuration = configuration;
            this.dbSet = context.Set<TEntity>();


        }


        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }


    }


}
