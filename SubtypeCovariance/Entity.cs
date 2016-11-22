using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    /* public class Entity
     {
         public Entity(Guid newID)
         {
             ID = newID;
         }

         public Guid ID { get; set; }

         public string Name { get; set; }
     }*/
    public class Entity
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
    }
    public interface IEqualityComparer<in TEntity>
 where TEntity : Entity
    {
        bool Equals(TEntity left, TEntity right);
    }
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException()
        : base()
        {
        }
        public EntityNotFoundException(string message)
        : base(message)
        {
        }
    }
}
