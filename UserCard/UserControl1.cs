using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib.Views;
using MyLib;
using System.IO;
using MyLib.Presenters;
using MyLib.Models;

namespace UserCard
{
    public partial class UserControl1: UserControl, IUserCard
    {
        private string login_;
        
        public UserControl1()
        {
            InitializeComponent();
        }
        public event Action<User> Redact;
        public void Show(User u)
        {
            textBoxName.Text = u.Name;
            textBoxSurname.Text = u.Surname;
            textBoxEmail.Text = u.Email;
            login_ = u.Login;

            pictureBox1.Image = Image.FromFile(u.Path);
        }
        private void buttonRedact_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBoxName.Text;
            u.Surname = textBoxSurname.Text;
            u.Email = textBoxEmail.Text;
            u.Login = login_;
            Redact.Invoke(u);
        }
    }
}