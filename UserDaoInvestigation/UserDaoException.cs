using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoInvestigation
{
    class UserDaoException : Exception
    {
        public UserDaoException(string message)
            :base(message)
        {

        }
    }
}
