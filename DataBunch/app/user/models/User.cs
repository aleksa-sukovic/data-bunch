using System.Collections.Generic;
using DataBunch.app.collection.models;
using DataBunch.app.foundation.models;
using DataBunch.app.foundation.utils;

namespace DataBunch.app.user.models
{
    public class User: Model
    {
        private List<Collection> collections;
        private string password;

        public User()
        {
            Username = "";
            this.password = "";
            Name = "";
            Privilege = "user";
            collections = new List<Collection>();
        }

        public User(long id, string username, string password, string name, int age, string privilege): base(id)
        {
            Username = username;
            this.password = password;
            Name = name;
            Age = age;
            Privilege = privilege;
            collections = new List<Collection>();
        }

        public User(string username, string password, string name, int age, string privilege)
        {
            Username = username;
            this.password = Hash.make(password);
            Name = name;
            Age = age;
            Privilege = privilege;
            collections = new List<Collection>();
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
        public string Username { get; set; }

        public string Password
        {
            get => this.password;
            set => this.password = Hash.make(value);
        }

        public int Age { get; set; }
        public string Privilege { get; set; }
        public List<Collection> Collections
        {
            get => this.collections;
            set => this.collections = value;
        }
        public override string ToString()
        {
            return "{ ID => " + ID + " Name => " + Name + " Age => " + Age + " }";
        }

        public override string[] ToArray()
        {
            return new [] { Username, Name, Age.ToString(), Privilege };
        }
    }
}
