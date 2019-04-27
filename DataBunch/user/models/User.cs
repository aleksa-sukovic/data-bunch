using DataBunch.foundation.models;

namespace DataBunch.user.models
{
    public class User: Model
    {
        public User(long id, string name, int age): base(id)
        {
            this.Name = name;
            this.Age = age;
        }

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "User: ID => " + ID + " Name => " + Name + " Age => " + Age;
        }
    }
}
