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

        public void ConfigureControls(bool editing)
        {
            if (editing)
            {
                txtName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                chkActive.Enabled = true;

                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = false;
            } else
            {
                txtName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                chkActive.Enabled = false;

                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnEdit.Enabled = true;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ConfigureControls(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User activeUser = (User)lstUsers.SelectedItem;

            activeUser.Name = txtName.Text;
            activeUser.Email = txtEmail.Text;
            activeUser.Active = chkActive.Checked;

            dao.UpdateUser(activeUser);

            ConfigureControls(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            User activeUser = (User)lstUsers.SelectedItem;

            txtName.Text = activeUser.Name;
            txtEmail.Text = activeUser.Email;
            chkActive.Checked = activeUser.Active;

            ConfigureControls(false);
        }
    }
}
