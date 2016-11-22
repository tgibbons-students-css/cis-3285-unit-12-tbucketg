using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    /*public class User : Entity
    {
        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
    }*/
    public class User : Entity
    {
        public string EmailAddress { get; private set; }
        public DateTime DateOfBirth { get; private set; }
    }
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        : base()
        {
        }
        public UserNotFoundException(string message)
        : base(message)
        {
        }
    }
   
}
