using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Application.Services.GenericRepo
{
    public interface ICrudEntity<TEntity> where TEntity : class
    {
 
        void Insert(TEntity entity);
    

    }

    public class CrudEntity<TEntity> : ICrudEntity<TEntity> where TEntity : class
    {

        internal readonly IConfiguration _configuration;
        internal DbSet<TEntity> dbSet;

        public CrudEntity(IConfiguration configuration, DbSet<TEntity> dbSet, DbContext context)
        {
            this._configuration = configuration;
            this.dbSet = context.Set<TEntity>();


        }


        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }


    }


}
