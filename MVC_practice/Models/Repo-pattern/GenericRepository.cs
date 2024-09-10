
using System;

namespace MVC_practice.Models.Repo_pattern
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity :DomainEntity
    {
        List<TEntity> entityInstance = new List<TEntity>();
        public void AddPerson(TEntity entity)
        {
            entityInstance.Add(entity);
        }

        public void DeletPerson(int id)
        {
            foreach (var entity in entityInstance) 
            {
                if (entity.Id == id)
                {
                    entityInstance.Remove(entity);
                }
            
            
            }
        }
        public IList<TEntity> GetAll()
        {
            return entityInstance.ToList();
        }
    }
}
