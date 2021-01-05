using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using ZenBD_API.Models;

namespace ZenBD_API.Repositories
{
    public class UserRepository:Repository<User>
    {
        public List<User> SearchByName(string SearchValue)
        {
            return this.context.Users.Where(x => x.Name.Contains(SearchValue)|| SearchValue == null).ToList();
        }
        public List<User> SearchByUserName(User user)
        {
            return GetAll().Where(x => x.Username.Contains(user.Username)).ToList();
        }

        public List<User> SearchByEmail(string SearchValue)
        {
            return this.context.Users.Where(x => x.Email.Contains(SearchValue) || SearchValue == null).ToList();
        }
        public List<User> SearchByPhone(string SearchValue)
        {
            return this.context.Users.Where(x => x.PhoneNumber == SearchValue || SearchValue == null).ToList();
        }

        public bool Validdata(User u)
        {
            User user = this.GetAll().Where<User>(x => x.Username == u.Username && x.Password == u.Password).FirstOrDefault();
            {
                if(user==null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public int Validdata(string encodedString)
        {
            string decodedString = Encoding.UTF8.GetString(Convert.FromBase64String(encodedString));
            string[] splittedText = decodedString.Split(new char[] { ':' });
            string userName = splittedText[0];
            string password = splittedText[1];

            User user = this.GetAll().Where<User>(x => x.Username == userName && x.Password == password).FirstOrDefault();
            if (user == null)
            {
                return -1;
            }
            else
            {
                if(user.UserType=="admin")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
                
            }

        }




    }
}