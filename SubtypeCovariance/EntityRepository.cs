using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class EntityRepository
    {
        public  Entity GetByID(Guid id)
        {
            return new Entity(id);
        }
    }
    public interface IEntityRepository<TEntity>
where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
    public class EntityEqualityComparer : IEqualityComparer<Entity>
    {
        public bool Equals(Entity left, Entity right)
        {
            return left.ID == right.ID;
        }
        public Entity GetByID(Guid id)
        {
            Contract.Requires<EntityNotFoundException>(id != Guid.Empty);
            return new Entity();
        }
    }
    
}
