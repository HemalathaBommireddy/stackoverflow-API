using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Stackoverflow_API.Exceptions
{
    
    
       
        
        [Serializable]
        internal class UserExceptions : Exception
        {
            public UserExceptions()
            {
            }

            public UserExceptions(string message) : base(message)
            {
            }

            public UserExceptions(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected UserExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    
    
}
