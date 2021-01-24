using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class UserManager : IUserService
    {
        public void Add(User user, EDevletService service)
        {
            service.VerifyUser(user);
            Console.WriteLine("Yeni kullanıcı eklendi");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi");
        }
    }
}
