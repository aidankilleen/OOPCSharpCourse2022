using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoImplementation
{
    public class UserDaoException : Exception
    {
        public UserDaoException(string message)
            :base(message)
        {

        }
    }
}
