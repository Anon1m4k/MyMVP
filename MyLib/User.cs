using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class User
    {
        public string Login { get; set; }
        public int Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email;
        public string Path;
        public DateTime DateBirth { get; set; }
    }
}
