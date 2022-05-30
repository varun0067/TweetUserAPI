using System;

namespace TweetAppUserAPI.Exceptions
{
    public class InvalidCredentialsException:ApplicationException
    {
        public InvalidCredentialsException()
        {

        }

        public InvalidCredentialsException(string msg):base(msg)
        {

        }
    }
}
