using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IUserService
    {
        void Add(User user, EDevletService service);
        void Update(User user);
        void Delete(User user);
    }
}
