using MyLib;
using MyLib.Models;
using MyLib.Presenters;
using MyLib.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyMVP
{
    public partial class MainForm : Form, IUsersView
    {
        private UsersPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new UsersPresenter(new MemoryUsersModel(), this, Card);
        }
        public void Show(List<User> users)
        {
            UsersList.DataSource = null;
            UsersList.DataSource = users;
        }
        void NameFiltr_Click(object sender, EventArgs e)
        {
            presenter_.View__FiltrEvent(NameTextBox.Text, ComboBoxFiltr.Text);
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            presenter_.Model__RefreshLoadedInfoUsers();
        }
        private void UsersList_SelectionChanged(object sender, EventArgs e)
        {
            int row = UsersList.CurrentCell.RowIndex;
            presenter_.SelectUser(row);
        }
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult DialogRes = MessageBox.Show("Вы хотите удалить выбранного пользователя?", "Проверка", MessageBoxButtons.YesNo);
            if (DialogRes == DialogResult.Yes)
            {
                presenter_.Model__DeleteUser();
            }
            else if (DialogRes == DialogResult.No) { }
        }
        public int GetSelectedUserIndex()
        {
            return UsersList.CurrentCell.RowIndex;
        }
    }
}