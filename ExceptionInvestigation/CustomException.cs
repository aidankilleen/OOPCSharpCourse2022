using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionInvestigation
{
    class CustomException : Exception
    {
        public CustomException(string message)
            : base(message)
        {

        }
    }
}
