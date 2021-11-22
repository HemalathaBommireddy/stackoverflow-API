using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseConnection.Exceptions
{
    
    
        public class UserException : Exception
        {
            public UserException()
            {

            }

            public UserException(string message) : base(message)
            {

            }

            public UserException(string message, Exception innerEx) : base(message, innerEx)
            {

            }
        }
    
}
public class UserExceptions : Exception
{
    public UserExceptions()
    {

    }

    public UserExceptions(string message) : base(message)
    {

    }

    public UserExceptions(string message, Exception innerEx) : base(message, innerEx)
    {

    }
}
