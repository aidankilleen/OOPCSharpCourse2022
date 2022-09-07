using System;
using System.Collections;
using System.Collections.Generic;

namespace CommonBaseClassInvestigation
{
    class User: Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public User()
        {
        }
        public User(int id, string name, string email, bool active)
        {
            Id = id;
            Name = name;
            Email = email;
            Active = active;
        }
        public override string ToString()
        {
            return $"{Id} - {Name} - { Email} - { (Active ? "Active": "Inactive") }";
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   Name == user.Name &&
                   Email == user.Email &&
                   Active == user.Active;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email, Active);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Common Base Class Investigation ");

            User user = new User
            {
                Id = 1,
                Name = "Alice",
                Email = "alice@gmail.com",
                Active = false
            };

            Console.WriteLine(user);

            User user2 = new User
            {
                Id = 1,
                Name = "alice",
                Email = "alice@gmail.com",
                Active = false
            };

            if (user.Equals(user2))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }

            Console.WriteLine(user.GetHashCode());
            Console.WriteLine(user2.GetHashCode());

            List<Object> stuff = new List<Object>
            {
                "this is a string",
                100,
                new User (),
            };

            stuff.ForEach(item => Console.WriteLine(item.GetType()));

            ArrayList ar = new ArrayList();

        }
    }
}
