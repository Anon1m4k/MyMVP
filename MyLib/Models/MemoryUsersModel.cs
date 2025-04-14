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
                Id = 1,
                Login = "AAAaaa",
                Password = "123",
                Name = "aaa",
                Surname = "AAA",
                DateBirth = new DateTime(2001, 01, 01),
                Path = "Котик.jpg",
                Email = "@"
            });
            _users.Add(new User
            {
                Id = 2,
                Login = "BBBbbb",
                Password = "456",
                Name = "bbb",
                Surname = "BBB",
                DateBirth = new DateTime(2002, 02, 02), 
                Path = "Лисичка.jpg",
                Email = "@" 
            });
            _users.Add(new User 
            {
                Id = 3,
                Login = "CCCccc",
                Password = "789",
                Name = "ccc",
                Surname = "CCC", 
                DateBirth = new DateTime(2003, 03, 03),
                Path = "Мишка.jpg",
                Email = "@"
            });
            _users.Add(new User 
            {
                Id = 4,
                Login = "DDDddd",
                Password = "012",
                Name = "ddd",
                Surname = "DDD",
                DateBirth = new DateTime(2004, 04, 04),
                Path = "Пингвин.jpg",
                Email = "@"
            });
            FiltrUser = _users;
            SuccessLoadedInfoUsers.Invoke();
        }
        public void FiltrUserData(string NameFiltr, string input)
        {
            if (input == "имени")
            {
                FiltrUser = _users.Where(p => p.Name.Contains(NameFiltr)).ToList();
                SuccessLoadedInfoUsers.Invoke();
            }
            if (input == "логину")
            {
                FiltrUser = _users.Where(p => p.Login.Contains(NameFiltr)).ToList();
                SuccessLoadedInfoUsers.Invoke();
            }
        }
        public void ChangeUser(User obj)
        {
            for (int index = 0; index < _users.Count; ++index)
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
        public void DeleteUser(int del)
        {
            User delete = FiltrUser.FirstOrDefault(u => u.Id == del);
            if (delete != null)
            {
                _users.Remove(delete);
                FiltrUser.Remove(delete);
                SuccessLoadedInfoUsers.Invoke();
            }
        }
    }
}