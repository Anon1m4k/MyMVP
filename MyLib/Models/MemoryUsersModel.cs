using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        private List<User> _users = new List<User>();
        private List<User> FiltrUser = new List<User>();
        public event Action SuccessLoadedInfoUsers;
        public List<User> GetUsers()
        {
            return FiltrUser;
        }
        public void LoadInfoUsers()
        {
            _users.Add(new User
            {
                Login = "AAAaaa",
                Password = 0,
                Name = "aaa",
                Surname = "AAA",
                DateBirth = new DateTime(2001, 01, 01),
                Path = "sample-green-400x300.jpg",
                Email = "@"
            });
            _users.Add(new User
            {
                Login = "BBBbbb",
                Password = 1,
                Name = "bbb",
                Surname = "BBB",
                DateBirth = new DateTime(2002, 02, 02), 
                Path = "sample-red-400x300.jpg",
                Email = "@" 
            });
            _users.Add(new User 
            {
                Login = "CCCccc",
                Password = 2,
                Name = "ccc",
                Surname = "CCC", 
                DateBirth = new DateTime(2003, 03, 03),
                Path = "sample-green-400x300.jpg",
                Email = "@"
            });
            _users.Add(new User 
            {
                Login = "DDDddd",
                Password = 3,
                Name = "ddd",
                Surname = "DDD",
                DateBirth = new DateTime(2004, 04, 04),
                Path = "sample-red-400x300.jpg",
                Email = "@"
            });
            FiltrUser = _users;
            SuccessLoadedInfoUsers.Invoke();
        }
        public void FiltrUserData(string NameFiltr, string input)
        {
            if (input == "Имя")
            {
                FiltrUser = _users.Where(p => p.Name.Contains(NameFiltr)).ToList();
                SuccessLoadedInfoUsers.Invoke();
            }
            if (input == "Логин")
            {
                FiltrUser = _users.Where(p => p.Login.Contains(NameFiltr)).ToList();
                SuccessLoadedInfoUsers.Invoke();
            }
        }
        public void UserCard__Redact(User obj)
        {
            for(int index = 0; index < _users.Count;++index)
            {
                User user = _users.ElementAt(index);
                if (obj.Login == user.Login)
                {
                    _users[index].Name = obj.Name;
                    _users[index].Surname = obj.Surname;
                    _users[index].Email = obj.Email;
                }
            }
            SuccessLoadedInfoUsers.Invoke();
        }
        public List<User> ReturnUsers()
        {
            return _users;
        }
        public void DeleteUser (int del)
        {
            User delete = FiltrUser.FirstOrDefault(u => u.Password == del);
            if (delete != null)
            {
                _users.Remove(delete);
                FiltrUser.Remove(delete);
                SuccessLoadedInfoUsers.Invoke();
            }
        }      
    }
}