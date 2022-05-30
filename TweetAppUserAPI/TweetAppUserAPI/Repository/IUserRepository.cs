using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TweetAppUserAPI.Models;

namespace TweetAppUserAPI.Repository
{
    public interface IUserRepository
    {
        List<User> FindAll();
        User FindByCondtion(Expression<Func<User, bool>> expression);
        void Create(User user);
        void Update(User user);
    }
}
