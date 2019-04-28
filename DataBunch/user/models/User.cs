using System.Collections.Generic;
using DataBunch.collection.models;
using DataBunch.foundation.models;

namespace DataBunch.user.models
{
    public class User: Model
    {
        private List<Collection> collections;

        public User(long id, string name, int age, string privilege): base(id)
        {
            this.Name = name;
            this.Age = age;
            this.Privilege = privilege;
            this.collections = new List<Collection>();
        }

        public User(string name, int age, string privilege)
        {
            this.Name = name;
            this.Age = age;
            this.Privilege = privilege;
            this.collections = new List<Collection>();
        }

        public bool isAdmin()
        {
            return Privilege != null && Privilege == "admin";
        }

        public bool isUser()
        {
            return Privilege != null && Privilege == "user";
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Privilege { get; set; }
        public List<Collection> Collections
        {
            get => this.collections;
            set => this.collections = value;
        }
        public override string ToString()
        {
            return "User: ID => " + ID + " Name => " + Name + " Age => " + Age;
        }
    }
}
