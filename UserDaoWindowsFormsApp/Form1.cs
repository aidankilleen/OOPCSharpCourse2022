using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDaoImplementation;

namespace UserDaoWindowsFormsApp
{
    public partial class Form1 : Form
    {
        UserDao dao = new UserDao(@"C:\data\oocsharpdbbackup\users.db");

        public Form1()
        {
            InitializeComponent();
            List<User> users = dao.GetUsers();

            foreach (User user in users)
            {
                lstUsers.Items.Add(user);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {



        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            User selectedUser = (User)lstUsers.SelectedItem;

            txtId.Text = $"{selectedUser.Id}";
            txtName.Text = selectedUser.Name;
            txtEmail.Text = selectedUser.Email;
            chkActive.Checked = selectedUser.Active;
        }
    }
}
