using System;

namespace TweetAppUserAPI.Exceptions
{
    public class InvalidDatabaseOperationException:ApplicationException
    {
        public InvalidDatabaseOperationException()
        {

        }

        public InvalidDatabaseOperationException(string msg):base(msg)
        {

        }
    }
}
