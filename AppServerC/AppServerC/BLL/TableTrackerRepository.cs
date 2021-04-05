using AppServerC.BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppServerC.BLL
{
    class TableTrackerRepository
    {
        //я б тут замість username, зробив би Name i Family Name
        public void Signup(string username, string email, string password)
        {
            PasswordWithHashSalter hash = new PasswordWithHashSalter();
            HashWithSaltResult hashResultSha256 = hash.HashWithSalt(password, 64, SHA256.Create());

            using var context = new postgresContext();

            var User = new User();
            User.Email = email;
            User.Username = username;
            User.Password = password;
            User.Salt = hashResultSha256.Salt;

            //напиши щось за валідацію, що маю зробити

            context.Add(User);

        }

        public string Login(string email, string password)
        {
            using var context = new postgresContext();

            var currentUser = context.Users.Where(x => x.Email == email).Single();

            PasswordWithHashSalter hash = new PasswordWithHashSalter();
            HashWithSaltResult hashResultSha256 = hash.HashWithExcistedSalt(password, currentUser.Salt, SHA256.Create());

            if(currentUser.Password == hashResultSha256.Digest)
            {
                return "Success";
            }
            else
            {
                return "Password Verification Error";
            }
        }


    }
}
