using NUnit.Framework;
using System.Collections.Generic;
using UserDaoImplementation;

namespace UserDaoTests
{
    public class Tests
    {
        UserDao dao = new UserDao(@"C:\data\testdb\users.db");
        User testUser;

        [SetUp]
        public void Setup()
        {
            if (testUser == null)
            {
                testUser = new User
                {
                    Name = "Test User",
                    Email = "test.user@gmail.com",
                    Active = false
                };
                testUser = dao.AddUser(testUser);
            }
        }
        [TearDown]
        public void TearDown()
        {
            dao.DeleteUser(testUser.Id);
            testUser = null;
        }

        [Test]
        public void TestInsertUserWithApostrophe()
        {
            User user = new User
            {
                Name = "Sarah O'Sullivan",
                Email = "sarah@gmail.com",
                Active = true
            };
            User addedUser = dao.AddUser(user);
            Assert.IsTrue(addedUser.Id > 0);

            dao.DeleteUser(addedUser.Id);
        }
        [Test]
        public void TestUpdate()
        {
            List<User> users = dao.GetUsers();
            User userToChange = users[0];

            Assert.IsNotNull(userToChange);
            if (userToChange.Name.StartsWith('c'))
            {
                userToChange.Name = "CHANGED";
            } else
            {
                userToChange.Name = "changed";
            }

            dao.UpdateUser(userToChange);

            User userCheck = dao.GetUser(userToChange.Id);
            Assert.AreEqual(userCheck.Name, userToChange.Name);
            
        }

        [Test]
        public void TestExceptionThrownOnUserNotFound()
        {
            Assert.Throws<UserDaoException>(() => {

                User user = dao.GetUser(9999);

            });
        }
        [Test]
        public void TestExceptionThrownOnDeleteUserNotFound()
        {
            Assert.Throws<UserDaoException>(() =>
            {
                dao.DeleteUser(9999);
            });
        }
    }
}