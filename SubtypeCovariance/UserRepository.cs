using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    /* public class UserRepository : EntityRepository
     {
         //public override Entity GetByID(Guid id)
         public override User GetByID(Guid id)
         {
             return new User(id);
         }
     }*/
    public class UserRepository : IEntityRepository<User>
    {
        public User GetByID(Guid id)
        {
            Contract.Requires<UserNotFoundException>(id != Guid.Empty);
            return new User();
        }
   
    }
}
