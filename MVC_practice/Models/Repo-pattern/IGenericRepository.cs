using System.Collections.Generic;

namespace MVC_practice.Models.Repo_pattern
{
    public interface IGenericRepository<TEntity>
    {
        public void AddPerson(TEntity entity);
        public void DeletPerson(int id );
        IList<TEntity> GetAll();
    }
}
